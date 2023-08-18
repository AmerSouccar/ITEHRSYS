import { Component, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { PositionServiceProxy, ReadPositionDto, ReadPositionDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs';
import { CreatePositionDialogComponent } from './create-position-dialog/create-position-dialog.component';
import { EditPositionDialogComponent } from './edit-position-dialog/edit-position-dialog.component';

class PagedPositionsRequestDto extends PagedRequestDto {
}

@Component({
  selector: 'app-position',
  templateUrl: './position.component.html',
  animations: [appModuleAnimation()]
})
export class PositionComponent extends PagedListingComponentBase<ReadPositionDto> {
  positions: ReadPositionDto[] = [];


  constructor(
    injector: Injector,
    private _positionService: PositionServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }

  list(
    request: PagedPositionsRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    this._positionService
      .getAll(request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: ReadPositionDtoPagedResultDto) => {
        this.positions = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(position: ReadPositionDto): void {
    abp.message.confirm(
      this.l('PositionDeleteWarningMessage', position.id),
      undefined,
      (result: boolean) => {
        if (result) {
          this._positionService
            .delete(position.id)
            .pipe(
              finalize(() => {
                abp.notify.success(this.l('SuccessfullyDeleted'));
                this.refresh();
              })
            )
            .subscribe(() => {});
        }
      }
    );
  }

  createPosition(): void {
    this.showCreateOrEditCountryDialog();
  }

  editPosition(position: ReadPositionDto): void {
    this.showCreateOrEditCountryDialog(position.id);
  }

  showCreateOrEditCountryDialog(id?: string): void {
    let createOrEditCountryDialog: BsModalRef;
    if (!id) {
      createOrEditCountryDialog = this._modalService.show(
        CreatePositionDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      createOrEditCountryDialog = this._modalService.show(
        EditPositionDialogComponent,
        {
          class: 'modal-lg',
          initialState: {
            id: id,
          },
        }
      );
    }

    createOrEditCountryDialog.content.onSave.subscribe(() => {
      this.refresh();
    });
  }

}

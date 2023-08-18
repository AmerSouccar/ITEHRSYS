import { Component, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { PositionWorkTypeServiceProxy, ReadPositionWorkTypeDto, ReadPositionWorkTypeDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs';
import { CreatePositionWorkTypeDialogComponent } from './create-position-work-type-dialog/create-position-work-type-dialog.component';
import { EditPositionWorkTypeDialogComponent } from './edit-position-work-type-dialog/edit-position-work-type-dialog.component';

class PagedPositionWorkTypeRequestDto extends PagedRequestDto {
}

@Component({
  selector: 'app-position-work-type',
  templateUrl: './position-work-type.component.html',
  animations: [appModuleAnimation()]
})
export class PositionWorkTypeComponent extends PagedListingComponentBase<ReadPositionWorkTypeDto> {
  positionWorkTypes: ReadPositionWorkTypeDto[] = [];


  constructor(
    injector: Injector,
    private _positionWorkTypeService: PositionWorkTypeServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }

  list(
    request: PagedPositionWorkTypeRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    this._positionWorkTypeService
      .getAll(request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: ReadPositionWorkTypeDtoPagedResultDto) => {
        this.positionWorkTypes = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(positionWorkType: ReadPositionWorkTypeDto): void {
    abp.message.confirm(
      this.l('PositionWorkTypeDeleteWarningMessage', positionWorkType.name),
      undefined,
      (result: boolean) => {
        if (result) {
          this._positionWorkTypeService
            .delete(positionWorkType.id)
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

  createPositionWorkType(): void {
    this.showCreateOrEditCountryDialog();
  }

  editPositionWorkType(positionWorkType: ReadPositionWorkTypeDto): void {
    this.showCreateOrEditCountryDialog(positionWorkType.id);
  }

  showCreateOrEditCountryDialog(id?: string): void {
    let createOrEditCountryDialog: BsModalRef;
    if (!id) {
      createOrEditCountryDialog = this._modalService.show(
        CreatePositionWorkTypeDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      createOrEditCountryDialog = this._modalService.show(
        EditPositionWorkTypeDialogComponent,
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

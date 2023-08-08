import { Component, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { ReligionDto, ReligionDtoPagedResultDto, ReligionServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs';
import { CreateReligionDialogComponent } from './create-religion-dialog/create-religion-dialog.component';
import { EditReligionDialogComponent } from './edit-religion-dialog/edit-religion-dialog.component';

class PagedReligionsRequestDto extends PagedRequestDto {
}

@Component({
  selector: 'app-religion',
  templateUrl: './religion.component.html',
  animations: [appModuleAnimation()]
})
export class ReligionComponent extends PagedListingComponentBase<ReligionDto> {
  religions: ReligionDto[] = [];


  constructor(
    injector: Injector,
    private _religionService: ReligionServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }

  list(
    request: PagedReligionsRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    this._religionService
      .getAll(request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: ReligionDtoPagedResultDto) => {
        this.religions = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(religion: ReligionDto): void {
    abp.message.confirm(
      this.l('CityDeleteWarningMessage', religion.name),
      undefined,
      (result: boolean) => {
        if (result) {
          this._religionService
            .delete(religion.id)
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

  createReligion(): void {
    this.showCreateOrEditReligionDialog();
  }

  editReligion(religion: ReligionDto): void {
    this.showCreateOrEditReligionDialog(religion.id);
  }

  showCreateOrEditReligionDialog(id?: string): void {
    let createOrEditReligionDialog: BsModalRef;
    if (!id) {
      createOrEditReligionDialog = this._modalService.show(
        CreateReligionDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      createOrEditReligionDialog = this._modalService.show(
        EditReligionDialogComponent,
        {
          class: 'modal-lg',
          initialState: {
            id: id,
          },
        }
      );
    }

    createOrEditReligionDialog.content.onSave.subscribe(() => {
      this.refresh();
    });
  }

}

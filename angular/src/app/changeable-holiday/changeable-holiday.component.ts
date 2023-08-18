import { Component, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { ChangeableHolidayServiceProxy, ReadChangeableHolidayDto, ReadChangeableHolidayDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs';
import { CreateChangeableHolidayDialogComponent } from './create-changeable-holiday-dialog/create-changeable-holiday-dialog.component';
import { EditChangeableHolidayDialogComponent } from './edit-changeable-holiday-dialog/edit-changeable-holiday-dialog.component';

class PagedChangeableHolidayRequestDto extends PagedRequestDto {
}

@Component({
  selector: 'app-changeable-holiday',
  templateUrl: './changeable-holiday.component.html',
  animations: [appModuleAnimation()]
})
export class ChangeableHolidayComponent extends PagedListingComponentBase<ReadChangeableHolidayDto> {
  changeableHolidays: ReadChangeableHolidayDto[] = [];


  constructor(
    injector: Injector,
    private _changeableHolidayService: ChangeableHolidayServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }

  list(
    request: PagedChangeableHolidayRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    this._changeableHolidayService
      .getAll(request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: ReadChangeableHolidayDtoPagedResultDto) => {
        this.changeableHolidays = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(holiday: ReadChangeableHolidayDto): void {
    abp.message.confirm(
      this.l('HolidayDeleteWarningMessage', holiday.name),
      undefined,
      (result: boolean) => {
        if (result) {
          this._changeableHolidayService
            .delete(holiday.id)
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

  createHoliday(): void {
    this.showCreateOrEditCityDialog();
  }

  editHoliday(holiday: ReadChangeableHolidayDto): void {
    this.showCreateOrEditCityDialog(holiday.id);
  }

  showCreateOrEditCityDialog(id?: string): void {
    let createOrEditCityDialog: BsModalRef;
    if (!id) {
      createOrEditCityDialog = this._modalService.show(
        CreateChangeableHolidayDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      createOrEditCityDialog = this._modalService.show(
        EditChangeableHolidayDialogComponent,
        {
          class: 'modal-lg',
          initialState: {
            id: id,
          },
        }
      );
    }

    createOrEditCityDialog.content.onSave.subscribe(() => {
      this.refresh();
    });
  }


}

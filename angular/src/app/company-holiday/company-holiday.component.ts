import { Component, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { CompanyHolidayServiceProxy, ReadCompanyHolidayDto, ReadCompanyHolidayDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs';
import { CreateCompanyHolidayDialogComponent } from './create-company-holiday-dialog/create-company-holiday-dialog.component';
import { EditCompanyHolidayDialogComponent } from './edit-company-holiday-dialog/edit-company-holiday-dialog.component';

class PagedCompanyHolidayRequestDto extends PagedRequestDto {
}

@Component({
  selector: 'app-company-holiday',
  templateUrl: './company-holiday.component.html',
  animations: [appModuleAnimation()]
})
export class CompanyHolidayComponent extends PagedListingComponentBase<ReadCompanyHolidayDto> {
  companyHolidays: ReadCompanyHolidayDto[] = [];


  constructor(
    injector: Injector,
    private _companyHolidayService: CompanyHolidayServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }

  list(
    request: PagedCompanyHolidayRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    this._companyHolidayService
      .getAll(request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: ReadCompanyHolidayDtoPagedResultDto) => {
        this.companyHolidays = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(holiday: ReadCompanyHolidayDto): void {
    abp.message.confirm(
      this.l('HolidayDeleteWarningMessage', holiday.id),
      undefined,
      (result: boolean) => {
        if (result) {
          this._companyHolidayService
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

  editHoliday(holiday: ReadCompanyHolidayDto): void {
    this.showCreateOrEditCityDialog(holiday.id);
  }

  showCreateOrEditCityDialog(id?: string): void {
    let createOrEditCityDialog: BsModalRef;
    if (!id) {
      createOrEditCityDialog = this._modalService.show(
        CreateCompanyHolidayDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      createOrEditCityDialog = this._modalService.show(
        EditCompanyHolidayDialogComponent,
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

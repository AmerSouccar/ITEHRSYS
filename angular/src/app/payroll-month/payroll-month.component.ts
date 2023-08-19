import { Component, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { MonthServiceProxy, ReadMonthDto, ReadMonthDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs';
import { CreatePayrollMonthDialogComponent } from './create-payroll-month-dialog/create-payroll-month-dialog.component';
import { EditPayrollMonthDialogComponent } from './edit-payroll-month-dialog/edit-payroll-month-dialog.component';
import { Router } from '@angular/router';

class PagedPayrollMonthsRequestDto extends PagedRequestDto {
}

@Component({
  selector: 'app-payroll-month',
  templateUrl: './payroll-month.component.html',
  animations: [appModuleAnimation()]
})
export class PayrollMonthComponent extends PagedListingComponentBase<ReadMonthDto> {
  months: ReadMonthDto[] = [];


  constructor(
    injector: Injector,
    private _monthService: MonthServiceProxy,
    private _modalService: BsModalService,
    private router : Router
  ) {
    super(injector);
  }

  list(
    request: PagedPayrollMonthsRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    this._monthService
      .getAll(request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: ReadMonthDtoPagedResultDto) => {
        this.months = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(month: ReadMonthDto): void {
    abp.message.confirm(
      this.l('MonthDeleteWarningMessage', month.year),
      undefined,
      (result: boolean) => {
        if (result) {
          this._monthService
            .delete(month.id)
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

  createMonth(): void {
    this.showCreateOrEditCountryDialog();
  }

  editMonth(month: ReadMonthDto): void {
    this.showCreateOrEditCountryDialog(month.id);
  }

  showCreateOrEditCountryDialog(id?: string): void {
    let createOrEditCountryDialog: BsModalRef;
    if (!id) {
      createOrEditCountryDialog = this._modalService.show(
        CreatePayrollMonthDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      createOrEditCountryDialog = this._modalService.show(
        EditPayrollMonthDialogComponent,
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


  onCalculatebuttonClick(event){
    this._monthService
    .calculateMonth(event.id)
    .pipe(
      finalize(() => {
        abp.notify.success(this.l('Calculated Successfully'));
        this.refresh();
      })
    )
    .subscribe(() => {});
  }


  onCardsButtonClick(event){
    this.router.navigateByUrl('app/payrollMonth/' + event.id +'/cards');
  }

}

import { Component, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { FinancialCardServiceProxy, ReadFinancialCardDto, ReadFinancialCardDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs';
import { EditFinancialCardDialogComponent } from './edit-financial-card-dialog/edit-financial-card-dialog.component';

class PagedFinancialCardsRequestDto extends PagedRequestDto {
}

@Component({
  selector: 'app-financial-card',
  templateUrl: './financial-card.component.html',
  animations: [appModuleAnimation()]
})
export class FinancialCardComponent extends PagedListingComponentBase<ReadFinancialCardDto> {
  financialCards: ReadFinancialCardDto[] = [];

  constructor(
    injector: Injector,
    private _financialCardService: FinancialCardServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }

  list(
    request: PagedFinancialCardsRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    this._financialCardService
      .getAll(request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: ReadFinancialCardDtoPagedResultDto) => {
        this.financialCards = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(financialCard: ReadFinancialCardDto): void {
    // abp.message.confirm(
    //   this.l('EmployeeCardDeleteWarningMessage', employeeCard.id),
    //   undefined,
    //   (result: boolean) => {
    //     if (result) {
    //       this._employeeCardService
    //         .delete(employee.id)
    //         .pipe(
    //           finalize(() => {
    //             abp.notify.success(this.l('SuccessfullyDeleted'));
    //             this.refresh();
    //           })
    //         )
    //         .subscribe(() => {});
    //     }
    //   }
    // );
  }

  // createEmployeeCard(): void {
  //   this.showCreateOrEditEmployeeDialog();
  // }

  editFinancialCard(financialCard: ReadFinancialCardDto): void {
    this.showCreateOrEditEmployeeDialog(financialCard.id);
  }

  showCreateOrEditEmployeeDialog(id?: string): void {
    let createOrEditEmployeeDialog: BsModalRef;
    if (!id) {
      // createOrEditEmployeeDialog = this._modalService.show(
      //   CreateEmployeeDialogComponent,
      //   {
      //     class: 'modal-lg',
      //   }
      // );
    } else {
      createOrEditEmployeeDialog = this._modalService.show(
        EditFinancialCardDialogComponent,
        {
          class: 'modal-lg',
          initialState: {
            id: id,
          },
        }
      );
    }

    createOrEditEmployeeDialog.content.onSave.subscribe(() => {
      this.refresh();
    });
  }

}

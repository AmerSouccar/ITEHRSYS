import { Component, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { EmployeeCardServiceProxy, ReadEmployeeCardDto, ReadEmployeeCardDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs';
import { EditEmployeeCardComponent } from './edit-employee-card/edit-employee-card.component';

class PagedEmployeeCardsRequestDto extends PagedRequestDto {
}

@Component({
  selector: 'app-employee-card',
  templateUrl: './employee-card.component.html',
  animations: [appModuleAnimation()]
})
export class EmployeeCardComponent extends PagedListingComponentBase<ReadEmployeeCardDto> {
  employeeCards: ReadEmployeeCardDto[] = [];

  constructor(
    injector: Injector,
    private _employeeCardService: EmployeeCardServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }

  list(
    request: PagedEmployeeCardsRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    this._employeeCardService
      .getAll(request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: ReadEmployeeCardDtoPagedResultDto) => {
        this.employeeCards = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(employeeCard: ReadEmployeeCardDto): void {
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

  editEmployeeCard(employeeCard: ReadEmployeeCardDto): void {
    this.showCreateOrEditEmployeeDialog(employeeCard.id);
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
        EditEmployeeCardComponent,
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

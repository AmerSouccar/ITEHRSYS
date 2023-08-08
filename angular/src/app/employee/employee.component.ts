import { Component, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { EmployeeServiceProxy, ReadEmployeeDto, ReadEmployeeDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs';
import { CreateEmployeeDialogComponent } from './create-employee-dialog/create-employee-dialog.component';
import { EditEmployeeDialogComponent } from './edit-employee-dialog/edit-employee-dialog.component';

class PagedEmployeesRequestDto extends PagedRequestDto {
}


@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  animations: [appModuleAnimation()]
})
export class EmployeeComponent extends PagedListingComponentBase<ReadEmployeeDto> {
  employees: ReadEmployeeDto[] = [];


  constructor(
    injector: Injector,
    private _employeeService: EmployeeServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }

  list(
    request: PagedEmployeesRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    this._employeeService
      .getAll(request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: ReadEmployeeDtoPagedResultDto) => {
        this.employees = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(employee: ReadEmployeeDto): void {
    abp.message.confirm(
      this.l('CityDeleteWarningMessage', employee.fullName),
      undefined,
      (result: boolean) => {
        if (result) {
          this._employeeService
            .delete(employee.id)
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

  createEmployee(): void {
    this.showCreateOrEditEmployeeDialog();
  }

  editEmployee(employee: ReadEmployeeDto): void {
    this.showCreateOrEditEmployeeDialog(employee.id);
  }

  showCreateOrEditEmployeeDialog(id?: string): void {
    let createOrEditEmployeeDialog: BsModalRef;
    if (!id) {
      createOrEditEmployeeDialog = this._modalService.show(
        CreateEmployeeDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      createOrEditEmployeeDialog = this._modalService.show(
        EditEmployeeDialogComponent,
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

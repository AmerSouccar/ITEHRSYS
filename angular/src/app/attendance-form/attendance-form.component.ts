import { Component, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { AttendanceFormServiceProxy, ReadAttendanceFormDto, ReadAttendanceFormDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs';
import { CreateAttendanceFormDialogComponent } from './create-attendance-form-dialog/create-attendance-form-dialog.component';
import { EditAttendanceFormDialogComponent } from './edit-attendance-form-dialog/edit-attendance-form-dialog.component';
import { Router } from '@angular/router';

class PagedAttendanceFormRequestDto extends PagedRequestDto {
}

@Component({
  selector: 'app-attendance-form',
  templateUrl: './attendance-form.component.html',
  animations: [appModuleAnimation()]
})
export class AttendanceFormComponent extends PagedListingComponentBase<ReadAttendanceFormDto> {
  attendanceForms: ReadAttendanceFormDto[] = [];

  constructor(
    injector: Injector,
    private _attendanceFormService: AttendanceFormServiceProxy,
    private _modalService: BsModalService,
    private router : Router
  ) {
    super(injector);
  }

  list(
    request: PagedAttendanceFormRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    this._attendanceFormService
      .getAll(request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: ReadAttendanceFormDtoPagedResultDto) => {
        this.attendanceForms = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(attendanceForm: ReadAttendanceFormDto): void {
    abp.message.confirm(
      this.l('AttendanceFormDeleteWarningMessage', attendanceForm.name),
      undefined,
      (result: boolean) => {
        if (result) {
          this._attendanceFormService
            .delete(attendanceForm.id)
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

  createAttendanceForm(): void {
    this.showCreateOrEditEmployeeDialog();
  }

  editAttendanceForm(attendanceForm: ReadAttendanceFormDto): void {
    this.showCreateOrEditEmployeeDialog(attendanceForm.id);
  }

  showCreateOrEditEmployeeDialog(id?: string): void {
    let createOrEditEmployeeDialog: BsModalRef;
    if (!id) {
      createOrEditEmployeeDialog = this._modalService.show(
        CreateAttendanceFormDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      createOrEditEmployeeDialog = this._modalService.show(
        EditAttendanceFormDialogComponent,
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

  onWorkshopButtonClick(event)
  {
    this.router.navigateByUrl('app/attendanceForm/' + event.id +'/workshops');
  }

}


import { Component, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { LeaveRequestServiceProxy, ReadLeaveRequestDto, ReadLeaveRequestDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalService } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs';

class PagedAcceptLeavesRequestDto extends PagedRequestDto {
}

@Component({
  selector: 'app-accept-leave-request-service',
  templateUrl: './accept-leave-request-service.component.html',
  animations: [appModuleAnimation()]
})
export class AcceptLeaveRequestServiceComponent extends PagedListingComponentBase<ReadLeaveRequestDto> {
  leaveRequests: ReadLeaveRequestDto[] = [];

  constructor(
    injector: Injector,
    private _leaveRequestService: LeaveRequestServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }



  list(
    request: PagedAcceptLeavesRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    this._leaveRequestService
      .getMyEmployeesLeaveRequests(request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: ReadLeaveRequestDtoPagedResultDto) => {
        this.leaveRequests = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(attendanceMonthlyCard: ReadLeaveRequestDto): void {
    // abp.message.confirm(
    //   this.l('AttendanceMonthlyCardDeleteWarningMessage', attendanceMonthlyCard.id),
    //   undefined,
    //   (result: boolean) => {
    //     if (result) {
    //       this._attendanceMonthlyCardService
    //         .delete(attendanceMonthlyCard.id)
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

  // createAttendanceMonthlyCard(): void {
  //   this.showCreateOrEditEmployeeDialog();
  // }

  // editAttendanceMonthlyCard(attendanceMonthlyCard: ReadAttendanceMonthlyCardDto): void {
  //   this.showCreateOrEditEmployeeDialog(attendanceMonthlyCard.id);
  // }

  // showCreateOrEditEmployeeDialog(id?: string): void {
  //   let createOrEditEmployeeDialog: BsModalRef;
  //   if (!id) {
  //     createOrEditEmployeeDialog = this._modalService.show(
  //       CreateAttendanceFormDialogComponent,
  //       {
  //         class: 'modal-lg',
  //       }
  //     );
  //   } else {
  //     createOrEditEmployeeDialog = this._modalService.show(
  //       EditAttendanceFormDialogComponent,
  //       {
  //         class: 'modal-lg',
  //         initialState: {
  //           id: id,
  //         },
  //       }
  //     );
  //   }

  //   createOrEditEmployeeDialog.content.onSave.subscribe(() => {
  //     this.refresh();
  //   });
  // }

  onAcceptButtonClick(event){
    this._leaveRequestService
    .acceptLeaveRequest(event.id)
    .pipe(
        finalize(() => {
                  abp.notify.success(this.l('Accepted'));
                  this.refresh();
                })
              )
              .subscribe(() => {});
  }

  onRejectButtonClick(event)
  {
    this._leaveRequestService
    .rejectLeaveRequest(event.id)
    .pipe(
        finalize(() => {
                  abp.notify.warn(this.l('Rejected'));
                  this.refresh();
                })
              )
              .subscribe(() => {});
  }

}


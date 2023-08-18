import { Component, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { LeaveRequestServiceProxy, ReadLeaveRequestDto, ReadLeaveRequestDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs';
import { CreateLeaveRequestDialogComponent } from './create-leave-request-dialog/create-leave-request-dialog.component';
import { EditLeaveRequestDialogComponent } from './edit-leave-request-dialog/edit-leave-request-dialog.component';

class PagedLeaveRequestsRequestDto extends PagedRequestDto {
}

@Component({
  selector: 'app-leave-request',
  templateUrl: './leave-request.component.html',
  animations: [appModuleAnimation()]
})
export class LeaveRequestComponent extends PagedListingComponentBase<ReadLeaveRequestDto> {
  leaveRequests: ReadLeaveRequestDto[] = [];


  constructor(
    injector: Injector,
    private _leaveRequestService: LeaveRequestServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }

  list(
    request: PagedLeaveRequestsRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    this._leaveRequestService
      .getAll(request.skipCount, request.maxResultCount)
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

  delete(leaveRequest: ReadLeaveRequestDto): void {
    abp.message.confirm(
      this.l('LeaveRequestDeleteWarningMessage', leaveRequest.id),
      undefined,
      (result: boolean) => {
        if (result) {
          this._leaveRequestService
            .delete(leaveRequest.id)
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

  createLeaveRequest(): void {
    this.showCreateOrEditCountryDialog();
  }

  editLeaveRequest(leaveRequest: ReadLeaveRequestDto): void {
    this.showCreateOrEditCountryDialog(leaveRequest.id);
  }

  showCreateOrEditCountryDialog(id?: string): void {
    let createOrEditCountryDialog: BsModalRef;
    if (!id) {
      createOrEditCountryDialog = this._modalService.show(
        CreateLeaveRequestDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      createOrEditCountryDialog = this._modalService.show(
        EditLeaveRequestDialogComponent,
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

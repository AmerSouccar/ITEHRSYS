import { Component, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { LeaveSettingServiceProxy, ReadLeaveSettingDto, ReadLeaveSettingDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs';
import { CreateLeaveSettingDialogComponent } from './create-leave-setting-dialog/create-leave-setting-dialog.component';
import { EditLeaveSettingDialogComponent } from './edit-leave-setting-dialog/edit-leave-setting-dialog.component';

class PagedLeaveSettingsRequestDto extends PagedRequestDto {
}

@Component({
  selector: 'app-leave-setting',
  templateUrl: './leave-setting.component.html',
  animations: [appModuleAnimation()]
})
export class LeaveSettingComponent extends PagedListingComponentBase<ReadLeaveSettingDto> {
  leaveSettings: ReadLeaveSettingDto[] = [];


  constructor(
    injector: Injector,
    private _leaveSettingService: LeaveSettingServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }

  list(
    request: PagedLeaveSettingsRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    this._leaveSettingService
      .getAll(request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: ReadLeaveSettingDtoPagedResultDto) => {
        this.leaveSettings = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(leaveSetting: ReadLeaveSettingDto): void {
    abp.message.confirm(
      this.l('LeaveSettingDeleteWarningMessage', leaveSetting.name),
      undefined,
      (result: boolean) => {
        if (result) {
          this._leaveSettingService
            .delete(leaveSetting.id)
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

  createLeaveSetting(): void {
    this.showCreateOrEditCountryDialog();
  }

  editLeaveSetting(leaveSetting: ReadLeaveSettingDto): void {
    this.showCreateOrEditCountryDialog(leaveSetting.id);
  }

  showCreateOrEditCountryDialog(id?: string): void {
    let createOrEditCountryDialog: BsModalRef;
    if (!id) {
      createOrEditCountryDialog = this._modalService.show(
        CreateLeaveSettingDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      createOrEditCountryDialog = this._modalService.show(
        EditLeaveSettingDialogComponent,
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

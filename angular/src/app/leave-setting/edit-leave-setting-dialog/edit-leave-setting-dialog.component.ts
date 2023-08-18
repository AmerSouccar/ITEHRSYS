import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { LeaveSettingServiceProxy, ReadLeaveSettingDto, ReadWorkflowSettingDto, ReadWorkflowSettingDtoPagedResultDto, UpdateLeaveSettingDto, WorkflowSettingServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-edit-leave-setting-dialog',
  templateUrl: './edit-leave-setting-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class EditLeaveSettingDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
leaveSetting : UpdateLeaveSettingDto = new UpdateLeaveSettingDto();
id: string;
workflowSettings : ReadWorkflowSettingDto[];

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _leaveSettingService: LeaveSettingServiceProxy,
  private _workflowSettingService: WorkflowSettingServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  this._workflowSettingService.getAll(0,100).subscribe((result: ReadWorkflowSettingDtoPagedResultDto) => {
    this.workflowSettings = result.items;
  });
  this._leaveSettingService.getForEdit(this.id).subscribe((result: UpdateLeaveSettingDto) => {
    this.leaveSetting = result;
  });
}

save(): void {
  this.saving = true;

  this._leaveSettingService.update(this.leaveSetting).subscribe(
    () => {
      this.notify.info(this.l('SavedSuccessfully'));
      this.bsModalRef.hide();
      this.onSave.emit();
    },
    () => {
      this.saving = false;
    }
  );
}
}
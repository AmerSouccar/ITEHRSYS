import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { InsertLeaveSettingDto, LeaveSettingServiceProxy, ReadWorkflowSettingDto, ReadWorkflowSettingDtoPagedResultDto, WorkflowSettingServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-create-leave-setting-dialog',
  templateUrl: './create-leave-setting-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreateLeaveSettingDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
leaveSetting = new InsertLeaveSettingDto();
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
}


save(): void {
  this.saving = true;

  this._leaveSettingService.insert(this.leaveSetting).subscribe(
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
import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { UpdateWorkflowSettingDto, WorkflowSettingServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-edit-workflow-settings-dialog',
  templateUrl: './edit-workflow-settings-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class EditWorkflowSettingsDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
workflowSetting : UpdateWorkflowSettingDto = new UpdateWorkflowSettingDto();
id: string;

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  public _workflowSettingService: WorkflowSettingServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  this._workflowSettingService.getForEdit(this.id).subscribe((result: UpdateWorkflowSettingDto) => {
    this.workflowSetting = result;
  });
}

save(): void {
  this.saving = true;

  this._workflowSettingService.update(this.workflowSetting).subscribe(
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

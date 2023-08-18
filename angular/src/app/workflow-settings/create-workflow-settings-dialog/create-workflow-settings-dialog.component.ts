import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { InsertWorkflowSettingDto, WorkflowSettingServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-create-workflow-settings-dialog',
  templateUrl: './create-workflow-settings-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreateWorkflowSettingsDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
workflowSetting = new InsertWorkflowSettingDto();

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _workflowSettingService: WorkflowSettingServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  
}


save(): void {
  this.saving = true;

  this._workflowSettingService.insert(this.workflowSetting).subscribe(
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

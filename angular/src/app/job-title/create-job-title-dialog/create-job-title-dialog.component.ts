import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { InsertJobTitleDto, JobTitleServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-create-job-title-dialog',
  templateUrl: './create-job-title-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreateJobTitleDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
jobTitle = new InsertJobTitleDto();
id : string;

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _jobTitleService: JobTitleServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  
}


save(): void {
  this.saving = true;
  this.jobTitle.gradeId = this.id;
  this._jobTitleService.insert(this.jobTitle).subscribe(
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

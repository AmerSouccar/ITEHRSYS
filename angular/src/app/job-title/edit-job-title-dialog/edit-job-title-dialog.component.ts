import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { JobTitleServiceProxy, ReadJobTitleDto, UpdateJobTitleDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-edit-job-title-dialog',
  templateUrl: './edit-job-title-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class EditJobTitleDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
jobTitle : UpdateJobTitleDto = new UpdateJobTitleDto();
id: string;

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  public _jobTitleService: JobTitleServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  this._jobTitleService.getbyId(this.id).subscribe((result: ReadJobTitleDto) => {
    this.jobTitle = result;
  });
}

save(): void {
  this.saving = true;

  this._jobTitleService.update(this.jobTitle).subscribe(
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

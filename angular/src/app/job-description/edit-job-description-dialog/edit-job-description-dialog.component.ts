import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { JobDescriptionServiceProxy, JobTitleServiceProxy, NodeServiceProxy, ReadJobTitleDto, ReadJobTitleDtoPagedResultDto, ReadNodeDto, ReadNodeDtoPagedResultDto, UpdateJobDescriptionDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-edit-job-description-dialog',
  templateUrl: './edit-job-description-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class EditJobDescriptionDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
jobDescription : UpdateJobDescriptionDto = new UpdateJobDescriptionDto();
jobTitles : ReadJobTitleDto[];
nodes : ReadNodeDto[];
id:string;

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _jobDescriptionService:JobDescriptionServiceProxy,
  private _jobTitlesService:JobTitleServiceProxy,
  private _nodeService:NodeServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

allNodes : ReadNodeDto[];


ngOnInit(): void {

  this._nodeService.getAll(0,100).subscribe((result: ReadNodeDtoPagedResultDto) => {
    this.nodes = result.items;
  });
  this._jobTitlesService.getAll(0,100).subscribe((result: ReadJobTitleDtoPagedResultDto) => {
    this.jobTitles = result.items;
  });

  this._jobDescriptionService.getForEdit(this.id).subscribe((result: UpdateJobDescriptionDto) => {
    this.jobDescription = result;
  });
}

save(): void {
  this.saving = true;

  this._jobDescriptionService.update(this.jobDescription).subscribe(
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
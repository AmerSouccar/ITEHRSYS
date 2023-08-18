import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { InsertJobDescriptionDto, JobDescriptionServiceProxy, JobTitleServiceProxy, NodeServiceProxy, ReadJobTitleDto, ReadJobTitleDtoPagedResultDto, ReadNodeDto, ReadNodeDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-create-job-description-dialog',
  templateUrl: './create-job-description-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreateJobDescriptionDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
jobDescription = new InsertJobDescriptionDto();
jobTitles : ReadJobTitleDto[];
nodes : ReadNodeDto[];

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

ngOnInit(): void {
  this._nodeService.getAll(0,100).subscribe((result: ReadNodeDtoPagedResultDto) => {
    this.nodes = result.items;
  });
  this._jobTitlesService.getAll(0,100).subscribe((result: ReadJobTitleDtoPagedResultDto) => {
    this.jobTitles = result.items;
  });
}


save(): void {
  this.saving = true;
  this._jobDescriptionService.insert(this.jobDescription).subscribe(
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
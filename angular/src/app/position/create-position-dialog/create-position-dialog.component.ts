import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { InsertPositionDto, JobDescriptionServiceProxy, PositionServiceProxy, PositionWorkTypeServiceProxy, ReadJobDescriptionDto, ReadJobDescriptionDtoPagedResultDto, ReadPositionDto, ReadPositionDtoPagedResultDto, ReadPositionWorkTypeDto, ReadPositionWorkTypeDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-create-position-dialog',
  templateUrl: './create-position-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreatePositionDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
position = new InsertPositionDto();
jobDescriptions : ReadJobDescriptionDto[];
workTypes : ReadPositionWorkTypeDto[];
managerPositions : ReadPositionDto[];

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _positionService: PositionServiceProxy,
  private _jobDescriptionService: JobDescriptionServiceProxy,
  private _positionWorkTypeService: PositionWorkTypeServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  this._jobDescriptionService.getAll(0,1000).subscribe((result: ReadJobDescriptionDtoPagedResultDto) => {
    this.jobDescriptions = result.items;
  });
  this._positionWorkTypeService.getAll(0,1000).subscribe((result: ReadPositionWorkTypeDtoPagedResultDto) => {
    this.workTypes = result.items;
  });
  this._positionService.getAll(0,1000).subscribe((result: ReadPositionDtoPagedResultDto) => {
    this.managerPositions = result.items;
  });
}


save(): void {
  this.saving = true;

  this._positionService.insert(this.position).subscribe(
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
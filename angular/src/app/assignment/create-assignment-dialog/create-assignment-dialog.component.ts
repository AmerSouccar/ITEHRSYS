import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { AssignmentServiceProxy, EmployeeCardServiceProxy, InsertAssignmentDto, JobTitleServiceProxy, PositionServiceProxy, ReadEmployeeCardDto, ReadEmployeeCardDtoPagedResultDto, ReadJobTitleDto, ReadJobTitleDtoPagedResultDto, ReadPositionDto, ReadPositionDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-create-assignment-dialog',
  templateUrl: './create-assignment-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreateAssignmentDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
assignment = new InsertAssignmentDto();
employeeCards: ReadEmployeeCardDto[];
jobTitles: ReadJobTitleDto[];
positions: ReadPositionDto[];

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _assignmentService: AssignmentServiceProxy,
  private _employeeCardService: EmployeeCardServiceProxy,
  private _positionService: PositionServiceProxy,
  private _jobTitleService: JobTitleServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  this._employeeCardService.getAllForDropdown(0,1000).subscribe((result: ReadEmployeeCardDtoPagedResultDto) => {
    this.employeeCards = result.items;
  });
  this._jobTitleService.getAll(0,1000).subscribe((result: ReadJobTitleDtoPagedResultDto) => {
    this.jobTitles = result.items;
  });
  this._positionService.getAllEmptyPositions(0,1000).subscribe((result: ReadPositionDtoPagedResultDto) => {
    this.positions = result.items;
  });
}


save(): void {
  this.saving = true;
  this._assignmentService.insert(this.assignment).subscribe(
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
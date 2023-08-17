import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { AttendanceFormServiceProxy, EmployeeCardServiceProxy, ReadAttendanceFormDto, ReadAttendanceFormDtoPagedResultDto, UpdateEmployeeCardDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-edit-employee-card',
  templateUrl: './edit-employee-card.component.html',
  animations: [appModuleAnimation()]
})
export class EditEmployeeCardComponent extends AppComponentBase
implements OnInit {
saving = false;
employeeCard : UpdateEmployeeCardDto = new UpdateEmployeeCardDto();
attendanceForms : ReadAttendanceFormDto[];
id: string;

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _employeeCardService: EmployeeCardServiceProxy,
  private _attendanceFormService: AttendanceFormServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {

  this._attendanceFormService.getAll(0,100).subscribe((result: ReadAttendanceFormDtoPagedResultDto) => {
    this.attendanceForms = result.items;
  });
  
  this._employeeCardService.getForEdit(this.id).subscribe((result: UpdateEmployeeCardDto) => {
    this.employeeCard = result;
  });
}

save(): void {
  this.saving = true;

  this._employeeCardService.update(this.employeeCard).subscribe(
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
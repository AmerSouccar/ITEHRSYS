import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { EmployeeServiceProxy, InsertLeaveRequestDto, LeaveRequestServiceProxy, LeaveSettingServiceProxy, ReadEmployeeDto, ReadEmployeeDtoPagedResultDto, ReadLeaveSettingDto, ReadLeaveSettingDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-create-leave-request-dialog',
  templateUrl: './create-leave-request-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreateLeaveRequestDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
leaveRequest = new InsertLeaveRequestDto();
leaveSettings : ReadLeaveSettingDto[];
employees : ReadEmployeeDto[];

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _leaveRequestService: LeaveRequestServiceProxy,
  private _leaveSettingService: LeaveSettingServiceProxy,
  private _employeeService: EmployeeServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  this._employeeService.getAll(0,1000).subscribe((result: ReadEmployeeDtoPagedResultDto) => {
    this.employees = result.items;
  });
  this._leaveSettingService.getAll(0,1000).subscribe((result: ReadLeaveSettingDtoPagedResultDto) => {
    this.leaveSettings = result.items;
  });
}


save(): void {
  this.saving = true;

  this._leaveRequestService.insert(this.leaveRequest).subscribe(
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
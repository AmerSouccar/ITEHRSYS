import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { EmployeeServiceProxy, EntranceExitRecordServiceProxy, InsertEntranceExitRecordDto, ReadEmployeeDto, ReadEmployeeDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-create-entrance-exit-record-dialog',
  templateUrl: './create-entrance-exit-record-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreateEntranceExitRecordDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
record = new InsertEntranceExitRecordDto();
employees : ReadEmployeeDto[];

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _entranceExitRecordService: EntranceExitRecordServiceProxy,
  private _employeeService: EmployeeServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  this._employeeService.getAll(0,1000).subscribe((result: ReadEmployeeDtoPagedResultDto) => {
    this.employees = result.items;
  });
}


save(): void {
  this.saving = true;

  this._entranceExitRecordService.insert(this.record).subscribe(
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
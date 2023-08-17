import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { EmployeeServiceProxy, EntranceExitRecordServiceProxy, ReadEmployeeDto, ReadEmployeeDtoPagedResultDto, UpdateEntranceExitRecordDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-edit-entrance-exit-record-dialog',
  templateUrl: './edit-entrance-exit-record-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class EditEntranceExitRecordDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
record : UpdateEntranceExitRecordDto = new UpdateEntranceExitRecordDto();
id: string;
employees : ReadEmployeeDto[];

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  public _entranceExitRecordService: EntranceExitRecordServiceProxy,
  private _employeeService: EmployeeServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  this._employeeService.getAll(0,1000).subscribe((result: ReadEmployeeDtoPagedResultDto) => {
    this.employees = result.items;
  });
  this._entranceExitRecordService.getForEdit(this.id).subscribe((result: UpdateEntranceExitRecordDto) => {
    this.record = result;
  });
}

save(): void {
  this.saving = true;

  this._entranceExitRecordService.update(this.record).subscribe(
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
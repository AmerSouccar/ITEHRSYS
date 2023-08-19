import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { AttendanceRecordServiceProxy, InsertAttendanceRecordDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-create-attendance-record-dialog',
  templateUrl: './create-attendance-record-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreateAttendanceRecordDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
attendanceRecord = new InsertAttendanceRecordDto();

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _attendanceRecordService: AttendanceRecordServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  
}


save(): void {
  this.saving = true;

  this._attendanceRecordService.insert(this.attendanceRecord).subscribe(
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

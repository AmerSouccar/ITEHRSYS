import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { AttendanceFormServiceProxy, InsertAttendanceFormDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs';

@Component({
  selector: 'app-create-attendance-form-dialog',
  templateUrl: './create-attendance-form-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreateAttendanceFormDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
attendanceForm = new InsertAttendanceFormDto();

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _attendanceForm: AttendanceFormServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {

}


save(): void {
  this.saving = true;

  this._attendanceForm.insert(this.attendanceForm).subscribe(
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
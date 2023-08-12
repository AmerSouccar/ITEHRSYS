import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { AttendanceFormServiceProxy, UpdateAttendanceFormDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-edit-attendance-form-dialog',
  templateUrl: './edit-attendance-form-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class EditAttendanceFormDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
attendanceForm : UpdateAttendanceFormDto = new UpdateAttendanceFormDto();
id: string;

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _attendanceFormService: AttendanceFormServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  this._attendanceFormService.getForEdit(this.id).subscribe((result: UpdateAttendanceFormDto) => {
    this.attendanceForm = result;
  });
}

save(): void {
  this.saving = true;

  this._attendanceFormService.update(this.attendanceForm).subscribe(
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
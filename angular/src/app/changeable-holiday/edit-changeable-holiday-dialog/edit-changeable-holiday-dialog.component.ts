import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { ChangeableHolidayServiceProxy, UpdateChangeableHolidayDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-edit-changeable-holiday-dialog',
  templateUrl: './edit-changeable-holiday-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class EditChangeableHolidayDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
changeableHoliday : UpdateChangeableHolidayDto = new UpdateChangeableHolidayDto();
id: string;

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  public _changeableHolidayService: ChangeableHolidayServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  this._changeableHolidayService.getForEdit(this.id).subscribe((result: UpdateChangeableHolidayDto) => {
    this.changeableHoliday = result;
  });
}

save(): void {
  this.saving = true;

  this._changeableHolidayService.update(this.changeableHoliday).subscribe(
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
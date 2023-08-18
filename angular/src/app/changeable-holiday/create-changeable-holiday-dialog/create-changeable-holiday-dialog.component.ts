import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { ChangeableHolidayServiceProxy, InsertChangeableHolidayDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-create-changeable-holiday-dialog',
  templateUrl: './create-changeable-holiday-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreateChangeableHolidayDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
changeableHoliday = new InsertChangeableHolidayDto();

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _changeableHolidayService: ChangeableHolidayServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  
}


save(): void {
  this.saving = true;

  this._changeableHolidayService.insert(this.changeableHoliday).subscribe(
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

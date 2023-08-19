import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { InsertMonthDto, MonthServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-create-payroll-month-dialog',
  templateUrl: './create-payroll-month-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreatePayrollMonthDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
month = new InsertMonthDto();

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _monthService: MonthServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  
}


save(): void {
  this.saving = true;

  this._monthService.insert(this.month).subscribe(
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
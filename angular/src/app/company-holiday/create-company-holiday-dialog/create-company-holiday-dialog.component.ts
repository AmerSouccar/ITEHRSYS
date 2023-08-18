import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { CompanyHolidayServiceProxy, InsertCompanyHolidayDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-create-company-holiday-dialog',
  templateUrl: './create-company-holiday-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreateCompanyHolidayDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
companyHoliday = new InsertCompanyHolidayDto();

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _companyHolidayService: CompanyHolidayServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  
}


save(): void {
  this.saving = true;

  this._companyHolidayService.insert(this.companyHoliday).subscribe(
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

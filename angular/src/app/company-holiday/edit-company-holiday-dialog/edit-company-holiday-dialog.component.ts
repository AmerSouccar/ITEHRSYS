import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { CompanyHolidayServiceProxy, UpdateCompanyHolidayDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-edit-company-holiday-dialog',
  templateUrl: './edit-company-holiday-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class EditCompanyHolidayDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
companyHoliday : UpdateCompanyHolidayDto = new UpdateCompanyHolidayDto();
id: string;

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  public _companyHoliday: CompanyHolidayServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  this._companyHoliday.getForEdit(this.id).subscribe((result: UpdateCompanyHolidayDto) => {
    this.companyHoliday = result;
  });
}

save(): void {
  this.saving = true;

  this._companyHoliday.update(this.companyHoliday).subscribe(
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
import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { CountryDto, CountryServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-edit-country-dialog',
  templateUrl: './edit-country-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class EditCountryDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
country : CountryDto = new CountryDto();
id: string;

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  public _countryService: CountryServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  this._countryService.getbyId(this.id).subscribe((result: CountryDto) => {
    this.country = result;
  });
}

save(): void {
  this.saving = true;

  this._countryService.update(this.country).subscribe(
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
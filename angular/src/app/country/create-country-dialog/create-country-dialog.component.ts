import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { CountryDto, CountryServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-create-country-dialog',
  templateUrl: './create-country-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreateCountryDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
country = new CountryDto();

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _countryService: CountryServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  
}


save(): void {
  this.saving = true;

  this._countryService.insert(this.country).subscribe(
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
import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { CityDto, CityServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-create-city-dialog',
  templateUrl: './create-city-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreateCityDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
city = new CityDto();

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _cityService: CityServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  
}


save(): void {
  this.saving = true;

  this._cityService.insert(this.city).subscribe(
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

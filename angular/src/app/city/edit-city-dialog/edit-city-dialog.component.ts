import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { CityDto, CityServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-edit-city-dialog',
  templateUrl: './edit-city-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class EditCityDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
city : CityDto = new CityDto();
id: string;

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  public _cityService: CityServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  this._cityService.getbyId(this.id).subscribe((result: CityDto) => {
    this.city = result;
  });
}

save(): void {
  this.saving = true;

  this._cityService.update(this.city).subscribe(
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
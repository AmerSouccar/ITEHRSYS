import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { NationalityDto, NationalityServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-create-nationality-dialog',
  templateUrl: './create-nationality-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreateNationalityDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
nationality = new NationalityDto();

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _nationalityService: NationalityServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  
}


save(): void {
  this.saving = true;

  this._nationalityService.insert(this.nationality).subscribe(
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
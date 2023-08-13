import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { NationalityDto, NationalityServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-edit-nationality-dialog',
  templateUrl: './edit-nationality-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class EditNationalityDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
nationality : NationalityDto = new NationalityDto();
id: string;

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _nationalityService: NationalityServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  this._nationalityService.getbyId(this.id).subscribe((result: NationalityDto) => {
    this.nationality = result;
  });
}

save(): void {
  this.saving = true;

  this._nationalityService.update(this.nationality).subscribe(
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
import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { ReligionDto, ReligionServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-create-religion-dialog',
  templateUrl: './create-religion-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreateReligionDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
religion = new ReligionDto();

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _religionService: ReligionServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  
}


save(): void {
  this.saving = true;

  this._religionService.insert(this.religion).subscribe(
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

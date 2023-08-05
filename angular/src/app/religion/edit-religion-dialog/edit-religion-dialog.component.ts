import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { ReligionDto, ReligionServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-edit-religion-dialog',
  templateUrl: './edit-religion-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class EditReligionDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
religion : ReligionDto = new ReligionDto();
id: string;

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  public _religionService: ReligionServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  this._religionService.getbyId(this.id).subscribe((result: ReligionDto) => {
    this.religion = result;
  });
}

save(): void {
  this.saving = true;

  this._religionService.update(this.religion).subscribe(
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

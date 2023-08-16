import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { InsertNormalShiftDto, NormalShiftServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-create-normal-shift-dialog',
  templateUrl: './create-normal-shift-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreateNormalShiftDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
normalShift = new InsertNormalShiftDto();
id: string;

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _normalShiftService: NormalShiftServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {

}


save(): void {
  this.saving = true;
  this.normalShift.workshopId = this.id;
  this._normalShiftService.insert(this.normalShift).subscribe(
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
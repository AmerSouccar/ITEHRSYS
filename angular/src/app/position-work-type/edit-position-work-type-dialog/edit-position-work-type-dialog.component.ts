import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { PositionWorkTypeServiceProxy, UpdatePositionWorkTypeDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-edit-position-work-type-dialog',
  templateUrl: './edit-position-work-type-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class EditPositionWorkTypeDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
positionWorkType : UpdatePositionWorkTypeDto = new UpdatePositionWorkTypeDto();
id: string;

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _positionWorkTypeService: PositionWorkTypeServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  this._positionWorkTypeService.getForEdit(this.id).subscribe((result: UpdatePositionWorkTypeDto) => {
    this.positionWorkType = result;
  });
}

save(): void {
  this.saving = true;

  this._positionWorkTypeService.update(this.positionWorkType).subscribe(
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
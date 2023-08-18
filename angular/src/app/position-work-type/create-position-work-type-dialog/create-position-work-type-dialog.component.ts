import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { InsertPositionWorkTypeDto, PositionWorkTypeServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-create-position-work-type-dialog',
  templateUrl: './create-position-work-type-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreatePositionWorkTypeDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
positionWorkType = new InsertPositionWorkTypeDto();

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _positionWorkTypeService: PositionWorkTypeServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  
}


save(): void {
  this.saving = true;

  this._positionWorkTypeService.insert(this.positionWorkType).subscribe(
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
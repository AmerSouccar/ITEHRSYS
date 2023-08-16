import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { UpdateWorkshopDto, WorkshopServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-edit-workshop-dialog',
  templateUrl: './edit-workshop-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class EditWorkshopDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
workshop : UpdateWorkshopDto = new UpdateWorkshopDto();
id: string;

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _workshopService: WorkshopServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  this._workshopService.getForEdit(this.id).subscribe((result: UpdateWorkshopDto) => {
    this.workshop = result;
  });
}

save(): void {
  this.saving = true;

  this._workshopService.update(this.workshop).subscribe(
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
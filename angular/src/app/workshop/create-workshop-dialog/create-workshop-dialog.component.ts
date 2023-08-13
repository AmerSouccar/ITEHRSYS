import { Component, EventEmitter, Injector, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { InsertWorkshopDto, WorkshopServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-create-workshop-dialog',
  templateUrl: './create-workshop-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreateWorkshopDialogComponent extends AppComponentBase {


  saving = false;
  workshop = new InsertWorkshopDto();

  constructor(
    injector: Injector,
    private _workshopService : WorkshopServiceProxy,
    public bsModalRef: BsModalRef
  ) {
    super(injector);
  }

  @Output() onSave = new EventEmitter<any>();
  id: string;

  ngOnInit(): void {

  }

  save(): void {

    ///////// add form Id in back end
    this.saving = true;
    this.workshop.attendanceFormId = this.id;
    this._phaseService.create(this.phase).subscribe(
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

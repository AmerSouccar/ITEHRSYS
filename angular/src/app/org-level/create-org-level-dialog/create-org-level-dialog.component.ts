import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { InsertOrganizationLevelDto, OrganizationLevelServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-create-org-level-dialog',
  templateUrl: './create-org-level-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreateOrgLevelDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
orgLevel = new InsertOrganizationLevelDto();

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _orgLevelService: OrganizationLevelServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  
}


save(): void {
  this.saving = true;

  this._orgLevelService.insert(this.orgLevel).subscribe(
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
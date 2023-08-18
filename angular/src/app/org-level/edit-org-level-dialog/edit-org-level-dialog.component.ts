import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { OrganizationLevelServiceProxy, ReadOrganizationLevelDto, UpdateOrganizationLevelDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-edit-org-level-dialog',
  templateUrl: './edit-org-level-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class EditOrgLevelDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
orgLevel : UpdateOrganizationLevelDto = new UpdateOrganizationLevelDto();
id: string;

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _orgLevelService: OrganizationLevelServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  this._orgLevelService.getForEdit(this.id).subscribe((result: UpdateOrganizationLevelDto) => {
    this.orgLevel = result;
  });
}

save(): void {
  this.saving = true;

  this._orgLevelService.update(this.orgLevel).subscribe(
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
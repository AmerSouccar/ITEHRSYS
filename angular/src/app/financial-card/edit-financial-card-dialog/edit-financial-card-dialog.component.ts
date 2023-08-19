import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { FinancialCardServiceProxy, UpdateFinancialCardDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-edit-financial-card-dialog',
  templateUrl: './edit-financial-card-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class EditFinancialCardDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
financialCard : UpdateFinancialCardDto = new UpdateFinancialCardDto();
id: string;

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _financailCardService: FinancialCardServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  
  this._financailCardService.getForEdit(this.id).subscribe((result: UpdateFinancialCardDto) => {
    this.financialCard = result;
  });
}

save(): void {
  this.saving = true;

  this._financailCardService.update(this.financialCard).subscribe(
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
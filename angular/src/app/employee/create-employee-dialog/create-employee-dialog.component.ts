import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { EmployeeServiceProxy, InsertEmployeeDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-create-employee-dialog',
  templateUrl: './create-employee-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreateEmployeeDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
employee = new InsertEmployeeDto();

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _employeeService: EmployeeServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  
}


save(): void {
  this.saving = true;

  this._employeeService.insert(this.employee).subscribe(
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

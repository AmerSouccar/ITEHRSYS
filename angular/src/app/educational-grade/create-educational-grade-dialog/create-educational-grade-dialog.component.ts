import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { EducationGradeServiceProxy, InsertEducationGradeDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-create-educational-grade-dialog',
  templateUrl: './create-educational-grade-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreateEducationalGradeDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
educationGrade = new InsertEducationGradeDto();

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _educationGradeService: EducationGradeServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  
}


save(): void {
  this.saving = true;

  this._educationGradeService.insert(this.educationGrade).subscribe(
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
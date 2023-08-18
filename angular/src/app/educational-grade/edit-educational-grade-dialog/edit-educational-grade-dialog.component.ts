import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { EducationGradeServiceProxy, UpdateEducationGradeDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-edit-educational-grade-dialog',
  templateUrl: './edit-educational-grade-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class EditEducationalGradeDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
educationGrade : UpdateEducationGradeDto = new UpdateEducationGradeDto();
id: string;

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _educationGradeService: EducationGradeServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  this._educationGradeService.getForEdit(this.id).subscribe((result: UpdateEducationGradeDto) => {
    this.educationGrade = result;
  });
}

save(): void {
  this.saving = true;

  this._educationGradeService.update(this.educationGrade).subscribe(
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
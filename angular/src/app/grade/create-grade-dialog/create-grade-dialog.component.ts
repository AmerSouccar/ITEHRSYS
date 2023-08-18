import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { EducationGradeServiceProxy, GradeServiceProxy, InsertGradeDto, OrganizationLevelServiceProxy, ReadEducationGradeDto, ReadEducationGradeDtoPagedResultDto, ReadGradeDtoPagedResultDto, ReadOrganizationLevelDto, ReadOrganizationLevelDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-create-grade-dialog',
  templateUrl: './create-grade-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreateGradeDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
grade = new InsertGradeDto();
educationGrades :ReadEducationGradeDto[];
orgLevels : ReadOrganizationLevelDto[];

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _gradeService: GradeServiceProxy,
  private _orgLevelService: OrganizationLevelServiceProxy,
  private _educationGradeService: EducationGradeServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  this._educationGradeService.getAll(0,100).subscribe((result: ReadEducationGradeDtoPagedResultDto) => {
    this.educationGrades = result.items;
  });

  this._orgLevelService.getAll(0,100).subscribe((result: ReadOrganizationLevelDtoPagedResultDto) => {
    this.orgLevels = result.items;
  });

}


save(): void {
  this.saving = true;

  this._gradeService.insert(this.grade).subscribe(
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
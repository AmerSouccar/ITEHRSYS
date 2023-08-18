import { Component, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { EducationGradeServiceProxy, ReadEducationGradeDto, ReadEducationGradeDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs';
import { CreateEducationalGradeDialogComponent } from './create-educational-grade-dialog/create-educational-grade-dialog.component';
import { EditEducationalGradeDialogComponent } from './edit-educational-grade-dialog/edit-educational-grade-dialog.component';

class PagedEducationalGradeRequestDto extends PagedRequestDto {
}

@Component({
  selector: 'app-educational-grade',
  templateUrl: './educational-grade.component.html',
  animations: [appModuleAnimation()]
})
export class EducationalGradeComponent extends PagedListingComponentBase<ReadEducationGradeDto> {
  educationGrades: ReadEducationGradeDto[] = [];


  constructor(
    injector: Injector,
    private _educationGradeService: EducationGradeServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }

  list(
    request: PagedEducationalGradeRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    this._educationGradeService
      .getAll(request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: ReadEducationGradeDtoPagedResultDto) => {
        this.educationGrades = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(educationGrade: ReadEducationGradeDto): void {
    abp.message.confirm(
      this.l('EducationGradeDeleteWarningMessage', educationGrade.name),
      undefined,
      (result: boolean) => {
        if (result) {
          this._educationGradeService
            .delete(educationGrade.id)
            .pipe(
              finalize(() => {
                abp.notify.success(this.l('SuccessfullyDeleted'));
                this.refresh();
              })
            )
            .subscribe(() => {});
        }
      }
    );
  }

  createEducationGrade(): void {
    this.showCreateOrEditCountryDialog();
  }

  editEducationGrade(educationGrade: ReadEducationGradeDto): void {
    this.showCreateOrEditCountryDialog(educationGrade.id);
  }

  showCreateOrEditCountryDialog(id?: string): void {
    let createOrEditCountryDialog: BsModalRef;
    if (!id) {
      createOrEditCountryDialog = this._modalService.show(
        CreateEducationalGradeDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      createOrEditCountryDialog = this._modalService.show(
        EditEducationalGradeDialogComponent,
        {
          class: 'modal-lg',
          initialState: {
            id: id,
          },
        }
      );
    }

    createOrEditCountryDialog.content.onSave.subscribe(() => {
      this.refresh();
    });
  }

}

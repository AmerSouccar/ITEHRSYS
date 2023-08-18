import { Component, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { GradeServiceProxy, ReadGradeDto, ReadGradeDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs';
import { CreateGradeDialogComponent } from './create-grade-dialog/create-grade-dialog.component';
import { EditGradeDialogComponent } from './edit-grade-dialog/edit-grade-dialog.component';

class PagedGradeRequestDto extends PagedRequestDto {
}

@Component({
  selector: 'app-grade',
  templateUrl: './grade.component.html',
  animations: [appModuleAnimation()]
})
export class GradeComponent extends PagedListingComponentBase<ReadGradeDto> {
  grades: ReadGradeDto[] = [];


  constructor(
    injector: Injector,
    private _gradeService: GradeServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }

  list(
    request: PagedGradeRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    this._gradeService
      .getAll(request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: ReadGradeDtoPagedResultDto) => {
        this.grades = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(grade: ReadGradeDto): void {
    abp.message.confirm(
      this.l('GradeDeleteWarningMessage', grade.name),
      undefined,
      (result: boolean) => {
        if (result) {
          this._gradeService
            .delete(grade.id)
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

  createGrade(): void {
    this.showCreateOrEditCountryDialog();
  }

  editGrade(grade: ReadGradeDto): void {
    this.showCreateOrEditCountryDialog(grade.id);
  }

  showCreateOrEditCountryDialog(id?: string): void {
    let createOrEditCountryDialog: BsModalRef;
    if (!id) {
      createOrEditCountryDialog = this._modalService.show(
        CreateGradeDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      createOrEditCountryDialog = this._modalService.show(
        EditGradeDialogComponent,
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

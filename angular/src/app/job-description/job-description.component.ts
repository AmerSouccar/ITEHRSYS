import { Component, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { JobDescriptionServiceProxy, ReadJobDescriptionDto, ReadJobDescriptionDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs';
import { CreateJobDescriptionDialogComponent } from './create-job-description-dialog/create-job-description-dialog.component';
import { EditJobDescriptionDialogComponent } from './edit-job-description-dialog/edit-job-description-dialog.component';

class PagedJobDescriptionRequestDto extends PagedRequestDto {
}

@Component({
  selector: 'app-job-description',
  templateUrl: './job-description.component.html',
  animations: [appModuleAnimation()]
})
export class JobDescriptionComponent extends PagedListingComponentBase<ReadJobDescriptionDto> {
  jobDescriptions: ReadJobDescriptionDto[] = [];

  constructor(
    injector: Injector,
    private _jobDescriptionService: JobDescriptionServiceProxy,
    private _modalService: BsModalService,
  ) {
    super(injector);
  }

  list(
    request: PagedJobDescriptionRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    this._jobDescriptionService
      .getAll(request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: ReadJobDescriptionDtoPagedResultDto) => {
        this.jobDescriptions = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(jobDescription: ReadJobDescriptionDto): void {
    abp.message.confirm(
      this.l('JobTitleDeleteWarningMessage', jobDescription.name),
      undefined,
      (result: boolean) => {
        if (result) {
          this._jobDescriptionService
            .delete(jobDescription.id)
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

  createJobDescription(): void {
    this.showCreateOrEditReligionDialog();
   }

  editJobDescription(jobDescription: ReadJobDescriptionDto): void {
    this.showCreateOrEditReligionDialog(jobDescription.id);
  }

  showCreateOrEditReligionDialog(id?: string): void {
    let createOrEditReligionDialog: BsModalRef;
    if (!id) {
      createOrEditReligionDialog = this._modalService.show(
        CreateJobDescriptionDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      createOrEditReligionDialog = this._modalService.show(
        EditJobDescriptionDialogComponent,
        {
          class: 'modal-lg',
          initialState: {
            id: id,
          },
        }
      );
    }

    createOrEditReligionDialog.content.onSave.subscribe(() => {
      this.refresh();
    });
  }

}

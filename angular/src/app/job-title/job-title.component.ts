import { Component, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { JobTitleServiceProxy, ReadJobTitleDto, ReadJobTitleDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { Subscription, finalize } from 'rxjs';
import { CreateJobTitleDialogComponent } from './create-job-title-dialog/create-job-title-dialog.component';
import { EditJobTitleDialogComponent } from './edit-job-title-dialog/edit-job-title-dialog.component';
import { ActivatedRoute, Router } from '@angular/router';

class PagedJobTitleRequestDto extends PagedRequestDto {
}

@Component({
  selector: 'app-job-title',
  templateUrl: './job-title.component.html',
  animations: [appModuleAnimation()]
})
export class JobTitleComponent extends PagedListingComponentBase<ReadJobTitleDto> {
  jobTitles: ReadJobTitleDto[] = [];
  private routeSub: Subscription;



  constructor(
    injector: Injector,
    private _jobTitleService: JobTitleServiceProxy,
    private _modalService: BsModalService,
    private router : Router,
    private route: ActivatedRoute,
  ) {
    super(injector);
  }

  list(
    request: PagedJobTitleRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    let id;
    this.routeSub = this.route.params.subscribe(params => {
      id =  params['id'];
    });
    this._jobTitleService
      .getAllbyId(id,request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: ReadJobTitleDtoPagedResultDto) => {
        this.jobTitles = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(jobTitle: ReadJobTitleDto): void {
    abp.message.confirm(
      this.l('JobTitleDeleteWarningMessage', jobTitle.name),
      undefined,
      (result: boolean) => {
        if (result) {
          this._jobTitleService
            .delete(jobTitle.id)
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

  createJobTitle(): void {
    let id;
    this.routeSub = this.route.params.subscribe(params => {
      id =  params['id'];
    });
    this.showCreateWithId(id); 
   }

   private showCreateWithId(id?: string): void {
    let showCreateOnlyWithId: BsModalRef;
    showCreateOnlyWithId = this._modalService.show(
      CreateJobTitleDialogComponent,
      {
        class: 'modal-lg',
        initialState: {
          id: id,
        },
      }
    );
    showCreateOnlyWithId.content.onSave.subscribe(() => {
      this.refresh();
    });

  }

  editJobTitle(jobTitle: ReadJobTitleDto): void {
    this.showCreateOrEditReligionDialog(jobTitle.id);
  }

  showCreateOrEditReligionDialog(id?: string): void {
    let createOrEditReligionDialog: BsModalRef;
    if (!id) {
      createOrEditReligionDialog = this._modalService.show(
        CreateJobTitleDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      createOrEditReligionDialog = this._modalService.show(
        EditJobTitleDialogComponent,
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

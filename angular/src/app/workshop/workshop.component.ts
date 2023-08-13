import { Component, Injector } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { ReadAttendanceFormDto, ReadWorkshopDto, ReadWorkshopDtoPagedResultDto, WorkshopServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { Subscription, finalize } from 'rxjs';
import { CreateWorkshopDialogComponent } from './create-workshop-dialog/create-workshop-dialog.component';
import { EditWorkshopDialogComponent } from './edit-workshop-dialog/edit-workshop-dialog.component';

class PagedWorkshopsRequestDto extends PagedRequestDto {
}

@Component({
  selector: 'app-workshop',
  templateUrl: './workshop.component.html',
  animations: [appModuleAnimation()]
})
export class WorkshopComponent extends PagedListingComponentBase<ReadWorkshopDto> {
  workshops: ReadWorkshopDto[] = [];
  attendanceForm : ReadAttendanceFormDto;
  private routeSub: Subscription;



  constructor(
    injector: Injector,
    private _workshopService: WorkshopServiceProxy,
    private _modalService: BsModalService,
    private route: ActivatedRoute,
    private router : Router
  ) {
    super(injector);
  }

  list(
    request: PagedWorkshopsRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    this._workshopService
      .getAll(request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: ReadWorkshopDtoPagedResultDto) => {
        this.workshops = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(workshop: ReadWorkshopDto): void {
    abp.message.confirm(
      this.l('WorkshopDeleteWarningMessage', workshop.name),
      undefined,
      (result: boolean) => {
        if (result) {
          this._workshopService
            .delete(workshop.id)
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

  createWorkshop(): void {
    let id;
    this.routeSub = this.route.params.subscribe(params => {
      id =  params['id'];
    });
    this.showCreateWithId(id);
  }

  editWorkshop(workshop: ReadWorkshopDto): void {
    this.showCreateOrEditPhaseDialog(workshop.id);
  }

  private showCreateWithId(id?: string): void {
    let showCreateOnlyWithId: BsModalRef;
    showCreateOnlyWithId = this._modalService.show(
      CreateWorkshopDialogComponent,
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

  private showCreateOrEditPhaseDialog(id?: string): void {
    let showCreateOrEditProjectDialog: BsModalRef;
    if (!id) {
      showCreateOrEditProjectDialog = this._modalService.show(
        CreateWorkshopDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      showCreateOrEditProjectDialog = this._modalService.show(
        EditWorkshopDialogComponent,
        {
          class: 'modal-lg',
          initialState: {
            id: id,
            attendanceFormId : this.attendanceForm.id,
          },
        }
      );
    }

    showCreateOrEditProjectDialog.content.onSave.subscribe(() => {
      this.refresh();
    });

  }

}

import { Component, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { ReadWorkflowDto, ReadWorkflowDtoPagedResultDto, WorkflowServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs';
import { CreateWorkflowDialogComponent } from './create-workflow-dialog/create-workflow-dialog.component';
import { EditWorkflowDialogComponent } from './edit-workflow-dialog/edit-workflow-dialog.component';

class PagedWorkflowsRequestDto extends PagedRequestDto {
}

@Component({
  selector: 'app-workflow',
  templateUrl: './workflow.component.html',
  animations: [appModuleAnimation()]
})
export class WorkflowComponent extends PagedListingComponentBase<ReadWorkflowDto> {
  workflows: ReadWorkflowDto[] = [];

  constructor(
    injector: Injector,
    private _workflowService: WorkflowServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }

  list(
    request: PagedWorkflowsRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    this._workflowService
      .getAll(request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: ReadWorkflowDtoPagedResultDto) => {
        this.workflows = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(workflow: ReadWorkflowDto): void {
    abp.message.confirm(
      this.l('EntranceExitRecordDeleteWarningMessage', workflow.id),
      undefined,
      (result: boolean) => {
        if (result) {
          this._workflowService
            .delete(workflow.id)
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

  createWorkflow(): void {
    this.showCreateOrEditEmployeeDialog();
  }

  editWorkflow(workflow: ReadWorkflowDto): void {
    this.showCreateOrEditEmployeeDialog(workflow.id);
  }


  showCreateOrEditEmployeeDialog(id?: string): void {
    let createOrEditEmployeeDialog: BsModalRef;
    if (!id) {
      createOrEditEmployeeDialog = this._modalService.show(
        CreateWorkflowDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      createOrEditEmployeeDialog = this._modalService.show(
        EditWorkflowDialogComponent,
        {
          class: 'modal-lg',
          initialState: {
            id: id,
          },
        }
      );
    }

    createOrEditEmployeeDialog.content.onSave.subscribe(() => {
      this.refresh();
    });
  }

}

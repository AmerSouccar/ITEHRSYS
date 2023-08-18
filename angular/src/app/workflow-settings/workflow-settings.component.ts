import { Component, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { ReadWorkflowSettingDto, ReadWorkflowSettingDtoPagedResultDto, WorkflowSettingServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs';
import { CreateWorkflowSettingsDialogComponent } from './create-workflow-settings-dialog/create-workflow-settings-dialog.component';
import { EditWorkflowSettingsDialogComponent } from './edit-workflow-settings-dialog/edit-workflow-settings-dialog.component';

class PagedWorkflowSettingsRequestDto extends PagedRequestDto {
}


@Component({
  selector: 'app-workflow-settings',
  templateUrl: './workflow-settings.component.html',
  animations: [appModuleAnimation()]
})
export class WorkflowSettingsComponent extends PagedListingComponentBase<ReadWorkflowSettingDto> {
  workflowSettings: ReadWorkflowSettingDto[] = [];

  constructor(
    injector: Injector,
    private _workflowSettingService: WorkflowSettingServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }

  list(
    request: PagedWorkflowSettingsRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    this._workflowSettingService
      .getAll(request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: ReadWorkflowSettingDtoPagedResultDto) => {
        this.workflowSettings = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(workflow: ReadWorkflowSettingDto): void {
    abp.message.confirm(
      this.l('WorkflowSettingsRecordDeleteWarningMessage', workflow.id),
      undefined,
      (result: boolean) => {
        if (result) {
          this._workflowSettingService
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

  editWorkflow(workflow: ReadWorkflowSettingDto): void {
    this.showCreateOrEditEmployeeDialog(workflow.id);
  }


  showCreateOrEditEmployeeDialog(id?: string): void {
    let createOrEditEmployeeDialog: BsModalRef;
    if (!id) {
      createOrEditEmployeeDialog = this._modalService.show(
        CreateWorkflowSettingsDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      createOrEditEmployeeDialog = this._modalService.show(
        EditWorkflowSettingsDialogComponent,
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

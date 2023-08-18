import { Component, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { AssignmentServiceProxy, ReadAssignmentDto, ReadAssignmentDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs';
import { CreateAssignmentDialogComponent } from './create-assignment-dialog/create-assignment-dialog.component';

class PagedAssignmentRequestDto extends PagedRequestDto {
}

@Component({
  selector: 'app-assignment',
  templateUrl: './assignment.component.html',
  animations: [appModuleAnimation()]
})
export class AssignmentComponent extends PagedListingComponentBase<ReadAssignmentDto> {
  assignments: ReadAssignmentDto[] = [];


  constructor(
    injector: Injector,
    private _assignmentService: AssignmentServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }

  list(
    request: PagedAssignmentRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    this._assignmentService
      .getAll(request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: ReadAssignmentDtoPagedResultDto) => {
        this.assignments = result.items;
        console.log(result.items);
        this.showPaging(result, pageNumber);
      });
  }

  delete(assignment: ReadAssignmentDto): void {
    abp.message.confirm(
      this.l('AssignmentDeleteWarningMessage', assignment.id),
      undefined,
      (result: boolean) => {
        if (result) {
          this._assignmentService
            .delete(assignment.id)
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

  createAssignment(): void {
    this.showCreateOrEditCountryDialog();
  }

  editAssignment(assignment: ReadAssignmentDto): void {
    this.showCreateOrEditCountryDialog(assignment.id);
  }

  showCreateOrEditCountryDialog(id?: string): void {
    let createOrEditCountryDialog: BsModalRef;
    if (!id) {
      createOrEditCountryDialog = this._modalService.show(
        CreateAssignmentDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      // createOrEditCountryDialog = this._modalService.show(
      //   EditCountryDialogComponent,
      //   {
      //     class: 'modal-lg',
      //     initialState: {
      //       id: id,
      //     },
      //   }
      // );
    }

    createOrEditCountryDialog.content.onSave.subscribe(() => {
      this.refresh();
    });
  }

}

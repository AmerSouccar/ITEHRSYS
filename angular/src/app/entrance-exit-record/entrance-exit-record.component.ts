import { Component, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { EntranceExitRecordServiceProxy, ReadEntranceExitRecordDto, ReadEntranceExitRecordDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs';
import { CreateEntranceExitRecordDialogComponent } from './create-entrance-exit-record-dialog/create-entrance-exit-record-dialog.component';
import { EditEntranceExitRecordDialogComponent } from './edit-entrance-exit-record-dialog/edit-entrance-exit-record-dialog.component';

class PagedEntraneExitRecordsRequestDto extends PagedRequestDto {
}

@Component({
  selector: 'app-entrance-exit-record',
  templateUrl: './entrance-exit-record.component.html',
  animations: [appModuleAnimation()]
})
export class EntranceExitRecordComponent extends PagedListingComponentBase<ReadEntranceExitRecordDto> {
  records: ReadEntranceExitRecordDto[] = [];

  constructor(
    injector: Injector,
    private _entraneExitRecordService: EntranceExitRecordServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }

  list(
    request: PagedEntraneExitRecordsRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    this._entraneExitRecordService
      .getAll(request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: ReadEntranceExitRecordDtoPagedResultDto) => {
        this.records = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(record: ReadEntranceExitRecordDto): void {
    abp.message.confirm(
      this.l('EntranceExitRecordDeleteWarningMessage', record.id),
      undefined,
      (result: boolean) => {
        if (result) {
          this._entraneExitRecordService
            .delete(record.id)
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

  createRecord(): void {
    this.showCreateOrEditEmployeeDialog();
  }

  editRecord(record: ReadEntranceExitRecordDto): void {
    this.showCreateOrEditEmployeeDialog(record.id);
  }

  showCreateOrEditEmployeeDialog(id?: string): void {
    let createOrEditEmployeeDialog: BsModalRef;
    if (!id) {
      createOrEditEmployeeDialog = this._modalService.show(
        CreateEntranceExitRecordDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      createOrEditEmployeeDialog = this._modalService.show(
        EditEntranceExitRecordDialogComponent,
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

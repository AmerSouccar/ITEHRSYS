import { Component, Injector } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { AttendanceRecordServiceProxy, ReadAttendanceRecordDto, ReadAttendanceRecordDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { Subscription, finalize } from 'rxjs';
import { CreateAttendanceRecordDialogComponent } from './create-attendance-record-dialog/create-attendance-record-dialog.component';
import { EditAttendanceRecordDialogComponent } from './edit-attendance-record-dialog/edit-attendance-record-dialog.component';

class PagedAttendanceRecordRequestDto extends PagedRequestDto {
}

@Component({
  selector: 'app-attendance-record',
  templateUrl: './attendance-record.component.html',
  animations: [appModuleAnimation()]
})
export class AttendanceRecordComponent extends PagedListingComponentBase<ReadAttendanceRecordDto> {
  attendanceRecords: ReadAttendanceRecordDto[] = [];
  private routeSub: Subscription;

  constructor(
    injector: Injector,
    private _attendanceRecordService: AttendanceRecordServiceProxy,
    private _modalService: BsModalService,
    private route: ActivatedRoute,
    private router : Router
  ) {
    super(injector);
  }

  ngOnInit(): void {
    this.refresh();
  }

  list(
    request: PagedAttendanceRecordRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    let id;
    this.routeSub = this.route.params.subscribe(params => {
      id =  params['id'];
    });
    this._attendanceRecordService
      .getAll(request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: ReadAttendanceRecordDtoPagedResultDto) => {
        this.attendanceRecords = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(attendanceRecord: ReadAttendanceRecordDto): void {
    abp.message.confirm(
      this.l('AttendanceRecordDeleteWarningMessage', attendanceRecord.name),
      undefined,
      (result: boolean) => {
        if (result) {
          this._attendanceRecordService
            .delete(attendanceRecord.id)
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

  createAttendanceRecord(): void {
    let id;
    this.routeSub = this.route.params.subscribe(params => {
      id =  params['id'];
    });
    this.showCreateWithId(id);
  }

  editAttendanceRecord(attendanceRecord: ReadAttendanceRecordDto): void {
    this.showCreateOrEditPhaseDialog(attendanceRecord.id);
  }

  private showCreateWithId(id?: string): void {
    let showCreateOnlyWithId: BsModalRef;
    showCreateOnlyWithId = this._modalService.show(
      CreateAttendanceRecordDialogComponent,
      {
        class: 'modal-lg',
        initialState: {
          // id: id,
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
        CreateAttendanceRecordDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      showCreateOrEditProjectDialog = this._modalService.show(
        EditAttendanceRecordDialogComponent,
        {
          class: 'modal-lg',
          initialState: {
            id: id,
          },
        }
      );
    }

    showCreateOrEditProjectDialog.content.onSave.subscribe(() => {
      this.refresh();
    });

  }

  onCardsButtonClick(event){
     this.router.navigateByUrl('app/attendanceRecord/' + event.id +'/monthlyCards');
  }

  onGenerateMonthButtonClick(event){
    // open new window that have all employees
    // check employees
    // generate
  }

  onCalculateMonthButtonClick(event){
    this._attendanceRecordService.calculateMonth(event.id).pipe(
      finalize(() => {
        abp.notify.success(this.l('Calculated!'));
        this.refresh();
      })
    )
    .subscribe(() => {});
  }

}

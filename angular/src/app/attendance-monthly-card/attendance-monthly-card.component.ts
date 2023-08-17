import { Component, Injector } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { AttendanceMonthlyCardServiceProxy, ReadAttendanceMonthlyCardDto, ReadAttendanceMonthlyCardDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { Subscription, finalize } from 'rxjs';

class PagedAttendanceMonthlyCardRequestDto extends PagedRequestDto {
}

@Component({
  selector: 'app-attendance-monthly-card',
  templateUrl: './attendance-monthly-card.component.html',
  animations: [appModuleAnimation()]
})
export class AttendanceMonthlyCardComponent extends PagedListingComponentBase<ReadAttendanceMonthlyCardDto> {
  attendanceMonthlyCards: ReadAttendanceMonthlyCardDto[] = [];

  constructor(
    injector: Injector,
    private _attendanceMonthlyCardService: AttendanceMonthlyCardServiceProxy,
    private _modalService: BsModalService,
    private router : Router,
    private route: ActivatedRoute,
  ) {
    super(injector);
  }

    private routeSub: Subscription;


  list(
    request: PagedAttendanceMonthlyCardRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    let id;
    this.routeSub = this.route.params.subscribe(params => {
      id =  params['id'];
    });
    this._attendanceMonthlyCardService
      .getAllbyId(id,request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: ReadAttendanceMonthlyCardDtoPagedResultDto) => {
        this.attendanceMonthlyCards = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(attendanceMonthlyCard: ReadAttendanceMonthlyCardDto): void {
    abp.message.confirm(
      this.l('AttendanceMonthlyCardDeleteWarningMessage', attendanceMonthlyCard.id),
      undefined,
      (result: boolean) => {
        if (result) {
          this._attendanceMonthlyCardService
            .delete(attendanceMonthlyCard.id)
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

  // createAttendanceMonthlyCard(): void {
  //   this.showCreateOrEditEmployeeDialog();
  // }

  // editAttendanceMonthlyCard(attendanceMonthlyCard: ReadAttendanceMonthlyCardDto): void {
  //   this.showCreateOrEditEmployeeDialog(attendanceMonthlyCard.id);
  // }

  // showCreateOrEditEmployeeDialog(id?: string): void {
  //   let createOrEditEmployeeDialog: BsModalRef;
  //   if (!id) {
  //     createOrEditEmployeeDialog = this._modalService.show(
  //       CreateAttendanceFormDialogComponent,
  //       {
  //         class: 'modal-lg',
  //       }
  //     );
  //   } else {
  //     createOrEditEmployeeDialog = this._modalService.show(
  //       EditAttendanceFormDialogComponent,
  //       {
  //         class: 'modal-lg',
  //         initialState: {
  //           id: id,
  //         },
  //       }
  //     );
  //   }

  //   createOrEditEmployeeDialog.content.onSave.subscribe(() => {
  //     this.refresh();
  //   });
  // }

  // onWorkshopButtonClick(event)
  // {
  //   this.router.navigateByUrl('app/attendanceForm/' + event.id +'/workshops');
  // }

}



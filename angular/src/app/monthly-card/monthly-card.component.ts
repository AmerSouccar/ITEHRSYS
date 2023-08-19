import { Component, Injector } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { MonthlyCardServiceProxy, ReadMonthlyCardDto, ReadMonthlyCardDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalService } from 'ngx-bootstrap/modal';
import { Subscription, finalize } from 'rxjs';

class PagedMonthlyCardsRequestDto extends PagedRequestDto {
}

@Component({
  selector: 'app-monthly-card',
  templateUrl: './monthly-card.component.html',
  animations: [appModuleAnimation()]
})
export class MonthlyCardComponent extends PagedListingComponentBase<ReadMonthlyCardDto> {
  monthlyCards: ReadMonthlyCardDto[] = [];

  constructor(
    injector: Injector,
    private _monthlyCardService: MonthlyCardServiceProxy,
    private _modalService: BsModalService,
    private router : Router,
    private route: ActivatedRoute,
  ) {
    super(injector);
  }

    private routeSub: Subscription;


  list(
    request: PagedMonthlyCardsRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    let id;
    this.routeSub = this.route.params.subscribe(params => {
      id =  params['id'];
    });
    this._monthlyCardService
      .getAllbyId(id,request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: ReadMonthlyCardDtoPagedResultDto) => {
        this.monthlyCards = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(attendanceMonthlyCard: ReadMonthlyCardDto): void {
    // abp.message.confirm(
    //   this.l('AttendanceMonthlyCardDeleteWarningMessage', attendanceMonthlyCard.id),
    //   undefined,
    //   (result: boolean) => {
    //     if (result) {
    //       this._attendanceMonthlyCardService
    //         .delete(attendanceMonthlyCard.id)
    //         .pipe(
    //           finalize(() => {
    //             abp.notify.success(this.l('SuccessfullyDeleted'));
    //             this.refresh();
    //           })
    //         )
    //         .subscribe(() => {});
    //     }
    //   }
    // );
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



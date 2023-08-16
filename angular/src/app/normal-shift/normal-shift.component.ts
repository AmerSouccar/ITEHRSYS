import { Component, Injector } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { NormalShiftServiceProxy, ReadNormalShiftDto, ReadNormalShiftDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { Subscription, finalize } from 'rxjs';
import { CreateNormalShiftDialogComponent } from './create-normal-shift-dialog/create-normal-shift-dialog.component';
import { EditNormalShiftDialogComponent } from './edit-normal-shift-dialog/edit-normal-shift-dialog.component';

class PagedNormalShiftsRequestDto extends PagedRequestDto {
}

@Component({
  selector: 'app-normal-shift',
  templateUrl: './normal-shift.component.html',
  animations: [appModuleAnimation()]
})
export class NormalShiftComponent extends PagedListingComponentBase<ReadNormalShiftDto> {
  normalShifts: ReadNormalShiftDto[] = [];
  private routeSub: Subscription;



  constructor(
    injector: Injector,
    private _normalShiftService: NormalShiftServiceProxy,
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
    request: PagedNormalShiftsRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    let id;
    this.routeSub = this.route.params.subscribe(params => {
      id =  params['id'];
    });
    this._normalShiftService
      .getAllById(id,request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: ReadNormalShiftDtoPagedResultDto) => {
        this.normalShifts = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(normalShift: ReadNormalShiftDto): void {
    abp.message.confirm(
      this.l('WorkshopDeleteWarningMessage', normalShift.id),
      undefined,
      (result: boolean) => {
        if (result) {
          this._normalShiftService
            .delete(normalShift.id)
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

  createNormalShift(): void {
    let id;
    this.routeSub = this.route.params.subscribe(params => {
      id =  params['id'];
    });
    this.showCreateWithId(id);
  }

  editNormalShift(normalShift: ReadNormalShiftDto): void {
    this.showCreateOrEditPhaseDialog(normalShift.id);
  }

  private showCreateWithId(id?: string): void {
    let showCreateOnlyWithId: BsModalRef;
    showCreateOnlyWithId = this._modalService.show(
      CreateNormalShiftDialogComponent,
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
        CreateNormalShiftDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      showCreateOrEditProjectDialog = this._modalService.show(
        EditNormalShiftDialogComponent,
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

  onNormalShiftButtonClick(event){
    this.router.navigateByUrl('app/workshop/' + event.id +'/normalshifts');
  }

}

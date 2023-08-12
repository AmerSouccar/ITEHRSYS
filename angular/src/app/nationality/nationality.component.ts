import { Component, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { NationalityDto, NationalityDtoPagedResultDto, NationalityServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs';
import { CreateNationalityDialogComponent } from './create-nationality-dialog/create-nationality-dialog.component';
import { EditNationalityDialogComponent } from './edit-nationality-dialog/edit-nationality-dialog.component';

class PagedNationalitiesRequestDto extends PagedRequestDto {
}

@Component({
  selector: 'app-nationality',
  templateUrl: './nationality.component.html',
  animations: [appModuleAnimation()]
})
export class NationalityComponent extends PagedListingComponentBase<NationalityDto> {
  nationalities: NationalityDto[] = [];


  constructor(
    injector: Injector,
    private _nationalityService: NationalityServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }

  list(
    request: PagedNationalitiesRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    this._nationalityService
      .getAll(request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: NationalityDtoPagedResultDto) => {
        this.nationalities = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(nationality: NationalityDto): void {
    abp.message.confirm(
      this.l('NationalityDeleteWarningMessage', nationality.name),
      undefined,
      (result: boolean) => {
        if (result) {
          this._nationalityService
            .delete(nationality.id)
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

  createNationality(): void {
    this.showCreateOrEditCountryDialog();
  }

  editNationality(nationality: NationalityDto): void {
    this.showCreateOrEditCountryDialog(nationality.id);
  }

  showCreateOrEditCountryDialog(id?: string): void {
    let createOrEditCountryDialog: BsModalRef;
    if (!id) {
      createOrEditCountryDialog = this._modalService.show(
        CreateNationalityDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      createOrEditCountryDialog = this._modalService.show(
        EditNationalityDialogComponent,
        {
          class: 'modal-lg',
          initialState: {
            id: id,
          },
        }
      );
    }

    createOrEditCountryDialog.content.onSave.subscribe(() => {
      this.refresh();
    });
  }

}

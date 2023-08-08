import { Component, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { CityDto, CityDtoPagedResultDto, CityServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs';
import { CreateCityDialogComponent } from './create-city-dialog/create-city-dialog.component';
import { EditCityDialogComponent } from './edit-city-dialog/edit-city-dialog.component';

class PagedCitiesRequestDto extends PagedRequestDto {
}

@Component({
  selector: 'app-city',
  templateUrl: './city.component.html',
  animations: [appModuleAnimation()]
})
export class CityComponent extends PagedListingComponentBase<CityDto> {
  cities: CityDto[] = [];


  constructor(
    injector: Injector,
    private _cityService: CityServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }

  list(
    request: PagedCitiesRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    this._cityService
      .getAll(request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: CityDtoPagedResultDto) => {
        this.cities = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(city: CityDto): void {
    abp.message.confirm(
      this.l('CityDeleteWarningMessage', city.name),
      undefined,
      (result: boolean) => {
        if (result) {
          this._cityService
            .delete(city.id)
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

  createCity(): void {
    this.showCreateOrEditCityDialog();
  }

  editRole(city: CityDto): void {
    this.showCreateOrEditCityDialog(city.id);
  }

  showCreateOrEditCityDialog(id?: string): void {
    let createOrEditCityDialog: BsModalRef;
    if (!id) {
      createOrEditCityDialog = this._modalService.show(
        CreateCityDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      createOrEditCityDialog = this._modalService.show(
        EditCityDialogComponent,
        {
          class: 'modal-lg',
          initialState: {
            id: id,
          },
        }
      );
    }

    createOrEditCityDialog.content.onSave.subscribe(() => {
      this.refresh();
    });
  }


}

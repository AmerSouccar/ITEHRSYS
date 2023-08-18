import { Component, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { OrganizationLevelServiceProxy, ReadOrganizationLevelDto, ReadOrganizationLevelDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs';
import { CreateOrgLevelDialogComponent } from './create-org-level-dialog/create-org-level-dialog.component';
import { EditOrgLevelDialogComponent } from './edit-org-level-dialog/edit-org-level-dialog.component';

class PagedOrgLevelRequestDto extends PagedRequestDto {
}

@Component({
  selector: 'app-org-level',
  templateUrl: './org-level.component.html',
  animations: [appModuleAnimation()]
})
export class OrgLevelComponent extends PagedListingComponentBase<ReadOrganizationLevelDto> {
  orgLevels: ReadOrganizationLevelDto[] = [];


  constructor(
    injector: Injector,
    private _orgLevelService: OrganizationLevelServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }

  list(
    request: PagedOrgLevelRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    this._orgLevelService
      .getAll(request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: ReadOrganizationLevelDtoPagedResultDto) => {
        this.orgLevels = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(orgLevel: ReadOrganizationLevelDto): void {
    abp.message.confirm(
      this.l('OrganizationLevelDeleteWarningMessage', orgLevel.name),
      undefined,
      (result: boolean) => {
        if (result) {
          this._orgLevelService
            .delete(orgLevel.id)
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

  editNationality(orgLevel: ReadOrganizationLevelDto): void {
    this.showCreateOrEditCountryDialog(orgLevel.id);
  }

  showCreateOrEditCountryDialog(id?: string): void {
    let createOrEditCountryDialog: BsModalRef;
    if (!id) {
      createOrEditCountryDialog = this._modalService.show(
        CreateOrgLevelDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      createOrEditCountryDialog = this._modalService.show(
        EditOrgLevelDialogComponent,
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

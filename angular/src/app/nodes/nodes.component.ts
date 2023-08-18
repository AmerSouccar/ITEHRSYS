import { Component, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { NodeServiceProxy, ReadNodeDto, ReadNodeDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs';
import { CreateNodesDialogComponent } from './create-nodes-dialog/create-nodes-dialog.component';
import { EditNodesDialogComponent } from './edit-nodes-dialog/edit-nodes-dialog.component';

class PagedNodesRequestDto extends PagedRequestDto {
}

@Component({
  selector: 'app-nodes',
  templateUrl: './nodes.component.html',
  animations: [appModuleAnimation()]
})
export class NodesComponent extends PagedListingComponentBase<ReadNodeDto> {
  nodes: ReadNodeDto[] = [];


  constructor(
    injector: Injector,
    private _nodesService: NodeServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }

  list(
    request: PagedNodesRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    this._nodesService
      .getAll(request.skipCount, request.maxResultCount)
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: ReadNodeDtoPagedResultDto) => {
        this.nodes = result.items;
        this.showPaging(result, pageNumber);
      });
  }

  delete(node: ReadNodeDto): void {
    abp.message.confirm(
      this.l('NationalityDeleteWarningMessage', node.name),
      undefined,
      (result: boolean) => {
        if (result) {
          this._nodesService
            .delete(node.id)
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

  createNode(): void {
    this.showCreateOrEditCountryDialog();
  }

  editNode(node: ReadNodeDto): void {
    this.showCreateOrEditCountryDialog(node.id);
  }

  showCreateOrEditCountryDialog(id?: string): void {
    let createOrEditCountryDialog: BsModalRef;
    if (!id) {
      createOrEditCountryDialog = this._modalService.show(
        CreateNodesDialogComponent,
        {
          class: 'modal-lg',
        }
      );
    } else {
      createOrEditCountryDialog = this._modalService.show(
        EditNodesDialogComponent,
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

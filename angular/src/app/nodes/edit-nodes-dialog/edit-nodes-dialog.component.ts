import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { NodeServiceProxy, ReadNodeDto, ReadNodeDtoPagedResultDto, UpdateNodeDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-edit-nodes-dialog',
  templateUrl: './edit-nodes-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class EditNodesDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
node : UpdateNodeDto = new UpdateNodeDto();
id: string;

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _nodeService: NodeServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

allNodes : ReadNodeDto[];


ngOnInit(): void {

  this._nodeService.getAll(0,100).subscribe((result: ReadNodeDtoPagedResultDto) => {
    this.allNodes = result.items;
    const nodeIndex = this.allNodes.findIndex(n => n.id === this.node.id);

    if (nodeIndex !== -1) {
        this.allNodes.splice(nodeIndex, 1);
    }
  });

  this._nodeService.getForEdit(this.id).subscribe((result: UpdateNodeDto) => {
    this.node = result;
  });
}

save(): void {
  this.saving = true;

  this._nodeService.update(this.node).subscribe(
    () => {
      this.notify.info(this.l('SavedSuccessfully'));
      this.bsModalRef.hide();
      this.onSave.emit();
    },
    () => {
      this.saving = false;
    }
  );
}
}
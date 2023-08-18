import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { InsertNodeDto, NodeServiceProxy, ReadNodeDto, ReadNodeDtoPagedResultDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-create-nodes-dialog',
  templateUrl: './create-nodes-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreateNodesDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
node = new InsertNodeDto();
allNodes : ReadNodeDto[];

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _nodeService: NodeServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  this._nodeService.getAll(0,100).subscribe((result: ReadNodeDtoPagedResultDto) => {
    this.allNodes = result.items;
  });
}


save(): void {
  this.saving = true;
  if(this.node.isRoot)
    this.node.parentId = null;
  this._nodeService.insert(this.node).subscribe(
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
import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { EntranceExitRecordServiceProxy, FileParameter } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-import-from-excel-dialog',
  templateUrl: './import-from-excel-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class ImportFromExcelDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
file : any ;
id: string;

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  public _entranceExitRecordService: EntranceExitRecordServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {

}

onFileChange(event){
  this.file = event.target.files[0];
}

save(): void {
  this.saving = true;
  const fileParameter: FileParameter = {
    data: this.file,
    fileName: this.file.name,
  };
    this._entranceExitRecordService.importDataFromExcel(fileParameter).subscribe(
    () => {
      this.notify.info(this.l('ImportedSuccessfully'));
      this.bsModalRef.hide();
      this.onSave.emit();
    },
    () => {
      this.saving = false;
    }
  );
}
}
import { Component } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';

@Component({
  selector: 'app-edit-workshop-dialog',
  templateUrl: './edit-workshop-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class EditWorkshopDialogComponent {

}

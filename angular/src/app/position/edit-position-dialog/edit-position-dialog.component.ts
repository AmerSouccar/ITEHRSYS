import { Component } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';

@Component({
  selector: 'app-edit-position-dialog',
  templateUrl: './edit-position-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class EditPositionDialogComponent {

}

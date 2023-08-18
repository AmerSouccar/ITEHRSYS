import { Component } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';

@Component({
  selector: 'app-edit-leave-request-dialog',
  templateUrl: './edit-leave-request-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class EditLeaveRequestDialogComponent {

}

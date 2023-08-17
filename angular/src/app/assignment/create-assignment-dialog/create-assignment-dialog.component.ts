import { Component } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';

@Component({
  selector: 'app-create-assignment-dialog',
  templateUrl: './create-assignment-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreateAssignmentDialogComponent {

}

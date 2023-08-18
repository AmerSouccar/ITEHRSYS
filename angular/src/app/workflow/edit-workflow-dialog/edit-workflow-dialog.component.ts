import { Component } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';

@Component({
  selector: 'app-edit-workflow-dialog',
  templateUrl: './edit-workflow-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class EditWorkflowDialogComponent {

}

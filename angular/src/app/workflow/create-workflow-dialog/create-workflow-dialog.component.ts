import { Component } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';

@Component({
  selector: 'app-create-workflow-dialog',
  templateUrl: './create-workflow-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreateWorkflowDialogComponent {

}

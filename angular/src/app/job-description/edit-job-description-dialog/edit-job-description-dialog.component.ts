import { Component } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';

@Component({
  selector: 'app-edit-job-description-dialog',
  templateUrl: './edit-job-description-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class EditJobDescriptionDialogComponent {

}

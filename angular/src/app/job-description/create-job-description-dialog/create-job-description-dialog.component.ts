import { Component } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';

@Component({
  selector: 'app-create-job-description-dialog',
  templateUrl: './create-job-description-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreateJobDescriptionDialogComponent {

}

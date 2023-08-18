import { Component } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';

@Component({
  selector: 'app-job-description',
  templateUrl: './job-description.component.html',
  animations: [appModuleAnimation()]
})
export class JobDescriptionComponent {

}

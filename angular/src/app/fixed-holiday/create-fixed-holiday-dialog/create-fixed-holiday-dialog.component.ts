import { Component } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';

@Component({
  selector: 'app-create-fixed-holiday-dialog',
  templateUrl: './create-fixed-holiday-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreateFixedHolidayDialogComponent {

}

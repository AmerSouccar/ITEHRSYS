import { Component } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';

@Component({
  selector: 'app-fixed-holiday',
  templateUrl: './fixed-holiday.component.html',
  animations: [appModuleAnimation()]
})
export class FixedHolidayComponent {

}

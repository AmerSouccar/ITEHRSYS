import { Component } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';

@Component({
  selector: 'app-payroll-month',
  templateUrl: './payroll-month.component.html',
  animations: [appModuleAnimation()]
})
export class PayrollMonthComponent {

}

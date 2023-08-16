import { Component } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';

@Component({
  selector: 'app-create-attendance-record-dialog',
  templateUrl: './create-attendance-record-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreateAttendanceRecordDialogComponent {

}

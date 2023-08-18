import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { AppRouteGuard } from '@shared/auth/auth-route-guard';
import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { UsersComponent } from './users/users.component';
import { TenantsComponent } from './tenants/tenants.component';
import { RolesComponent } from 'app/roles/roles.component';
import { ChangePasswordComponent } from './users/change-password/change-password.component';
import { CityComponent } from './city/city.component';
import { CountryComponent } from './country/country.component';
import { ReligionComponent } from './religion/religion.component';
import { EmployeeComponent } from './employee/employee.component';
import { NationalityComponent } from './nationality/nationality.component';
import { AttendanceFormComponent } from './attendance-form/attendance-form.component';
import { WorkshopComponent } from './workshop/workshop.component';
import { NormalShiftComponent } from './normal-shift/normal-shift.component';
import { AttendanceRecordComponent } from './attendance-record/attendance-record.component';
import { AttendanceMonthlyCardComponent } from './attendance-monthly-card/attendance-monthly-card.component';
import { EmployeeCardComponent } from './employee-card/employee-card.component';
import { EntranceExitRecordComponent } from './entrance-exit-record/entrance-exit-record.component';
import { AssignmentComponent } from './assignment/assignment.component';
import { NodesComponent } from './nodes/nodes.component';
import { EducationalGradeComponent } from './educational-grade/educational-grade.component';
import { GradeComponent } from './grade/grade.component';
import { JobTitleComponent } from './job-title/job-title.component';
import { OrgLevelComponent } from './org-level/org-level.component';

@NgModule({
    imports: [
        RouterModule.forChild([
            {
                path: '',
                component: AppComponent,
                children: [
                    { path: 'home', component: HomeComponent,  canActivate: [AppRouteGuard] },
                    { path: 'users', component: UsersComponent, data: { permission: 'Pages.Users' }, canActivate: [AppRouteGuard] },
                    { path: 'roles', component: RolesComponent, data: { permission: 'Pages.Roles' }, canActivate: [AppRouteGuard] },
                    { path: 'tenants', component: TenantsComponent, data: { permission: 'Pages.Tenants' }, canActivate: [AppRouteGuard] },
                    { path: 'about', component: AboutComponent, canActivate: [AppRouteGuard] },
                    { path: 'update-password', component: ChangePasswordComponent, canActivate: [AppRouteGuard] },
                    { path: 'cities', component: CityComponent, canActivate: [AppRouteGuard] },
                    { path: 'countries', component: CountryComponent, canActivate: [AppRouteGuard] },
                    { path: 'religions', component: ReligionComponent, canActivate: [AppRouteGuard] },
                    { path: 'employees', component: EmployeeComponent, canActivate: [AppRouteGuard] },
                    { path: 'assignments', component: AssignmentComponent, canActivate: [AppRouteGuard] },
                    { path: 'nodes', component: NodesComponent, canActivate: [AppRouteGuard] },
                    { path: 'employee-cards', component: EmployeeCardComponent, canActivate: [AppRouteGuard] },
                    { path: 'nationalities', component: NationalityComponent, canActivate: [AppRouteGuard] },
                    { path: 'education-grades', component: EducationalGradeComponent, canActivate: [AppRouteGuard] },
                    { path: 'grades', component: GradeComponent, canActivate: [AppRouteGuard] },
                    { path: 'organization-levels', component: OrgLevelComponent, canActivate: [AppRouteGuard] },
                    { path: 'entrance-exit-records', component: EntranceExitRecordComponent, canActivate: [AppRouteGuard] },
                    { path: 'attendanceForms', component: AttendanceFormComponent, canActivate: [AppRouteGuard] },
                    { path: 'attendanceForm/:id/workshops', component:WorkshopComponent ,  canActivate: [AppRouteGuard] },
                    { path: 'workshop/:id/normalshifts', component:NormalShiftComponent ,  canActivate: [AppRouteGuard] },
                    { path: 'attendanceRecords', component: AttendanceRecordComponent, canActivate: [AppRouteGuard] },
                    { path: 'attendanceRecord/:id/monthlyCards', component:AttendanceMonthlyCardComponent ,  canActivate: [AppRouteGuard] },
                    { path: 'grade/:id/jobTitles', component:JobTitleComponent ,  canActivate: [AppRouteGuard] },

                ]
            }
        ])
    ],
    exports: [RouterModule]
})
export class AppRoutingModule { }

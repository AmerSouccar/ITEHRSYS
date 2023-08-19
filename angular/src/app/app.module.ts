import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientJsonpModule } from '@angular/common/http';
import { HttpClientModule } from '@angular/common/http';
import { ModalModule } from 'ngx-bootstrap/modal';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { CollapseModule } from 'ngx-bootstrap/collapse';
import { TabsModule } from 'ngx-bootstrap/tabs';
import { NgxPaginationModule } from 'ngx-pagination';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ServiceProxyModule } from '@shared/service-proxies/service-proxy.module';
import { SharedModule } from '@shared/shared.module';
import { HomeComponent } from '@app/home/home.component';
import { AboutComponent } from '@app/about/about.component';
// tenants
import { TenantsComponent } from '@app/tenants/tenants.component';
import { CreateTenantDialogComponent } from './tenants/create-tenant/create-tenant-dialog.component';
import { EditTenantDialogComponent } from './tenants/edit-tenant/edit-tenant-dialog.component';
// roles
import { RolesComponent } from '@app/roles/roles.component';
import { CreateRoleDialogComponent } from './roles/create-role/create-role-dialog.component';
import { EditRoleDialogComponent } from './roles/edit-role/edit-role-dialog.component';
// users
import { UsersComponent } from '@app/users/users.component';
import { CreateUserDialogComponent } from '@app/users/create-user/create-user-dialog.component';
import { EditUserDialogComponent } from '@app/users/edit-user/edit-user-dialog.component';
import { ChangePasswordComponent } from './users/change-password/change-password.component';
import { ResetPasswordDialogComponent } from './users/reset-password/reset-password.component';
// layout
import { HeaderComponent } from './layout/header.component';
import { HeaderLeftNavbarComponent } from './layout/header-left-navbar.component';
import { HeaderLanguageMenuComponent } from './layout/header-language-menu.component';
import { HeaderUserMenuComponent } from './layout/header-user-menu.component';
import { FooterComponent } from './layout/footer.component';
import { SidebarComponent } from './layout/sidebar.component';
import { SidebarLogoComponent } from './layout/sidebar-logo.component';
import { SidebarUserPanelComponent } from './layout/sidebar-user-panel.component';
import { SidebarMenuComponent } from './layout/sidebar-menu.component';
import { CityComponent } from './city/city.component';
import { CreateCityDialogComponent } from './city/create-city-dialog/create-city-dialog.component';
import { EditCityDialogComponent } from './city/edit-city-dialog/edit-city-dialog.component';
import { CountryComponent } from './country/country.component';
import { CreateCountryDialogComponent } from './country/create-country-dialog/create-country-dialog.component';
import { EditCountryDialogComponent } from './country/edit-country-dialog/edit-country-dialog.component';
import { ReligionComponent } from './religion/religion.component';
import { CreateReligionDialogComponent } from './religion/create-religion-dialog/create-religion-dialog.component';
import { EditReligionDialogComponent } from './religion/edit-religion-dialog/edit-religion-dialog.component';
import { EmployeeComponent } from './employee/employee.component';
import { CreateEmployeeDialogComponent } from './employee/create-employee-dialog/create-employee-dialog.component';
import { EditEmployeeDialogComponent } from './employee/edit-employee-dialog/edit-employee-dialog.component';
import { NationalityComponent } from './nationality/nationality.component';
import { CreateNationalityDialogComponent } from './nationality/create-nationality-dialog/create-nationality-dialog.component';
import { EditNationalityDialogComponent } from './nationality/edit-nationality-dialog/edit-nationality-dialog.component';
import { AttendanceFormComponent } from './attendance-form/attendance-form.component';
import { CreateAttendanceFormDialogComponent } from './attendance-form/create-attendance-form-dialog/create-attendance-form-dialog.component';
import { EditAttendanceFormDialogComponent } from './attendance-form/edit-attendance-form-dialog/edit-attendance-form-dialog.component';
import { WorkshopComponent } from './workshop/workshop.component';
import { CreateWorkshopDialogComponent } from './workshop/create-workshop-dialog/create-workshop-dialog.component';
import { EditWorkshopDialogComponent } from './workshop/edit-workshop-dialog/edit-workshop-dialog.component';
import { NormalShiftComponent } from './normal-shift/normal-shift.component';
import { CreateNormalShiftDialogComponent } from './normal-shift/create-normal-shift-dialog/create-normal-shift-dialog.component';
import { EditNormalShiftDialogComponent } from './normal-shift/edit-normal-shift-dialog/edit-normal-shift-dialog.component';
import { AttendanceRecordComponent } from './attendance-record/attendance-record.component';
import { CreateAttendanceRecordDialogComponent } from './attendance-record/create-attendance-record-dialog/create-attendance-record-dialog.component';
import { EditAttendanceRecordDialogComponent } from './attendance-record/edit-attendance-record-dialog/edit-attendance-record-dialog.component';
import { AttendanceMonthlyCardComponent } from './attendance-monthly-card/attendance-monthly-card.component';
import { EmployeeCardComponent } from './employee-card/employee-card.component';
import { EditEmployeeCardComponent } from './employee-card/edit-employee-card/edit-employee-card.component';
import { EntranceExitRecordComponent } from './entrance-exit-record/entrance-exit-record.component';
import { CreateEntranceExitRecordDialogComponent } from './entrance-exit-record/create-entrance-exit-record-dialog/create-entrance-exit-record-dialog.component';
import { EditEntranceExitRecordDialogComponent } from './entrance-exit-record/edit-entrance-exit-record-dialog/edit-entrance-exit-record-dialog.component';
import { ImportFromExcelDialogComponent } from './entrance-exit-record/import-from-excel-dialog/import-from-excel-dialog.component';
import { AssignmentComponent } from './assignment/assignment.component';
import { CreateAssignmentDialogComponent } from './assignment/create-assignment-dialog/create-assignment-dialog.component';
import { NodesComponent } from './nodes/nodes.component';
import { CreateNodesDialogComponent } from './nodes/create-nodes-dialog/create-nodes-dialog.component';
import { EditNodesDialogComponent } from './nodes/edit-nodes-dialog/edit-nodes-dialog.component';
import { EducationalGradeComponent } from './educational-grade/educational-grade.component';
import { CreateEducationalGradeDialogComponent } from './educational-grade/create-educational-grade-dialog/create-educational-grade-dialog.component';
import { EditEducationalGradeDialogComponent } from './educational-grade/edit-educational-grade-dialog/edit-educational-grade-dialog.component';
import { GradeComponent } from './grade/grade.component';
import { CreateGradeDialogComponent } from './grade/create-grade-dialog/create-grade-dialog.component';
import { EditGradeDialogComponent } from './grade/edit-grade-dialog/edit-grade-dialog.component';
import { JobTitleComponent } from './job-title/job-title.component';
import { CreateJobTitleDialogComponent } from './job-title/create-job-title-dialog/create-job-title-dialog.component';
import { EditJobTitleDialogComponent } from './job-title/edit-job-title-dialog/edit-job-title-dialog.component';
import { OrgLevelComponent } from './org-level/org-level.component';
import { CreateOrgLevelDialogComponent } from './org-level/create-org-level-dialog/create-org-level-dialog.component';
import { EditOrgLevelDialogComponent } from './org-level/edit-org-level-dialog/edit-org-level-dialog.component';
import { JobDescriptionComponent } from './job-description/job-description.component';
import { CreateJobDescriptionDialogComponent } from './job-description/create-job-description-dialog/create-job-description-dialog.component';
import { EditJobDescriptionDialogComponent } from './job-description/edit-job-description-dialog/edit-job-description-dialog.component';
import { PositionWorkTypeComponent } from './position-work-type/position-work-type.component';
import { CreatePositionWorkTypeDialogComponent } from './position-work-type/create-position-work-type-dialog/create-position-work-type-dialog.component';
import { EditPositionWorkTypeDialogComponent } from './position-work-type/edit-position-work-type-dialog/edit-position-work-type-dialog.component';
import { PositionComponent } from './position/position.component';
import { CreatePositionDialogComponent } from './position/create-position-dialog/create-position-dialog.component';
import { EditPositionDialogComponent } from './position/edit-position-dialog/edit-position-dialog.component';
import { ChangeableHolidayComponent } from './changeable-holiday/changeable-holiday.component';
import { CreateChangeableHolidayDialogComponent } from './changeable-holiday/create-changeable-holiday-dialog/create-changeable-holiday-dialog.component';
import { EditChangeableHolidayDialogComponent } from './changeable-holiday/edit-changeable-holiday-dialog/edit-changeable-holiday-dialog.component';
import { CompanyHolidayComponent } from './company-holiday/company-holiday.component';
import { CreateCompanyHolidayDialogComponent } from './company-holiday/create-company-holiday-dialog/create-company-holiday-dialog.component';
import { EditCompanyHolidayDialogComponent } from './company-holiday/edit-company-holiday-dialog/edit-company-holiday-dialog.component';
import { FixedHolidayComponent } from './fixed-holiday/fixed-holiday.component';
import { CreateFixedHolidayDialogComponent } from './fixed-holiday/create-fixed-holiday-dialog/create-fixed-holiday-dialog.component';
import { EditFixedHolidayDialogComponent } from './fixed-holiday/edit-fixed-holiday-dialog/edit-fixed-holiday-dialog.component';
import { WorkflowComponent } from './workflow/workflow.component';
import { CreateWorkflowDialogComponent } from './workflow/create-workflow-dialog/create-workflow-dialog.component';
import { EditWorkflowDialogComponent } from './workflow/edit-workflow-dialog/edit-workflow-dialog.component';
import { WorkflowSettingsComponent } from './workflow-settings/workflow-settings.component';
import { CreateWorkflowSettingsDialogComponent } from './workflow-settings/create-workflow-settings-dialog/create-workflow-settings-dialog.component';
import { EditWorkflowSettingsDialogComponent } from './workflow-settings/edit-workflow-settings-dialog/edit-workflow-settings-dialog.component';
import { LeaveSettingComponent } from './leave-setting/leave-setting.component';
import { CreateLeaveSettingDialogComponent } from './leave-setting/create-leave-setting-dialog/create-leave-setting-dialog.component';
import { EditLeaveSettingDialogComponent } from './leave-setting/edit-leave-setting-dialog/edit-leave-setting-dialog.component';
import { LeaveRequestComponent } from './leave-request/leave-request.component';
import { CreateLeaveRequestDialogComponent } from './leave-request/create-leave-request-dialog/create-leave-request-dialog.component';
import { EditLeaveRequestDialogComponent } from './leave-request/edit-leave-request-dialog/edit-leave-request-dialog.component';
import { PayrollMonthComponent } from './payroll-month/payroll-month.component';
import { CreatePayrollMonthDialogComponent } from './payroll-month/create-payroll-month-dialog/create-payroll-month-dialog.component';
import { EditPayrollMonthDialogComponent } from './payroll-month/edit-payroll-month-dialog/edit-payroll-month-dialog.component';
import { FinancialCardComponent } from './financial-card/financial-card.component';
import { EditFinancialCardDialogComponent } from './financial-card/edit-financial-card-dialog/edit-financial-card-dialog.component';

@NgModule({
    declarations: [
        AppComponent,
        HomeComponent,
        AboutComponent,
        // tenants
        TenantsComponent,
        CreateTenantDialogComponent,
        EditTenantDialogComponent,
        // roles
        RolesComponent,
        CreateRoleDialogComponent,
        EditRoleDialogComponent,
        // users
        UsersComponent,
        CreateUserDialogComponent,
        EditUserDialogComponent,
        ChangePasswordComponent,
        ResetPasswordDialogComponent,
        // layout
        HeaderComponent,
        HeaderLeftNavbarComponent,
        HeaderLanguageMenuComponent,
        HeaderUserMenuComponent,
        FooterComponent,
        SidebarComponent,
        SidebarLogoComponent,
        SidebarUserPanelComponent,
        SidebarMenuComponent,
        CityComponent,
        CreateCityDialogComponent,
        EditCityDialogComponent,
        CountryComponent,
        CreateCountryDialogComponent,
        EditCountryDialogComponent,
        ReligionComponent,
        CreateReligionDialogComponent,
        EditReligionDialogComponent,
        EmployeeComponent,
        CreateEmployeeDialogComponent,
        EditEmployeeDialogComponent,
        NationalityComponent,
        CreateNationalityDialogComponent,
        EditNationalityDialogComponent,
        AttendanceFormComponent,
        CreateAttendanceFormDialogComponent,
        EditAttendanceFormDialogComponent,
        WorkshopComponent,
        CreateWorkshopDialogComponent,
        EditWorkshopDialogComponent,
        NormalShiftComponent,
        CreateNormalShiftDialogComponent,
        EditNormalShiftDialogComponent,
        AttendanceRecordComponent,
        CreateAttendanceRecordDialogComponent,
        EditAttendanceRecordDialogComponent,
        AttendanceMonthlyCardComponent,
        EmployeeCardComponent,
        EditEmployeeCardComponent,
        EntranceExitRecordComponent,
        CreateEntranceExitRecordDialogComponent,
        EditEntranceExitRecordDialogComponent,
        ImportFromExcelDialogComponent,
        AssignmentComponent,
        CreateAssignmentDialogComponent,
        NodesComponent,
        CreateNodesDialogComponent,
        EditNodesDialogComponent,
        EducationalGradeComponent,
        CreateEducationalGradeDialogComponent,
        EditEducationalGradeDialogComponent,
        GradeComponent,
        CreateGradeDialogComponent,
        EditGradeDialogComponent,
        JobTitleComponent,
        CreateJobTitleDialogComponent,
        EditJobTitleDialogComponent,
        OrgLevelComponent,
        CreateOrgLevelDialogComponent,
        EditOrgLevelDialogComponent,
        JobDescriptionComponent,
        CreateJobDescriptionDialogComponent,
        EditJobDescriptionDialogComponent,
        PositionWorkTypeComponent,
        CreatePositionWorkTypeDialogComponent,
        EditPositionWorkTypeDialogComponent,
        PositionComponent,
        CreatePositionDialogComponent,
        EditPositionDialogComponent,
        ChangeableHolidayComponent,
        CreateChangeableHolidayDialogComponent,
        EditChangeableHolidayDialogComponent,
        CompanyHolidayComponent,
        CreateCompanyHolidayDialogComponent,
        EditCompanyHolidayDialogComponent,
        FixedHolidayComponent,
        CreateFixedHolidayDialogComponent,
        EditFixedHolidayDialogComponent,
        WorkflowComponent,
        CreateWorkflowDialogComponent,
        EditWorkflowDialogComponent,
        WorkflowSettingsComponent,
        CreateWorkflowSettingsDialogComponent,
        EditWorkflowSettingsDialogComponent,
        LeaveSettingComponent,
        CreateLeaveSettingDialogComponent,
        EditLeaveSettingDialogComponent,
        LeaveRequestComponent,
        CreateLeaveRequestDialogComponent,
        EditLeaveRequestDialogComponent,
        PayrollMonthComponent,
        CreatePayrollMonthDialogComponent,
        EditPayrollMonthDialogComponent,
        FinancialCardComponent,
        EditFinancialCardDialogComponent,
        
    ],
    imports: [
        CommonModule,
        FormsModule,
        ReactiveFormsModule,
        HttpClientModule,
        HttpClientJsonpModule,
        ModalModule.forChild(),
        BsDropdownModule,
        CollapseModule,
        TabsModule,
        AppRoutingModule,
        ServiceProxyModule,
        SharedModule,
        NgxPaginationModule,
    ],
    providers: []
})
export class AppModule {}

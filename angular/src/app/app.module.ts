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
        EditAttendanceRecordDialogComponent
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

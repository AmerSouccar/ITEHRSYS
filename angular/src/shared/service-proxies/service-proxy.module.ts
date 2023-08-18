import { NgModule } from '@angular/core';
import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { AbpHttpInterceptor } from 'abp-ng2-module';

import * as ApiServiceProxies from './service-proxies';

@NgModule({
    providers: [
        ApiServiceProxies.RoleServiceProxy,
        ApiServiceProxies.SessionServiceProxy,
        ApiServiceProxies.TenantServiceProxy,
        ApiServiceProxies.UserServiceProxy,
        ApiServiceProxies.TokenAuthServiceProxy,
        ApiServiceProxies.AccountServiceProxy,
        ApiServiceProxies.ConfigurationServiceProxy,
        ApiServiceProxies.CityServiceProxy,
        ApiServiceProxies.CountryServiceProxy,
        ApiServiceProxies.ReligionServiceProxy,
        ApiServiceProxies.EmployeeServiceProxy,
        ApiServiceProxies.NationalityServiceProxy,
        ApiServiceProxies.AttendanceFormServiceProxy,
        ApiServiceProxies.WorkshopServiceProxy,
        ApiServiceProxies.NormalShiftServiceProxy,
        ApiServiceProxies.AttendanceRecordServiceProxy,
        ApiServiceProxies.EmployeeCardServiceProxy,
        ApiServiceProxies.AttendanceMonthlyCardServiceProxy,
        ApiServiceProxies.EntranceExitRecordServiceProxy,
        ApiServiceProxies.AssignmentServiceProxy,
        ApiServiceProxies.NodeServiceProxy,
        ApiServiceProxies.EducationGradeServiceProxy,
        ApiServiceProxies.GradeServiceProxy,
        ApiServiceProxies.JobTitleServiceProxy,
        ApiServiceProxies.JobDescriptionServiceProxy,
        ApiServiceProxies.PositionServiceProxy,
        ApiServiceProxies.OrganizationLevelServiceProxy,
        ApiServiceProxies.JobDescriptionServiceProxy,
        { provide: HTTP_INTERCEPTORS, useClass: AbpHttpInterceptor, multi: true }
    ]
})
export class ServiceProxyModule { }

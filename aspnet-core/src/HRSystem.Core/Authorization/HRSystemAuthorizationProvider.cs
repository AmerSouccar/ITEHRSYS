using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace HRSystem.Authorization
{
    public class HRSystemAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Users_Activation, L("UsersActivation"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
           
            context.CreatePermission(PermissionNames.Perm_Employee, L("Employee"));
            context.CreatePermission(PermissionNames.Perm_Employeecard, L("Employeecard"));
            context.CreatePermission(PermissionNames.Perm_Country, L("Country"));
            context.CreatePermission(PermissionNames.Perm_City, L("City"));
            context.CreatePermission(PermissionNames.Perm_Religion, L("Religion"));
            context.CreatePermission(PermissionNames.Perm_Nationality, L("Nationality"));
            context.CreatePermission(PermissionNames.Perm_Nodes, L("Nodes"));
            context.CreatePermission(PermissionNames.Perm_EducationalGrade, L("EducationalGrade"));
            context.CreatePermission(PermissionNames.Perm_Grade, L("Grade"));
            context.CreatePermission(PermissionNames.Perm_OrgLevels, L("OrgLevles"));
            context.CreatePermission(PermissionNames.Perm_JobDescription, L("JobDescription"));
            context.CreatePermission(PermissionNames.Perm_Position, L("Position"));
            context.CreatePermission(PermissionNames.Perm_PositionType, L("PositionType"));
            context.CreatePermission(PermissionNames.Perm_AttendanceForm, L("AttendaceForm"));
            context.CreatePermission(PermissionNames.Perm_AttendanceRecord, L("Attendacerecord"));
            context.CreatePermission(PermissionNames.Perm_EntryExitRecord, L("EntryExitRecord"));
            context.CreatePermission(PermissionNames.Perm_Assignment, L("Assignment"));
            context.CreatePermission(PermissionNames.Perm_ChangableHolidays, L("ChangableHolidays"));
            context.CreatePermission(PermissionNames.Perm_CompanyHolidays, L("CompanyHolidays"));
            context.CreatePermission(PermissionNames.Perm_LeaveSetting, L("LeaveSetting"));
            context.CreatePermission(PermissionNames.Perm_LeaveRequest, L("LeaveRequest"));
            context.CreatePermission(PermissionNames.Perm_LeaveRequestService, L("LeaveRequestService"));
            context.CreatePermission(PermissionNames.Perm_AcceptLeaveRequest, L("AcceptLeaveRequest"));
            context.CreatePermission(PermissionNames.Perm_Month, L("Month"));
            context.CreatePermission(PermissionNames.Perm_FinancialCards, L("FinancialCards"));
            context.CreatePermission(PermissionNames.Perm_WorkFlow, L("WorkFlow"));
            context.CreatePermission(PermissionNames.Perm_WorkFlowSettings, L("WorkFlowSettings"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, HRSystemConsts.LocalizationSourceName);
        }
    }
}

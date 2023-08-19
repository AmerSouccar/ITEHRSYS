import {Component, Injector, OnInit} from '@angular/core';
import {AppComponentBase} from '@shared/app-component-base';
import {
    Router,
    RouterEvent,
    NavigationEnd,
    PRIMARY_OUTLET
} from '@angular/router';
import {BehaviorSubject} from 'rxjs';
import {filter} from 'rxjs/operators';
import {MenuItem} from '@shared/layout/menu-item';

@Component({
    selector: 'sidebar-menu',
    templateUrl: './sidebar-menu.component.html'
})
export class SidebarMenuComponent extends AppComponentBase implements OnInit {
    menuItems: MenuItem[];
    menuItemsMap: { [key: number]: MenuItem } = {};
    activatedMenuItems: MenuItem[] = [];
    routerEvents: BehaviorSubject<RouterEvent> = new BehaviorSubject(undefined);
    homeRoute = '/app/about';

    constructor(injector: Injector, private router: Router) {
        super(injector);
        this.router.events.subscribe(this.routerEvents);
    }

    ngOnInit(): void {
        this.menuItems = this.getMenuItems();
        this.patchMenuItems(this.menuItems);
        this.routerEvents
            .pipe(filter((event) => event instanceof NavigationEnd))
            .subscribe((event) => {
                const currentUrl = event.url !== '/' ? event.url : this.homeRoute;
                const primaryUrlSegmentGroup = this.router.parseUrl(currentUrl).root
                    .children[PRIMARY_OUTLET];
                if (primaryUrlSegmentGroup) {
                    this.activateMenuItems('/' + primaryUrlSegmentGroup.toString());
                }
            });
    }

    getMenuItems(): MenuItem[] {
        return [
            new MenuItem(this.l('About'), '/app/about', 'fas fa-info-circle'),
            new MenuItem(this.l('HomePage'), '/app/home', 'fas fa-home'),
            new MenuItem(
                this.l('Roles'),
                '/app/roles',
                'fas fa-theater-masks',
                'Pages.Roles'
            ),
            new MenuItem(
                this.l('Tenants'),
                '/app/tenants',
                'fas fa-building',
                'Pages.Tenants'
            ),
            new MenuItem(
                this.l('Users'),
                '/app/users',
                'fas fa-users',
                'Pages.Users'
            ),
            new MenuItem(this.l('Administrative'), '', 'fas fa-circle', '', [
                new MenuItem(this.l('Personal'), '', 'fas fa-dot-circle', '', [
                    new MenuItem(
                        this.l('Employee'),
                        '/app/employees',
                        'far fa-circle'
                    ),
                    new MenuItem(
                        this.l('Employee Card'),
                        '/app/employee-cards',
                        'far fa-circle'
                    ),
                    new MenuItem(
                        this.l('Indexes'),
                        '',
                        'fas fa-dot-circle',
                        '',
                        [
                            new MenuItem(
                                this.l('Country'),
                                '/app/countries',
                                'far fa-circle'
                            ),
                            new MenuItem(
                                this.l('City'),
                                '/app/cities',
                                'far fa-circle'
                            ),
                            new MenuItem(
                                this.l('Religion'),
                                '/app/religions',
                                'far fa-circle'
                            ),
                            new MenuItem(
                                this.l('Nationality'),
                                '/app/nationalities',
                                'far fa-circle'
                            ),
                        ]
                    ),
                   
                ]),
                new MenuItem(this.l('OrgChart'), '', 'fas fa-dot-circle', '', [
                    new MenuItem(
                        this.l('Nodes'),
                        '/app/nodes',
                        'far fa-circle'
                    ),
                ]),
                new MenuItem(this.l('Grades'), '', 'fas fa-dot-circle', '', [
                    new MenuItem(
                        this.l('Educational Grade'),
                        '/app/education-grades',
                        'far fa-circle'
                    ),
                    new MenuItem(
                        this.l('Grade'),
                        '/app/grades',
                        'far fa-circle'
                    ),
                    
                    new MenuItem(
                        this.l('Indexes'),
                        '',
                        'fas fa-dot-circle',
                        '',
                        [
                            new MenuItem(
                                this.l('OrgLevels'),
                                '/app/organization-levels',
                                'far fa-circle'
                            ),
                           
                        ]
                    ),
                ]),
                new MenuItem(this.l('Job Descriptions'), '', 'fas fa-dot-circle', '', [
                    new MenuItem(
                        this.l('Job Description'),
                        '/app/job-descriptions',
                        'far fa-circle'
                    ),
                    new MenuItem(
                        this.l('Position'),
                        '/app/positions',
                        'far fa-circle'
                    ),
                  
                    new MenuItem(
                        this.l('Indexes'),
                        '',
                        'fas fa-dot-circle',
                        '',
                        [
                            new MenuItem(
                                this.l('Position Type'),
                                '/app/position-work-types',
                                'far fa-circle'
                            ),
                           
                        ]
                    ),
                ]),
            ]),

            new MenuItem(this.l('Organizational'), '', 'fas fa-circle', '', [
                new MenuItem(this.l('Attendance'), '', 'fas fa-dot-circle', '', [
                    new MenuItem(
                        this.l('AttendanceForm'),
                        '/app/attendanceForms',
                        'far fa-circle'
                    ),
                    new MenuItem(
                        this.l('AttendanceRecord'),
                        '/app/attendanceRecords',
                        'far fa-circle'
                    ),
                    new MenuItem(
                        this.l('EntryExitRecords'),
                        '/app/entrance-exit-records',
                        'far fa-circle'
                    ),
                   
                ]),
                new MenuItem(this.l('EmployeeServices'), '', 'fas fa-dot-circle', '', [
                    new MenuItem(
                        this.l('Assignments'),
                        '/app/assignments',
                        'far fa-circle'
                    ),
                    new MenuItem(
                        this.l('ChangeableHolidays'),
                        '/app/changeable-holidays',
                        'far fa-circle'
                    ),
                    new MenuItem(
                        this.l('CompanyHolidays'),
                        '/app/company-holidays',
                        'far fa-circle'
                    ),
                    // new MenuItem(
                    //     this.l('FixedHolidays'),
                    //     '/app/fixed-holidays',
                    //     'far fa-circle'
                    // ),
                    new MenuItem(
                        this.l('LeaveSettings'),
                        '/app/leave-settings',
                        'far fa-circle'
                    ),
                    new MenuItem(
                        this.l('LeaveRequests'),
                        '/app/leave-requests',
                        'far fa-circle'
                    ),
                      // new MenuItem(
                    //     this.l('Promotions'),
                    //     '/app/promotions',
                    //     'far fa-circle'
                    // ),
                    // new MenuItem(
                    //     this.l('Resignations'),
                    //     '/app/resignations',
                    //     'far fa-circle'
                    // ),
                    // new MenuItem(
                    //     this.l('Transfers'),
                    //     '/app/transfers',
                    //     'far fa-circle'
                    // ),
                    new MenuItem(
                        this.l('Services'),
                        '',
                        'fas fa-dot-circle',
                        '',
                        [
                            // new MenuItem(
                            //     this.l('LeaveRequestService'),
                            //     '/app/countries',
                            //     'far fa-circle'
                            // ),
                            new MenuItem(
                                this.l('AcceptLeaveRequest'),
                                '/app/my-employees-leave-requests',
                                'far fa-circle'
                            ),
                           
                        ]
                    ),
                   
                ]),

                new MenuItem(this.l('Payroll'), '', 'fas fa-dot-circle', '', [
                    new MenuItem(
                        this.l('Month'),
                        '/app/payroll-months',
                        'far fa-circle'
                    ),
                    new MenuItem(
                        this.l('FinancialCards'),
                        '/app/financial-cards',
                        'far fa-circle'
                    ),
                   
                ]),

                new MenuItem(this.l('Workflows'), '', 'fas fa-dot-circle', '', [
                    new MenuItem(
                        this.l('Workflow'),
                        '/app/workflows',
                        'far fa-circle'
                    ),
                    new MenuItem(
                        this.l('WorkflowSettings'),
                        '/app/workflow-settings',
                        'far fa-circle'
                    ),
                   
                ]),

            ])

            
        ];
    }

    patchMenuItems(items: MenuItem[], parentId?: number): void {
        items.forEach((item: MenuItem, index: number) => {
            item.id = parentId ? Number(parentId + '' + (index + 1)) : index + 1;
            if (parentId) {
                item.parentId = parentId;
            }
            if (parentId || item.children) {
                this.menuItemsMap[item.id] = item;
            }
            if (item.children) {
                this.patchMenuItems(item.children, item.id);
            }
        });
    }

    activateMenuItems(url: string): void {
        this.deactivateMenuItems(this.menuItems);
        this.activatedMenuItems = [];
        const foundedItems = this.findMenuItemsByUrl(url, this.menuItems);
        foundedItems.forEach((item) => {
            this.activateMenuItem(item);
        });
    }

    deactivateMenuItems(items: MenuItem[]): void {
        items.forEach((item: MenuItem) => {
            item.isActive = false;
            item.isCollapsed = true;
            if (item.children) {
                this.deactivateMenuItems(item.children);
            }
        });
    }

    findMenuItemsByUrl(
        url: string,
        items: MenuItem[],
        foundedItems: MenuItem[] = []
    ): MenuItem[] {
        items.forEach((item: MenuItem) => {
            if (item.route === url) {
                foundedItems.push(item);
            } else if (item.children) {
                this.findMenuItemsByUrl(url, item.children, foundedItems);
            }
        });
        return foundedItems;
    }

    activateMenuItem(item: MenuItem): void {
        item.isActive = true;
        if (item.children) {
            item.isCollapsed = false;
        }
        this.activatedMenuItems.push(item);
        if (item.parentId) {
            this.activateMenuItem(this.menuItemsMap[item.parentId]);
        }
    }

    isMenuItemVisible(item: MenuItem): boolean {
        if (!item.permissionName) {
            return true;
        }
        return this.permission.isGranted(item.permissionName);
    }
}

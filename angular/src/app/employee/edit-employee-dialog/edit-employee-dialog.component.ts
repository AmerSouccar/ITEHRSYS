import { ChangeDetectorRef, Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { CityDto, CityDtoPagedResultDto, CityServiceProxy, CountryDto, CountryDtoPagedResultDto, CountryServiceProxy, EmployeeServiceProxy, NationalityDto, NationalityDtoPagedResultDto, NationalityServiceProxy, ReligionDto, ReligionDtoPagedResultDto, ReligionServiceProxy, UpdateEmployeeDto } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs';
import { combineLatest } from 'rxjs';


@Component({
  selector: 'app-edit-employee-dialog',
  templateUrl: './edit-employee-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class EditEmployeeDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
employee : UpdateEmployeeDto = new UpdateEmployeeDto();
id: string;
cities : CityDto[] = [];
countries : CountryDto[] = [];
religions : ReligionDto[] = [];
nationalities : NationalityDto[] = [];

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  public _employeeService: EmployeeServiceProxy,
  private _cityService: CityServiceProxy,
  private _countryService: CountryServiceProxy,
  private _religionService: ReligionServiceProxy,
  private _nationalityService: NationalityServiceProxy,
  public bsModalRef: BsModalRef,
  private cdr: ChangeDetectorRef
) {
  super(injector);
}

dataLoaded = false; // Add this property

ngOnInit(): void {
  const cityObservable = this._cityService.getAll(0, 1000);
  const countryObservable = this._countryService.getAll(0, 1000);
  const religionObservable = this._religionService.getAll(0, 1000);
  const nationalityObservable = this._nationalityService.getAll(0, 1000);
  const employeeObservable = this._employeeService.getForEdit(this.id);

  combineLatest([
    cityObservable,
    countryObservable,
    religionObservable,
    nationalityObservable,
    employeeObservable
  ]).pipe(
    finalize(() => {
      this.dataLoaded = true; // Set the flag to indicate data is loaded
    })
  ).subscribe(([cityResult, countryResult, religionResult, nationalityResult, employeeResult]) => {
    this.cities = cityResult.items;
    this.countries = countryResult.items;
    this.religions = religionResult.items;
    this.nationalities = nationalityResult.items;
    this.employee = employeeResult;
    console.log(employeeResult);
    console.log(this.employee);
    this.cdr.detectChanges();
  });
}


save(): void {
  this.saving = true;

  this._employeeService.update(this.employee).subscribe(
    () => {
      this.notify.info(this.l('SavedSuccessfully'));
      this.bsModalRef.hide();
      this.onSave.emit();
    },
    () => {
      this.saving = false;
    }
  );
}
}


import { Component, EventEmitter, Injector, OnInit, Output } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/app-component-base';
import { CityDto, CityDtoPagedResultDto, CityServiceProxy, CountryDto, CountryDtoPagedResultDto, CountryServiceProxy, EmployeeServiceProxy, InsertEmployeeDto, NationalityDto, NationalityDtoPagedResultDto, NationalityServiceProxy, ReligionDto, ReligionDtoPagedResultDto, ReligionServiceProxy } from '@shared/service-proxies/service-proxies';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs';

@Component({
  selector: 'app-create-employee-dialog',
  templateUrl: './create-employee-dialog.component.html',
  animations: [appModuleAnimation()]
})
export class CreateEmployeeDialogComponent extends AppComponentBase
implements OnInit {
saving = false;
employee = new InsertEmployeeDto();
cities : CityDto[] = [];
countries : CountryDto[] = [];
religions : ReligionDto[] = [];
nationalities : NationalityDto[] = [];

@Output() onSave = new EventEmitter<any>();

constructor(
  injector: Injector,
  private _employeeService: EmployeeServiceProxy,
  private _cityService: CityServiceProxy,
  private _countryService: CountryServiceProxy,
  private _religionService: ReligionServiceProxy,
  private _nationalityService: NationalityServiceProxy,
  public bsModalRef: BsModalRef
) {
  super(injector);
}

ngOnInit(): void {
  this._cityService
  .getAll(0, 1000)
  .pipe(
    finalize(() => {
    })
  )
  .subscribe((result: CityDtoPagedResultDto) => {
    this.cities = result.items;
  });

  this._countryService
  .getAll(0, 1000)
  .pipe(
    finalize(() => {
    })
  )
  .subscribe((result: CountryDtoPagedResultDto) => {
    this.countries = result.items;
  });

  this._religionService
  .getAll(0, 1000)
  .pipe(
    finalize(() => {
    })
  )
  .subscribe((result: ReligionDtoPagedResultDto) => {
    this.religions = result.items;
  });


  this._nationalityService
  .getAll(0, 1000)
  .pipe(
    finalize(() => {
    })
  )
  .subscribe((result: NationalityDtoPagedResultDto) => {
    this.nationalities = result.items;
  });

}


save(): void {
  this.saving = true;

  this._employeeService.insert(this.employee).subscribe(
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



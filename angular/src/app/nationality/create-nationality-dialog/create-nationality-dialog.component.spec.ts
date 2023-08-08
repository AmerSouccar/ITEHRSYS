import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateNationalityDialogComponent } from './create-nationality-dialog.component';

describe('CreateNationalityDialogComponent', () => {
  let component: CreateNationalityDialogComponent;
  let fixture: ComponentFixture<CreateNationalityDialogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreateNationalityDialogComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CreateNationalityDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

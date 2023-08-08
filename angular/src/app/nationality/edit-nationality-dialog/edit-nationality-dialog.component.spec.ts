import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditNationalityDialogComponent } from './edit-nationality-dialog.component';

describe('EditNationalityDialogComponent', () => {
  let component: EditNationalityDialogComponent;
  let fixture: ComponentFixture<EditNationalityDialogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditNationalityDialogComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EditNationalityDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

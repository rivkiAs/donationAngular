import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddKerenFileComponent } from './add-keren-file.component';

describe('AddKerenFileComponent', () => {
  let component: AddKerenFileComponent;
  let fixture: ComponentFixture<AddKerenFileComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AddKerenFileComponent]
    });
    fixture = TestBed.createComponent(AddKerenFileComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

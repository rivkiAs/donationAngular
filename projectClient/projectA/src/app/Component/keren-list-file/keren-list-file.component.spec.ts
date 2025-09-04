import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KerenListFileComponent } from './keren-list-file.component';

describe('KerenListFileComponent', () => {
  let component: KerenListFileComponent;
  let fixture: ComponentFixture<KerenListFileComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [KerenListFileComponent]
    });
    fixture = TestBed.createComponent(KerenListFileComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BeginFileComponent } from './begin-file.component';

describe('BeginFileComponent', () => {
  let component: BeginFileComponent;
  let fixture: ComponentFixture<BeginFileComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [BeginFileComponent]
    });
    fixture = TestBed.createComponent(BeginFileComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

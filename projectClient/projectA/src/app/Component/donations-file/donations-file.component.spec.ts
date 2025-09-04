import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DonationsFileComponent } from './donations-file.component';

describe('DonationsFileComponent', () => {
  let component: DonationsFileComponent;
  let fixture: ComponentFixture<DonationsFileComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DonationsFileComponent]
    });
    fixture = TestBed.createComponent(DonationsFileComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { TestBed } from '@angular/core/testing';

import { KerenService } from './keren.service';

describe('KerenService', () => {
  let service: KerenService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(KerenService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

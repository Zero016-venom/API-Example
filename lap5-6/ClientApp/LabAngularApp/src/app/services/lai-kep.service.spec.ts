import { TestBed } from '@angular/core/testing';

import { LaiKepService } from './lai-kep.service';

describe('LaiKepService', () => {
  let service: LaiKepService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(LaiKepService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

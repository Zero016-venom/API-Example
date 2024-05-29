import { TestBed } from '@angular/core/testing';

import { KoiTheService } from './koi-the.service';

describe('KoiTheService', () => {
  let service: KoiTheService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(KoiTheService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

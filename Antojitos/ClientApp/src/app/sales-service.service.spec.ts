import { TestBed } from '@angular/core/testing';

import { SalesServiceService } from './sales-service.service';

describe('SalesServiceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: SalesServiceService = TestBed.get(SalesServiceService);
    expect(service).toBeTruthy();
  });
});

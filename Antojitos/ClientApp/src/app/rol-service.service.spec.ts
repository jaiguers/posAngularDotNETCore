import { TestBed } from '@angular/core/testing';

import { RolServiceService } from './rol-service.service';

describe('RolServiceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: RolServiceService = TestBed.get(RolServiceService);
    expect(service).toBeTruthy();
  });
});

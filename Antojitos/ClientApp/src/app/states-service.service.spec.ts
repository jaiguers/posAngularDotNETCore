import { TestBed } from '@angular/core/testing';

import { StatesServiceService } from './states-service.service';

describe('StatesServiceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: StatesServiceService = TestBed.get(StatesServiceService);
    expect(service).toBeTruthy();
  });
});

import { TestBed, inject } from '@angular/core/testing';

import { ConfigService } from './config-service.service';

describe('ConfigServiceService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ConfigService]
    });
  });

  it('should be created', inject([ConfigService], (service: ConfigService) => {
    expect(service).toBeTruthy();
  }));
});

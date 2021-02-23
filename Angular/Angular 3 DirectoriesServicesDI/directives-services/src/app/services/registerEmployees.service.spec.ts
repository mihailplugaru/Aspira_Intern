import { TestBed } from '@angular/core/testing';

import { RegisterEmployeesService } from './registerEmployees.service';

describe('RegisterEmployeesService', () => {
  let service: RegisterEmployeesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(RegisterEmployeesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

import { TestBed } from '@angular/core/testing';

import { SavePersonsToObservableService } from './save-persons-to-observable.service';

describe('SavePersonsToObservableService', () => {
  let service: SavePersonsToObservableService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SavePersonsToObservableService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

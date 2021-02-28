import { TestBed } from '@angular/core/testing';

import { SaveNamesToSubjectService } from './save-names-to-subject.service';

describe('SaveNamesToSubjectService', () => {
  let service: SaveNamesToSubjectService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SaveNamesToSubjectService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

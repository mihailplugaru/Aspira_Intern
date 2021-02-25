import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RestAndPartyComponent } from './rest-and-party.component';

describe('RestAndPartyComponent', () => {
  let component: RestAndPartyComponent;
  let fixture: ComponentFixture<RestAndPartyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RestAndPartyComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RestAndPartyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

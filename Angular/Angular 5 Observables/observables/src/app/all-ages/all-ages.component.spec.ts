import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AllAgesComponent } from './all-ages.component';

describe('AllAgesComponent', () => {
  let component: AllAgesComponent;
  let fixture: ComponentFixture<AllAgesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AllAgesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AllAgesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

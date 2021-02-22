import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DataSharerOneComponent } from './data-sharer-one.component';

describe('DataSharerOneComponent', () => {
  let component: DataSharerOneComponent;
  let fixture: ComponentFixture<DataSharerOneComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DataSharerOneComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DataSharerOneComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

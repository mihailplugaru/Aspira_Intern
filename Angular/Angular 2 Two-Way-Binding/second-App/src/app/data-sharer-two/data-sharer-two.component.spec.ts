import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DataSharerTwoComponent } from './data-sharer-two.component';

describe('DataSharerTwoComponent', () => {
  let component: DataSharerTwoComponent;
  let fixture: ComponentFixture<DataSharerTwoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DataSharerTwoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DataSharerTwoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

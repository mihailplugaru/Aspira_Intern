import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UsersDisplayerComponent } from './users-displayer.component';

describe('UsersDisplayerComponent', () => {
  let component: UsersDisplayerComponent;
  let fixture: ComponentFixture<UsersDisplayerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UsersDisplayerComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UsersDisplayerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LaiKepComponent } from './lai-kep.component';

describe('LaiKepComponent', () => {
  let component: LaiKepComponent;
  let fixture: ComponentFixture<LaiKepComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LaiKepComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(LaiKepComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

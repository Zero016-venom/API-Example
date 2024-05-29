import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KoiTheComponent } from './koi-the.component';

describe('KoiTheComponent', () => {
  let component: KoiTheComponent;
  let fixture: ComponentFixture<KoiTheComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ KoiTheComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(KoiTheComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LaiKepComponent } from './lai-kep/lai-kep.component';
import { KoiTheComponent } from './koi-the/koi-the.component';

const routes: Routes = [
  { path: "laikep", component: LaiKepComponent },
  { path: "koithe", component: KoiTheComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

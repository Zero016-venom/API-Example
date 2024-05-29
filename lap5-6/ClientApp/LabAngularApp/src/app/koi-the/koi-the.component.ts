import { Component } from '@angular/core';
import { KoiThe } from '../models/koi-the';
import { KoiTheService } from '../services/koi-the.service';

@Component({
  selector: 'app-koi-the',
  templateUrl: './koi-the.component.html',
  styleUrls: ['./koi-the.component.css']
})
export class KoiTheComponent {
  koiThes: KoiThe[] = [];

  constructor(private koiTheService: KoiTheService) {
  }

  ngOnInit() {
    this.koiTheService.getKoiThes()
      .subscribe({
        next: (reponse: KoiThe[]) => {
          this.koiThes = reponse;
        },

        error: (error: any) => {
          console.log(error)
        },

        complete: () => { }
      });
  }
}


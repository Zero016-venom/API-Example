export class KoiThe {
  koiTheID: string | null;
  koiTheName: string | null;
  koiThePrice: number | null;

  constructor(koiTheID: string | null = null, koiTheName: string | null = null, koiThePrice: number | null = null) {
    this.koiTheID = koiTheID;
    this.koiTheName = koiTheName;
    this.koiThePrice = koiThePrice;
  }

}

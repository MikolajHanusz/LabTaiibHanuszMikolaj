import { Component } from '@angular/core';
import { ProductResponseDTO } from '../models/product.interface';
import { ProductsService } from '../products.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrl: './products.component.css'
})
export class ProductsComponent {
  public data: ProductResponseDTO[] = [];
  public product?: ProductResponseDTO;
  public productId: number = -1;
  private getData() {
    this.productsService.get().subscribe({
      next: (res) => {
        this.data = res;
        console.log(res);
      },
      error: (err) => console.log(err),
      complete: () => console.log('complete')
    });

    for(let i=0;i<this.data.length;i++){
      if(this.data.at(i)?.id == this.productId){
        this.product = this.data.at(i);
      }
    }
  }

  constructor(private productsService: ProductsService){
    this.getData();
    this.product = this.data.at(3);
    console.log(this.product?.name);
    console.log(this.data.at(3)?.name);
  }
}

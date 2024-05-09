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
  private getData() {
    this.productsService.get().subscribe({
      next: (res) => {
        this.data = res;
        console.log(res);
      },
      error: (err) => console.log(err),
      complete: () => console.log('complete')
    });
  }

  constructor(private productsService: ProductsService){
    this.getData();
  }
}

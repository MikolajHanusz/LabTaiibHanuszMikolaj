import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ProductRequestDTO, ProductResponseDTO } from './models/product.interface';

@Injectable({
  providedIn: 'root'
})
export class ProductsService {

  constructor(private httpClient: HttpClient) { }

  public get(): Observable<ProductResponseDTO[]>{
    return this.httpClient.get<ProductResponseDTO[]>('https://localhost:7137/api/Products');
  }
  
  public post(body: ProductRequestDTO): Observable<void> {
    return this.httpClient.post<void>('https://localhost:7254/api/Students', body);
  }
}
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';
import { Album } from '../interfaces/Album';


@Injectable({
  providedIn: 'root'
})
export class DataServiceService {

  baseUrl: string = "https://jsonplaceholder.typicode.com/albums";

  constructor(private httpClient: HttpClient) { }

  getAlbums() : Observable<Album[]>{
    return this.httpClient.get<Album[]>(this.baseUrl);
  }

  postAlbum(album : Album) : Observable<Album>{
    return this.httpClient.post<Album>(this.baseUrl, album);
  }

  putAlbum(album : Album) : Observable<Album>{
    return this.httpClient.put<Album>(this.baseUrl+"/1", album);
  }

  deleteAlbum() : Observable<Album>{
    return this.httpClient.delete<Album>(this.baseUrl+"/1");
  }

}

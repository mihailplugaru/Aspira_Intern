import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';
import { User } from '../models/User';


@Injectable({
  providedIn: 'root'
})
export class DataServiceService {

  baseUrl: string = "https://jsonplaceholder.typicode.com/albums";

  constructor(private httpClient: HttpClient) { }

  getAlbums() : Observable<any>{
    return this.httpClient.get(this.baseUrl);
  }

  postAlbum(album : User) : Observable<any>{
    return this.httpClient.post(this.baseUrl, album);
  }

  putAlbum(album : User){
    return this.httpClient.put(this.baseUrl+"/1", album);
  }

  deleteAlbum(){
    return this.httpClient.delete(this.baseUrl+"/1");
  }

}

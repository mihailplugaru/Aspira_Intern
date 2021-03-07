import { Component, OnInit } from '@angular/core';
import { DataServiceService } from '../services/data-service.service';
import { Album } from '../interfaces/Album'

@Component({
  selector: 'app-data-displayer',
  templateUrl: './data-displayer.component.html',
  styleUrls: ['./data-displayer.component.css']
})
export class DataDisplayerComponent implements OnInit {

  albums: Album[];
  p: number = 1
 
  constructor(private dataService: DataServiceService) { }

  ngOnInit(): void { }

  getAlbums(){
    this.dataService.getAlbums().subscribe(a => {
        this.albums = a
    });
  }
  
  postAlbum(){
    var album1 = new Album();
    album1.userId = 1111;
    album1.title = "some title"

    this.dataService.postAlbum(album1)
    .subscribe((p)=>{
        console.log(p)
    });
  }
  
  updateAlbum(){
    var album1 = new Album();
    album1.userId = 2222;
    album1.title = "some other title"
    album1.id = 1;

    this.dataService.putAlbum(album1)
    .subscribe((p)=>{
        console.log(p)
    });
  }
  
  deleteAlbum(){
    this.dataService.deleteAlbum()
    .subscribe((d)=>{
        console.log(d)
    });
  }
}

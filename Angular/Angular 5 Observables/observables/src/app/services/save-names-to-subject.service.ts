import { Injectable } from '@angular/core';
import { ReplaySubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SaveNamesToSubjectService {

  names = new ReplaySubject();

  constructor() { }


}


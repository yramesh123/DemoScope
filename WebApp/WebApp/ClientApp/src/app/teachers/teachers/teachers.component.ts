import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-teachers',
  templateUrl: './teachers.component.html',
  styleUrls: ['./teachers.component.css']
})
export class TeachersComponent  {

  public teachers: TeacherDataModel[];
  public studentURL: string;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {

    this.studentURL = 'https://localhost:44323/api/Teachers/Get';
    http.get<TeacherDataModel[]>(this.studentURL).subscribe(result => {
      console.log(result);
      this.teachers = result;
    }, error => console.error(error));
  }

 
}


interface TeacherDataModel {
  firstName: string;
  lastName: string;
  subject: string;
  empId: number;
}

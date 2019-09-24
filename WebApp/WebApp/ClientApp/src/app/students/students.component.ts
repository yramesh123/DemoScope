import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-student',
  templateUrl: './students.component.html',
})
export class StudentComponent
{
  public students: StudentDataModel[];
  public studentURL: string; 

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string)
  {

    this.studentURL = 'https://localhost:44323/api/students';
    http.get<StudentDataModel[]>(this.studentURL).subscribe(result =>
    {
      console.log(result);
      this.students = result;
    }, error => console.error(error));
  }
}

interface StudentDataModel {
  firstName: string;
  lastName: string;
  rollNumber: number;
  idNum: string;  
}

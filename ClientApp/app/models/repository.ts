import { Student } from "./student.model";
import { Injectable } from "@angular/core";
import { Http, RequestMethod, Request, Response } from "@angular/http";
import { Observable } from "rxjs/Observable";
import "rxjs/add/operator/map";

const studentsUrl = "/api/students";

@Injectable()
export class Repository
{
    constructor(private http: Http) {
        this.getStudents(true);
    }

    getStudent(id: number)
    {
        this.sendRequest(RequestMethod.Get, studentsUrl + "/" + id)
            .subscribe(response => { this.student = response.json; });
    }

    getStudents(related = false)
    {
        this.sendRequest(RequestMethod.Get, studentsUrl + "?related=" + related)
            .subscribe(response => this.students = response);
    }

    private sendRequest(verb: RequestMethod, url: string, data?: any): Observable<any>
    {
        return this.http.request(new Request({ method: verb, url: url, body: data }))
            .map(response => response.json());
    }

    student: Student;
    students: Student[];
}
import { Student } from "./student.model";
import { School } from "./school.model";
import { Grade } from "./grade.model";
import { County } from "./county.model";


export class StudentDetail 
{
    constructor(
        public studentDetailId?: number,
        public student?: Student,
        public school?: School,
        public grade?: Grade,
        public address?: string,
        public address2?: string,
        public city?: string,
        public state?: string,
        public zip?: string,
        public county?: County,
        public createDate?: string) { }
}
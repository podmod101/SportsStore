import { Product } from "./product.model";
import { Student } from "./student.model";

export class Repository {
    constructor() {
        this.student = JSON.parse(document.getElementById("data").textContent);
    }
    student: Student;
}
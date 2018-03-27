import { Product } from "./product.model";
import { Student } from "./student.model";

export class Repository {
    constructor() {
        //this.product = JSON.parse(document.getElementById("data").textContent);
        this.student = JSON.parse(document.getElementById("data").textContent);
    }
    //product: Product;
    student: Student;
}
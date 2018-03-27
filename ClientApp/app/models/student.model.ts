import { StudentDetail } from "./studentdetail.model";
import { StudentTournamentDetail } from "./studenttournamentdetail.model";

export class Student 
{
    constructor(
        public studentId?: number,
        public customerNumber?: number,
        public firstName?: string,
        public middleInitial?: string,
        public lastName?: string,
        public gender?: string,
        public dateOfBirth?: string,
        public lastFourSSN?: number,
        public huntingLicenseNumber?: string,
        public studentDetails?: StudentDetail[],
        public studentTournamentDetails?: StudentTournamentDetail[]) { } 
}
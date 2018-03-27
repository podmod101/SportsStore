import { Student } from "./student.model";
import { Tournament } from "./tournament.model";

export class StudentTournamentDetail
{
    constructor(
        public studentTournamentDetailId?: number,
        public student?: Student,
        public tournament?: Tournament,
        public createDate?: string) { }
}
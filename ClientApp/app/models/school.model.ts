import { County } from "./county.model";
import { SchoolDetail } from "./schoolDetail.model";
import { SchoolTournamentDetail } from "./schooltournamentdetail.model";

export class School
{
    constructor(
        public schoolId?: number,
        public name?: string,
        public address?: string,
        public address2?: string,
        public city?: string,
        public state?: string,
        public zip?: string,
        public county?: County,
        public schoolDetails?: SchoolDetail[],
        public schoolTournamentDetails?: SchoolTournamentDetail[]) { }
}
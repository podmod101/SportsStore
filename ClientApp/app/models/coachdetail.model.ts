import { School } from "./school.model";

export class CoachDetail
{
    constructor(
        public coachDetailId?: number,
        public school?: School,
        public name?: string,
        public email?: string,
        public cellPhone?: string,
        public telephone?: string,
        public createDate?: string) { }
}
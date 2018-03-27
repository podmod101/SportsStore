import { School } from "./school.model";
import { Tournament } from "./tournament.model";
import { ShootDay } from "./shootday.model";

export class SchoolTournamentDetail
{
    constructor(
        public schoolTournamentDetailId?: number,
        public school?: School,
        public tournament?: Tournament,
        public shootTime?: string,
        public shootDay?: ShootDay,
        public comment?: string,
        public createDate?: string) { }
}
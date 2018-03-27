import { SchoolTournamentDetail } from "./schooltournamentdetail.model";
import { StudentTournamentDetail } from "./studenttournamentdetail.model";

export class Tournament
{
    constructor(
        public tournamentId?: number,
        public name?: string,
        public location?: string,
        public stateChampionship?: boolean,
        public address?: string,
        public city?: string,
        public state?: string,
        public zip?: string,
        public startDate?: string,
        public endDate?: string,
        public schoolTournamentDetails?: SchoolTournamentDetail[],
        public studentTournamentDetails?: StudentTournamentDetail[]) { }
}
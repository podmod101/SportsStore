import { School } from "./school.model";
import { Sector } from "./sector.model";
import { Division } from "./division.model";
import { Level } from "./level.model";

export class SchoolDetail
{
    constructor(
        public schoolDetailId?: number,
        public school?: School,
        public sector?: Sector,
        public division?: Division,
        public level?: Level,
        public createDate?: string) { }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teams.Models
{
    public class Team
    {
        /*TeamId int Primary Key identity,
	Location varchar(25) not null,
	TeamName varchar(25) not null,
	Conference int not null,
	Division int not null,
	Wins int not null default 0,
	Losses int not null default 0,

	Constraint Check_TeamConference Check (Conference Between 1 and 2),
	Constraint Check_TeamDivision Check (Division Between 1 and 4) */

        public int TeamId { get; set; }
        public string Location { get; set; }
        public string TeamName { get; set; }
        public Conference Conference { get; set; }
        public Division Division { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }

        public Team()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teams.Models
{
    public class Player
	{/*Create Table Player 
(
	PlayerID int identity,
	FirstName nvarchar(30) not null,
	LastName nvarchar(30) not null,
	TeamId int NULL, -- Player can be a free agent
	BirthDate date not null,
	Position varchar(3) not null, -- It is a design decision to make it an int

	Constraint PK_Player Primary Key (PlayerId),
	Constraint FK_PlayerTeam Foreign Key (TeamId) References Team(TeamId) 
);*/

        public int PlayerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? TeamId { get; set; }
		public DateTime BirthDate { get; set; }
        public string Position { get; set; }
    }
}

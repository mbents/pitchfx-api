using System;

namespace PitchFX.DTO
{
    public class GameDTO
    {
        public int GameID { get; set; }
        public string Description { get; set; }
        public DateTime GameDate { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
    }
}

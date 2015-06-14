using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PitchFX.DTO;
using PitchFX.DAL;

namespace PitchFX.BL
{
    public class Game
    {
        public List<GameDTO> GetGamesByDate(DateTime date)
        {
            var list = new List<GameDTO>();

            using (var dbContext = new Model1Container())
            {
                var games = dbContext.Games.Where(x => x.GameDate.Year == date.Year
                                                    && x.GameDate.Month == date.Month
                                                    && x.GameDate.Day == date.Day).ToList();
                games.ForEach(x => list.Add(new GameDTO
                {
                    AwayTeam = x.AwayTeam,
                    Description = x.Description,
                    GameDate = x.GameDate,
                    GameID = x.Id,
                    HomeTeam = x.HomeTeam
                }));
            }

            return list;
        }
    }
}

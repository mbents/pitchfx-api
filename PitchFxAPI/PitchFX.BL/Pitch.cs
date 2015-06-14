using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PitchFX.DTO;
using PitchFX.DAL;

namespace PitchFX.BL
{
    public class Pitch
    {
        public List<PitchDTO> GetPitchesByPitcher(int pitcherID)
        {
            var list = new List<PitchDTO>();

            using (var dbContext = new Model1Container())
            {
                list = (from pitches in dbContext.Pitches
                        join atBats in dbContext.AtBats on pitches.AtBatId equals atBats.Id
                        join games in dbContext.Games on atBats.GameId equals games.Id
                        where atBats.pitcher == pitcherID
                        select new PitchDTO
                        {
                            Id = pitches.Id,
                            des = pitches.des,
                            pitch_id = pitches.pitch_id,
                            type = pitches.type,
                            tfs = pitches.tfs,
                            tfs_zulu = pitches.tfs_zulu,
                            x = pitches.x,
                            y = pitches.y,
                            sv_id = pitches.sv_id,
                            start_speed = pitches.start_speed,
                            end_speed = pitches.end_speed,
                            sz_top = pitches.sz_top,
                            sz_bot = pitches.sz_bot,
                            pfx_x = pitches.pfx_x,
                            pfx_z = pitches.pfx_z,
                            px = pitches.px,
                            pz = pitches.pz,
                            x0 = pitches.x0,
                            y0 = pitches.y0,
                            z0 = pitches.z0,
                            vx0 = pitches.vx0,
                            vy0 = pitches.vy0,
                            vz0 = pitches.vz0,
                            ax = pitches.ax,
                            ay = pitches.ay,
                            az = pitches.az,
                            break_y = pitches.break_y,
                            break_angle = pitches.break_angle,
                            break_length = pitches.break_length,
                            pitch_type = pitches.pitch_type,
                            type_confidence = pitches.type_confidence,
                            zone = pitches.zone,
                            nasty = pitches.nasty,
                            spin_dir = pitches.spin_dir,
                            spin_rate = pitches.spin_rate,
                            cc = pitches.cc,
                            mt = pitches.mt,
                            AtBatId = pitches.AtBatId,
                            GameDate = games.GameDate,
                            HomeTeam = games.HomeTeam,
                            AwayTeam = games.AwayTeam
                        }).ToList();
            }

            return list;
        }

        public List<PitchDTO> GetPitchesByPitchType(string pitchType)
        {
            var list = new List<PitchDTO>();

            using (var dbContext = new Model1Container())
            {
                list = (from pitches in dbContext.Pitches
                        join atBats in dbContext.AtBats on pitches.AtBatId equals atBats.Id
                        join games in dbContext.Games on atBats.GameId equals games.Id
                        where pitches.pitch_type == pitchType
                        select new PitchDTO
                        {
                            Id = pitches.Id,
                            des = pitches.des,
                            pitch_id = pitches.pitch_id,
                            type = pitches.type,
                            tfs = pitches.tfs,
                            tfs_zulu = pitches.tfs_zulu,
                            x = pitches.x,
                            y = pitches.y,
                            sv_id = pitches.sv_id,
                            start_speed = pitches.start_speed,
                            end_speed = pitches.end_speed,
                            sz_top = pitches.sz_top,
                            sz_bot = pitches.sz_bot,
                            pfx_x = pitches.pfx_x,
                            pfx_z = pitches.pfx_z,
                            px = pitches.px,
                            pz = pitches.pz,
                            x0 = pitches.x0,
                            y0 = pitches.y0,
                            z0 = pitches.z0,
                            vx0 = pitches.vx0,
                            vy0 = pitches.vy0,
                            vz0 = pitches.vz0,
                            ax = pitches.ax,
                            ay = pitches.ay,
                            az = pitches.az,
                            break_y = pitches.break_y,
                            break_angle = pitches.break_angle,
                            break_length = pitches.break_length,
                            pitch_type = pitches.pitch_type,
                            type_confidence = pitches.type_confidence,
                            zone = pitches.zone,
                            nasty = pitches.nasty,
                            spin_dir = pitches.spin_dir,
                            spin_rate = pitches.spin_rate,
                            cc = pitches.cc,
                            mt = pitches.mt,
                            AtBatId = pitches.AtBatId,
                            GameDate = games.GameDate,
                            HomeTeam = games.HomeTeam,
                            AwayTeam = games.AwayTeam
                        }).ToList();
            }

            return list;
        }

    }
}

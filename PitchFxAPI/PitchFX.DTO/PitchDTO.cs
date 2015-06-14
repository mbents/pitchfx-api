using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitchFX.DTO
{
    public class PitchDTO
    {
        public int AtBatId { get; set; }
        public string AwayTeam { get; set; }
        public decimal? ax { get; set; }
        public decimal? ay { get; set; }
        public decimal? az { get; set; }
        public decimal? break_angle { get; set; }
        public decimal? break_length { get; set; }
        public decimal? break_y { get; set; }
        public string cc { get; set; }
        public string des { get; set; }
        public decimal? end_speed { get; set; }
        public DateTime GameDate { get; set; }
        public string HomeTeam { get; set; }
        public int Id { get; set; }
        public string mt { get; set; }
        public int? nasty { get; set; }
        public decimal? pfx_x { get; set; }
        public decimal? pfx_z { get; set; }
        public int pitch_id { get; set; }
        public string pitch_type { get; set; }
        public decimal? px { get; set; }
        public decimal? pz { get; set; }
        public decimal? spin_dir { get; set; }
        public decimal? spin_rate { get; set; }
        public decimal? start_speed { get; set; }
        public string sv_id { get; set; }
        public decimal? sz_bot { get; set; }
        public decimal? sz_top { get; set; }
        public string tfs { get; set; }
        public string tfs_zulu { get; set; }
        public string type { get; set; }
        public decimal? type_confidence { get; set; }
        public decimal? vx0 { get; set; }
        public decimal? vy0 { get; set; }
        public decimal? vz0 { get; set; }
        public decimal? x { get; set; }
        public decimal? x0 { get; set; }
        public decimal? y { get; set; }
        public decimal? y0 { get; set; }
        public decimal? z0 { get; set; }
        public int? zone { get; set; }
    }
}

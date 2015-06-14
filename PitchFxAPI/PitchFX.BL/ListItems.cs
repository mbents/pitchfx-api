using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitchFX.BL
{
    public class ListItems
    {
        public List<string> GetVariables()
        {
            var list = new List<string>();

            list.Add("start_speed");
            list.Add("pz");
            list.Add("spin_rate");
            list.Add("break_length");

            return list;
        }

        public List<string> GetPitchTypes()
        {
            var list = new List<string>();

            list.Add("AB");
            list.Add("AS");
            list.Add("CH");
            list.Add("CU");
            list.Add("EP");
            list.Add("FA");
            list.Add("FC");
            list.Add("FF");
            list.Add("FO");
            list.Add("FS");
            list.Add("FT");
            list.Add("IN");
            list.Add("KC");
            list.Add("KN");
            list.Add("PO");
            list.Add("SC");
            list.Add("SI");
            list.Add("SL");
            list.Add("UN");

            return list;
        }

        public List<string> GetPitchDescriptions()
        {
            var list = new List<string>();

            list.Add("Automatic Ball");
            list.Add("Automatic Strike");
            list.Add("Ball");
            list.Add("Ball In Dirt");
            list.Add("Called Strike");
            list.Add("Foul");
            list.Add("Foul (Runner Going)");
            list.Add("Foul Bunt");
            list.Add("Foul Pitchout");
            list.Add("Foul Tip");
            list.Add("Hit By Pitch");
            list.Add("In play, no out");
            list.Add("In play, out(s)");
            list.Add("In play, run(s)");
            list.Add("Intent Ball");
            list.Add("Missed Bunt");
            list.Add("Pitchout");
            list.Add("Strike");
            list.Add("Swinging Pitchout");
            list.Add("Swinging Strike");
            list.Add("Swinging Strike (Blocked)");
            list.Add("Unknown Strike");

            return list;
        }

        public List<string> GetOperators()
        {
            var list = new List<string>();

            list.Add("=");
            list.Add("<");
            list.Add(">");
            list.Add("<=");
            list.Add(">=");

            return list;
        }
    }
}

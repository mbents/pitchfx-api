using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitchFX.DTO
{
    public class QueryModelDTO
    {
        public string XAxisVarId { get; set; }
        public string XAxisVarOperatorId { get; set; }
        public string XAxisVarValue { get; set; }
        public string YAxisVarId { get; set; }
        public string YAxisVarOperatorId { get; set; }
        public string YAxisVarValue { get; set; }
        public string PitchTypeId { get; set; }
        public string PitchDescriptionId { get; set; }
    }
}

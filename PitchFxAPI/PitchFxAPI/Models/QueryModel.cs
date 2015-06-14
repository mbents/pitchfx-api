using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;

namespace PitchFxAPI.Models
{
    public class QueryModel
    {
        [Required]
        [Display(Name = "x-axis")]
        public string XAxisVarId { get; set; }
        public IEnumerable<SelectListItem> XAxisVariables { get; set; }

        [Required]
        public string XAxisVarOperatorId { get; set; }
        public IEnumerable<SelectListItem> XAxisVarOperators { get; set; }

        [Required]
        public string XAxisVarValue { get; set; }

        [Required]
        [Display(Name = "y-axis")]
        public string YAxisVarId { get; set; }
        public IEnumerable<SelectListItem> YAxisVariables { get; set; }

        [Required]
        public string YAxisVarOperatorId { get; set; }
        public IEnumerable<SelectListItem> YAxisVarOperators { get; set; }

        [Required]
        public string YAxisVarValue { get; set; }

        [Display(Name = "Pitch Type")]
        public string PitchTypeId { get; set; }
        public IEnumerable<SelectListItem> PitchTypes { get; set; }

        [Display(Name = "Pitch Description")]
        public string PitchDescriptionId { get; set; }
        public IEnumerable<SelectListItem> PitchDescriptions { get; set; }

        [Display(Name = "Correlation coefficient")]
        public double? CorrelationCoefficient { get; set; }

        public double[] XValues { get; set; }
        public double[] YValues { get; set; }
        public double[] XValuesForRegression { get; set; }
        public double[] YValuesForRegression { get; set; }
    }
}
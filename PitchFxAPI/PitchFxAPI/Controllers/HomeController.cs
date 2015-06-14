using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using PitchFxAPI.Models;
using PitchFX.BL;
using PitchFX.DTO;

namespace PitchFxAPI.Controllers
{
    public class HomeController : Controller
    {
        private static QueryModel _model;

        public ActionResult Index()
        {
            _model = PopulateDropdowns();

            return View(_model);
        }

        [HttpPost]
        public ActionResult Index(QueryModel model)
        {
            var dto = new QueryModelDTO
            {
                PitchDescriptionId = model.PitchDescriptionId,
                PitchTypeId = model.PitchTypeId,
                XAxisVarId = model.XAxisVarId,
                XAxisVarOperatorId = model.XAxisVarOperatorId,
                XAxisVarValue = model.XAxisVarValue,
                YAxisVarId = model.YAxisVarId,
                YAxisVarOperatorId = model.YAxisVarOperatorId,
                YAxisVarValue = model.YAxisVarValue
            };

            model = PopulateDropdowns();
            model.XAxisVarId = dto.XAxisVarId;
            model.YAxisVarId = dto.YAxisVarId;
            var stat = new Stat();

            double _corr;
            double[] _x;
            double[] _y;
            double[] _xRegressionVals;
            double[] _yRegressionVals;
            stat.Run(dto, out _corr, out _x, out _y, out _xRegressionVals, out _yRegressionVals);
            model.CorrelationCoefficient = _corr;
            model.XValues = _x;
            model.YValues = _y;
            model.XValuesForRegression = _xRegressionVals;
            model.YValuesForRegression = _yRegressionVals;

            _model = model;
            return View(model);
        }

        public ActionResult ShowChart()
        {
            return View("Chart", _model);
        }

        private QueryModel PopulateDropdowns()
        {
            var listItems = new ListItems();
            var variables = listItems.GetVariables()
                                    .Select(x => new SelectListItem
                                    {
                                        Value = x,
                                        Text = x
                                    });
            var pitchTypes = listItems.GetPitchTypes()
                                    .Select(x => new SelectListItem
                                    {
                                        Value = x,
                                        Text = x
                                    });
            var operators = listItems.GetOperators()
                                    .Select(x => new SelectListItem
                                    {
                                        Value = x,
                                        Text = x
                                    });
            var descriptions = listItems.GetPitchDescriptions()
                                    .Select(x => new SelectListItem
                                    {
                                        Value = x,
                                        Text = x
                                    });

            var model = new QueryModel
            {
                XAxisVariables = variables,
                YAxisVariables = variables,
                XAxisVarOperators = operators,
                YAxisVarOperators = operators,
                PitchTypes = pitchTypes,
                PitchDescriptions = descriptions
            };

            return model;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MathNet.Numerics.Statistics;
using PitchFX.DTO;
using PitchFX.DAL;

using System.Linq.Expressions;
using System.Reflection;
using System.Linq.Dynamic;

namespace PitchFX.BL
{
    public class Stat
    {
        private List<PitchDTO> _results;

        public void Run(QueryModelDTO modelDto, out double correlation, out double[] xValues, out double[] yValues, out double[] xLineValues, out double[] yLineValues)
        {
            var queryBuilder = new QueryBuilder(modelDto);
            queryBuilder.BuildQuery();
            _results = queryBuilder.RunQuery();

            var _xList = new List<double>();
            var _yList = new List<double>();
            correlation = GetCorrelation(modelDto, out _xList, out _yList);

            xValues = _xList.ToArray();
            yValues = _yList.ToArray();

            Tuple<double, double> regression = RunSimpleRegression(xValues, yValues);
            GetXY(regression, _xList.Max(), _yList.Max(), out xLineValues, out yLineValues);
        }

        private double GetCorrelation(QueryModelDTO modelDto, out List<double> xList, out List<double> yList)
        {
            var list1 = new List<double>();
            var list2 = new List<double>();
            foreach (var item in _results.Select(modelDto.XAxisVarId))
                list1.Add(Convert.ToDouble(item));

            foreach (var item in _results.Select(modelDto.YAxisVarId))
                list2.Add(Convert.ToDouble(item));

            xList = list1;
            yList = list2;
            return MathNet.Numerics.Statistics.Correlation.Pearson(list1, list2);
        }

        private Tuple<double, double> RunSimpleRegression(double[] xValues, double[] yValues)
        {
            Tuple<double, double> tuple = MathNet.Numerics.LinearRegression.SimpleRegression.Fit(xValues, yValues);
            return tuple;
        }

        private void GetXY(Tuple<double, double> regression, double maxX, double maxY, out double[] xValues, out double[] yValues)
        {
            var _xList = new List<double>();
            var _yList = new List<double>();

            double newX = 0;
            double newY = regression.Item1;
            _xList.Add(newX);
            _yList.Add(newY);
            double yIncrease = regression.Item2 < 1 ? regression.Item2 * 100 : regression.Item2;
            double xIncrease = regression.Item2 < 1 ? 100 : 1;
            do {
                newX += xIncrease;
                newY += yIncrease;
                _xList.Add(newX);
                _yList.Add(newY);
            } while (newX < maxX && newY < maxY);

            xValues = _xList.ToArray();
            yValues = _yList.ToArray();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Linq.Dynamic;
using PitchFX.DTO;
using PitchFX.DAL;

namespace PitchFX.BL
{
    public class QueryBuilder
    {
        private QueryModelDTO _modelDto;
        private StringBuilder _whereClause;

        public QueryBuilder(QueryModelDTO modelDTO)
        {
            _modelDto = modelDTO;
        }

        public void BuildQuery()
        {
            int paramCounter = 0;
            _whereClause = new StringBuilder();

            _whereClause.Append(string.Format("{0} != NULL AND {0} {1} @{2}", _modelDto.XAxisVarId, _modelDto.XAxisVarOperatorId, paramCounter++));
            _whereClause.Append(string.Format(" AND {0} != NULL AND {0} {1} @{2}", _modelDto.YAxisVarId, _modelDto.YAxisVarOperatorId, paramCounter++));

            if (!string.IsNullOrEmpty(_modelDto.PitchDescriptionId))
                _whereClause.Append(string.Format(" AND des = @{0}", paramCounter++));

            if (!string.IsNullOrEmpty(_modelDto.PitchTypeId))
                _whereClause.Append(string.Format(" AND pitch_type = @{0}", paramCounter++));
        }

        public List<PitchDTO> RunQuery()
        {
            using (var dbContext = new Model1Container())
            {
                dbContext.CommandTimeout = 120;
                var result = dbContext.Pitches
                                .Where(_whereClause.ToString(), Convert.ToDecimal(_modelDto.XAxisVarValue), Convert.ToDecimal(_modelDto.YAxisVarValue), _modelDto.PitchDescriptionId, _modelDto.PitchTypeId)
                                .Select(x => new PitchDTO { spin_rate = x.spin_rate, start_speed = x.start_speed, px = x.px, pz = x.pz, break_length = x.break_length }).ToList();
                return result;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhyInterface
{
    public interface IManagementLevelEmployee
    {
        IEvaluatedEmployee EvaluateSubordinate(IEvaluatedEmployee employee);
    }
}

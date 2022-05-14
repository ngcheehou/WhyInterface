using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhyInterface
{
    public interface IEmployee
    {
        string Name { get; set; }
        string Designation { get; set; }
    }
}
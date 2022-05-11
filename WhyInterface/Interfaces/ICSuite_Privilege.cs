using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhyInterface.Models;

namespace WhyInterface
{
    public interface ICSuite_Privilege
    {
        void TerminateExecutive(Executive executive);
        void TerminateManager(Manager manager);
    }
}

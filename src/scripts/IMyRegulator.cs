using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyrillius.Interface
{
    interface IMyRegulator
    {
        float setEntry();
        float setSetpoint();
        void applyResult(float result);
    }
}

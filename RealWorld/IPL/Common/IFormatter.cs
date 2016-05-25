using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorld.IPL.Common
{
    interface IFormatter<T>
    {
        void Format(IEnumerable<T> values, params Func<T, object>[] selectors);
    }
}

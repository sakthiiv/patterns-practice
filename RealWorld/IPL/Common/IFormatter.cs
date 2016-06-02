namespace RealWorld.IPL.Common
{
    using System;
    using System.Collections.Generic;

    interface IFormatter<T>
    {
        void Format(IEnumerable<T> values, params Func<T, object>[] selectors);
    }
}

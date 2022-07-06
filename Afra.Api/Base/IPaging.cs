using System.Collections.Generic;

namespace Afra.api.Base
{
    public interface IPaging<T>
    {
        IEnumerable<T> Data { get; set; }
        int TotalRecord { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPManagement.Core.Paging
{
    public class PaginatedList<T>
    {
        public PaginatedList(IQueryable<T> source, int count)
        {
            TotalCount = count;
            Rows = source;
        }

        public PaginatedList(ICollection<T> source, int count)
        {
            TotalCount = count;
            Rows = source;
        }

        public int TotalCount { get; }

        public IEnumerable<T> Rows { get; }

        public static PaginatedList<T> Deafault => new PaginatedList<T>(Array.Empty<T>(), 0);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPManagement.Core.Paging
{
    public interface IPagedRequest
    {
        public int Page { get; set; }

        public int Size { get; set; }
    }
}

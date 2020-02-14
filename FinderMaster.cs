

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ClinkIT
{
    public class FinderMaster
    {
        protected List<string> answerList = new List<string>();
        protected String[] src { get; set; }
        protected IEnumerable<string> dictionary { get; set; }
    }
}

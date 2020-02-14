
using System;
using System.Collections.Generic;

namespace ClinkIT
{
    interface IFinderRepository
    {
        public IList<string> Find(String[] src);
    }

}
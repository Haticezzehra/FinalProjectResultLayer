﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public  class DataResult<T> : Result,IDataResult<T>
    {
        public T data { get; }

    }
}

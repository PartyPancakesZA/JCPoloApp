﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Response
{
    public interface IResponse
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}

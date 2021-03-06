﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace BatchGuy.App.Shared.Models
{
    public class ErrorCollection : List<Error>
    {
        public string GetErrorMessage()
        {
            if (this != null && this.Count() > 0)
                return string.Format("{0} Errors found: {1}", this.Count() ,string.Join(Environment.NewLine,this.Select(e => e.Description)));
            else
                return string.Empty;
        }
    }
}

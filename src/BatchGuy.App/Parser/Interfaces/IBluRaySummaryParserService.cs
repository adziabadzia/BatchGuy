﻿using BatchGuy.App.Parser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Parser.Interfaces
{
    public interface IBluRaySummaryParserService
    {
        List<BluRaySummaryInfo> GetSummaryList();
        string GetId(ProcessOutputLineItem lineItem);
    }
}
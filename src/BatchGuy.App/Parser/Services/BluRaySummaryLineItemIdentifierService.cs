﻿using BatchGuy.App.Parser.Interfaces;
using BatchGuy.App.Parser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.Parser.Services
{
    public class BluRaySummaryLineItemIdentifierService : ILineItemIdentifierService
    {
        public EnumLineItemType GetLineItemType(ProcessOutputLineItem processOutputLineItem)
        {
            EnumLineItemType type;

            if (this.IsHeaderLine(processOutputLineItem))
            {
                type = EnumLineItemType.BluRaySummaryHeaderLine;
            }
            else if (this.IsDetailLine(processOutputLineItem))
            {
                type = EnumLineItemType.BluRaySummaryDetailLine;    
            }
            else
            {
                type = EnumLineItemType.BluRaySummaryEmptyLine;
            }

            return type;
        }

        public bool IsHeaderLine(ProcessOutputLineItem processOutputLineItem)
        {
            string[] values = new string[] { ".mpls", ".m2ts" };

            bool isHeader = values.Any(v => processOutputLineItem.Text.ToLower().Contains(v));

            return isHeader;
        }

        public bool IsDetailLine(ProcessOutputLineItem processOutputLineItem)
        {
            string[] values = new string[] { "chapters", "h264", "dts", "ac3" };

            bool isDetail = values.Any(v => processOutputLineItem.Text.ToLower().Contains(v));

            return isDetail;
        }
    }
}

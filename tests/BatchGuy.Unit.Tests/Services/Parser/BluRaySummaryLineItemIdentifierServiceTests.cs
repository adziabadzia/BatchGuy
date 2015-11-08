﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssert;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Parser.Services;
using BatchGuy.App;
using BatchGuy.App.Parser.Interfaces;

namespace BatchGuy.Unit.Tests.Services.Parser
{
    [TestFixture]
    public class BluRaySummaryLineItemIdentifierServiceTests
    {
        [Test]
        public void bluraysummarylineitemidentifierservice_can_identify_bluray_header_line_item_test()
        {
            ProcessOutputLineItem lineItem = new ProcessOutputLineItem() { Id =1 , Text = "1) 00010.mpls, 3:04:31" };
            ILineItemIdentifierService service = new BluRaySummaryLineItemIdentifierService();
            EnumLineItemType type = service.GetLineItemType(lineItem);
            type.ShouldBeEqualTo(EnumLineItemType.BluRaySummaryHeaderLine);
        }

        public void bluraysummarylineitemidentifierservice_can_identify_bluray_detail_line_item_test()
        {
            ProcessOutputLineItem lineItem = new ProcessOutputLineItem() { Id = 1, Text = "- DTS Master Audio, Swedish, multi-channel, 48kHz" };
            ILineItemIdentifierService service = new BluRaySummaryLineItemIdentifierService();
            EnumLineItemType type = service.GetLineItemType(lineItem);
            type.ShouldBeEqualTo(EnumLineItemType.BluRaySummaryDetailLine);
        }

        public void bluraysummarylineitemidentifierservice_can_identify_bluray_empty_line_item_test()
        {
            ProcessOutputLineItem lineItem = new ProcessOutputLineItem() { Id = 1, Text = "" };
            ILineItemIdentifierService service = new BluRaySummaryLineItemIdentifierService();
            EnumLineItemType type = service.GetLineItemType(lineItem);
            type.ShouldBeEqualTo(EnumLineItemType.BluRaySummaryEmptyLine);
        }
    }
}

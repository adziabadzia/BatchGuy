﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BatchGuy.App.MKVMerge.Interfaces;
using BatchGuy.App.MKVMerge.Services;
using FluentAssertions;

namespace BatchGuy.Unit.Tests.Services.MKVMerge
{
    public class MKVMergeLanguageServiceTests
    {
        [Test]
        public void mkvmergelanguageservice_can_get_languages_test()
        {
            //given
            IMKVMergeLanguageService service = new MKVMergeLanguageService();
            //when
            var languages = service.GetLanguages();
            //then
            languages.Count().Should().BeGreaterThan(0);
        }

        [Test]
        public void mkvmergelanguageservice_returns_undetermined_when_language_not_found_test()
        {
            //given
            IMKVMergeLanguageService service = new MKVMergeLanguageService();
            //when
            var language = service.GetLanguageByName("nolanguage");
            //then
            language.Value.Should().Be("und");
        }

        [Test]
        public void mkvmergelanguageservice_returns_correct_language_test()
        {
            //given
            IMKVMergeLanguageService service = new MKVMergeLanguageService();
            //when
            var language = service.GetLanguageByName("English");
            //then
            language.Value.Should().Be("eng");
        }
    }
}
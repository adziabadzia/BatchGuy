﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssert;
using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.Eac3To.Interfaces;
using BatchGuy.App.Eac3To.Services;
using BatchGuy.App.Eac3To.Models;
using BatchGuy.App.Extensions;
using BatchGuy.App.Helpers;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Enums;

namespace BatchGuy.Unit.Tests.Services.Eac3to
{
    [TestFixture]
    public class EAC3ToOutputNamingServiceTests
    {
        [Test]
        public void eac3ToOutputNamingService_can_set_chapter_name_when_not_extract_for_remux()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration() { IsExtractForRemux = false };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            //when i get the chapter name
            IEAC3ToOutputNamingService service = new EAC3ToOutputNamingService();
            string chapterName = service.GetChapterName(config, filesOutputPath, paddedEpisodeNumber);
            //then chapter name should be hard coded for workflow
            chapterName.ShouldBeEqualTo("\"c:\\bluray\\chapters01.txt\"");
        }

        [Test]
        public void eac3ToOutputNamingService_can_set_chapter_name_when_is_extract_for_remux()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration() { IsExtractForRemux = true, RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate() { AudioType = "FLAC 5.1", SeriesName = "BatchGuy",
             SeasonNumber = 2, SeasonYear = 1978, Tag = "Guy", VideoResolution = "1080p"} };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            //when i get the chapter name
            IEAC3ToOutputNamingService service = new EAC3ToOutputNamingService();
            string chapterName = service.GetChapterName(config, filesOutputPath, paddedEpisodeNumber);
            //then chapter name should be based on the remux template
            chapterName.ShouldBeEqualTo("\"c:\\bluray\\BatchGuy S02E01 1080p Remux AVC FLAC 5.1-Guy chapters.txt\"");
        }

        [Test]
        public void eac3ToOutputNamingService_can_set_video_name_when_not_extract_for_remux()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration() { IsExtractForRemux = false };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            //when i get the video name
            IEAC3ToOutputNamingService service = new EAC3ToOutputNamingService();
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber);
            //then video name should be hard coded for workflow
            videoName.ShouldBeEqualTo("\"c:\\bluray\\video01.mkv\"");
        }

        [Test]
        public void eac3ToOutputNamingService_can_set_video_name_when_is_extract_for_remux()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    AudioType = "FLAC 5.1",
                    SeriesName = "BatchGuy",
                    SeasonNumber = 2,
                    SeasonYear = 1978,
                    Tag = "Guy",
                    VideoResolution = "1080p"
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            //when i get the video name
            IEAC3ToOutputNamingService service = new EAC3ToOutputNamingService();
            string videoName = service.GetVideoName(config, filesOutputPath, paddedEpisodeNumber);
            //then video name should be based on the remux template
            videoName.ShouldBeEqualTo("\"c:\\bluray\\BatchGuy S02E01 1080p Remux AVC FLAC 5.1-Guy.mkv\"");
        }

        [Test]
        public void eac3ToOutputNamingService_can_set_audio_name_when_not_extract_for_remux()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration() { IsExtractForRemux = false };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            BluRayTitleAudio audio = new BluRayTitleAudio() { AudioType = EnumAudioType.DTS, Language = "english" };
            //when i get the audio name
            IEAC3ToOutputNamingService service = new EAC3ToOutputNamingService();
            string audioName = service.GetAudioName(config, audio, filesOutputPath, paddedEpisodeNumber, 1);
            //then audio name should be hard coded for workflow
            audioName.ShouldBeEqualTo("\"c:\\bluray\\english01-1.dts\"");
        }

        [Test]
        public void eac3ToOutputNamingService_can_set_audio_name_when_is_extract_for_remux()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    AudioType = "FLAC 5.1",
                    SeriesName = "BatchGuy",
                    SeasonNumber = 2,
                    SeasonYear = 1978,
                    Tag = "Guy",
                    VideoResolution = "1080p"
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            //when i get the audio name
            IEAC3ToOutputNamingService service = new EAC3ToOutputNamingService();
            BluRayTitleAudio audio = new BluRayTitleAudio() { AudioType = EnumAudioType.DTS, Language = "english" };
            string audioName = service.GetAudioName(config, audio, filesOutputPath, paddedEpisodeNumber, 1);
            //then audio name should be based on the remux template
            audioName.ShouldBeEqualTo("\"c:\\bluray\\BatchGuy S02E01 1080p Remux AVC FLAC 5.1-Guy english01-1.dts\"");
        }

        [Test]
        public void eac3ToOutputNamingService_can_set_subtitle_name_when_not_extract_for_remux()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration() { IsExtractForRemux = false };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            BluRayTitleSubtitle subtitle = new BluRayTitleSubtitle() { Language = "english" };
            //when i get the subtitle name
            IEAC3ToOutputNamingService service = new EAC3ToOutputNamingService();
            string  subtitleName = service.GetSubtitleName(config, subtitle, filesOutputPath, paddedEpisodeNumber, 1);
            //then subtitle name should be hard coded for workflow
            subtitleName.ShouldBeEqualTo("\"c:\\bluray\\english01-1.sup\"");
        }

        [Test]
        public void eac3ToOutputNamingService_can_set_subtitle_name_when_is_extract_for_remux()
        {
            //given not extract for remux
            EAC3ToConfiguration config = new EAC3ToConfiguration()
            {
                IsExtractForRemux = true,
                RemuxFileNameTemplate = new EAC3ToRemuxFileNameTemplate()
                {
                    AudioType = "FLAC 5.1",
                    SeriesName = "BatchGuy",
                    SeasonNumber = 2,
                    SeasonYear = 1978,
                    Tag = "Guy",
                    VideoResolution = "1080p"
                }
            };
            string filesOutputPath = "c:\\bluray";
            string paddedEpisodeNumber = "01";
            //when i get the subtitle name
            IEAC3ToOutputNamingService service = new EAC3ToOutputNamingService();
            BluRayTitleSubtitle subtitle = new BluRayTitleSubtitle() { Language = "english" };
            string subtitleName = service.GetSubtitleName(config, subtitle, filesOutputPath, paddedEpisodeNumber, 1);
            //then subtitle name should be based on the remux template
            subtitleName.ShouldBeEqualTo("\"c:\\bluray\\BatchGuy S02E01 1080p Remux AVC FLAC 5.1-Guy english01-1.sup\"");
        }
    }
}

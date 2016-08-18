﻿using BatchGuy.App.Eac3to.Models;
using BatchGuy.App.Eac3To.Interfaces;
using BatchGuy.App.Enums;
using BatchGuy.App.Extensions;
using BatchGuy.App.Helpers;
using BatchGuy.App.MKVMerge.Interfaces;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.App.MKVMerge.Services
{
    public class MKVMergeOutputService : IMKVMergeOutputService
    {
        private EAC3ToConfiguration _eac3ToConfiguration;
        private ErrorCollection _errors = new ErrorCollection();
        private string _filesOutputPath;
        private string _paddedEpisodeNumber;
        private string _bluRayPath;
        private BluRaySummaryInfo _bluRaySummaryInfo;
        private IEAC3ToOutputNamingService _eac3ToOutputNamingService;

        public MKVMergeOutputService(EAC3ToConfiguration config, IEAC3ToOutputNamingService eac3ToOutputNamingService, string bluRayPath, BluRaySummaryInfo bluRaySummaryInfo)
        {
            _eac3ToConfiguration = config;
            _eac3ToOutputNamingService = eac3ToOutputNamingService;
            _bluRayPath = bluRayPath;
            _bluRaySummaryInfo = bluRaySummaryInfo;
            this.Init();
        }

        private void Init()
        {
            _paddedEpisodeNumber = HelperFunctions.PadNumberWithZeros(_eac3ToConfiguration.NumberOfEpisodes, _bluRaySummaryInfo.BluRayTitleInfo.EpisodeNumber.StringToInt());
            if (_eac3ToConfiguration.OutputDirectoryType == EnumDirectoryType.DirectoryPerEpisode)
            {
                string folderName = string.Format("e{0}", _paddedEpisodeNumber);
                _filesOutputPath = string.Format("{0}\\{1}", _eac3ToConfiguration.EAC3ToOutputPath, folderName);
            }
            else
            {
                _filesOutputPath = string.Format("{0}", _eac3ToConfiguration.EAC3ToOutputPath);
            }
        }

        public string GetMKVMergePathPart()
        {
            return string.Format("\"{0}\"", _eac3ToConfiguration.MKVMergePath);
        }

        public string GetOutputPart()
        {
            return string.Format("--ui-language en --output ^\"{0}^\"", _eac3ToOutputNamingService.GetVideoName(_eac3ToConfiguration, _eac3ToConfiguration.MKVMergeOutputPath, _paddedEpisodeNumber, _bluRaySummaryInfo.BluRayTitleInfo.EpisodeName).RemoveDoubleQuotes());
        }

        public string GetVideoPart()
        {
            StringBuilder sb = new StringBuilder();
            if (_bluRaySummaryInfo.BluRayTitleInfo.Video != null)
            {
                if (_bluRaySummaryInfo.BluRayTitleInfo.Video.IsSelected)
                {
                    sb.Append(string.Format("--language 0:und ^\"^(^\" ^\"{0}^\" ^\"^)^\"", _eac3ToOutputNamingService.GetVideoName(_eac3ToConfiguration, _filesOutputPath, _paddedEpisodeNumber, _bluRaySummaryInfo.BluRayTitleInfo.EpisodeName).RemoveDoubleQuotes()));
                }
            }
            return sb.ToString();
        }

        public string GetTrackOrderPart()
        {
            StringBuilder sb = new StringBuilder();
            int trackCount = 0;

            sb.Append("--track-order ");
            if (_bluRaySummaryInfo.BluRayTitleInfo.Video != null && _bluRaySummaryInfo.BluRayTitleInfo.Video.IsSelected)
            { 
                trackCount++;
            }
            if (_bluRaySummaryInfo.BluRayTitleInfo.AudioList != null && _bluRaySummaryInfo.BluRayTitleInfo.AudioList.Where(a => a.IsSelected).Count() > 0)
            {
                trackCount += _bluRaySummaryInfo.BluRayTitleInfo.AudioList.Where(a => a.IsSelected).Count();
            }
            if (_bluRaySummaryInfo.BluRayTitleInfo.Subtitles != null && _bluRaySummaryInfo.BluRayTitleInfo.Subtitles.Where(a => a.IsSelected).Count() > 0)
            {
                trackCount += _bluRaySummaryInfo.BluRayTitleInfo.Subtitles.Where(a => a.IsSelected).Count();
            }

            for (int i = 0; i < trackCount; i++)
            {
                sb.Append(string.Format("{0}:0,", i));
            }

            return sb.ToString().Substring(0,sb.ToString().Length -1);
        }

        public string GetAudioStreamPart()
        {
            throw new NotImplementedException();
        }

        public string GetChapterStreamPart()
        {
            throw new NotImplementedException();
        }

        public string GetSubtitleStreamPart()
        {
            throw new NotImplementedException();
        }
    }
}

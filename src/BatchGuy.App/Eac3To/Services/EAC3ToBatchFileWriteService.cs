﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.Eac3to.Models;
using System.IO;
using BatchGuy.App.Helpers;
using BatchGuy.App.Eac3to.Interfaces;
using BatchGuy.App.Shared.Models;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Eac3To.Interfaces;
using BatchGuy.App.Extensions;
using log4net;
using System.Reflection;
using BatchGuy.App.Eac3To.Services;

namespace BatchGuy.App.Eac3to.Services
{
    public class EAC3ToBatchFileWriteService : IEAC3ToBatchFileWriteService
    {
        private ErrorCollection _errors = new ErrorCollection();
        private List<BluRayDiscInfo> _bluRayDiscInfoList;
        private EAC3ToConfiguration _eac3toConfiguration;

        public static readonly ILog _log = LogManager.GetLogger(typeof(EAC3ToBatchFileWriteService));

        public ErrorCollection Errors
        {
            get { return _errors; }
        }

        public EAC3ToBatchFileWriteService(EAC3ToConfiguration eac3toConfiguration, List<BluRayDiscInfo> bluRayDiscInfo)
        {
            _bluRayDiscInfoList = bluRayDiscInfo;
            _eac3toConfiguration = eac3toConfiguration;
            _errors = new ErrorCollection();
        }

        public ErrorCollection Write()
        {
            if (this.IsValid())
            {
                try
                {
                    IEAC3ToOutputNamingService eac3ToOutputNamingService = new EAC3ToOutputNamingService();
                    foreach (BluRayDiscInfo disc in _bluRayDiscInfoList.Where(d => d.IsSelected))
                    {
                        foreach (BluRaySummaryInfo summary in disc.BluRaySummaryInfoList.Where(s => s.IsSelected).OrderBy(s => s.EpisodeNumber))
                        {
                            IEAC3ToOutputService eacOutputService = new EAC3ToOutputService(_eac3toConfiguration, eac3ToOutputNamingService, disc.BluRayPath, summary);
                            string eac3ToPathPart = eacOutputService.GetEAC3ToPathPart();
                            string bluRayStreamPart = eacOutputService.GetBluRayStreamPart();
                            string chapterStreamPart = eacOutputService.GetChapterStreamPart();
                            string videoStreamPart = eacOutputService.GetVideoStreamPart();
                            string audioStreamPart = eacOutputService.GetAudioStreamPart();
                            string subtitleStreamPart = eacOutputService.GetSubtitleStreamPart();
                            string logPart = eacOutputService.GetLogPart();

                            using (StreamWriter sw = new StreamWriter(_eac3toConfiguration.BatchFilePath, true))
                            {
                                sw.WriteLine(string.Format("{0} {1} {2} {3} {4} {5} {6} -progressnumbers", eac3ToPathPart, bluRayStreamPart, chapterStreamPart, videoStreamPart, audioStreamPart,
                                    subtitleStreamPart, logPart));
                                sw.WriteLine();
                                sw.WriteLine();
                            }
                        }
                    } 
                }
                catch (Exception ex)
                {
                    _log.ErrorFormat(Program.GetLogErrorFormat(), ex.Message, MethodBase.GetCurrentMethod().Name);
                    _errors.Add(new Error() { Description = "There was an error will creating the eac3to batch file." });
                }
            }
            return _errors;
        }

        public bool IsValid()
        {
            if (!this.IsAtLeastOneDiscSelected())
                return false;
            if (!this.IsAtLeastOneSummarySelected())
                return false;
            if (!this.WhenSummarySelectedAtLeastOneStreamSelected())
                return false;
            if (!this.IsAllEpisodeNumbersSet())
                return false;

            return true;
        }

        private bool IsAtLeastOneDiscSelected()
        {
            bool isValid = true;

            if (_bluRayDiscInfoList.Where(d => d.IsSelected).Count() == 0)
            {
                isValid = false;
                this._errors.Add(new Error() { Description = "No Disc was selected." });
            }
            return isValid;
        }

        private bool IsAtLeastOneSummarySelected()
        {
            bool isValid = false;

            foreach (BluRayDiscInfo disc in _bluRayDiscInfoList.Where(d => d.IsSelected))
            {
                if (disc.BluRaySummaryInfoList.Where(s => s.IsSelected).Count() > 0)
                {
                    isValid = true;
                }                
            }

            if (!isValid)
            {
                this._errors.Add(new Error() { Description="No episodes selected." });
            }
            return isValid;
        }

        private bool WhenSummarySelectedAtLeastOneStreamSelected()
        {
            bool isValid = false;

            foreach (BluRayDiscInfo disc in _bluRayDiscInfoList.Where(d => d.IsSelected))
            {
                foreach (BluRaySummaryInfo summary in disc.BluRaySummaryInfoList.Where(s => s.IsSelected))
                {
                    if (summary.BluRayTitleInfo != null && summary.BluRayTitleInfo.Video.IsSelected)
                    {
                        isValid = true;
                    }
                    if (summary.BluRayTitleInfo != null && summary.BluRayTitleInfo.AudioList != null && summary.BluRayTitleInfo.AudioList.Where(a => a.IsSelected).Count() > 0)
                    {
                        isValid = true;
                    }
                    if (summary.BluRayTitleInfo != null && summary.BluRayTitleInfo.Subtitles != null && summary.BluRayTitleInfo.Subtitles.Where(s => s.IsSelected).Count() > 0 )
                    {
                        isValid = true;
                    }
                    if (summary.BluRayTitleInfo != null && summary.BluRayTitleInfo.Chapter != null && summary.BluRayTitleInfo.Chapter.IsSelected)
                    {
                        isValid = true;
                    }
                    if (!isValid)
                    {
                        this._errors.Add(new Error() { Description = "Some selected titles have no streams selected." });
                        return isValid;
                    }
                    isValid = false;
                }

            }
            return true;
        }

        private bool IsAllEpisodeNumbersSet()
        {
            bool isValid = true;

            foreach (BluRayDiscInfo disc in _bluRayDiscInfoList.Where(d => d.IsSelected))
            {
                foreach (BluRaySummaryInfo info in disc.BluRaySummaryInfoList.Where(s => s.IsSelected))
                {
                    if (info.EpisodeNumber == null)
                    {
                        isValid = false;
                    }             
                }
            }

            if (!isValid)
            {
                this._errors.Add(new Error() { Description = "Episode not set for all titles." });
            }
            return isValid;
        }
    }
}
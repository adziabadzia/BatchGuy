﻿using BatchGuy.App.Enums;
using BatchGuy.App.Parser.Models;
using BatchGuy.App.Settings.Interface;
using BatchGuy.App.Shared.Interfaces;
using BatchGuy.App.Shared.Models;
using System.Linq;

namespace BatchGuy.App.Settings.Services
{
    public class BluRayTitleInfoDefaultSettingsService : IBluRayTitleInfoDefaultSettingsService
    {
        private ApplicationSettings _applicationSettings;
        private BluRaySummaryInfo _bluRaySummaryInfo;
        private IAudioService _audioService;

        public BluRayTitleInfoDefaultSettingsService(ApplicationSettings applicationSettings, BluRaySummaryInfo bluRaySummaryInfo, IAudioService audioService)
        {
            _applicationSettings = applicationSettings;
            _bluRaySummaryInfo = bluRaySummaryInfo;
            _audioService = audioService;
        }
        public void SetAudioDefaultSettings()
        {
            if (_bluRaySummaryInfo.BluRayTitleInfo.AudioList != null)
            {
                foreach (BluRayTitleAudio audio in _bluRaySummaryInfo.BluRayTitleInfo.AudioList)
                {
                    var defaultSetting = _applicationSettings.BluRayTitleInfoDefaultSettings.Audio.First(a => a.Type == audio.AudioType);
                    audio.Arguments = defaultSetting.Arguments;
                    audio.AudioType = _audioService.GetAudioTypeByName(defaultSetting.DefaultType);
                }

                if (_applicationSettings.AudioLanguageAlwaysSelectedEnabled)
                {
                    foreach (BluRayTitleAudio audio in _bluRaySummaryInfo.BluRayTitleInfo.AudioList.Where(a => a.Text.ToLower().Contains(_applicationSettings.AudioMKVMergeDefaultSettings.DefaultMKVMergeItem.Language.Language.ToLower())))
                    {
                        if (_applicationSettings.AudioMKVMergeDefaultSettings.AudioTypeFilterCriteria == "Any Type")
                        {
                            audio.IsSelected = true;
                        }
                        else if (_applicationSettings.AudioMKVMergeDefaultSettings.AudioTypeFilterCriteria == "Lossless")
                        {
                            if (audio.IsLossless)
                            {
                                audio.IsSelected = true;
                            }
                        }
                        else
                        {
                            EnumAudioType audioTypeFilter = _audioService.GetAudioTypeByName(_applicationSettings.AudioMKVMergeDefaultSettings.AudioTypeFilterCriteria);
                            if (audioTypeFilter == audio.OriginalAudioType)
                            {
                                audio.IsSelected = true;
                            }
                        }
                    }
                }
            }
        }

        public void SetChaptersDefaultSettings()
        {
            if (_bluRaySummaryInfo.BluRayTitleInfo.Chapter != null)
            {
                _bluRaySummaryInfo.BluRayTitleInfo.Chapter.IsSelected = _applicationSettings.BluRayTitleInfoDefaultSettings.SelectChapters;
            }
        }

        public void SetSubtitleDefaultSettings()
        {
            if (_bluRaySummaryInfo.BluRayTitleInfo.Subtitles != null)
            {
                _bluRaySummaryInfo.BluRayTitleInfo.Subtitles.ForEach(s => s.IsSelected = _applicationSettings.BluRayTitleInfoDefaultSettings.SelectAllSubtitles);

                if (_applicationSettings.SubtitleLanguageAlwaysSelectedEnabled)
                {
                    foreach (BluRayTitleSubtitle subtitle in _bluRaySummaryInfo.BluRayTitleInfo.Subtitles.Where(a => a.Text.ToLower().Contains(_applicationSettings.SubtitlesMKVMergeDefaultSettings.DefaultMKVMergeItem.Language.Language.ToLower())))
                    {
                        subtitle.IsSelected = true;
                    }
                }
            }
        }
    }
}

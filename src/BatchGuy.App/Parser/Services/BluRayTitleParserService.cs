﻿using BatchGuy.App.Parser.Interfaces;
using BatchGuy.App.Parser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.Enums;

namespace BatchGuy.App.Parser.Services
{
    public class BluRayTitleParserService : IBluRayTitleParserService
    {
        private ILineItemIdentifierService _lineItemIdentifierService;
        private List<ProcessOutputLineItem> _processOutputLineItems;
        private readonly BluRayTitleInfo _bluRayTtileInfo;

        public BluRayTitleParserService(ILineItemIdentifierService lineItemIdentifierService, List<ProcessOutputLineItem> processOutputLineItems)
        {
            _lineItemIdentifierService = lineItemIdentifierService;
            _processOutputLineItems = processOutputLineItems;
            _bluRayTtileInfo = new BluRayTitleInfo();
        }

        public BluRayTitleInfo GetTitleInfo()
        {
            foreach (ProcessOutputLineItem item in _processOutputLineItems)
            {
                EnumLineItemType type = _lineItemIdentifierService.GetLineItemType(item);

                switch (type)
                {
                    case EnumLineItemType.BluRayTitleHeaderLine:
                        _bluRayTtileInfo.HeaderText = item.Text;
                        break;
                    case EnumLineItemType.BluRayTitleEmptyLine:
                        break;
                    case EnumLineItemType.BluRayTitleChapterLine:
                        this.SetChapter(item);
                        break;
                    case EnumLineItemType.BluRayTitleVideoLine:
                        this.SetVideo(item);
                        break;
                    case EnumLineItemType.BluRayTitleAudioLine:
                        this.SetAudio(item);
                        break;
                    case EnumLineItemType.BluRayTitleSubtitleLine:
                        this.SetSubtitle(item);
                        break;
                    default:
                        break;
                }
            }

            return _bluRayTtileInfo;
        }

        public string GetId(ProcessOutputLineItem lineItem)
        {
            string[] splitted = lineItem.Text.Split(' ');
            return splitted[0];
        }

        public EnumAudioType GetAudioType(ProcessOutputLineItem lineItem)
        {
            EnumAudioType type = EnumAudioType.AC3;

            if (this.IsAudioType(lineItem, "dts"))
            {
                type = EnumAudioType.DTS;
            }
            else if (this.IsAudioType(lineItem, "truehd"))
            {
                type = EnumAudioType.TrueHD;
            }
            else if (this.IsAudioType(lineItem, "lpcm"))
            {
                type = EnumAudioType.FLAC;
            }
            return type;
        }

        public string GetLanguage(ProcessOutputLineItem lineItem)
        {
            string[] languages = new string[] { "chinese", "dutch", "english", "english", "finnish", "french", "german", "italian", "spanish", "japanese", "norwegian", "portuguese", "swedish"};
            string lineItemLanguage = "undetermined";

            foreach (string language in languages)
            {
                if (lineItem.Text.ToLower().Contains(language))
                {
                    return lineItemLanguage = language;
                }
            }
            return lineItemLanguage;
        }

        public bool IsAudioType(ProcessOutputLineItem processOutputLineItem, string criteria )
        {
            string[] values = new string[] { criteria };

            bool isAudio = values.Any(v => processOutputLineItem.Text.ToLower().Contains(v));

            return isAudio;
        }

        private void SetChapter(ProcessOutputLineItem lineItem)
        {
            _bluRayTtileInfo.Chapter = new BluRayTitleChapter() { Id = this.GetId(lineItem), IsSelected = true };
        }

        private void SetVideo(ProcessOutputLineItem lineItem)
        {
            _bluRayTtileInfo.Movie = new BluRayTitleMovie() { Id = this.GetId(lineItem), IsSelected = true };
        }

        private void SetAudio(ProcessOutputLineItem lineItem)
        {
            if (_bluRayTtileInfo.AudioList == null)
                _bluRayTtileInfo.AudioList = new List<BluRayTitleAudio>();

            BluRayTitleAudio audio = new BluRayTitleAudio();
            audio.Id = this.GetId(lineItem);
            audio.IsSelected = false;
            audio.AudioType = this.GetAudioType(lineItem);
            audio.Language = this.GetLanguage(lineItem);
            if (audio.AudioType == EnumAudioType.TrueHD)
            {
                audio.Arguments = "-640";
            }
            else if (audio.AudioType == EnumAudioType.DTS)
            {
                audio.Arguments = "-core";
            }

            _bluRayTtileInfo.AudioList.Add(audio);
        }

        private void SetSubtitle(ProcessOutputLineItem lineItem)
        {
            if (_bluRayTtileInfo.Subtitles == null)
                _bluRayTtileInfo.Subtitles = new List<BluRayTitleSubtitle>();

            BluRayTitleSubtitle subtitle = new BluRayTitleSubtitle();
            subtitle.Id = this.GetId(lineItem);
            subtitle.Language = this.GetLanguage(lineItem);
            _bluRayTtileInfo.Subtitles.Add(subtitle);
        }
    }
}

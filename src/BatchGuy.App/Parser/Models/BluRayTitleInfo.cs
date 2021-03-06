﻿using System.Collections.Generic;

namespace BatchGuy.App.Parser.Models
{
    public class BluRayTitleInfo
    {
        public string EpisodeNumber { get; set; }
        public string EpisodeName { get; set; }
        public string HeaderText { get; set; }
        public BluRayTitleChapter Chapter { get; set; }
        public BluRayTitleVideo Video { get; set; }
        public List<BluRayTitleAudio> AudioList { get; set; }
        public List<BluRayTitleSubtitle> Subtitles { get; set; }
    }
}

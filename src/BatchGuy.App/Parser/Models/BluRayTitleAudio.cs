﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatchGuy.App.Enums;


namespace BatchGuy.App.Parser.Models
{
    public class BluRayTitleAudio
    {
        public string Id { get; set; }
        public EnumAudioType AudioType { get; set; }
        public string Language { get; set; }
        public string Arguments { get; set; }
        public bool IsSelected { get; set; }
        public string Text { get; set; }
    }
}

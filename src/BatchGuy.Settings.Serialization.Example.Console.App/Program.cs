﻿using BatchGuy.App.Settings.Interface;
using BatchGuy.App.Settings.Models;
using BatchGuy.App.Settings.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchGuy.Settings.Serialization.Example.Console.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize services
            IJsonSerializationService<ApplicationSettings> jsonSerializationService = new JsonSerializationService<ApplicationSettings>(); //serialization service
            IApplicationSettingsService applicationSettingsService = new ApplicationSettingsService(jsonSerializationService); //application service

            //get current application settings
            ApplicationSettings applicationSettings = applicationSettingsService.GetApplicationSettings();

            //add
            applicationSettings.Settings.Add(new Setting() { Name = "eac3to", Path = @"c:\exe\eac3to.exe" });
            //save to disc
            applicationSettingsService.Save(applicationSettings);

            var errors = applicationSettingsService.Errors;

            //get settings
            applicationSettings = applicationSettingsService.GetApplicationSettings();

            errors = applicationSettingsService.Errors;

            System.Console.ReadLine();
        }
    }
}

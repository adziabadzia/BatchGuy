﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatchGuy.App.Shared.Interface;
using BatchGuy.App.Shared.Models;
using BatchGuy.App.Shared.Services;
using BatchGuy.App.Extensions;
using BatchGuy.App.Settings.Models;
using BatchGuy.App.MKVMerge.Models;
using BatchGuy.App.MKVMerge.Interfaces;
using BatchGuy.App.MKVMerge.Services;
using BatchGuy.App.Enums;

namespace BatchGuy.App
{
    public partial class SettingsForm : Form
    {
        private BindingList<BluRayTitleInfoDefaultSettingsAudio> _bindingBluRayTitleInfoDefaultSettingsAudio = new BindingList<BluRayTitleInfoDefaultSettingsAudio>();
        private BindingList<MKVMergeLanguageItem> _bindingListSubtitlesMKVMergeDefaultSettingsLanguage = new BindingList<MKVMergeLanguageItem>();
        private BindingList<MKVMergeLanguageItem> _bindingListAudioMKVMergeDefaultSettingsLanguage = new BindingList<MKVMergeLanguageItem>();

        public SettingsForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            this.LoadMKVLanguageDropDownBoxes();
            this.LoadSettings();
            this.LoadControls();
            this.SetToolTips();
        }

        private void SetToolTips()
        {
            new ToolTip().SetToolTip(btnOpenEac3toFileDialog, "eac3to exe path");
            new ToolTip().SetToolTip(btnOpenVfw4x264FileDialog, "vfw4x264 exe path");
            new ToolTip().SetToolTip(btnOpenMKVMergeFileDialog, "mkvmege exe path");
            new ToolTip().SetToolTip(chkShowProgressNumbers, "Specify if eac3to should use the progressnumbers parameter");

            new ToolTip().SetToolTip(chkBluRayTitleInfoDefaultSettingsSelectSubtitles, "Should all subtitles be selected by default");
            new ToolTip().SetToolTip(chkBluRayTitleInfoDefaultSettingsSelectChapters, "Should chapters be selected by default");

            new ToolTip().SetToolTip(chkAudioLanguageAlwaysSelectedEnabled, "Always select audio if it is a certain language");
            new ToolTip().SetToolTip(cbAudioMKVMergeDefaultSettingsLanguage, "Audio language that is always selected");
            new ToolTip().SetToolTip(cbAudioMKVMergeDefaultSettingsAudioType, "Filter audio language always selected by language and the audio type ie only select if English and DTS");
            new ToolTip().SetToolTip(cbAudioMKVMergeDefaultSettingsDefaultTrackFlag, "Set the mkvmerge default track flag of the always selected audio");

            new ToolTip().SetToolTip(chkSubtitleLanguageAlwaysSelectedEnabled, "Always select subtitles if it is a certain language");
            new ToolTip().SetToolTip(cbSubtitlesMKVMergeDefaultSettingsLanguage, "Subtitle language that is always selected");
            new ToolTip().SetToolTip(cbSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag, "Set the mkvmerge default track flag of the always selected subtitle");

            new ToolTip().SetToolTip(cbRemuxNamingConventionDefaults, "Set the default remux naming convention template");
        }

        private void LoadSettings()
        {
            txtEac3toPath.Text = this.LoadSetting("eac3to");
            txtVfw4x264.Text = this.LoadSetting("vfw4x264");
            txtMKVMerge.Text = this.LoadSetting("mkvmerge");

            foreach (BluRayTitleInfoDefaultSettingsAudio bluRayTitleInfoDefaultSettingsAudio in Program.ApplicationSettings.BluRayTitleInfoDefaultSettings.Audio)
            {
                _bindingBluRayTitleInfoDefaultSettingsAudio.Add(bluRayTitleInfoDefaultSettingsAudio);
            }
            bsBluRayTitleInfoDefaultSettingsAudio.DataSource = _bindingBluRayTitleInfoDefaultSettingsAudio;
        }

        private void LoadControls()
        {
            chkBluRayTitleInfoDefaultSettingsSelectChapters.Checked = Program.ApplicationSettings.BluRayTitleInfoDefaultSettings.SelectChapters;
            chkBluRayTitleInfoDefaultSettingsSelectSubtitles.Checked = Program.ApplicationSettings.BluRayTitleInfoDefaultSettings.SelectAllSubtitles;
            chkShowProgressNumbers.Checked = Program.ApplicationSettings.EAC3ToDefaultSettings.ShowProgressNumbers;

            chkSubtitleLanguageAlwaysSelectedEnabled.Checked = Program.ApplicationSettings.SubtitleLanguageAlwaysSelectedEnabled;
            cbSubtitlesMKVMergeDefaultSettingsLanguage.SelectedValue = Program.ApplicationSettings.SubtitlesMKVMergeDefaultSettings.DefaultMKVMergeItem.Language.Value;
            cbSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag.SelectedIndex = cbSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag.FindString(Program.ApplicationSettings.SubtitlesMKVMergeDefaultSettings.DefaultMKVMergeItem.DefaultTrackFlag);
            gbSubtitlesMKVMergeDefaultSettings.Enabled = Program.ApplicationSettings.SubtitleLanguageAlwaysSelectedEnabled;

            chkAudioLanguageAlwaysSelectedEnabled.Checked = Program.ApplicationSettings.AudioLanguageAlwaysSelectedEnabled;
            cbAudioMKVMergeDefaultSettingsLanguage.SelectedValue = Program.ApplicationSettings.AudioMKVMergeDefaultSettings.DefaultMKVMergeItem.Language.Value;
            cbAudioMKVMergeDefaultSettingsDefaultTrackFlag.SelectedIndex = cbAudioMKVMergeDefaultSettingsDefaultTrackFlag.FindString(Program.ApplicationSettings.AudioMKVMergeDefaultSettings.DefaultMKVMergeItem.DefaultTrackFlag);
            cbAudioMKVMergeDefaultSettingsAudioType.SelectedIndex = cbAudioMKVMergeDefaultSettingsAudioType.FindString(Program.ApplicationSettings.AudioMKVMergeDefaultSettings.AudioTypeFilterCriteria);
            gbAudioMKVMergeDefaultSettings.Enabled = Program.ApplicationSettings.AudioLanguageAlwaysSelectedEnabled;

            cbRemuxNamingConventionDefaults.SelectedIndex = cbRemuxNamingConventionDefaults.FindString(this.GetEnumEAC3ToNamingConventionType(Program.ApplicationSettings.EnumEAC3ToNamingConventionType));
        }

        private void LoadMKVLanguageDropDownBoxes()
        {
            IJsonSerializationService<ISOLanguageCodeCollection> jsonSerializationService = new JsonSerializationService<ISOLanguageCodeCollection>();
            IMKVMergeLanguageService service = new MKVMergeLanguageService(jsonSerializationService);
            foreach (MKVMergeLanguageItem item in service.GetLanguages())
            {
                _bindingListSubtitlesMKVMergeDefaultSettingsLanguage.Add(item);
                _bindingListAudioMKVMergeDefaultSettingsLanguage.Add(item);
            }

            bsAudioMKVMergeDefaultSettingsLanguage.DataSource = _bindingListAudioMKVMergeDefaultSettingsLanguage;
            _bindingListAudioMKVMergeDefaultSettingsLanguage.AllowEdit = false;

            bsSubtitlesMKVMergeDefaultSettingsLanguage.DataSource = _bindingListSubtitlesMKVMergeDefaultSettingsLanguage;
            _bindingListSubtitlesMKVMergeDefaultSettingsLanguage.AllowEdit = false;
        }

        private string LoadSetting(string settingName)
        {
            Setting setting = Program.ApplicationSettingsService.GetSettingByName(settingName);
            if (setting != null)
                return setting.Value;
            else
                return string.Empty;
        }

        private void btnOpenEac3toFileDialog_Click(object sender, EventArgs e)
        {
            this.HandleOpenEac3ToFileDialogClick();
        }

        private void HandleOpenEac3ToFileDialogClick()
        {
            ofdFileDialog.FileName = "eac3to executable";
            ofdFileDialog.Filter = "Files|*.exe";
            DialogResult result = ofdFileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
               txtEac3toPath.Text = ofdFileDialog.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            gbScreen.SetEnabled(false);
            this.HandleSaveClick();
            this.Close();
        }

        private void HandleSaveClick()
        {
            Program.ApplicationSettings.Settings.Clear();
            Program.ApplicationSettings.Settings.Add(new Setting() { Name = "eac3to", Value = txtEac3toPath.Text } );
            Program.ApplicationSettings.Settings.Add(new Setting() { Name = "vfw4x264", Value = txtVfw4x264.Text });
            Program.ApplicationSettings.Settings.Add(new Setting() { Name = "mkvmerge", Value = txtMKVMerge.Text });

            Program.ApplicationSettingsService.Save(Program.ApplicationSettings);
        }

        private bool IsScreenValid()
        {
            if (string.IsNullOrEmpty(txtEac3toPath.Text) || string.IsNullOrEmpty(txtVfw4x264.Text))
            {
                MessageBox.Show("All settings must be entered to save!", "Settings Information Not Provided", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnOpenVfw4x264FileDialog_Click(object sender, EventArgs e)
        {
            this.HandleOpenVfw4x264FileDialogClick();
        }

        private void HandleOpenVfw4x264FileDialogClick()
        {
            ofdFileDialog.FileName = "Vfw4x264 executable";
            ofdFileDialog.Filter = "Files|*.exe";
            DialogResult result = ofdFileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txtVfw4x264.Text = ofdFileDialog.FileName;
            }
        }

        private void btnOpenMKVMergeFileDialog_Click(object sender, EventArgs e)
        {
            this.HandleOpenMKVMergeFileDialogClick();
        }

        private void HandleOpenMKVMergeFileDialogClick()
        {
            ofdFileDialog.FileName = "mkvmerge executable";
            ofdFileDialog.Filter = "Files|*.exe";
            DialogResult result = ofdFileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
              txtMKVMerge.Text = ofdFileDialog.FileName;
            }
        }

        private string GetEnumEAC3ToNamingConventionType(EnumEAC3ToNamingConventionType eac3ToNamingConventionType)
        {
            string type = string.Empty;
            switch (eac3ToNamingConventionType)
            {
                case EnumEAC3ToNamingConventionType.RemuxNamingConventionTemplate1:
                    type = "Template 1";
                    break;
                case EnumEAC3ToNamingConventionType.RemuxNamingConventionTemplate2:
                    type = "Template 2";
                    break;
                case EnumEAC3ToNamingConventionType.RemuxNamingConventionTemplate3:
                    type = "Template 3";
                    break;
                default:
                    throw new Exception("Invalid EnumEAC3ToNamingConventionType");
            }
            return type;
        }

        private void chkBluRayTitleInfoDefaultSettingsSelectSubtitles_CheckedChanged(object sender, EventArgs e)
        {
            this.HandlesChkBluRayTitleInfoDefaultSettingsSelectSubtitlesCheckedChanged();
        }

        private void HandlesChkBluRayTitleInfoDefaultSettingsSelectSubtitlesCheckedChanged()
        {
            Program.ApplicationSettings.BluRayTitleInfoDefaultSettings.SelectAllSubtitles = chkBluRayTitleInfoDefaultSettingsSelectSubtitles.Checked;
        }

        private void chkBluRayTitleInfoDefaultSettingsSelectChapters_CheckedChanged(object sender, EventArgs e)
        {
            this.HandlesChkBluRayTitleInfoDefaultSettingsSelectChaptersCheckedChanged();
        }

        private void HandlesChkBluRayTitleInfoDefaultSettingsSelectChaptersCheckedChanged()
        {
            Program.ApplicationSettings.BluRayTitleInfoDefaultSettings.SelectChapters = chkBluRayTitleInfoDefaultSettingsSelectChapters.Checked;
        }

        private void dgvBluRayTitleInfoDefaultSettingsAudio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvBluRayTitleInfoDefaultSettingsAudio.Rows[e.RowIndex].Selected = true; 
        }

        private void chkShowProgressNumbers_CheckedChanged(object sender, EventArgs e)
        {
            this.HandlesChkShowProgressNumbersCheckedChanged();
        }

        private void HandlesChkShowProgressNumbersCheckedChanged()
        {
            Program.ApplicationSettings.EAC3ToDefaultSettings.ShowProgressNumbers = chkShowProgressNumbers.Checked;
        }

        private void chkSubtitleLanguageAlwaysSelectedEnabled_CheckedChanged(object sender, EventArgs e)
        {
            this.HandlesChkSubtitleLanguageAlwaysSelecedEnabledCheckedChanged();
        }

        private void HandlesChkSubtitleLanguageAlwaysSelecedEnabledCheckedChanged()
        {
            Program.ApplicationSettings.SubtitleLanguageAlwaysSelectedEnabled = chkSubtitleLanguageAlwaysSelectedEnabled.Checked;
            gbSubtitlesMKVMergeDefaultSettings.Enabled = Program.ApplicationSettings.SubtitleLanguageAlwaysSelectedEnabled;
        }

        private void cbSubtitlesMKVMergeDefaultSettingsLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.HandlesCBSubtitlesMKVMergeDefaultSettingsLanguageSelectedIndexChanged();
        }

        private void HandlesCBSubtitlesMKVMergeDefaultSettingsLanguageSelectedIndexChanged()
        {
            Program.ApplicationSettings.SubtitlesMKVMergeDefaultSettings.DefaultMKVMergeItem.Language = (MKVMergeLanguageItem)cbSubtitlesMKVMergeDefaultSettingsLanguage.SelectedItem;
        }

        private void cbSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.HandlesCBSubtitlesMKVMergeDefaultSettingsDefaultTrackFlagSelectedIndexChanged();
        }

        private void HandlesCBSubtitlesMKVMergeDefaultSettingsDefaultTrackFlagSelectedIndexChanged()
        {
            Program.ApplicationSettings.SubtitlesMKVMergeDefaultSettings.DefaultMKVMergeItem.DefaultTrackFlag = cbSubtitlesMKVMergeDefaultSettingsDefaultTrackFlag.Text;
        }

        private void cbAudioMKVMergeDefaultSettingsLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.HandlesCBAudioMKVMergeDefaultSettingsLanguageSelectedIndexChanged();
        }

        private void HandlesCBAudioMKVMergeDefaultSettingsLanguageSelectedIndexChanged()
        {
            Program.ApplicationSettings.AudioMKVMergeDefaultSettings.DefaultMKVMergeItem.Language = (MKVMergeLanguageItem) cbAudioMKVMergeDefaultSettingsLanguage.SelectedItem;
        }

        private void cbAudioMKVMergeDefaultSettingsDefaultTrackFlag_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.HandlesCBAudioMKVMergeDefaultSettingsDefaultTrackFlagSelectedIndexChanged();
        }

        private void HandlesCBAudioMKVMergeDefaultSettingsDefaultTrackFlagSelectedIndexChanged()
        {
            Program.ApplicationSettings.AudioMKVMergeDefaultSettings.DefaultMKVMergeItem.DefaultTrackFlag = cbAudioMKVMergeDefaultSettingsDefaultTrackFlag.Text;
        }

        private void cbAudioMKVMergeDefaultSettingsAudioType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.HandlesCBAudioMKVMergeDefaultSettingsAudioTypeSelectedIndexChanged();
        }

        private void HandlesCBAudioMKVMergeDefaultSettingsAudioTypeSelectedIndexChanged()
        {
            Program.ApplicationSettings.AudioMKVMergeDefaultSettings.AudioTypeFilterCriteria = cbAudioMKVMergeDefaultSettingsAudioType.Text;
        }

        private void chkAudioLanguageAlwaysSelectedEnabled_CheckedChanged(object sender, EventArgs e)
        {
            this.HandlesChkAudioLanguageAlwaysSelectedEnabledCheckedChanged();
        }

        private void HandlesChkAudioLanguageAlwaysSelectedEnabledCheckedChanged()
        {
            Program.ApplicationSettings.AudioLanguageAlwaysSelectedEnabled = chkAudioLanguageAlwaysSelectedEnabled.Checked;
            gbAudioMKVMergeDefaultSettings.Enabled = Program.ApplicationSettings.AudioLanguageAlwaysSelectedEnabled;
        }

        private void cbRemuxNamingConventionDefaults_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.HanldesCBRemuxNamingConventionDefaultsSelectedIndexChanged(cbRemuxNamingConventionDefaults.Text);
        }

        private void HanldesCBRemuxNamingConventionDefaultsSelectedIndexChanged(string value)
        {
            EnumEAC3ToNamingConventionType type;
            switch (value)
            {
                case "Template 1":
                    type = EnumEAC3ToNamingConventionType.RemuxNamingConventionTemplate1;
                    lblRemuxNamingConventionExample.Text = "TV Show S01E01 Episode Name 1080p Remux AVC FLAC5.1-Tag.mkv";
                    break;
                case "Template 2":
                    type = EnumEAC3ToNamingConventionType.RemuxNamingConventionTemplate2;
                    lblRemuxNamingConventionExample.Text = "TV Show, S01E01 (2016).mkv";
                    break;
                case "Template 3":
                    type = EnumEAC3ToNamingConventionType.RemuxNamingConventionTemplate3;
                    lblRemuxNamingConventionExample.Text = "2x01 Episode Name.mkv";
                    break;
                default:
                    throw new Exception("Invalid EnumEAC3ToNamingConventionType");
            }
            Program.ApplicationSettings.EnumEAC3ToNamingConventionType = type;
        }
    }
}

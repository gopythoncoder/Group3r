﻿using Group3r.Options.AssessmentOptions;
using LibSnaffle.ActiveDirectory;
using System.Collections.Generic;

namespace Group3r.Assessment.Analysers
{
    public class NtServiceAnalyser : Analyser
    {
        public NtServiceSetting setting { get; set; }

        public override SettingResult Analyse(AssessmentOptions assessmentOptions)
        {
            List<GpoFinding> findings = new List<GpoFinding>();

            /*
            findings.Add(new GpoFinding()
            {
                //GpoSetting = setting,
                FindingReason = "NtService analyser not implemented.",
                FindingDetail = "NtService analyser not implemented.",
                Triage = Constants.Triage.Green
            });
            // put findings in settingResult
            SettingResult.Findings = findings;

            // make a new setting object minus the ugly bits we don't care about.
            SettingResult.Setting = new NtServiceSetting();
            */
            SettingResult.Setting = setting;

            return SettingResult;
        }
    }
}
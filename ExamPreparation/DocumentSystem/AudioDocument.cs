﻿namespace DocumentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AudioDocument : MultimediaDocument
    {
        private static readonly string DefaultSampleRateString = "samplerate";

        public int? SampleRate { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == DefaultSampleRateString)
            {
                this.SampleRate = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>(DefaultSampleRateString, this.SampleRate));
        }
    }
}
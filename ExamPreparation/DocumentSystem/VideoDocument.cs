namespace DocumentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class VideoDocument : MultimediaDocument
    {
        private static readonly string DefaultFrameRateString = "framerate";

        public int? FrameRate { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == DefaultFrameRateString)
            {
                this.FrameRate = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>(DefaultFrameRateString, this.FrameRate));
        }
    }
}
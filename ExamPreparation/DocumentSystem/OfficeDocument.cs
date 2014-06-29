namespace DocumentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class OfficeDocument : EncryptableBinaryDocument
    {
        private static readonly string DefaultVersionString = "version";

        public string Version { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == DefaultVersionString)
            {
                this.Version = value;
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>(DefaultVersionString, this.Version));
        }
    }
}
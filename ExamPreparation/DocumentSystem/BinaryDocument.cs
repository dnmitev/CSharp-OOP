namespace DocumentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class BinaryDocument : Document
    {
        private static readonly string DefaultSizeString = "size";

        public long? Size { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == DefaultSizeString)
            {
                this.Size = long.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>(DefaultSizeString, this.Size));
        }
    }
}
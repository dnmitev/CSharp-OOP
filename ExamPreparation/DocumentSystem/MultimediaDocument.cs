namespace DocumentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class MultimediaDocument : BinaryDocument
    {
        private static readonly string DefaultLengthString = "length";

        public int? Length { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == DefaultLengthString)
            {
                this.Length = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>(DefaultLengthString, this.Length));
        }
    }
}
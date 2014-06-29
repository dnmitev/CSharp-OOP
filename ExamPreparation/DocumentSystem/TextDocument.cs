namespace DocumentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TextDocument : Document, IEditable
    {
        private static readonly string DefaultCharsetString = "charset";

        public string Charset { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == DefaultCharsetString)
            {
                this.Charset = value;
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>(DefaultCharsetString, this.Charset));
        }

        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }
    }
}
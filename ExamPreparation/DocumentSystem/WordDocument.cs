namespace DocumentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class WordDocument : OfficeDocument, IEditable
    {
        private static readonly string DefaultNumberOfCharsString = "chars";

        public int? CharactersNumber { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == DefaultNumberOfCharsString)
            {
                this.CharactersNumber = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>(DefaultNumberOfCharsString, this.CharactersNumber));
        }

        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }
    }
}
namespace DocumentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PDFDocument : EncryptableBinaryDocument
    {
        private static readonly string DefaultNumberOfPagesString = "pages";

        public int? NumberOfPages { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == DefaultNumberOfPagesString)
            {
                this.NumberOfPages = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>(DefaultNumberOfPagesString, this.NumberOfPages));
        }
    }
}
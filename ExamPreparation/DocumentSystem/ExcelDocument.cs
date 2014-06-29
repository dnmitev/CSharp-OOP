namespace DocumentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ExcelDocument : OfficeDocument
    {
        private static readonly string DefaultRowsString = "rows";
        private static readonly string DefaultColsString = "cols";

        public int? RowsNumber { get; set; }

        public int? ColsNumber { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == DefaultRowsString)
            {
                this.RowsNumber = int.Parse(value);
            }
            else if (key == DefaultColsString)
            {
                this.ColsNumber = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>(DefaultRowsString, this.RowsNumber));
            output.Add(new KeyValuePair<string, object>(DefaultColsString, this.ColsNumber));
        }
    }
}
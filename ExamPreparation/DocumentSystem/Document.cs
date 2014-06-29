namespace DocumentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Document : IDocument
    {
        private static readonly string DefaultNameString = "name";
        private static readonly string DefaultContentString = "content";

        public string Name { get; protected set; }

        public string Content { get; protected set; }

        public virtual void LoadProperty(string key, string value)
        {
            if (key == DefaultNameString)
            {
                this.Name = value;
            }
            else if (key == DefaultContentString)
            {
                this.Content = value;
            }
            else
            {
                throw new ArgumentException(string.Format("Key '{0}' not found", key));
            }
        }

        public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>(DefaultNameString, this.Name));
            output.Add(new KeyValuePair<string, object>(DefaultContentString, this.Content));
        }

        public override string ToString()
        {
            List<KeyValuePair<string, object>> properties = new List<KeyValuePair<string, object>>();

            this.SaveAllProperties(properties);

            properties.Sort((a, b) => a.Key.CompareTo(b.Key)); // sort keys alphabetically 

            StringBuilder result = new StringBuilder();

            result.Append(this.GetType().Name);
            result.Append("[");

            bool isFirst = true;

            foreach (var pr in properties)
            {
                if (pr.Value != null)
                {
                    if (!isFirst)
                    {
                        result.Append(";");
                    }

                    result.AppendFormat("{0}={1}", pr.Key, pr.Value);
                    isFirst = false;
                }
            }

            result.Append("]");

            return result.ToString();
        }
    }
}
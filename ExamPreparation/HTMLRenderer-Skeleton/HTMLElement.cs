namespace HTMLRenderer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class HTMLElement : IElement
    {
        private readonly IList<IElement> childElements;

        public HTMLElement(string htmlName)
        {
            this.Name = htmlName;
            this.childElements = new List<IElement>();
        }

        public HTMLElement(string name, string content) : this(name)
        {
            this.TextContent = content;
        }

        public virtual string Name { get; set; }

        public virtual string TextContent { get; set; }

        public virtual IEnumerable<IElement> ChildElements
        {
            get
            {
                return this.childElements;
            }
        }

        public virtual void AddElement(IElement element)
        {
            this.childElements.Add(element);
        }

        public virtual void Render(StringBuilder output)
        {
            if (this.Name != null)
            {
                output.Append("<");
                output.Append(this.Name);
                output.Append(">");
            }

            if (this.TextContent != null)
            {
                output.Append(this.HTMLEscaping(this.TextContent));
            }

            foreach (var child in this.childElements)
            {
                child.Render(output);
            }

            if (this.Name != null)
            {
                output.Append("</");
                output.Append(this.Name);
                output.Append(">");
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            this.Render(result);

            return result.ToString();
        }

        private string HTMLEscaping(string text)
        {
            StringBuilder result = new StringBuilder();

            foreach (var ch in text)
            {
                if (ch == '<')
                {
                    result.Append("&lt;");
                }
                else if (ch == '>')
                {
                    result.Append("&gt;");
                }
                else if (ch == '&')
                {
                    result.Append("&amp;");
                }
                else
                {
                    result.Append(ch);
                }
            }

            return result.ToString();
        }
    }
}
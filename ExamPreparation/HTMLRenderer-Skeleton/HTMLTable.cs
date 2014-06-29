namespace HTMLRenderer
{
    using System;
    using System.Linq;
    using System.Text;

    public class HTMLTable : HTMLElement, ITable
    {
        private static readonly string DefaultTableElementName = "table";

        private readonly IElement[,] tableElements;
        private int rows;
        private int cols;

        public HTMLTable(int rowsCount, int colsCount) : base(DefaultTableElementName)
        {
            this.Rows = rowsCount;
            this.Cols = colsCount;
            this.tableElements = new IElement[this.rows, this.cols];
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Rows cannot be negative.");
                }

                this.rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Cols cannot be negative.");
                }

                this.cols = value;
            }
        }

        public override string TextContent
        {
            get
            {
                return null;
            }
            set
            {
                throw new InvalidOperationException("Text content cannot be addet to tables.");
            }
        }

        public IElement this[int row, int col]
        {
            get
            {
                return this.tableElements[row, col];
            }

            set
            {
                this.tableElements[row, col] = value;
            }
        }

        public override void Render(StringBuilder output)
        {
            output.Append("<table>");

            for (int row = 0; row < this.Rows; row++)
            {
                output.Append("<tr>");

                for (int col = 0; col < this.Cols; col++)
                {
                    output.Append("<td>");
                    this.tableElements[row, col].Render(output);
                    output.Append("</td>");
                }

                output.Append("</tr>");
            }
            
            output.Append("</table>");
        }
    }
}
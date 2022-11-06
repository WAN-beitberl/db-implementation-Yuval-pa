using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalBar_OPP_1
{
    public class Table
    {
        private string x;
        private string y;
        private List<Row> rows;
        public Table()
        {
            rows = new List<Row>();
            this.x = "";
            this.y = "";
        }
        public void insertColumnNames(string x,string y)
        {
            this.x = x;
            this.y = y;
        }
        public void insertRow(string x, string y)
        {
            Row r = new Row(x, y);
            rows.Add(r);
        }
        public string GetValue(string columName, int index)
        {
            Row r = rows.ElementAt(index - 1);
            if (r == null)
                return "error";
            if (columName == this.x)
                return r.GetFirstColum();
            if(columName == this.y)
                return r.GetSecondColum();
            return "error";
        }
        protected class Row
        {
            private string firstColum;
            private string secondColum;
            public Row(string firstColum, string secondColum)
            {
                this.firstColum = firstColum;
                this.secondColum = secondColum;
            }
            public string GetFirstColum() { return firstColum; }
            public string GetSecondColum() { return secondColum; }
           
        }
    }
}

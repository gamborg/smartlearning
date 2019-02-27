using System;
using System.Text;

namespace opgave2_4
{
    class Table
    {
        private int _table;
        public Table(int i)
        {
            _table = i;
        }

        public string Print(int howMany)
        {
            var sb = new StringBuilder();
            for (var i = 1; i <= howMany; i++)
            {
                sb.Append((_table * i) + "\t");
            }

            return sb.ToString();
        }
    }
}
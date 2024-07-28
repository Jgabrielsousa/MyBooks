using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook.Data.Configuration.Base
{
    public class SqlType
    {


        public const int strLength = 80;
        private const string datetimeDefaultValue = "(getdate())";

        private SqlType(string columnType)
        {
            ColumnType = columnType;

            switch (ColumnType)
            {
                case "datetime":
                    ValueSql = datetimeDefaultValue;
                    break;
                case "nvarchar":
                    Length = strLength;
                    break;
                default:
                    ValueSql = string.Empty;
                    break;
            }

        }

        public string ColumnType { get; set; }
        public string ValueSql { get; set; }
        public int Length { get; set; }




        public static SqlType Uniqueidentifier { get { return new SqlType("uniqueidentifier"); } }
        public static SqlType Datetime { get { return new SqlType("datetime"); } }
        public static SqlType Bit { get { return new SqlType("bit"); } }
        public static SqlType Int { get { return new SqlType("int"); } }
        public static SqlType Nvarchar { get { return new SqlType("nvarchar"); } }

    }
}

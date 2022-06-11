using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1
{
  public  class TryVanDuLieu
    {
        SqlConnection con = new SqlConnection("Data Source=DELL;Initial Catalog= QL_Khach_San; User ID = sa; Password=sa2019");
            /* SqlConnection("Data Source=PC24;Initial Catalog
= QLSINHVIEN; User ID=sa; Password=sa2012");*/
        public static string maph;
        public static int madatphong;
        public static string _manvDangNhap;
        public DataTable  truyvan(string sql)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi"+ex);
            }
        }
        public DataTable getDataTable(DataTable tb, string maph)
        {
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                if (tb.Rows[i][3].Equals(maph))
                {
                    return (DataTable)tb.Rows[i][0];
                }
            }
            return null;
        }

        public DataTable ToDataTable<T>(IEnumerable<T> collection)
        {
            DataTable newDataTable = new DataTable();
            Type impliedType = typeof(T);
            PropertyInfo[] _propInfo = impliedType.GetProperties();
            foreach (PropertyInfo pi in _propInfo)
                newDataTable.Columns.Add(pi.Name, pi.PropertyType);

            foreach (T item in collection)
            {
                DataRow newDataRow = newDataTable.NewRow();
                newDataRow.BeginEdit();
                foreach (PropertyInfo pi in _propInfo)
                    newDataRow[pi.Name] = pi.GetValue(item, null);
                newDataRow.EndEdit();
                newDataTable.Rows.Add(newDataRow);
            }
            return newDataTable;
        }
        public List<T> ConvertToList<T>(DataTable dt)
        {
            var columnNames = dt.Columns.Cast<DataColumn>()
                    .Select(c => c.ColumnName)
                    .ToList();
            var properties = typeof(T).GetProperties();
            return dt.AsEnumerable().Select(row =>
            {
                var objT = Activator.CreateInstance<T>();
                foreach (var pro in properties)
                {
                    if (columnNames.Contains(pro.Name))
                    {
                        PropertyInfo pI = objT.GetType().GetProperty(pro.Name);
                        pro.SetValue(objT, row[pro.Name] == DBNull.Value ? null : Convert.ChangeType(row[pro.Name], pI.PropertyType));
                    }
                }
                return objT;
            }).ToList();
        }
    }
}

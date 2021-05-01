using System;
using System.Collections.Generic;
using System.Text;
using System.Data;//bu referans dataadapter ve datatable için eklendi
using System.Data.SqlClient;//sqlconnection için eklendi
using System.Windows.Forms;//listbox için eklendi

namespace HastaneRandevu //burada connection nesnemizi ve metotlarımızı tutuyoruz
{
    class kubi
    {
        SqlConnection bag = new SqlConnection("server=LAPTOP-R3CU39GJ\\SQLEXPRESS;initial catalog=HastaneRandevu; integrated security=true");
        public void lblistele(ListBox lb,string sql)//da.fill için datanın doldurulacağı yeri parantez içine yazdık
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            lb.DataSource = tbl;
            lb.ValueMember = tbl.Columns[0].ColumnName; //ya da direk kolon adı yani lb.valuemember="polno" da yazabiliriz. ve doktorno ve saat no
            lb.DisplayMember = tbl.Columns[1].ColumnName;//bu ise listbox da görüntülenecek kısım. yani poliklinikleri isimleri
        }
    }
}

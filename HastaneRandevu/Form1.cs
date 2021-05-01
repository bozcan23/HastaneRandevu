using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        kubi kb = new kubi();
        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "select * from poller order by pol"; //sorgumuzu adapter içine de yazabiliriz ya da string nesnesine atayıp adapter içinden string ile çağırabiliriz
            kb.lblistele(lbpoliklinik,sql);
        }

        private void lbpoliklinik_MouseClick(object sender, MouseEventArgs e)
        {
            string sql = "select * from doktorlar where polno=" + lbpoliklinik.SelectedValue.ToString();
            kb.lblistele(lbdoktor, sql);
        }

      
        private void dttarih_ValueChanged(object sender, EventArgs e)
        {
            string doktorno = lbdoktor.SelectedValue.ToString();
            string tarih = dttarih.Value.ToShortDateString();
            string sql = "select * from saatler where saatno not in(select saatno from randevular where doktorno='"+doktorno+"' and tarih='"+tarih+"')";
            kb.lblistele(lbsaat, sql);
        }
    }
}

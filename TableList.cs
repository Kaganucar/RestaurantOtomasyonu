using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOtomasyonu
{
    public partial class TableList : Form
    {
        public TableList()
        {
            InitializeComponent();
        }
        RestaurantDatabaseEntities db = new RestaurantDatabaseEntities();
        private void doldur()
        {
            int i = 0;
            LvListele.Items.Clear();
            foreach (var item in db.TBLTables.ToList())
            {
                LvListele.Items.Add(item.TableNo);
                if (db.TBLBasket.Any(x => x.TablesNo == item.TableNo))
                {
                    LvListele.Items[i].ImageKey = "MasaAcik.png";
                }
                else
                {
                    LvListele.Items[i].ImageKey = "MasaKapali.PNG";
                }
                i++;
            }
        }
        private void TableList_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void LvListele_DoubleClick(object sender, EventArgs e)
        {
            string Masa = LvListele.SelectedItems[0].Text.Split('.')[0];
            // Form Açıksa Uyarı Veriyor, Açık değilse Form Açılıyor.
            if (Application.OpenForms.OfType<Baskets>().Any())
            {
                MessageBox.Show("Başka Masa'nın Sipari Açıktır.");
            }
            else
            {
                Baskets Frm = new Baskets();
                // Form Açılırken Masa Numarasıda gönderiliyor.
                Frm.LBLMasaNo.Text = LvListele.SelectedItems[0].Text;
                Frm.Show();
            }
        }

        private void yENILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doldur();
        }
    }
}

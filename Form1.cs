using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
 
namespace Sorgulayici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        yeniBaglanti frmYeniBaglanti;
        SqlDataAdapter da;
        string sorgu;
        
        private void Form1_Load(object sender, EventArgs e)
        {
  
          
        }

   
        private void btnYeniBaglanti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmYeniBaglanti = new yeniBaglanti();
            frmYeniBaglanti.anaFrm = this;
            frmYeniBaglanti.ShowDialog();
        }

        private void lbTablolar_DoubleClick(object sender, EventArgs e)
        {
            this.columnsTableAdapter.Fill(ds.columns, lbTablolar.SelectedItem.ToString());
            lbStunlar.Items.Clear();

            foreach (DataRow dr in ds.columns)
            {
                lbStunlar.Items.Add(dr[0].ToString());
            }
        }

   
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
          
        }

        private void lbStunlar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string stunAdlari = "";
                foreach (string item in lbStunlar.CheckedItems)
                {
                    stunAdlari += item.ToString() + ",";
                }
                lbStunlar.Refresh();
                stunAdlari = stunAdlari.Substring(0, stunAdlari.Count() - 1);
                System.Windows.Forms.Clipboard.SetText(stunAdlari);
                txtSorgu.Paste();

            }
        }

        private void lbTablolar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string tabloAdi = "";
                tabloAdi = lbTablolar.SelectedItem.ToString();
                System.Windows.Forms.Clipboard.SetText(tabloAdi);
                txtSorgu.Paste();
            }
        }

        private void lbProsedure_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.all_sql_modulesTableAdapter.Fill(ds.all_sql_modules, lbProsedure.SelectedItem.ToString());
                txtSorgu.Text = ds.all_sql_modules[0][0].ToString();
            }
        }

        private void lbViews_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.viewGetirTableAdapter.Fill(ds.viewGetir, lbViews.SelectedItem.ToString());
                txtSorgu.Text = ds.viewGetir[0][0].ToString();
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            txtSorgu.Text = "";
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            if (txtSorgu.Text.Length > 1)
            {
                try
                {
                    sorgu = txtSorgu.Text;
                    da = new SqlDataAdapter(sorgu, Properties.Settings.Default.Cs.ToString());

                    ds.SorgudanDonenler.Columns.Clear();

                    ds.SorgudanDonenler.Clear();
                    da.Fill(ds.SorgudanDonenler);

                    gridControl1.DataSource = ds.SorgudanDonenler;
                    gridView1.Columns.Clear();
                    gridView1.PopulateColumns();
                    txtHata.Text = "";
                }
                catch (SqlException ex)
                {
                    txtHata.Text = ex.Message.ToString();
                }
            }
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            try
            {
                string stunAdlari = "";
                foreach (string item in lbStunlar.CheckedItems)
                {
                    stunAdlari += item.ToString() + ",";
                }
                stunAdlari = stunAdlari.Substring(0, stunAdlari.Count() - 1);

                string q = "SELECT " + stunAdlari + " FROM " + lbTablolar.SelectedItem.ToString();
                System.Windows.Forms.Clipboard.SetText(q);
                txtSorgu.Paste();
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message.ToString());
            }
        
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                raporKaydet.Title = "Cari Liste Kaydet!";
                raporKaydet.DefaultExt = "Cari Liste Kaydet";
                raporKaydet.Filter = "Excel Dosyaları (*.xls)|*.xls|(*.xlsx)|*.xlsx";

                DialogResult = raporKaydet.ShowDialog();
                if (DialogResult == DialogResult.OK || DialogResult == DialogResult.Yes)
                {
                    gridControl1.ExportToExcelOld(@raporKaydet.FileName);
                    MessageBox.Show("Excel e Aktarım Tamamlandı.");
                }
            }
        }

    }
}

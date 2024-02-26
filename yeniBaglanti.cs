using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SQLDMO;
using System.Collections;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Sorgulayici
{
    public partial class yeniBaglanti : Form
    {
        public yeniBaglanti()
        {
            InitializeComponent();
        }
        public Form1 anaFrm { get; set;}

        SQLDMO.Application sqlApplication = new SQLDMO.Application();
        public SqlConnection con=new SqlConnection();

        private void dbListesi()
        {
            lbDb.Properties.Items.Clear();
            SQLDMO.NameList sqlServers = sqlApplication.ListAvailableSQLServers();
            for (int i = 0; i < sqlServers.Count; i++)
            {
                object srv = sqlServers.Item(i + 1);
                if (srv != null)
                {
                   lbDb.Properties.Items.Add(srv.ToString());
                }
            }
        }
        //Data Source=ERKANPC\ERKAN;Initial Catalog=MikroDB_V14__01;User ID=sa;Password=1
        //Data Source=ERKANPC\ERKAN;Initial Catalog=MikroDB_V14__01;Integrated Security=True
        private void yeniBaglanti_Load(object sender, EventArgs e)
        {
            txtKullaniciAdi.Enabled = false;
            txtSifre.Enabled = false;
            dbListesi();
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            sqlConnection1.Close();
            if (cb.Checked)
                sqlConnection1.ConnectionString = "Data Source=" + lbDb.Text + ";Initial Catalog="+ txtSirket.Text  +";User ID="+txtKullaniciAdi.Text+";Password="+txtSifre.Text+"";
            else
                sqlConnection1.ConnectionString = "Data Source=" + lbDb.Text + ";Initial Catalog=" + txtSirket.Text + ";Integrated Security=True";

            Properties.Settings.Default["Cs"] = sqlConnection1.ConnectionString.ToString();

            try
            {
                sqlConnection1.Open();
                anaFrm.lblVeriTabani.Text = txtSirket.Text;
                anaFrm.lblServer.Text = lbDb.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            ds.Clear();
            this.tablesTableAdapter.Fill(this.ds.tables);
            this.proceduresTableAdapter.Fill(this.ds.procedures);
            this.viewsTableAdapter.Fill(this.ds.views);

            anaFrm.lbTablolar.Items.Clear();
            anaFrm.lbProsedure.Items.Clear();
            anaFrm.lbStunlar.Items.Clear();

            foreach (DataRow dr in ds.tables.Rows)
            {
                anaFrm.lbTablolar.Items.Add(dr[0].ToString());
            }

            foreach (DataRow dr in ds.procedures)
            {
                anaFrm.lbProsedure.Items.Add(dr[0].ToString());
            }

            this.columnsTableAdapter.Fill(ds.columns, anaFrm.lbTablolar.SelectedItem.ToString());

            anaFrm.lbStunlar.Items.Clear();
            foreach (DataRow dr in ds.columns)
            {
            anaFrm.lbStunlar.Items.Add(dr[0].ToString());
            }

            anaFrm.lbViews.Items.Clear();
            foreach (DataRow dr in ds.views)
            {
                anaFrm.lbViews.Items.Add(dr[0].ToString());
            }
            
            con.ConnectionString = Properties.Settings.Default.Cs;
        
            anaFrm.columnsTableAdapter.Connection = con;
            anaFrm.all_sql_modulesTableAdapter.Connection = con;

            this.Close();
        }

        private void cb_CheckedChanged(object sender, EventArgs e)
        {
            if (!cb.Checked)
            {
                txtKullaniciAdi.Enabled = false;
                txtSifre.Enabled = false;
            }
            else
            {
                txtKullaniciAdi.Enabled = true;
                txtSifre.Enabled = true;
            }
         
        }

        private void gridLookUpEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            sqlConnection1.Close();
            if (cb.Checked)
                sqlConnection1.ConnectionString = "Data Source=" + lbDb.Text + ";Initial Catalog=Master"+";User ID=" + txtKullaniciAdi.Text + ";Password=" + txtSifre.Text + "";
            else
                sqlConnection1.ConnectionString = "Data Source=" + lbDb.Text + ";Initial Catalog=Master;Integrated Security=True";

            Properties.Settings.Default["Cs"] = sqlConnection1.ConnectionString.ToString();

            try
            {
                sqlConnection1.Open();
                this.databasesTableAdapter.Fill(this.ds.databases);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

    }
}

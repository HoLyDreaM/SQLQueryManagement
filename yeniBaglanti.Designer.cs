namespace Sorgulayici
{
    partial class yeniBaglanti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnBaglan = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.lbDb = new DevExpress.XtraEditors.ComboBoxEdit();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.cb = new System.Windows.Forms.CheckBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSirket = new DevExpress.XtraEditors.GridLookUpEdit();
            this.databasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new Sorgulayici.Ds();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablesTableAdapter = new Sorgulayici.DsTableAdapters.tablesTableAdapter();
            this.tableAdapterManager = new Sorgulayici.DsTableAdapters.TableAdapterManager();
            this.proceduresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proceduresTableAdapter = new Sorgulayici.DsTableAdapters.proceduresTableAdapter();
            this.databasesTableAdapter = new Sorgulayici.DsTableAdapters.databasesTableAdapter();
            this.columnsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.columnsTableAdapter = new Sorgulayici.DsTableAdapters.columnsTableAdapter();
            this.viewsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewsTableAdapter = new Sorgulayici.DsTableAdapters.viewsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbDb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSirket.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proceduresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSifre
            // 
            this.txtSifre.EditValue = "";
            this.txtSifre.Location = new System.Drawing.Point(97, 68);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.PasswordChar = '#';
            this.txtSifre.Size = new System.Drawing.Size(142, 20);
            this.txtSifre.TabIndex = 25;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl4.Location = new System.Drawing.Point(15, 68);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(82, 20);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "Şifre";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl3.Location = new System.Drawing.Point(15, 44);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 20);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "Kullanıcı";
            // 
            // btnBaglan
            // 
            this.btnBaglan.Location = new System.Drawing.Point(98, 118);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(141, 23);
            this.btnBaglan.TabIndex = 22;
            this.btnBaglan.Text = "Bağlan";
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl1.Location = new System.Drawing.Point(15, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 20);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Server Adı";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.EditValue = "";
            this.txtKullaniciAdi.Location = new System.Drawing.Point(97, 44);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(120, 20);
            this.txtKullaniciAdi.TabIndex = 28;
            // 
            // lbDb
            // 
            this.lbDb.Location = new System.Drawing.Point(97, 20);
            this.lbDb.Name = "lbDb";
            this.lbDb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lbDb.Size = new System.Drawing.Size(142, 20);
            this.lbDb.TabIndex = 32;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=ERKANPC\\ERKAN;Initial Catalog=MikroDB_V14__01;User ID=sa;Password=1";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // cb
            // 
            this.cb.AutoSize = true;
            this.cb.Location = new System.Drawing.Point(222, 47);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(15, 14);
            this.cb.TabIndex = 33;
            this.cb.UseVisualStyleBackColor = true;
            this.cb.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl2.Location = new System.Drawing.Point(15, 92);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 20);
            this.labelControl2.TabIndex = 34;
            this.labelControl2.Text = "Veri Tabanı";
            // 
            // txtSirket
            // 
            this.txtSirket.EditValue = "";
            this.txtSirket.Location = new System.Drawing.Point(97, 92);
            this.txtSirket.Name = "txtSirket";
            this.txtSirket.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSirket.Properties.DataSource = this.databasesBindingSource;
            this.txtSirket.Properties.DisplayMember = "NAME";
            this.txtSirket.Properties.ValueMember = "NAME";
            this.txtSirket.Properties.View = this.gridLookUpEdit1View;
            this.txtSirket.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.gridLookUpEdit1_Properties_ButtonClick);
            this.txtSirket.Size = new System.Drawing.Size(142, 20);
            this.txtSirket.TabIndex = 36;
            // 
            // databasesBindingSource
            // 
            this.databasesBindingSource.DataMember = "databases";
            this.databasesBindingSource.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "Ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // tablesBindingSource
            // 
            this.tablesBindingSource.DataMember = "tables";
            this.tablesBindingSource.DataSource = this.ds;
            // 
            // tablesTableAdapter
            // 
            this.tablesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Sorgulayici.DsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // proceduresBindingSource
            // 
            this.proceduresBindingSource.DataMember = "procedures";
            this.proceduresBindingSource.DataSource = this.ds;
            // 
            // proceduresTableAdapter
            // 
            this.proceduresTableAdapter.ClearBeforeFill = true;
            // 
            // databasesTableAdapter
            // 
            this.databasesTableAdapter.ClearBeforeFill = true;
            // 
            // columnsBindingSource
            // 
            this.columnsBindingSource.DataMember = "columns";
            this.columnsBindingSource.DataSource = this.ds;
            // 
            // columnsTableAdapter
            // 
            this.columnsTableAdapter.ClearBeforeFill = true;
            // 
            // viewsBindingSource
            // 
            this.viewsBindingSource.DataMember = "views";
            this.viewsBindingSource.DataSource = this.ds;
            // 
            // viewsTableAdapter
            // 
            this.viewsTableAdapter.ClearBeforeFill = true;
            // 
            // yeniBaglanti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 223);
            this.Controls.Add(this.txtSirket);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.lbDb);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnBaglan);
            this.Controls.Add(this.labelControl1);
            this.Name = "yeniBaglanti";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Bağlantı";
            this.Load += new System.EventHandler(this.yeniBaglanti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbDb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSirket.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proceduresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnBaglan;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.ComboBoxEdit lbDb;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.CheckBox cb;
        private Ds ds;
        private System.Windows.Forms.BindingSource tablesBindingSource;
        private DsTableAdapters.tablesTableAdapter tablesTableAdapter;
        private DsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource proceduresBindingSource;
        private DsTableAdapters.proceduresTableAdapter proceduresTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource databasesBindingSource;
        private DsTableAdapters.databasesTableAdapter databasesTableAdapter;
        private System.Windows.Forms.BindingSource columnsBindingSource;
        private DsTableAdapters.columnsTableAdapter columnsTableAdapter;
        private System.Windows.Forms.BindingSource viewsBindingSource;
        private DsTableAdapters.viewsTableAdapter viewsTableAdapter;
        public DevExpress.XtraEditors.GridLookUpEdit txtSirket;

    }
}
namespace LimitControl_alfa
{
    partial class LimitsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LimitsForm));
            this.tbcMain = new DevExpress.XtraTab.XtraTabControl();
            this.pControlBankLimit = new DevExpress.XtraTab.XtraTabPage();
            this.pControlGroupLimit = new DevExpress.XtraTab.XtraTabPage();
            this.pLimitList = new DevExpress.XtraTab.XtraTabPage();
            this.tbListLimit = new DevExpress.XtraTab.XtraTabControl();
            this.pBankLimitList = new DevExpress.XtraTab.XtraTabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddBank = new DevExpress.XtraEditors.SimpleButton();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pGroupsLimitList = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.tbcMain)).BeginInit();
            this.tbcMain.SuspendLayout();
            this.pLimitList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbListLimit)).BeginInit();
            this.tbListLimit.SuspendLayout();
            this.pBankLimitList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcMain
            // 
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.Location = new System.Drawing.Point(0, 0);
            this.tbcMain.MultiLine = DevExpress.Utils.DefaultBoolean.False;
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedTabPage = this.pControlBankLimit;
            this.tbcMain.Size = new System.Drawing.Size(1422, 853);
            this.tbcMain.TabIndex = 0;
            this.tbcMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pControlBankLimit,
            this.pControlGroupLimit,
            this.pLimitList});
            // 
            // pControlBankLimit
            // 
            this.pControlBankLimit.Name = "pControlBankLimit";
            this.pControlBankLimit.Size = new System.Drawing.Size(1415, 819);
            this.pControlBankLimit.Text = "Контроль лимитов на банки";
            // 
            // pControlGroupLimit
            // 
            this.pControlGroupLimit.Name = "pControlGroupLimit";
            this.pControlGroupLimit.Size = new System.Drawing.Size(1415, 819);
            this.pControlGroupLimit.Text = "Контроль лимитов на группы";
            // 
            // pLimitList
            // 
            this.pLimitList.AllowTouchScroll = true;
            this.pLimitList.AutoScroll = true;
            this.pLimitList.Controls.Add(this.tbListLimit);
            this.pLimitList.Name = "pLimitList";
            this.pLimitList.Size = new System.Drawing.Size(1415, 819);
            this.pLimitList.Text = "Лимитная ведомость";
            // 
            // tbListLimit
            // 
            this.tbListLimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbListLimit.Location = new System.Drawing.Point(0, 0);
            this.tbListLimit.Name = "tbListLimit";
            this.tbListLimit.SelectedTabPage = this.pBankLimitList;
            this.tbListLimit.Size = new System.Drawing.Size(1415, 819);
            this.tbListLimit.TabIndex = 0;
            this.tbListLimit.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pBankLimitList,
            this.pGroupsLimitList});
            // 
            // pBankLimitList
            // 
            this.pBankLimitList.AllowTouchScroll = true;
            this.pBankLimitList.AutoScroll = true;
            this.pBankLimitList.Controls.Add(this.textBox1);
            this.pBankLimitList.Controls.Add(this.dateTimePicker1);
            this.pBankLimitList.Controls.Add(this.dateEdit1);
            this.pBankLimitList.Controls.Add(this.simpleButton2);
            this.pBankLimitList.Controls.Add(this.btnAddBank);
            this.pBankLimitList.Controls.Add(this.button1);
            this.pBankLimitList.Controls.Add(this.dataGridView1);
            this.pBankLimitList.Name = "pBankLimitList";
            this.pBankLimitList.Size = new System.Drawing.Size(1408, 785);
            this.pBankLimitList.Text = "Лимиты на Банки";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 23);
            this.textBox1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(258, 23);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(298, 115);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.dateEdit1.Size = new System.Drawing.Size(100, 22);
            this.dateEdit1.TabIndex = 8;
            this.dateEdit1.EditValueChanged += new System.EventHandler(this.dateEdit1_EditValueChanged);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(734, 100);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "simpleButton2";
            // 
            // btnAddBank
            // 
            this.btnAddBank.Location = new System.Drawing.Point(895, 27);
            this.btnAddBank.Name = "btnAddBank";
            this.btnAddBank.Size = new System.Drawing.Size(110, 34);
            this.btnAddBank.TabIndex = 6;
            this.btnAddBank.Text = "Add new Bank";
            this.btnAddBank.Click += new System.EventHandler(this.btnAddBank_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(131, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // pGroupsLimitList
            // 
            this.pGroupsLimitList.Name = "pGroupsLimitList";
            this.pGroupsLimitList.Size = new System.Drawing.Size(1408, 785);
            this.pGroupsLimitList.Text = "Лимиты на банковские группы";
            // 
            // LimitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1422, 853);
            this.Controls.Add(this.tbcMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(150, 160);
            this.Name = "LimitsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Limits";
            this.Load += new System.EventHandler(this.LimitsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbcMain)).EndInit();
            this.tbcMain.ResumeLayout(false);
            this.pLimitList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbListLimit)).EndInit();
            this.tbListLimit.ResumeLayout(false);
            this.pBankLimitList.ResumeLayout(false);
            this.pBankLimitList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tbcMain;
        private DevExpress.XtraTab.XtraTabPage pControlBankLimit;
        private DevExpress.XtraTab.XtraTabPage pControlGroupLimit;
        private DevExpress.XtraTab.XtraTabPage pLimitList;
        private DevExpress.XtraTab.XtraTabControl tbListLimit;
        private DevExpress.XtraTab.XtraTabPage pBankLimitList;
        private DevExpress.XtraTab.XtraTabPage pGroupsLimitList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnAddBank;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}


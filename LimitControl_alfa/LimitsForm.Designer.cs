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
            this.pGroupsLimitList = new DevExpress.XtraTab.XtraTabPage();
            this.pBankLimitList = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.tbcMain)).BeginInit();
            this.tbcMain.SuspendLayout();
            this.pLimitList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbListLimit)).BeginInit();
            this.tbListLimit.SuspendLayout();
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
            this.tbListLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbListLimit.Location = new System.Drawing.Point(3, 3);
            this.tbListLimit.Name = "tbListLimit";
            this.tbListLimit.SelectedTabPage = this.pBankLimitList;
            this.tbListLimit.Size = new System.Drawing.Size(932, 706);
            this.tbListLimit.TabIndex = 0;
            this.tbListLimit.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pBankLimitList,
            this.pGroupsLimitList});
            // 
            // pGroupsLimitList
            // 
            this.pGroupsLimitList.Name = "pGroupsLimitList";
            this.pGroupsLimitList.Size = new System.Drawing.Size(925, 672);
            this.pGroupsLimitList.Text = "Лимиты на банковские группы";
            // 
            // pBankLimitList
            // 
            this.pBankLimitList.AllowTouchScroll = true;
            this.pBankLimitList.AutoScroll = true;
            this.pBankLimitList.Name = "pBankLimitList";
            this.pBankLimitList.Size = new System.Drawing.Size(925, 672);
            this.pBankLimitList.Text = "Лимиты на Банки";
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
            ((System.ComponentModel.ISupportInitialize)(this.tbcMain)).EndInit();
            this.tbcMain.ResumeLayout(false);
            this.pLimitList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbListLimit)).EndInit();
            this.tbListLimit.ResumeLayout(false);
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
    }
}


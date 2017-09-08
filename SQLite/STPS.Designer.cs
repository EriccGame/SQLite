namespace SQLite
{
    partial class STPS
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
            this.gridSTPS = new System.Windows.Forms.DataGridView();
            this.tabSTPS = new MetroFramework.Controls.MetroTabControl();
            this.tab5 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSTPS)).BeginInit();
            this.tabSTPS.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridSTPS
            // 
            this.gridSTPS.AllowUserToAddRows = false;
            this.gridSTPS.AllowUserToDeleteRows = false;
            this.gridSTPS.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridSTPS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridSTPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSTPS.Location = new System.Drawing.Point(12, 12);
            this.gridSTPS.Name = "gridSTPS";
            this.gridSTPS.ReadOnly = true;
            this.gridSTPS.RowHeadersVisible = false;
            this.gridSTPS.Size = new System.Drawing.Size(543, 150);
            this.gridSTPS.TabIndex = 0;
            // 
            // tabSTPS
            // 
            this.tabSTPS.Controls.Add(this.tab5);
            this.tabSTPS.Controls.Add(this.metroTabPage2);
            this.tabSTPS.Location = new System.Drawing.Point(12, 168);
            this.tabSTPS.Name = "tabSTPS";
            this.tabSTPS.SelectedIndex = 0;
            this.tabSTPS.Size = new System.Drawing.Size(543, 194);
            this.tabSTPS.TabIndex = 1;
            this.tabSTPS.UseSelectable = true;
            // 
            // tab5
            // 
            this.tab5.AutoScroll = true;
            this.tab5.HorizontalScrollbar = true;
            this.tab5.HorizontalScrollbarBarColor = true;
            this.tab5.HorizontalScrollbarHighlightOnWheel = false;
            this.tab5.HorizontalScrollbarSize = 10;
            this.tab5.Location = new System.Drawing.Point(4, 38);
            this.tab5.Name = "tab5";
            this.tab5.Size = new System.Drawing.Size(535, 152);
            this.tab5.TabIndex = 0;
            this.tab5.Text = "5";
            this.tab5.VerticalScrollbar = true;
            this.tab5.VerticalScrollbarBarColor = true;
            this.tab5.VerticalScrollbarHighlightOnWheel = false;
            this.tab5.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(535, 152);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = ":)";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(476, 368);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK!";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // STPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 405);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tabSTPS);
            this.Controls.Add(this.gridSTPS);
            this.Name = "STPS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STPS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.STPS_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gridSTPS)).EndInit();
            this.tabSTPS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSTPS;
        private MetroFramework.Controls.MetroTabControl tabSTPS;
        private MetroFramework.Controls.MetroTabPage tab5;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Button btnOK;
    }
}
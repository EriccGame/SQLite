using MetroFramework.Controls;

namespace SQLite
{
    partial class FrmSQLite
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
            this.btnConectar = new MetroFramework.Controls.MetroButton();
            this.btnCrearBD = new MetroFramework.Controls.MetroButton();
            this.tbRFCEmpresa = new MetroFramework.Controls.MetroTextBox();
            this.tbNombreEmpresa = new MetroFramework.Controls.MetroTextBox();
            this.tbNombreRepresentante = new MetroFramework.Controls.MetroTextBox();
            this.tbPuestoRepresentante = new MetroFramework.Controls.MetroTextBox();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.cmbEmpresa = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(23, 111);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(194, 42);
            this.btnConectar.TabIndex = 1;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseSelectable = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnCrearBD
            // 
            this.btnCrearBD.Location = new System.Drawing.Point(23, 63);
            this.btnCrearBD.Name = "btnCrearBD";
            this.btnCrearBD.Size = new System.Drawing.Size(194, 42);
            this.btnCrearBD.TabIndex = 0;
            this.btnCrearBD.Text = "Crear BD";
            this.btnCrearBD.UseSelectable = true;
            this.btnCrearBD.Click += new System.EventHandler(this.btnCrearBD_Click);
            // 
            // tbRFCEmpresa
            // 
            // 
            // 
            // 
            this.tbRFCEmpresa.CustomButton.Image = null;
            this.tbRFCEmpresa.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.tbRFCEmpresa.CustomButton.Name = "";
            this.tbRFCEmpresa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbRFCEmpresa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbRFCEmpresa.CustomButton.TabIndex = 1;
            this.tbRFCEmpresa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbRFCEmpresa.CustomButton.UseSelectable = true;
            this.tbRFCEmpresa.CustomButton.Visible = false;
            this.tbRFCEmpresa.Lines = new string[0];
            this.tbRFCEmpresa.Location = new System.Drawing.Point(23, 159);
            this.tbRFCEmpresa.MaxLength = 3;
            this.tbRFCEmpresa.Name = "tbRFCEmpresa";
            this.tbRFCEmpresa.PasswordChar = '\0';
            this.tbRFCEmpresa.PromptText = "R.F.C. Empresa";
            this.tbRFCEmpresa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbRFCEmpresa.SelectedText = "";
            this.tbRFCEmpresa.SelectionLength = 0;
            this.tbRFCEmpresa.SelectionStart = 0;
            this.tbRFCEmpresa.ShortcutsEnabled = true;
            this.tbRFCEmpresa.Size = new System.Drawing.Size(194, 23);
            this.tbRFCEmpresa.TabIndex = 2;
            this.tbRFCEmpresa.UseSelectable = true;
            this.tbRFCEmpresa.WaterMark = "R.F.C. Empresa";
            this.tbRFCEmpresa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbRFCEmpresa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbRFCEmpresa.Leave += new System.EventHandler(this.tbRFCEmpresa_Leave);
            // 
            // tbNombreEmpresa
            // 
            // 
            // 
            // 
            this.tbNombreEmpresa.CustomButton.Image = null;
            this.tbNombreEmpresa.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.tbNombreEmpresa.CustomButton.Name = "";
            this.tbNombreEmpresa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbNombreEmpresa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNombreEmpresa.CustomButton.TabIndex = 1;
            this.tbNombreEmpresa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNombreEmpresa.CustomButton.UseSelectable = true;
            this.tbNombreEmpresa.CustomButton.Visible = false;
            this.tbNombreEmpresa.Lines = new string[0];
            this.tbNombreEmpresa.Location = new System.Drawing.Point(23, 188);
            this.tbNombreEmpresa.MaxLength = 32767;
            this.tbNombreEmpresa.Name = "tbNombreEmpresa";
            this.tbNombreEmpresa.PasswordChar = '\0';
            this.tbNombreEmpresa.PromptText = "Nombre de la empresa";
            this.tbNombreEmpresa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNombreEmpresa.SelectedText = "";
            this.tbNombreEmpresa.SelectionLength = 0;
            this.tbNombreEmpresa.SelectionStart = 0;
            this.tbNombreEmpresa.ShortcutsEnabled = true;
            this.tbNombreEmpresa.Size = new System.Drawing.Size(194, 23);
            this.tbNombreEmpresa.TabIndex = 3;
            this.tbNombreEmpresa.UseSelectable = true;
            this.tbNombreEmpresa.WaterMark = "Nombre de la empresa";
            this.tbNombreEmpresa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNombreEmpresa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbNombreRepresentante
            // 
            // 
            // 
            // 
            this.tbNombreRepresentante.CustomButton.Image = null;
            this.tbNombreRepresentante.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.tbNombreRepresentante.CustomButton.Name = "";
            this.tbNombreRepresentante.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbNombreRepresentante.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNombreRepresentante.CustomButton.TabIndex = 1;
            this.tbNombreRepresentante.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNombreRepresentante.CustomButton.UseSelectable = true;
            this.tbNombreRepresentante.CustomButton.Visible = false;
            this.tbNombreRepresentante.Lines = new string[0];
            this.tbNombreRepresentante.Location = new System.Drawing.Point(23, 217);
            this.tbNombreRepresentante.MaxLength = 32767;
            this.tbNombreRepresentante.Name = "tbNombreRepresentante";
            this.tbNombreRepresentante.PasswordChar = '\0';
            this.tbNombreRepresentante.PromptText = "Nombre del representante";
            this.tbNombreRepresentante.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNombreRepresentante.SelectedText = "";
            this.tbNombreRepresentante.SelectionLength = 0;
            this.tbNombreRepresentante.SelectionStart = 0;
            this.tbNombreRepresentante.ShortcutsEnabled = true;
            this.tbNombreRepresentante.Size = new System.Drawing.Size(194, 23);
            this.tbNombreRepresentante.TabIndex = 4;
            this.tbNombreRepresentante.UseSelectable = true;
            this.tbNombreRepresentante.WaterMark = "Nombre del representante";
            this.tbNombreRepresentante.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNombreRepresentante.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbPuestoRepresentante
            // 
            // 
            // 
            // 
            this.tbPuestoRepresentante.CustomButton.Image = null;
            this.tbPuestoRepresentante.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.tbPuestoRepresentante.CustomButton.Name = "";
            this.tbPuestoRepresentante.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPuestoRepresentante.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPuestoRepresentante.CustomButton.TabIndex = 1;
            this.tbPuestoRepresentante.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPuestoRepresentante.CustomButton.UseSelectable = true;
            this.tbPuestoRepresentante.CustomButton.Visible = false;
            this.tbPuestoRepresentante.Lines = new string[0];
            this.tbPuestoRepresentante.Location = new System.Drawing.Point(23, 246);
            this.tbPuestoRepresentante.MaxLength = 32767;
            this.tbPuestoRepresentante.Name = "tbPuestoRepresentante";
            this.tbPuestoRepresentante.PasswordChar = '\0';
            this.tbPuestoRepresentante.PromptText = "Puesto del representante";
            this.tbPuestoRepresentante.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPuestoRepresentante.SelectedText = "";
            this.tbPuestoRepresentante.SelectionLength = 0;
            this.tbPuestoRepresentante.SelectionStart = 0;
            this.tbPuestoRepresentante.ShortcutsEnabled = true;
            this.tbPuestoRepresentante.Size = new System.Drawing.Size(194, 23);
            this.tbPuestoRepresentante.TabIndex = 5;
            this.tbPuestoRepresentante.UseSelectable = true;
            this.tbPuestoRepresentante.WaterMark = "Puesto del representante";
            this.tbPuestoRepresentante.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPuestoRepresentante.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(23, 275);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(194, 42);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.ItemHeight = 23;
            this.cmbEmpresa.Location = new System.Drawing.Point(23, 323);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(194, 29);
            this.cmbEmpresa.Style = MetroFramework.MetroColorStyle.Red;
            this.cmbEmpresa.TabIndex = 7;
            this.cmbEmpresa.UseSelectable = true;
            // 
            // FrmSQLite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 385);
            this.Controls.Add(this.cmbEmpresa);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tbPuestoRepresentante);
            this.Controls.Add(this.tbNombreRepresentante);
            this.Controls.Add(this.tbNombreEmpresa);
            this.Controls.Add(this.tbRFCEmpresa);
            this.Controls.Add(this.btnCrearBD);
            this.Controls.Add(this.btnConectar);
            this.Name = "FrmSQLite";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "SQLite";
            this.Load += new System.EventHandler(this.FrmSQLite_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroButton btnConectar;
        private MetroButton btnCrearBD;
        private MetroTextBox tbRFCEmpresa;
        private MetroTextBox tbNombreEmpresa;
        private MetroTextBox tbNombreRepresentante;
        private MetroTextBox tbPuestoRepresentante;
        private MetroButton btnGuardar;
        private MetroComboBox cmbEmpresa;
    }
}
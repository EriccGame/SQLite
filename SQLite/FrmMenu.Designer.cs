namespace SQLite
{
    partial class FrmMenu
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
            this.panelRegistro = new MetroFramework.Controls.MetroPanel();
            this.tbDescripcionProceso = new MetroFramework.Controls.MetroTextBox();
            this.tbDireccion = new MetroFramework.Controls.MetroTextBox();
            this.tbGiro = new MetroFramework.Controls.MetroTextBox();
            this.tbNombre = new MetroFramework.Controls.MetroTextBox();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.cmbEmpresas = new MetroFramework.Controls.MetroComboBox();
            this.btnEntrar = new MetroFramework.Controls.MetroButton();
            this.btnRegistrar = new MetroFramework.Controls.MetroButton();
            this.panelRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRegistro
            // 
            this.panelRegistro.Controls.Add(this.tbDescripcionProceso);
            this.panelRegistro.Controls.Add(this.tbDireccion);
            this.panelRegistro.Controls.Add(this.tbGiro);
            this.panelRegistro.Controls.Add(this.tbNombre);
            this.panelRegistro.Controls.Add(this.btnGuardar);
            this.panelRegistro.HorizontalScrollbarBarColor = true;
            this.panelRegistro.HorizontalScrollbarHighlightOnWheel = false;
            this.panelRegistro.HorizontalScrollbarSize = 10;
            this.panelRegistro.Location = new System.Drawing.Point(23, 168);
            this.panelRegistro.Name = "panelRegistro";
            this.panelRegistro.Size = new System.Drawing.Size(188, 177);
            this.panelRegistro.Style = MetroFramework.MetroColorStyle.Red;
            this.panelRegistro.TabIndex = 0;
            this.panelRegistro.VerticalScrollbarBarColor = true;
            this.panelRegistro.VerticalScrollbarHighlightOnWheel = false;
            this.panelRegistro.VerticalScrollbarSize = 10;
            // 
            // tbDescripcionProceso
            // 
            // 
            // 
            // 
            this.tbDescripcionProceso.CustomButton.Image = null;
            this.tbDescripcionProceso.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.tbDescripcionProceso.CustomButton.Name = "";
            this.tbDescripcionProceso.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbDescripcionProceso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDescripcionProceso.CustomButton.TabIndex = 1;
            this.tbDescripcionProceso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDescripcionProceso.CustomButton.UseSelectable = true;
            this.tbDescripcionProceso.CustomButton.Visible = false;
            this.tbDescripcionProceso.Lines = new string[0];
            this.tbDescripcionProceso.Location = new System.Drawing.Point(3, 108);
            this.tbDescripcionProceso.MaxLength = 32767;
            this.tbDescripcionProceso.Name = "tbDescripcionProceso";
            this.tbDescripcionProceso.PasswordChar = '\0';
            this.tbDescripcionProceso.PromptText = "Descripción del proceso";
            this.tbDescripcionProceso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDescripcionProceso.SelectedText = "";
            this.tbDescripcionProceso.SelectionLength = 0;
            this.tbDescripcionProceso.SelectionStart = 0;
            this.tbDescripcionProceso.ShortcutsEnabled = true;
            this.tbDescripcionProceso.Size = new System.Drawing.Size(182, 29);
            this.tbDescripcionProceso.Style = MetroFramework.MetroColorStyle.Red;
            this.tbDescripcionProceso.TabIndex = 7;
            this.tbDescripcionProceso.UseSelectable = true;
            this.tbDescripcionProceso.WaterMark = "Descripción del proceso";
            this.tbDescripcionProceso.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDescripcionProceso.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbDireccion
            // 
            // 
            // 
            // 
            this.tbDireccion.CustomButton.Image = null;
            this.tbDireccion.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.tbDireccion.CustomButton.Name = "";
            this.tbDireccion.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbDireccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDireccion.CustomButton.TabIndex = 1;
            this.tbDireccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDireccion.CustomButton.UseSelectable = true;
            this.tbDireccion.CustomButton.Visible = false;
            this.tbDireccion.Lines = new string[0];
            this.tbDireccion.Location = new System.Drawing.Point(3, 73);
            this.tbDireccion.MaxLength = 32767;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.PasswordChar = '\0';
            this.tbDireccion.PromptText = "Dirección";
            this.tbDireccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDireccion.SelectedText = "";
            this.tbDireccion.SelectionLength = 0;
            this.tbDireccion.SelectionStart = 0;
            this.tbDireccion.ShortcutsEnabled = true;
            this.tbDireccion.Size = new System.Drawing.Size(182, 29);
            this.tbDireccion.Style = MetroFramework.MetroColorStyle.Red;
            this.tbDireccion.TabIndex = 6;
            this.tbDireccion.UseSelectable = true;
            this.tbDireccion.WaterMark = "Dirección";
            this.tbDireccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDireccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbGiro
            // 
            // 
            // 
            // 
            this.tbGiro.CustomButton.Image = null;
            this.tbGiro.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.tbGiro.CustomButton.Name = "";
            this.tbGiro.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbGiro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbGiro.CustomButton.TabIndex = 1;
            this.tbGiro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbGiro.CustomButton.UseSelectable = true;
            this.tbGiro.CustomButton.Visible = false;
            this.tbGiro.Lines = new string[0];
            this.tbGiro.Location = new System.Drawing.Point(3, 38);
            this.tbGiro.MaxLength = 32767;
            this.tbGiro.Name = "tbGiro";
            this.tbGiro.PasswordChar = '\0';
            this.tbGiro.PromptText = "Giro";
            this.tbGiro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbGiro.SelectedText = "";
            this.tbGiro.SelectionLength = 0;
            this.tbGiro.SelectionStart = 0;
            this.tbGiro.ShortcutsEnabled = true;
            this.tbGiro.Size = new System.Drawing.Size(182, 29);
            this.tbGiro.Style = MetroFramework.MetroColorStyle.Red;
            this.tbGiro.TabIndex = 5;
            this.tbGiro.UseSelectable = true;
            this.tbGiro.WaterMark = "Giro";
            this.tbGiro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbGiro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbNombre
            // 
            // 
            // 
            // 
            this.tbNombre.CustomButton.Image = null;
            this.tbNombre.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.tbNombre.CustomButton.Name = "";
            this.tbNombre.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNombre.CustomButton.TabIndex = 1;
            this.tbNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNombre.CustomButton.UseSelectable = true;
            this.tbNombre.CustomButton.Visible = false;
            this.tbNombre.Lines = new string[0];
            this.tbNombre.Location = new System.Drawing.Point(3, 3);
            this.tbNombre.MaxLength = 32767;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.PasswordChar = '\0';
            this.tbNombre.PromptText = "Nombre";
            this.tbNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNombre.SelectedText = "";
            this.tbNombre.SelectionLength = 0;
            this.tbNombre.SelectionStart = 0;
            this.tbNombre.ShortcutsEnabled = true;
            this.tbNombre.Size = new System.Drawing.Size(182, 29);
            this.tbNombre.Style = MetroFramework.MetroColorStyle.Red;
            this.tbNombre.TabIndex = 4;
            this.tbNombre.UseSelectable = true;
            this.tbNombre.WaterMark = "Nombre";
            this.tbNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbNombre.Leave += new System.EventHandler(this.tbNombre_Leave);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(0, 145);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(188, 29);
            this.btnGuardar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbEmpresas
            // 
            this.cmbEmpresas.FormattingEnabled = true;
            this.cmbEmpresas.ItemHeight = 23;
            this.cmbEmpresas.Location = new System.Drawing.Point(23, 63);
            this.cmbEmpresas.Name = "cmbEmpresas";
            this.cmbEmpresas.Size = new System.Drawing.Size(188, 29);
            this.cmbEmpresas.Style = MetroFramework.MetroColorStyle.Red;
            this.cmbEmpresas.TabIndex = 1;
            this.cmbEmpresas.UseSelectable = true;
            this.cmbEmpresas.Click += new System.EventHandler(this.cmbEmpresas_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(23, 98);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(188, 29);
            this.btnEntrar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseSelectable = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(23, 133);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(188, 29);
            this.btnRegistrar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseSelectable = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 363);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.cmbEmpresas);
            this.Controls.Add(this.panelRegistro);
            this.Name = "FrmMenu";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.panelRegistro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelRegistro;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroComboBox cmbEmpresas;
        private MetroFramework.Controls.MetroButton btnEntrar;
        private MetroFramework.Controls.MetroButton btnRegistrar;
        private MetroFramework.Controls.MetroTextBox tbNombre;
        private MetroFramework.Controls.MetroTextBox tbDescripcionProceso;
        private MetroFramework.Controls.MetroTextBox tbDireccion;
        private MetroFramework.Controls.MetroTextBox tbGiro;
    }
}
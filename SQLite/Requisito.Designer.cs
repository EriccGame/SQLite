namespace SQLite
{
    public partial class Requisito
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbtnCumple = new MetroFramework.Controls.MetroRadioButton();
            this.rbtnNoCumple = new MetroFramework.Controls.MetroRadioButton();
            this.rbtnNoAplica = new MetroFramework.Controls.MetroRadioButton();
            this.tbRequisito = new MetroFramework.Controls.MetroTextBox();
            this.tbObservacion = new MetroFramework.Controls.MetroTextBox();
            this.gbRequisito = new System.Windows.Forms.GroupBox();
            this.gbRequisito.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnCumple
            // 
            this.rbtnCumple.AutoSize = true;
            this.rbtnCumple.Location = new System.Drawing.Point(89, 37);
            this.rbtnCumple.Name = "rbtnCumple";
            this.rbtnCumple.Size = new System.Drawing.Size(32, 15);
            this.rbtnCumple.TabIndex = 0;
            this.rbtnCumple.Text = "SI";
            this.rbtnCumple.UseSelectable = true;
            // 
            // rbtnNoCumple
            // 
            this.rbtnNoCumple.AutoSize = true;
            this.rbtnNoCumple.Location = new System.Drawing.Point(127, 37);
            this.rbtnNoCumple.Name = "rbtnNoCumple";
            this.rbtnNoCumple.Size = new System.Drawing.Size(41, 15);
            this.rbtnNoCumple.TabIndex = 1;
            this.rbtnNoCumple.Text = "NO";
            this.rbtnNoCumple.UseSelectable = true;
            // 
            // rbtnNoAplica
            // 
            this.rbtnNoAplica.AutoSize = true;
            this.rbtnNoAplica.Location = new System.Drawing.Point(174, 37);
            this.rbtnNoAplica.Name = "rbtnNoAplica";
            this.rbtnNoAplica.Size = new System.Drawing.Size(45, 15);
            this.rbtnNoAplica.TabIndex = 2;
            this.rbtnNoAplica.Text = "N/A";
            this.rbtnNoAplica.UseSelectable = true;
            // 
            // tbRequisito
            // 
            // 
            // 
            // 
            this.tbRequisito.CustomButton.Image = null;
            this.tbRequisito.CustomButton.Location = new System.Drawing.Point(272, 1);
            this.tbRequisito.CustomButton.Name = "";
            this.tbRequisito.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbRequisito.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbRequisito.CustomButton.TabIndex = 1;
            this.tbRequisito.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbRequisito.CustomButton.UseSelectable = true;
            this.tbRequisito.CustomButton.Visible = false;
            this.tbRequisito.Enabled = false;
            this.tbRequisito.Lines = new string[0];
            this.tbRequisito.Location = new System.Drawing.Point(3, 10);
            this.tbRequisito.MaxLength = 32767;
            this.tbRequisito.Multiline = true;
            this.tbRequisito.Name = "tbRequisito";
            this.tbRequisito.PasswordChar = '\0';
            this.tbRequisito.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbRequisito.SelectedText = "";
            this.tbRequisito.SelectionLength = 0;
            this.tbRequisito.SelectionStart = 0;
            this.tbRequisito.ShortcutsEnabled = true;
            this.tbRequisito.Size = new System.Drawing.Size(294, 23);
            this.tbRequisito.TabIndex = 3;
            this.tbRequisito.UseSelectable = true;
            this.tbRequisito.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbRequisito.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbObservacion
            // 
            // 
            // 
            // 
            this.tbObservacion.CustomButton.Image = null;
            this.tbObservacion.CustomButton.Location = new System.Drawing.Point(232, 2);
            this.tbObservacion.CustomButton.Name = "";
            this.tbObservacion.CustomButton.Size = new System.Drawing.Size(59, 59);
            this.tbObservacion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbObservacion.CustomButton.TabIndex = 1;
            this.tbObservacion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbObservacion.CustomButton.UseSelectable = true;
            this.tbObservacion.CustomButton.Visible = false;
            this.tbObservacion.Lines = new string[0];
            this.tbObservacion.Location = new System.Drawing.Point(3, 51);
            this.tbObservacion.MaxLength = 32767;
            this.tbObservacion.Multiline = true;
            this.tbObservacion.Name = "tbObservacion";
            this.tbObservacion.PasswordChar = '\0';
            this.tbObservacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbObservacion.SelectedText = "";
            this.tbObservacion.SelectionLength = 0;
            this.tbObservacion.SelectionStart = 0;
            this.tbObservacion.ShortcutsEnabled = true;
            this.tbObservacion.Size = new System.Drawing.Size(294, 64);
            this.tbObservacion.TabIndex = 4;
            this.tbObservacion.UseSelectable = true;
            this.tbObservacion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbObservacion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gbRequisito
            // 
            this.gbRequisito.Controls.Add(this.rbtnNoCumple);
            this.gbRequisito.Controls.Add(this.tbRequisito);
            this.gbRequisito.Controls.Add(this.rbtnCumple);
            this.gbRequisito.Controls.Add(this.rbtnNoAplica);
            this.gbRequisito.Location = new System.Drawing.Point(0, -5);
            this.gbRequisito.Name = "gbRequisito";
            this.gbRequisito.Size = new System.Drawing.Size(300, 125);
            this.gbRequisito.TabIndex = 5;
            this.gbRequisito.TabStop = false;
            // 
            // Requisito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tbObservacion);
            this.Controls.Add(this.gbRequisito);
            this.Name = "Requisito";
            this.Size = new System.Drawing.Size(300, 120);
            this.gbRequisito.ResumeLayout(false);
            this.gbRequisito.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroRadioButton rbtnCumple;
        public MetroFramework.Controls.MetroRadioButton rbtnNoCumple;
        public MetroFramework.Controls.MetroRadioButton rbtnNoAplica;
        public MetroFramework.Controls.MetroTextBox tbRequisito;
        public MetroFramework.Controls.MetroTextBox tbObservacion;
        private System.Windows.Forms.GroupBox gbRequisito;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQLite
{
    public partial class STPS : Form
    {
        String NombreEmpresa;

        public STPS(String NombreEmpresa)
        {
            InitializeComponent();

            this.NombreEmpresa = NombreEmpresa;

            SQLiteConnection SqliteConexion = new SQLiteConnection();
            SqliteConexion.ConnectionString = "Data Source = STPS.sqlite; Version = 3; New = True;";
            SqliteConexion.Open();
            SQLiteCommand SqliteComando = new SQLiteCommand(SqliteConexion);
            SqliteComando.CommandText = String.Format("SELECT NombreSTPS, Tipo, Requisito, Observacion, Estatus, Orden FROM NomStps WHERE Empresa = '{0}' ORDER BY Orden ASC", NombreEmpresa);

            SQLiteDataAdapter DA = new SQLiteDataAdapter(SqliteComando);
            DataTable DT = new DataTable();
            DA.Fill(DT);

            gridSTPS.DataSource = DT;

            Int32 iPosY = -125;
            String sEstatus = String.Empty;
            Requisito R;

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                R = new Requisito
                {
                    Location = new Point(0, iPosY += 125),
                    Name = DT.Rows[i][5].ToString()
                };

                R.tbRequisito.Text = DT.Rows[i][2].ToString();
                R.tbObservacion.Text = DT.Rows[i][3].ToString();
                sEstatus = DT.Rows[i][4].ToString();

                if (sEstatus.Equals("1"))
                {
                    R.rbtnCumple.Checked = true;
                }
                else if (sEstatus.Equals("2")) 
                {
                    R.rbtnNoCumple.Checked = true;
                }
                else if (sEstatus.Equals("3"))
                {
                    R.rbtnNoAplica.Checked = true;
                }

                tab5.Controls.Add(R);
            }
        }

        private void STPS_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Application.Exit();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

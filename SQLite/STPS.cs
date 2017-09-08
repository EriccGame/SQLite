using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace SQLite
{
    public partial class STPS : MetroForm
    {
        Requisito[] R;
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
            R = new Requisito[DT.Rows.Count];

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                Add(i, iPosY += 125, DT.Rows[i][5].ToString(), DT.Rows[i][2].ToString(), DT.Rows[i][3].ToString(), DT.Rows[i][4].ToString());
            }
        }

        private void Add(Int32 iID, Int32 iPosY, String sNombre, String sRequisito, String sObservacion, String sEstatus)
        {
            R[iID] = new Requisito();
            R[iID].Ubicacion = iPosY;
            R[iID].Name = sNombre;
            R[iID].Requisitos = sRequisito;
            R[iID].Observacion = sObservacion;
            R[iID].RadioButtonCheck(sEstatus);

            tab5.Controls.Add(R[iID]);
        }

        private void STPS_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                if (MessageBox.Show("Exit?", "Salir", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Application.Exit();
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
    }
}

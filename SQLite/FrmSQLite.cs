using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Data.SQLite;

namespace SQLite
{
    public partial class FrmSQLite : MetroForm
    {
        SQLiteConnection SqliteConexion = new SQLiteConnection();
        SQLiteCommand SqliteComando;
        Boolean bExiste;

        public FrmSQLite()
        {
            InitializeComponent();
        }

        private void FrmSQLite_Load(object sender, EventArgs e)
        {
            bExiste = false;
            tbRFCEmpresa.MaxLength = 13;
            tbNombreEmpresa.MaxLength = 100;
            tbNombreRepresentante.MaxLength = 100;
            tbPuestoRepresentante.MaxLength = 50;
        }

        private void btnCrearBD_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("DB.sqlite"))
                {
                    SQLiteConnection.CreateFile("DB.sqlite");
                    MetroMessageBox.Show(this, ":)", "AllOK", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, 50);
                }
                else
                {
                    MetroMessageBox.Show(this, ":O", "Ya existe la BD!", MessageBoxButtons.OK, MessageBoxIcon.Information, 50);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                SqliteConexion.ConnectionString = "Data Source = DB.sqlite; Version = 3; New = True;";
                SqliteConexion.Open();
                CrearTablas();
                CargarCombo();
                MessageBox.Show(":)");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (bExiste)
            {
                Actualizar();
            }
            else
            {
                Guardar();
            }
        }

        private void Guardar()
        {
            try
            {
                if (tbNombreEmpresa.Text.Length > 0 && tbNombreRepresentante.Text.Length > 0
                    && tbPuestoRepresentante.Text.Length > 0 && tbRFCEmpresa.Text.Length > 0)
                {
                    String sQuery = String.Format("INSERT INTO Empresa VALUES ('{0}', '{1}', '{2}', '{3}')",
                        tbRFCEmpresa.Text, tbNombreEmpresa.Text, tbNombreRepresentante.Text, tbPuestoRepresentante.Text);
                    SqliteComando = new SQLiteCommand(SqliteConexion);
                    SqliteComando.CommandText = sQuery;
                    SqliteComando.ExecuteNonQuery();
                    MetroMessageBox.Show(this, "AllOK!");
                    Limpiar();
                }
                else
                {
                    MetroMessageBox.Show(this, "No se permiten campos vacios!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Actualizar()
        {
            try
            {
                if (tbNombreEmpresa.Text.Length > 0 && tbNombreRepresentante.Text.Length > 0
                    && tbPuestoRepresentante.Text.Length > 0 && tbRFCEmpresa.Text.Length > 0)
                {
                    String sQuery = String.Format("UPDATE Empresa SET NombreEmpresa = '{1}', NombreRepresentante = '{2}', PuestoRepresentante = '{3}' WHERE RFC = '{0}'",
                        tbRFCEmpresa.Text, tbNombreEmpresa.Text, tbNombreRepresentante.Text, tbPuestoRepresentante.Text);
                    SqliteComando = new SQLiteCommand(SqliteConexion);
                    SqliteComando.CommandText = sQuery;
                    SqliteComando.ExecuteNonQuery();
                    MetroMessageBox.Show(this, "AllOK!");
                    Limpiar();
                }
                else
                {
                    MetroMessageBox.Show(this, "No se permiten campos vacios!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Limpiar()
        {
            tbNombreEmpresa.Text = "";
            tbNombreRepresentante.Text = "";
            tbPuestoRepresentante.Text = "";
            tbRFCEmpresa.Text = "";
            tbRFCEmpresa.Focus();
            bExiste = false;
        }

        private void CrearTablas()
        {
            try
            {
                SqliteComando = new SQLiteCommand(SqliteConexion);

                SqliteComando.CommandText = "CREATE TABLE IF NOT EXISTS Empresa " +
                                            "(" +
                                                "RFC VARCHAR(15) NOT NULL," +
                                                "NombreEmpresa VARCHAR(100) NOT NULL," +
                                                "NombreRepresentante VARCHAR(100) NOT NULL," +
                                                "PuestoRepresentante VARCHAR(50) NOT NULL," +
                                                "PRIMARY KEY (RFC)" +
                                            ")";
                SqliteComando.ExecuteNonQuery();

                /*SqliteComando.CommandText = "CREATE TABLE IF NOT EXISTS Empresa " +
                                            "(" +
                                                "RFC VARCHAR(15) NOT NULL," +
                                                "NombreEmpresa VARCHAR(100) NOT NULL," +
                                                "NombreRepresentante VARCHAR(100) NOT NULL," +
                                                "PuestoRepresentante VARCHAR(50) NOT NULL," +
                                                "FOREIGN KEY (NombreEmpresa) "+
                                                "REFERENCES Empresa(NombreEmpresa)" +
                                            ")";
                SqliteComando.ExecuteNonQuery();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarCombo()
        {
            try
            {
                SqliteComando = new SQLiteCommand(SqliteConexion);
                SqliteComando.CommandText = String.Format("SELECT NombreEmpresa FROM Empresa");
                DataTable DT = new DataTable();
                SQLiteDataAdapter DA = new SQLiteDataAdapter(SqliteComando);
                DA.Fill(DT);

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    cmbEmpresa.Items.Add(DT.Rows[i][0].ToString());
                    //bExiste = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbRFCEmpresa_Leave(object sender, EventArgs e)
        {
            try
            {
                if (tbRFCEmpresa.Text.Length > 0)
                {
                    SqliteComando = new SQLiteCommand(SqliteConexion);
                    SqliteComando.CommandText = String.Format("SELECT NombreEmpresa, NombreRepresentante, PuestoRepresentante FROM Empresa WHERE RFC LIKE '%{0}%'", tbRFCEmpresa.Text);
                    DataTable DT = new DataTable();
                    SQLiteDataAdapter DA = new SQLiteDataAdapter(SqliteComando);
                    DA.Fill(DT);

                    if (DT.Rows.Count > 0)
                    {
                        tbNombreEmpresa.Text = DT.Rows[0][0].ToString();
                        tbNombreRepresentante.Text = DT.Rows[0][1].ToString();
                        tbPuestoRepresentante.Text = DT.Rows[0][2].ToString();
                        bExiste = true;
                    }
                    else
                    {
                        tbNombreEmpresa.Text = "";
                        tbNombreRepresentante.Text = "";
                        tbPuestoRepresentante.Text = "";
                        bExiste = false;
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Campo RFC vacio!");
                    tbRFCEmpresa.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace SQLite
{
    public partial class FrmMenu : MetroForm
    {
        Boolean bExiste = false;

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            if (CrearBD())
            {
                CargarCombo();
                panelRegistro.Visible = false;
            }
            else
            {
                MessageBox.Show(this, "Error al crear al base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean CrearBD()
        {
            try
            {
                if (!File.Exists("STPS.sqlite"))
                {
                    SQLiteConnection.CreateFile("STPS.sqlite");
                    CrearTablas();
                    MetroMessageBox.Show(this, ":)", "AllOK", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, 50);
                }
                else
                {
                    MetroMessageBox.Show(this, ":O", "Ya existe la BD!", MessageBoxButtons.OK, MessageBoxIcon.Information, 50);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void CrearTablas()
        {
            try
            {
                SQLiteConnection SqliteConexion = new SQLiteConnection();
                SqliteConexion.ConnectionString = "Data Source = STPS.sqlite; Version = 3; New = True;";
                SqliteConexion.Open();
                SQLiteCommand SqliteComando = new SQLiteCommand(SqliteConexion);

                SqliteComando.CommandText = "CREATE TABLE IF NOT EXISTS Empresa " +
                                            "(" +
                                                "Nombre VARCHAR(100) NOT NULL," +
                                                "Giro VARCHAR(200) NOT NULL," +
                                                "Direccion VARCHAR(100) NOT NULL," +
                                                "Proceso VARCHAR(5000) NOT NULL," +
                                                "PRIMARY KEY (Nombre)" +
                                            ")";
                SqliteComando.ExecuteNonQuery();

                SqliteComando.CommandText = "CREATE TABLE IF NOT EXISTS NomStps " +
                                            "(" +
                                                "NombreSTPS VARCHAR(100) NOT NULL," + //NOM-000-STPS-0000
                                                "Tipo VARCHAR(100) NOT NULL," + //5, 6, 7, 8, 9...
                                                "Orden INTEGER NOT NULL," + //1, 2, 3, 4, 5, 6, 7, 8, 9, 10...
                                                "Requisito VARCHAR(1000) NOT NULL," + //"Escribir"
                                                "Observacion VARCHAR(5000) NOT NULL," + //Datos usuario
                                                "Estatus VARCHAR(1) NOT NULL," + //0, 1, 2, 3
                                                "Empresa VARCHAR(100) NOT NULL," + //Datos
                                                "FOREIGN KEY (Empresa) " +
                                                "REFERENCES Empresa(Nombre)" +
                                             ")";
                SqliteComando.ExecuteNonQuery();

                SqliteComando.CommandText = "CREATE TABLE IF NOT EXISTS AcccionesCorrectivas " +
                                            "(" +
                                                "Acciones VARCHAR(5000) NOT NULL," +
                                                "Empresa VARCHAR(100) NOT NULL," +
                                                "FOREIGN KEY (Empresa) " +
                                                "REFERENCES Empresa(Nombre)" +
                                            ")";
                SqliteComando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (cmbEmpresas.Text.Length > 0)
            {
                STPS Nom = new STPS(cmbEmpresas.Text);
                this.Hide();
                Nom.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this, "No hay nada seleccionado!");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = false;
            cmbEmpresas.Enabled = true;
            btnEntrar.Enabled = true;
            btnRegistrar.Enabled = true;
            GuardarActualizar();

            if (!bExiste)
            {
                AgregarDatosSTPS();
            }

            CargarCombo();
        }

        private Boolean GuardarActualizar()
        {
            Boolean bAllOK = false;
            try
            {
                SQLiteConnection SqliteConexion = new SQLiteConnection();
                SqliteConexion.ConnectionString = "Data Source = STPS.sqlite; Version = 3; New = True;";
                SqliteConexion.Open();
                String sQuery = String.Empty;

                if (tbNombre.Text.Length > 0
                    && tbGiro.Text.Length > 0
                    && tbDireccion.Text.Length > 0
                    && tbDescripcionProceso.Text.Length > 0)
                {
                    if (bExiste)
                    {
                        sQuery = String.Format("UPDATE Empresa SET Giro = '{1}', Direccion = '{2}', Proceso = '{3}' WHERE Nombre = '{0}'",
                            tbNombre.Text.Trim(), tbGiro.Text.Trim(), tbDireccion.Text.Trim(), tbDescripcionProceso.Text.Trim());
                    }
                    else
                    {
                        sQuery = String.Format("INSERT INTO Empresa VALUES ('{0}', '{1}', '{2}', '{3}')",
                            tbNombre.Text.Trim(), tbGiro.Text.Trim(), tbDireccion.Text.Trim(), tbDescripcionProceso.Text.Trim());
                    }
                    SQLiteCommand SqliteComando = new SQLiteCommand(SqliteConexion);
                    SqliteComando.CommandText = sQuery;
                    SqliteComando.ExecuteNonQuery();
                    bAllOK = true;
                    MetroMessageBox.Show(this, "AllOK!");
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
            return bAllOK;
        }

        private void AgregarDatosSTPS()
        {
            AgregarAC();
            EjecutarConsulta("NOM-001-STPS-1994", "5. Obligaciones", 0, "Cumple... 0", "Ob.0", 0);
            EjecutarConsulta("NOM-002-STPS-1994", "5. Obligaciones", 1, "Cumple... 1", "Ob.1", 2);
            EjecutarConsulta("NOM-003-STPS-1994", "5. Obligaciones", 2, "Cumple... 2", "Ob.2", 1);
            EjecutarConsulta("NOM-004-STPS-1994", "5. Obligaciones", 3, "Cumple... 3", "Ob.3", 3);
        }

        private void EjecutarConsulta(String sSTPS, String sTipo, Int32 iOrden, String sRequisito, String sObservacion, Int32 iEstatus)
        {
            SQLiteConnection SqliteConexion = new SQLiteConnection();
            SqliteConexion.ConnectionString = "Data Source = STPS.sqlite; Version = 3; New = True;";
            SqliteConexion.Open();
            SQLiteCommand SqliteComando = new SQLiteCommand(SqliteConexion);

            SqliteComando.CommandText = String.Format("INSERT INTO NomStps VALUES ('{0}', '{1}', {2}, '{3}', '{4}', '{5}', '{6}')",
                sSTPS, sTipo, iOrden, sRequisito, sObservacion, iEstatus, tbNombre.Text.Trim());
            SqliteComando.ExecuteNonQuery();
        }

        private void AgregarAC()
        {
            SQLiteConnection SqliteConexion = new SQLiteConnection();
            SqliteConexion.ConnectionString = "Data Source = STPS.sqlite; Version = 3; New = True;";
            SqliteConexion.Open();
            SQLiteCommand SqliteComando = new SQLiteCommand(SqliteConexion);
            SqliteComando.CommandText = String.Format("INSERT INTO AcccionesCorrectivas VALUES ('{0}', '{1}')",
                "", tbNombre.Text.Trim());
            SqliteComando.ExecuteNonQuery();
            SqliteConexion.Close();
        }

        private Boolean CargarCombo()
        {
            Boolean bEntra = false;
            try
            {
                SQLiteConnection SqliteConexion = new SQLiteConnection();
                SqliteConexion.ConnectionString = "Data Source = STPS.sqlite; Version = 3; New = True;";
                SqliteConexion.Open();
                SQLiteCommand SqliteComando = new SQLiteCommand(SqliteConexion);
                SqliteComando.CommandText = "SELECT Giro, Nombre FROM Empresa";
                SQLiteDataAdapter DA = new SQLiteDataAdapter(SqliteComando);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                cmbEmpresas.DataSource = DT;
                cmbEmpresas.ValueMember = "Giro";
                cmbEmpresas.DisplayMember = "Nombre";

                if (cmbEmpresas.Items.Count > 0)
                {
                    bEntra = true;
                }
                else
                {
                    cmbEmpresas.Enabled = false;
                    btnEntrar.Enabled = false;
                    btnRegistrar.Enabled = false;

                    panelRegistro.Visible = true;
                    tbNombre.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return bEntra;
        }

        private void tbNombre_Leave(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection SqliteConexion = new SQLiteConnection();
                SqliteConexion.ConnectionString = "Data Source = STPS.sqlite; Version = 3; New = True;";
                SqliteConexion.Open();
                SQLiteCommand SqliteComando = new SQLiteCommand(SqliteConexion);
                SqliteComando.CommandText = String.Format("SELECT Giro, Direccion, Proceso FROM Empresa WHERE Nombre = '{0}'", tbNombre.Text.Trim());
                SQLiteDataAdapter DA = new SQLiteDataAdapter(SqliteComando);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                if (DT.Rows.Count > 0)
                {
                    tbGiro.Text = DT.Rows[0][0].ToString();
                    tbDireccion.Text = DT.Rows[0][1].ToString();
                    tbDescripcionProceso.Text = DT.Rows[0][2].ToString();
                    bExiste = true;
                }
                else
                {
                    tbGiro.Text = "";
                    tbDireccion.Text = "";
                    tbDescripcionProceso.Text = "";
                    bExiste = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbEmpresas_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbEmpresas.SelectedValue.ToString());
        }
    }
}

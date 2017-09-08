using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQLite
{
    public partial class Requisito : UserControl
    {
        //R[iID].Name = sNombre;
        //R[iID].tbRequisito.Text = sRequisito;
        //R[iID].tbObservacion.Text = sObservacion;
        private Int32 iUbicacion;
        private String sRequisito;
        private String sObservacion;

        public String Observacion
        {
            get { return sObservacion; }
            set
            {
                sObservacion = value;
                tbObservacion.Text = sObservacion;
            }
        }

        public String Requisitos
        {
            get { return sRequisito; }
            set
            {
                sRequisito = value;
                tbRequisito.Text = sRequisito;
            }
        }

        public Int32 Ubicacion
        {
            get { return iUbicacion; }
            set
            {
                iUbicacion = value;
                Location = new Point(0, iUbicacion);
            }
        }

        public Requisito()
        {
            InitializeComponent();
        }

        public void RadioButtonCheck(String sEstatus)
        {
            if (sEstatus.Equals("1"))
            {
                rbtnCumple.Checked = true;
            }
            else if (sEstatus.Equals("2"))
            {
                rbtnNoCumple.Checked = true;
            }
            else if (sEstatus.Equals("3"))
            {
                rbtnNoAplica.Checked = true;
            }
        }
    }
}

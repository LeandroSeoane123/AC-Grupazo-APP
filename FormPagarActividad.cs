using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1.Datos;

namespace TP1
{
    public partial class FormPagarActividad : Form
    {
        int flag = 0;
        string dniNoSocioAux;
        string actividadAux;
        string montoAux;
        string formaPagoAux;

        public FormPagarActividad(string dni, string actividad, string monto)
        {
            InitializeComponent();
            dniNoSocioAux = dni;
            actividadAux = actividad;
            montoAux = monto;
            formaPagoAux = "";
            this.ControlBox = false;
        }

        private void FormPagarActividad_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            label5.Text = montoAux;
            label6.Visible = false;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                MessageBox.Show("Debe completar el pago de la factura para poder volver.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Close();
            }
        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            if (!radioButtonEfectivo.Checked && !radioButtonTarjeta.Checked)
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Datos.CuotaActividad dato1 = new Datos.CuotaActividad();

                if (radioButtonEfectivo.Checked == true)
                {
                    dato1.pagar_CuotaActividad(dniNoSocioAux, "Efectivo", actividadAux);
                    MessageBox.Show("Pago de cuota exitoso.", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonComprobante.Visible = true;
                    label6.Visible = true;
                    formaPagoAux = "Efectivo";
                    flag = 1;
                }
                else
                {
                    dato1.pagar_CuotaActividad(dniNoSocioAux, "Tarjeta", actividadAux);
                    MessageBox.Show("Pago de cuota exitoso.", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonComprobante.Visible = true;
                    label6.Visible = true;
                    formaPagoAux = "Tarjeta";
                    flag = 1;
                }
            }
        }

        private void buttonComprobante_Click(object sender, EventArgs e)
        {
            FormFacturaActividad facturaAct = new FormFacturaActividad(dniNoSocioAux, actividadAux, formaPagoAux, montoAux);
            facturaAct.ShowDialog();
        }

    }
}

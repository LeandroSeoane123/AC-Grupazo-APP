using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class FormPagarCuotaSocial : Form
    {
        int flag = 0;
        string dniSocioAux;
        string nombreAux;
        string montoAux = "";
        string formaPagoAux = "";

        public FormPagarCuotaSocial(string nombre, string dniSocio)
        {
            InitializeComponent();
            dniSocioAux = dniSocio;
            nombreAux = nombre;
        }

        private void FormPagarCuotaSocial_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            buttonComprobante.Visible = false;
            buttonCarnet.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
        }

        private void buttonComprobante_Click(object sender, EventArgs e)
        {
            FormFacturaCuotaSocio factura = new FormFacturaCuotaSocio(nombreAux, dniSocioAux, formaPagoAux, montoAux);
            factura.ShowDialog();
        }
        private void buttonVolver_Click_1(object sender, EventArgs e)
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
            if (textBoxMonto.Text == "" || (!radioButtonEfectivo.Checked && !radioButtonTarjeta.Checked))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Datos.CuotaSocial dato1 = new Datos.CuotaSocial();
                montoAux = textBoxMonto.Text;

                if (radioButtonEfectivo.Checked == true)
                {
                    dato1.pagar_Cuota(dniSocioAux, "Efectivo", textBoxMonto.Text);
                    MessageBox.Show("Pago de cuota exitoso.", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonComprobante.Visible = true;
                    buttonCarnet.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    formaPagoAux = "Efectivo";
                    flag = 1;
                }
                else
                {
                    dato1.pagar_Cuota(dniSocioAux, "Tarjeta", textBoxMonto.Text);
                    MessageBox.Show("Pago de cuota exitoso.", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonComprobante.Visible = true;
                    buttonCarnet.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    formaPagoAux = "Tarjeta";
                    flag = 1;
                }
            }
        }

        private void buttonCarnet_Click(object sender, EventArgs e)
        {
            FormCarnet carnet = new FormCarnet(dniSocioAux, nombreAux);
            carnet.ShowDialog();
        }
    }
}

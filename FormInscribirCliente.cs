using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class FormInscribirCliente : Form
    {
        public FormInscribirCliente()
        {
            InitializeComponent();
        }

        private void FormInscribirCliente_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            // volver al formulario anterior
            this.Close();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {

            if (!checkBoxAptoFisico.Checked || textBoxNombre.Text == "" || textBoxApellido.Text == "" || textBoxNumeroDNI.Text == "" || comboBoxAño.Text == "" || comboBoxMes.Text == "" || comboBoxDia.Text == "" || textBoxTelefono.Text == "" || textBoxEmail.Text == "" || comboBoxTipoCliente.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (Convert.ToInt64(textBoxNumeroDNI.Text) >= 1000000 && Convert.ToInt64(textBoxNumeroDNI.Text) <= 100000000)
                {
                    if (Convert.ToInt64(textBoxTelefono.Text) >= 1100000000)
                    {
                        DataTable tablaRegistroSocio = new DataTable();
                        Datos.Cliente dato1 = new Datos.Cliente();
                        Datos.Socio_NoSocio dato2 = new Datos.Socio_NoSocio();

                        tablaRegistroSocio = dato1.agregar_NuevoCliente(textBoxNumeroDNI.Text, textBoxNombre.Text, textBoxApellido.Text, (comboBoxAño.Text + "-" + comboBoxMes.Text + "-" + comboBoxDia.Text), textBoxTelefono.Text, textBoxEmail.Text, comboBoxTipoCliente.Text);

                        if (tablaRegistroSocio.Rows.Count > 0)
                        {
                            MessageBox.Show("ERROR: El socio ya fue registrado.", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dato2.agregarSocio_O_NoSocio(textBoxNumeroDNI.Text, comboBoxTipoCliente.Text);
                            MessageBox.Show("Registro exitoso.", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (comboBoxTipoCliente.Text == "Socio")
                            {
                                FormPagarCuotaSocial pagarCuota = new FormPagarCuotaSocial((textBoxNombre.Text + " " + textBoxApellido.Text), textBoxNumeroDNI.Text);
                                pagarCuota.ShowDialog();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El telefono ingresado no esta en el formato correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("El DNI ingresado no esta en el formato correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void textBoxNumeroDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

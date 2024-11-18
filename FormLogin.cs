
using System.Data;
using System.Windows.Forms;

namespace TP1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
                txtPass.UseSystemPasswordChar = true;
            }

        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.ForeColor = Color.Gray;
                txtPass.Text = "Contraseña";
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.ForeColor = Color.Gray;
                txtUser.Text = "Usuario";
            }
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
            Datos.Usuarios dato = new Datos.Usuarios(); // variable que contiene todas las caracteristicas de la clase
            tablaLogin = dato.Log_Usu(txtUser.Text, txtPass.Text);
            if (tablaLogin.Rows.Count > 0)
            {
                // quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE
                MessageBox.Show("Ingreso exitoso.", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Creo una instancia del formulario FormPantallaPrincipal
                FormPantallaPrincipal formPantallaPrincipal = new FormPantallaPrincipal();
                // Seteo el valor de la variable "rol" en el formulario FormPantallaPrincipal
                // asignandole el valor de la columna 0 de la fila 0 de la tabla "tablaLogin"
                formPantallaPrincipal.rol = Convert.ToString(tablaLogin.Rows[0][0]);

                // Seteo el valor de la variable "usuario" en el formulario FormPantallaPrincipal
                // asignandole el valor del campo txtUser
                formPantallaPrincipal.usuario = Convert.ToString(txtUser.Text);
                // Muestro el formulario principal
                formPantallaPrincipal.Show();
                // cuando el usuario haga click en el botón Ok del MessageBox, debería llevarme a un nuevo formulario
                // y cerrar el actual
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos.", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

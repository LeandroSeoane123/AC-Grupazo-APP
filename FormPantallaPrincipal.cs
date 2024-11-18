using System.Windows.Forms;

namespace TP1
{
    public partial class FormPantallaPrincipal : Form
    {
        public FormPantallaPrincipal()
        {
            InitializeComponent();
        }

        internal string? rol;
        internal string? usuario;

        private void FormPantallaPrincipal_Load(object sender, EventArgs e)
        {
            // Uso los datos usuario y rol que seteo en FormLogin para mostrarlos en el label2
            label2.Text = usuario + " (" + rol + ")";
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Font = new Font("Impact", 10F); ;
            this.ControlBox = false;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            // Cuando clickeo el botón Salir, cierra la aplicación.
            Application.Exit();
        }

        private void buttonNavegarPantallaNuevoSocio_Click(object sender, EventArgs e)
        {
            // ir a la pantalla FormInscribirSocio
            FormInscribirCliente formInscribirSocio = new FormInscribirCliente();
            this.Hide();
            formInscribirSocio.ShowDialog();
            this.Show();
        }

        private void buttonNavegarPantallaAsignarActividad_Click(object sender, EventArgs e)
        {
            FormAsignarActividades formActividad = new FormAsignarActividades();
            this.Hide();
            formActividad.ShowDialog();
            this.Show();
        }

        private void buttonNavegarPantallaListarSociosCuotaVencida_Click(object sender, EventArgs e)
        {
            FormListarSociosCuotaVencida formListar = new FormListarSociosCuotaVencida();
            this.Hide();
            formListar.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollado por:\n\nLeandro Seoane\nMartin Comito\nLucrecia Pedraza\nCamila Cuns\nPablo Combis", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
namespace ARRASTRA_Y_JUEGA__JAFERYAC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCerrarJuego_Click(object sender, EventArgs e)
        {
            Close(); //Cerrar el juego en la pantalla de inicio
        }

        private void buttonIniciarJuego_Click(object sender, EventArgs e)
        {
            RECICLA_Y_JUEGA VENTANA = new RECICLA_Y_JUEGA(); //ME ABRE LA VENTANA DONDE ES EL JUEGO
            VENTANA.Show();
            this.Hide();


            INSTRUCCIONES INSTRUCCIONES = new INSTRUCCIONES();  //ME ABRE LA VENTANA DE INSTRUCCIONES ANTES DE INICIAR EL JUEGO
            INSTRUCCIONES.StartPosition = FormStartPosition.CenterParent;
            INSTRUCCIONES.ShowDialog(this);

        }
    }
}

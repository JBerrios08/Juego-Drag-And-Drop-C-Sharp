using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARRASTRA_Y_JUEGA__JAFERYAC
{
    public partial class FINDELJUEGO : Form
    {
        public bool Reiniciar { get; private set; } = false;
        public FINDELJUEGO(string Mensaje)
        {
            InitializeComponent();
            LabelMensaje.Text = Mensaje;
        }

        private void ButtonReiniciar_Click(object sender, EventArgs e)
        {
            Reiniciar = true; // PARA REINICIAR
            this.Close();
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            Reiniciar = false;
            Application.Exit(); // SE CIERRA TODO EL PROGRAMA
        }
    }
}

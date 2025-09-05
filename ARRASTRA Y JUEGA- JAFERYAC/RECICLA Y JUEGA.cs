namespace ARRASTRA_Y_JUEGA__JAFERYAC
{
    public partial class RECICLA_Y_JUEGA : Form
    {
        //MIS VARIABLES PARA MIS PUNTOS Y EL TIEMPO
        int puntos = 0;
        int tiempo = 60;

        //VARIABLES DE BASURERO PARA PODER ARRASTRAR
        bool arrastrar = false;
        Point offset;

        //LISTA DE BASURAS
        List<PictureBox> basuras;

        //DICCIONARIO PARA GUARDAR POSICIONES ORIGINALES DE MI BASURA
        Dictionary<PictureBox, Point> posicionesOriginales = new Dictionary<PictureBox, Point>();

        public RECICLA_Y_JUEGA()
        {
            InitializeComponent();

            //OCULTO MIS LABEL PARA QUE NO SE MUESTREN ANTES DE PRECIONAR EL  BUTTON "INCIAR JUEGO"
            LabelTiempo.Visible = false;
            LabelPorcentaje.Visible = false;

            //OCULTO MIS BASUREROS.
            pictureBoxVERDE.Visible = false;
            pictureBoxAmarillo.Visible = false;
            pictureBoxRojo.Visible = false;
            pictureBoxAzul.Visible = false;
            pictureBoxGris.Visible = false;
            pictureBoxNaranja.Visible = false;

            //OCULTO MI BASURA
            pictureBoxCARTON.Visible = false;
            pictureBoxBateria.Visible = false;
            pictureBoxBotellaVidrio.Visible = false;
            pictureBoxCigarro.Visible = false;
            pictureBoxHoja.Visible = false;
            pictureBoxToxico.Visible = false;
            pictureBoxTierra.Visible = false;
            pictureBoxLata.Visible = false;
            pictureBoxPapel.Visible = false;
            PictureBoxBanana.Visible = false;
            pictureBoxBotella.Visible = false;
            pictureBoxVidrio.Visible = false;

            //CREAMOS LA LISTA DE BASURAS SOLO UNA VEZ
            basuras = new List<PictureBox>()
            {
                pictureBoxCARTON,
                pictureBoxBateria,
                pictureBoxBotellaVidrio,
                pictureBoxCigarro,
                pictureBoxHoja,
                pictureBoxToxico,
                pictureBoxTierra,
                pictureBoxLata,
                pictureBoxPapel,
                PictureBoxBanana,
                pictureBoxBotella,
                pictureBoxVidrio
            };

            //GUARDAMOS LAS POSICIONES INICIALES
            foreach (var pb in basuras)
            {
                posicionesOriginales[pb] = pb.Location;

                pb.MouseDown += Basura_MouseDown;
                pb.MouseMove += Basura_MouseMove;
                pb.MouseUp += Basura_MouseUp;
                pb.Visible = false; // al inicio ocultas la basura
            }
        }

        //MIS EVENTOS DE ARRASTRAR
        private void Basura_MouseDown(object sender, MouseEventArgs e)
        {
            arrastrar = true;
            offset = e.Location;
        }

        private void Basura_MouseMove(Object sender, MouseEventArgs e)
        {
            if (arrastrar)
            {
                PictureBox pb = sender as PictureBox;
                pb.Left = e.X + pb.Left - offset.X;
                pb.Top = e.Y + pb.Top - offset.Y;
            }
        }

        private void Basura_MouseUp(object sender, MouseEventArgs e)
        {
            arrastrar = false;
            PictureBox pb = sender as PictureBox;

            bool correcta = false;

            //VERIFICO QUE BASURA VA EN CADA BASURERO

            //PARA BASURERO VERDE:
            if ((pb == pictureBoxVidrio && pb.Bounds.IntersectsWith(pictureBoxVERDE.Bounds)) ||
                (pb == pictureBoxBotellaVidrio && pb.Bounds.IntersectsWith(pictureBoxVERDE.Bounds)) ||
            //PARA BASURERO AMARILLO:
                (pb == pictureBoxLata && pb.Bounds.IntersectsWith(pictureBoxAmarillo.Bounds)) ||
                (pb == pictureBoxBotella && pb.Bounds.IntersectsWith(pictureBoxAmarillo.Bounds)) ||
            //PARA BASURERO ROJO:
                (pb == pictureBoxToxico && pb.Bounds.IntersectsWith(pictureBoxRojo.Bounds)) ||
                (pb == pictureBoxBateria && pb.Bounds.IntersectsWith(pictureBoxRojo.Bounds)) ||
            //PARA BASURERO AZUL:
                (pb == pictureBoxPapel && pb.Bounds.IntersectsWith(pictureBoxAzul.Bounds)) ||
                (pb == pictureBoxCARTON && pb.Bounds.IntersectsWith(pictureBoxAzul.Bounds)) ||
            //PARA BASURERO GRIS:
                (pb == pictureBoxCigarro && pb.Bounds.IntersectsWith(pictureBoxGris.Bounds)) ||
                (pb == pictureBoxTierra && pb.Bounds.IntersectsWith(pictureBoxGris.Bounds)) ||
            //PARA BASURERO NARANJA:
                (pb == PictureBoxBanana && pb.Bounds.IntersectsWith(pictureBoxNaranja.Bounds)) ||
                (pb == pictureBoxHoja && pb.Bounds.IntersectsWith(pictureBoxNaranja.Bounds)))
            {
                correcta = true;
                pb.Visible = false;
            }
            else
            {
                pb.Location = posicionesOriginales[pb];
                pb.Visible = true;
            }

            if (correcta)
            {
                //POR CADA ACIERTO SON 10 PUNTOS
                puntos += 10;
            }
            else
            {
                //POR CADA ERROR SON MENOS 5 PUNTOS
                puntos -= 5;
                if (puntos < 0) puntos = 0; // PARA QUE NO PASE DE 0 Y TENGA PUNTOS NEGATIVOS
            }

            LabelPorcentaje.Text = "PUNTOS: " + puntos;
            verificarfin();
        }

        //BOTON DE INICIAR JUEGO
        private void button1_Click(object sender, EventArgs e)
        {
            InicializarJuego();
        }

        private void InicializarJuego()
        {
            //UTILIZO LAS VARIABLES Y LE DOY UN VALOR
            tiempo = 60;
            puntos = 0;

            LabelTiempo.Text = "TIEMPO: " + tiempo;
            LabelPorcentaje.Text = "PUNTOS: " + puntos;

            buttonIniciarJuego.Visible = false;

            //PARA MOSTRAR MIS LABEL PORCENTAJE Y TIEMPO
            LabelTiempo.Visible = true;
            LabelPorcentaje.Visible = true;

            //MUESTRO MIS BASUREROS
            pictureBoxVERDE.Visible = true;
            pictureBoxAmarillo.Visible = true;
            pictureBoxRojo.Visible = true;
            pictureBoxAzul.Visible = true;
            pictureBoxGris.Visible = true;
            pictureBoxNaranja.Visible = true;

            //MOSTRAMOS TODA LA BASURA
            //MOSTRAMOS TODA LA BASURA EN SU POSICIÓN ORIGINAL
            ReiniciarBasuras();

            //INICIAMOS TEMPORIZADOR
            // REINICIAMOS TEMPORIZADOR
            temporizador.Stop();
            temporizador.Tick -= temporizador_Tick;
            IniciarTemporizador();
        }

        //VERIFICACIÓN DEL FIN DEL JUEGO
        private void verificarfin(bool forzarFin = false)
        {
            foreach (var pb in basuras)
            {
                if (pb.Visible && !forzarFin) return; // si queda basura y no se fuerza el fin, salimos
            }

            //MI TEMPORIZADOR SE DETENDRA CUANDO SE HAYAN COLOCADO TODA LA BASURA EN SUS BASUREROS Y MOSTRARA UN FORMULARIO
            temporizador.Stop();

            int tiempoUsado = 60 - tiempo; // TIEMPO EN QUE SE RECICLO TODA LA BASURA
            string mensaje;

            //MUESTRO EN EL LABEL DEL FORMULARIO "FINDELJUEGO" SI GANA O PIERDE
            if (puntos >= 120)
                mensaje = $"¡FELICIDADES!, ¡HAS GANADO!\n" +
                    $"LO HAS LOGRADO EN: {tiempoUsado} SEGUNDOS\n" +
                    $"TU PUNTUACIÓN: {puntos}";
            else
                mensaje = $"FIN DEL JUEGO\n" +
                    $"LOS HAS HECHO EN: {tiempoUsado} SEGUNDOS\n" +
                    $"TU PUNTUACIÓN: {puntos}";

            //MOSTRAMOS EL FORMULARIO QUE APARECE PARA DARNOS LOS RESULTADOS
            using (FINDELJUEGO finForm = new FINDELJUEGO(mensaje))
            {
                finForm.ShowDialog();

                //PARA REINICIAR EL JUEGO 
                if (finForm.Reiniciar)
                {
                    ReiniciarJuego();
                }

                //PARA SALIR Y CERRAR TODO EL PROGRAMA
                else
                {
                    Application.Exit(); 
                }
            }
        }

        //UNA VES SE REINICIA EL JUEGO ENTRARIA EN ACCION "ReiniciarJuego"
        private void ReiniciarJuego()
        {
            InicializarJuego();
        }

        //METODO PARA COLOCAR TODA LA BASURA EN SU POSICIÓN ORIGINAL
        private void ReiniciarBasuras()
        {
            foreach (var pb in basuras)
            {
                pb.Location = posicionesOriginales[pb]; // posición inicial
                pb.Visible = true;
            }
        }

        //INICIAR TEMPORIZADOR NUEVAMENTE
        private void IniciarTemporizador()
        {
            temporizador.Interval = 1000;

            // Solo agregamos el evento una vez para evitar duplicados
            temporizador.Tick -= temporizador_Tick;
            temporizador.Tick += temporizador_Tick;

            temporizador.Start();
        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            tiempo--;
            LabelTiempo.Text = "TIEMPO: " + tiempo;

            if (tiempo <= 0)
            {
                temporizador.Stop();
                verificarfin(forzarFin: true); // usamos el mismo formulario de fin de juego
            }
        }
    }
}

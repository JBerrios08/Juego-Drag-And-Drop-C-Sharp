namespace ARRASTRA_Y_JUEGA__JAFERYAC
{
    partial class FINDELJUEGO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FINDELJUEGO));
            LabelMensaje = new Label();
            ButtonReiniciar = new Button();
            ButtonSalir = new Button();
            SuspendLayout();
            // 
            // LabelMensaje
            // 
            LabelMensaje.AutoSize = true;
            LabelMensaje.BackColor = Color.Transparent;
            LabelMensaje.Font = new Font("Snap ITC", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelMensaje.ForeColor = Color.Yellow;
            LabelMensaje.Location = new Point(162, 28);
            LabelMensaje.Name = "LabelMensaje";
            LabelMensaje.Size = new Size(164, 48);
            LabelMensaje.TabIndex = 0;
            LabelMensaje.Text = "LABEL";
            // 
            // ButtonReiniciar
            // 
            ButtonReiniciar.BackColor = Color.Olive;
            ButtonReiniciar.Cursor = Cursors.Hand;
            ButtonReiniciar.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonReiniciar.ForeColor = Color.White;
            ButtonReiniciar.Location = new Point(492, 318);
            ButtonReiniciar.Name = "ButtonReiniciar";
            ButtonReiniciar.Size = new Size(219, 74);
            ButtonReiniciar.TabIndex = 1;
            ButtonReiniciar.Text = "REINICIAR";
            ButtonReiniciar.UseVisualStyleBackColor = false;
            ButtonReiniciar.Click += ButtonReiniciar_Click;
            // 
            // ButtonSalir
            // 
            ButtonSalir.BackColor = Color.Olive;
            ButtonSalir.Cursor = Cursors.Hand;
            ButtonSalir.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonSalir.ForeColor = Color.Red;
            ButtonSalir.Location = new Point(492, 424);
            ButtonSalir.Name = "ButtonSalir";
            ButtonSalir.Size = new Size(219, 74);
            ButtonSalir.TabIndex = 2;
            ButtonSalir.Text = "SALIR";
            ButtonSalir.UseVisualStyleBackColor = false;
            ButtonSalir.Click += ButtonSalir_Click;
            // 
            // FINDELJUEGO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1156, 596);
            Controls.Add(ButtonSalir);
            Controls.Add(ButtonReiniciar);
            Controls.Add(LabelMensaje);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FINDELJUEGO";
            Text = "FINDELJUEGO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelMensaje;
        private Button ButtonReiniciar;
        private Button ButtonSalir;
    }
}
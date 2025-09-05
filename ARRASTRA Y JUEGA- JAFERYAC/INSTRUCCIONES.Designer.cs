namespace ARRASTRA_Y_JUEGA__JAFERYAC
{
    partial class INSTRUCCIONES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INSTRUCCIONES));
            AceptarInciarJuego = new Button();
            SuspendLayout();
            // 
            // AceptarInciarJuego
            // 
            AceptarInciarJuego.BackColor = Color.LightSeaGreen;
            AceptarInciarJuego.Cursor = Cursors.Hand;
            AceptarInciarJuego.FlatAppearance.BorderSize = 0;
            AceptarInciarJuego.FlatAppearance.MouseDownBackColor = Color.Navy;
            AceptarInciarJuego.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 64);
            AceptarInciarJuego.FlatStyle = FlatStyle.Flat;
            AceptarInciarJuego.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AceptarInciarJuego.ForeColor = Color.White;
            AceptarInciarJuego.Location = new Point(118, 303);
            AceptarInciarJuego.Name = "AceptarInciarJuego";
            AceptarInciarJuego.Size = new Size(184, 47);
            AceptarInciarJuego.TabIndex = 1;
            AceptarInciarJuego.Text = "ACEPATR";
            AceptarInciarJuego.UseVisualStyleBackColor = false;
            AceptarInciarJuego.Click += AceptarInciarJuego_Click;
            // 
            // INSTRUCCIONES
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(415, 362);
            Controls.Add(AceptarInciarJuego);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "INSTRUCCIONES";
            Text = "INTRUCCIONES";
            ResumeLayout(false);
        }

        #endregion

        private Button AceptarInciarJuego;
    }
}
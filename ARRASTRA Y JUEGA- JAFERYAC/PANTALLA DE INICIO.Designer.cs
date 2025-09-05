namespace ARRASTRA_Y_JUEGA__JAFERYAC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            buttonIniciarJuego = new Button();
            buttonCerrarJuego = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tw Cen MT Condensed Extra Bold", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1210, 237);
            label1.Name = "label1";
            label1.Size = new Size(665, 114);
            label1.TabIndex = 0;
            label1.Text = "RECICLA Y JUEGA";
            // 
            // buttonIniciarJuego
            // 
            buttonIniciarJuego.BackColor = Color.Transparent;
            buttonIniciarJuego.BackgroundImage = (Image)resources.GetObject("buttonIniciarJuego.BackgroundImage");
            buttonIniciarJuego.BackgroundImageLayout = ImageLayout.None;
            buttonIniciarJuego.Cursor = Cursors.Hand;
            buttonIniciarJuego.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            buttonIniciarJuego.FlatAppearance.BorderSize = 0;
            buttonIniciarJuego.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonIniciarJuego.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonIniciarJuego.FlatStyle = FlatStyle.Flat;
            buttonIniciarJuego.Location = new Point(1404, 431);
            buttonIniciarJuego.Name = "buttonIniciarJuego";
            buttonIniciarJuego.Size = new Size(283, 95);
            buttonIniciarJuego.TabIndex = 1;
            buttonIniciarJuego.UseVisualStyleBackColor = false;
            buttonIniciarJuego.Click += buttonIniciarJuego_Click;
            // 
            // buttonCerrarJuego
            // 
            buttonCerrarJuego.BackColor = Color.Transparent;
            buttonCerrarJuego.BackgroundImage = (Image)resources.GetObject("buttonCerrarJuego.BackgroundImage");
            buttonCerrarJuego.BackgroundImageLayout = ImageLayout.None;
            buttonCerrarJuego.Cursor = Cursors.Hand;
            buttonCerrarJuego.FlatAppearance.BorderSize = 0;
            buttonCerrarJuego.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonCerrarJuego.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonCerrarJuego.FlatStyle = FlatStyle.Flat;
            buttonCerrarJuego.ForeColor = Color.Transparent;
            buttonCerrarJuego.Location = new Point(1404, 553);
            buttonCerrarJuego.Name = "buttonCerrarJuego";
            buttonCerrarJuego.Size = new Size(284, 92);
            buttonCerrarJuego.TabIndex = 2;
            buttonCerrarJuego.UseVisualStyleBackColor = false;
            buttonCerrarJuego.Click += buttonCerrarJuego_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1576, 963);
            label2.Name = "label2";
            label2.Size = new Size(340, 76);
            label2.TabIndex = 3;
            label2.Text = "JAFERYAC";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1037);
            Controls.Add(label2);
            Controls.Add(buttonCerrarJuego);
            Controls.Add(buttonIniciarJuego);
            Controls.Add(label1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonIniciarJuego;
        private Button buttonCerrarJuego;
        private Label label2;
    }
}

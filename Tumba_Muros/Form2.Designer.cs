namespace Tumba_Muros
{
    partial class escenario2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltiempo = new System.Windows.Forms.Label();
            this.lblvidas = new System.Windows.Forms.Label();
            this.lblpuntaje = new System.Windows.Forms.Label();
            this.timerPelota = new System.Windows.Forms.Timer(this.components);
            this.timertiempo = new System.Windows.Forms.Timer(this.components);
            this.timervida = new System.Windows.Forms.Timer(this.components);
            this.timerRecompensa = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(552, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nivel: 2";
            // 
            // lbltiempo
            // 
            this.lbltiempo.AutoSize = true;
            this.lbltiempo.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltiempo.ForeColor = System.Drawing.Color.Transparent;
            this.lbltiempo.Location = new System.Drawing.Point(552, 106);
            this.lbltiempo.Name = "lbltiempo";
            this.lbltiempo.Size = new System.Drawing.Size(71, 18);
            this.lbltiempo.TabIndex = 6;
            this.lbltiempo.Text = "Tiempo: 0";
            // 
            // lblvidas
            // 
            this.lblvidas.AutoSize = true;
            this.lblvidas.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvidas.ForeColor = System.Drawing.Color.Transparent;
            this.lblvidas.Location = new System.Drawing.Point(552, 74);
            this.lblvidas.Name = "lblvidas";
            this.lblvidas.Size = new System.Drawing.Size(60, 18);
            this.lblvidas.TabIndex = 5;
            this.lblvidas.Text = "Vidas: 3";
            // 
            // lblpuntaje
            // 
            this.lblpuntaje.AutoSize = true;
            this.lblpuntaje.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpuntaje.ForeColor = System.Drawing.Color.Transparent;
            this.lblpuntaje.Location = new System.Drawing.Point(552, 42);
            this.lblpuntaje.Name = "lblpuntaje";
            this.lblpuntaje.Size = new System.Drawing.Size(74, 18);
            this.lblpuntaje.TabIndex = 4;
            this.lblpuntaje.Text = "Puntaje: 0";
            // 
            // timerPelota
            // 
            this.timerPelota.Enabled = true;
            this.timerPelota.Interval = 15;
            this.timerPelota.Tick += new System.EventHandler(this.timerPelota_Tick);
            // 
            // timertiempo
            // 
            this.timertiempo.Enabled = true;
            this.timertiempo.Interval = 1000;
            this.timertiempo.Tick += new System.EventHandler(this.timertiempo_Tick);
            // 
            // timervida
            // 
            this.timervida.Enabled = true;
            this.timervida.Interval = 90;
            this.timervida.Tick += new System.EventHandler(this.timervida_Tick);
            // 
            // timerRecompensa
            // 
            this.timerRecompensa.Enabled = true;
            this.timerRecompensa.Interval = 40;
            this.timerRecompensa.Tick += new System.EventHandler(this.timerRecompensa_Tick);
            // 
            // escenario2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Tumba_Muros.Properties.Resources.FONDO2;
            this.ClientSize = new System.Drawing.Size(648, 468);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltiempo);
            this.Controls.Add(this.lblvidas);
            this.Controls.Add(this.lblpuntaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "escenario2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tumba Muros";
            this.Load += new System.EventHandler(this.escenario2_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.escenario_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltiempo;
        private System.Windows.Forms.Label lblvidas;
        private System.Windows.Forms.Label lblpuntaje;
        private System.Windows.Forms.Timer timerPelota;
        private System.Windows.Forms.Timer timertiempo;
        private System.Windows.Forms.Timer timervida;
        private System.Windows.Forms.Timer timerRecompensa;
    }
}
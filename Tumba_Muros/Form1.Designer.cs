namespace Tumba_Muros
{
    partial class escenario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerPelota = new System.Windows.Forms.Timer(this.components);
            this.lblpuntaje = new System.Windows.Forms.Label();
            this.lblvidas = new System.Windows.Forms.Label();
            this.lbltiempo = new System.Windows.Forms.Label();
            this.timertiempo = new System.Windows.Forms.Timer(this.components);
            this.timervida = new System.Windows.Forms.Timer(this.components);
            this.timerRecompensa = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerPelota
            // 
            this.timerPelota.Enabled = true;
            this.timerPelota.Interval = 25;
            this.timerPelota.Tick += new System.EventHandler(this.timerPelota_Tick);
            // 
            // lblpuntaje
            // 
            this.lblpuntaje.AutoSize = true;
            this.lblpuntaje.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpuntaje.ForeColor = System.Drawing.Color.Transparent;
            this.lblpuntaje.Location = new System.Drawing.Point(552, 45);
            this.lblpuntaje.Name = "lblpuntaje";
            this.lblpuntaje.Size = new System.Drawing.Size(74, 18);
            this.lblpuntaje.TabIndex = 0;
            this.lblpuntaje.Text = "Puntaje: 0";
            // 
            // lblvidas
            // 
            this.lblvidas.AutoSize = true;
            this.lblvidas.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvidas.ForeColor = System.Drawing.Color.Transparent;
            this.lblvidas.Location = new System.Drawing.Point(552, 77);
            this.lblvidas.Name = "lblvidas";
            this.lblvidas.Size = new System.Drawing.Size(60, 18);
            this.lblvidas.TabIndex = 1;
            this.lblvidas.Text = "Vidas: 3";
            // 
            // lbltiempo
            // 
            this.lbltiempo.AutoSize = true;
            this.lbltiempo.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltiempo.ForeColor = System.Drawing.Color.Transparent;
            this.lbltiempo.Location = new System.Drawing.Point(552, 109);
            this.lbltiempo.Name = "lbltiempo";
            this.lbltiempo.Size = new System.Drawing.Size(71, 18);
            this.lbltiempo.TabIndex = 2;
            this.lbltiempo.Text = "Tiempo: 0";
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
            this.timervida.Tick += new System.EventHandler(this.timervida_Tick);
            // 
            // timerRecompensa
            // 
            this.timerRecompensa.Enabled = true;
            this.timerRecompensa.Interval = 40;
            this.timerRecompensa.Tick += new System.EventHandler(this.timerRecompensa_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(552, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nivel: 1";
            // 
            // escenario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Tumba_Muros.Properties.Resources.FONDO1;
            this.ClientSize = new System.Drawing.Size(648, 468);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltiempo);
            this.Controls.Add(this.lblvidas);
            this.Controls.Add(this.lblpuntaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "escenario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tumba Muros";
            this.Load += new System.EventHandler(this.escenario_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.escenario_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerPelota;
        private System.Windows.Forms.Label lblpuntaje;
        private System.Windows.Forms.Label lblvidas;
        private System.Windows.Forms.Label lbltiempo;
        private System.Windows.Forms.Timer timertiempo;
        private System.Windows.Forms.Timer timervida;
        private System.Windows.Forms.Timer timerRecompensa;
        private System.Windows.Forms.Label label1;
    }
}


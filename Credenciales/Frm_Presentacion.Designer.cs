namespace Credenciales
{
    partial class Frm_Presentacion
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Seleccionar = new System.Windows.Forms.Button();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Btn_Continuar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 108);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Seleccionar
            // 
            this.Btn_Seleccionar.BackColor = System.Drawing.Color.MidnightBlue;
            this.Btn_Seleccionar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Seleccionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Seleccionar.Location = new System.Drawing.Point(462, 408);
            this.Btn_Seleccionar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Seleccionar.Name = "Btn_Seleccionar";
            this.Btn_Seleccionar.Size = new System.Drawing.Size(264, 75);
            this.Btn_Seleccionar.TabIndex = 4;
            this.Btn_Seleccionar.Text = "Seleccionar archivo";
            this.Btn_Seleccionar.UseVisualStyleBackColor = false;
            this.Btn_Seleccionar.Click += new System.EventHandler(this.Btn_Seleccionar_Click);
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Lbl_Titulo.Location = new System.Drawing.Point(6, 126);
            this.Lbl_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(1187, 57);
            this.Lbl_Titulo.TabIndex = 5;
            this.Lbl_Titulo.Text = "Bienvenido, selecciona porfavor el archivo que  contiene los datos";
            this.Lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Continuar
            // 
            this.Btn_Continuar.BackColor = System.Drawing.Color.MidnightBlue;
            this.Btn_Continuar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Continuar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Continuar.Location = new System.Drawing.Point(496, 518);
            this.Btn_Continuar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Continuar.Name = "Btn_Continuar";
            this.Btn_Continuar.Size = new System.Drawing.Size(189, 75);
            this.Btn_Continuar.TabIndex = 6;
            this.Btn_Continuar.Text = "Continuar";
            this.Btn_Continuar.UseVisualStyleBackColor = false;
            this.Btn_Continuar.Click += new System.EventHandler(this.Btn_Continuar_Click);
            // 
            // Frm_Presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1197, 612);
            this.Controls.Add(this.Btn_Continuar);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Btn_Seleccionar);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Presentacion";
            this.Text = "Frm_Presentacion";
            this.Load += new System.EventHandler(this.Frm_Presentacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button Btn_Seleccionar;
        private System.Windows.Forms.Label Lbl_Titulo;
        public System.Windows.Forms.Button Btn_Continuar;
    }
}
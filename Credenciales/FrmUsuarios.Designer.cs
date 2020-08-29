namespace Credenciales
{
    partial class Frm_usuarios
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
            this.Dgv_Miembros = new System.Windows.Forms.DataGridView();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Detalles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Miembros)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Miembros
            // 
            this.Dgv_Miembros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Miembros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Miembros.Location = new System.Drawing.Point(1, 0);
            this.Dgv_Miembros.Name = "Dgv_Miembros";
            this.Dgv_Miembros.ReadOnly = true;
            this.Dgv_Miembros.Size = new System.Drawing.Size(857, 334);
            this.Dgv_Miembros.TabIndex = 0;
            this.Dgv_Miembros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Miembros_CellContentClick);
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.BackColor = System.Drawing.Color.Navy;
            this.Btn_Actualizar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Actualizar.Location = new System.Drawing.Point(26, 367);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(151, 39);
            this.Btn_Actualizar.TabIndex = 2;
            this.Btn_Actualizar.Text = "Actualizar";
            this.Btn_Actualizar.UseVisualStyleBackColor = false;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // Btn_Detalles
            // 
            this.Btn_Detalles.BackColor = System.Drawing.Color.Navy;
            this.Btn_Detalles.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Detalles.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Detalles.Location = new System.Drawing.Point(214, 367);
            this.Btn_Detalles.Name = "Btn_Detalles";
            this.Btn_Detalles.Size = new System.Drawing.Size(151, 39);
            this.Btn_Detalles.TabIndex = 3;
            this.Btn_Detalles.Text = "Detalles";
            this.Btn_Detalles.UseVisualStyleBackColor = false;
            this.Btn_Detalles.Click += new System.EventHandler(this.Btn_Detalles_Click);
            // 
            // Frm_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 477);
            this.Controls.Add(this.Btn_Detalles);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Dgv_Miembros);
            this.Name = "Frm_usuarios";
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.Frm_usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Miembros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Miembros;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_Detalles;
    }
}
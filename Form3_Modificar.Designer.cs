namespace Practica7
{
    partial class Form3_Modificar
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
            this.lbl_nomModificar = new System.Windows.Forms.Label();
            this.lbl_passModificar = new System.Windows.Forms.Label();
            this.txtBox_nomModificar = new System.Windows.Forms.TextBox();
            this.txtBox_passModificar = new System.Windows.Forms.TextBox();
            this.txtBox_idBuscar = new System.Windows.Forms.TextBox();
            this.lbl_idBuscar = new System.Windows.Forms.Label();
            this.btn_GuardarModificacion = new System.Windows.Forms.Button();
            this.lbl_TituloModificacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_nomModificar
            // 
            this.lbl_nomModificar.AutoSize = true;
            this.lbl_nomModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomModificar.Location = new System.Drawing.Point(103, 190);
            this.lbl_nomModificar.Name = "lbl_nomModificar";
            this.lbl_nomModificar.Size = new System.Drawing.Size(126, 20);
            this.lbl_nomModificar.TabIndex = 0;
            this.lbl_nomModificar.Text = "Nuevo Nombre";
            // 
            // lbl_passModificar
            // 
            this.lbl_passModificar.AutoSize = true;
            this.lbl_passModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passModificar.Location = new System.Drawing.Point(87, 255);
            this.lbl_passModificar.Name = "lbl_passModificar";
            this.lbl_passModificar.Size = new System.Drawing.Size(141, 20);
            this.lbl_passModificar.TabIndex = 1;
            this.lbl_passModificar.Text = "Nuevo Password";
            // 
            // txtBox_nomModificar
            // 
            this.txtBox_nomModificar.Location = new System.Drawing.Point(246, 187);
            this.txtBox_nomModificar.Multiline = true;
            this.txtBox_nomModificar.Name = "txtBox_nomModificar";
            this.txtBox_nomModificar.Size = new System.Drawing.Size(215, 30);
            this.txtBox_nomModificar.TabIndex = 2;
            // 
            // txtBox_passModificar
            // 
            this.txtBox_passModificar.Location = new System.Drawing.Point(246, 251);
            this.txtBox_passModificar.Multiline = true;
            this.txtBox_passModificar.Name = "txtBox_passModificar";
            this.txtBox_passModificar.Size = new System.Drawing.Size(215, 30);
            this.txtBox_passModificar.TabIndex = 3;
            // 
            // txtBox_idBuscar
            // 
            this.txtBox_idBuscar.Location = new System.Drawing.Point(246, 126);
            this.txtBox_idBuscar.Multiline = true;
            this.txtBox_idBuscar.Name = "txtBox_idBuscar";
            this.txtBox_idBuscar.Size = new System.Drawing.Size(215, 30);
            this.txtBox_idBuscar.TabIndex = 4;
            this.txtBox_idBuscar.TextChanged += new System.EventHandler(this.TxtBox_idBuscar_TextChanged);
            // 
            // lbl_idBuscar
            // 
            this.lbl_idBuscar.AutoSize = true;
            this.lbl_idBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idBuscar.Location = new System.Drawing.Point(142, 129);
            this.lbl_idBuscar.Name = "lbl_idBuscar";
            this.lbl_idBuscar.Size = new System.Drawing.Size(86, 20);
            this.lbl_idBuscar.TabIndex = 5;
            this.lbl_idBuscar.Text = "Id Buscar";
            // 
            // btn_GuardarModificacion
            // 
            this.btn_GuardarModificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarModificacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_GuardarModificacion.Location = new System.Drawing.Point(277, 322);
            this.btn_GuardarModificacion.Name = "btn_GuardarModificacion";
            this.btn_GuardarModificacion.Size = new System.Drawing.Size(147, 64);
            this.btn_GuardarModificacion.TabIndex = 6;
            this.btn_GuardarModificacion.Text = "Guardar";
            this.btn_GuardarModificacion.UseVisualStyleBackColor = true;
            this.btn_GuardarModificacion.Click += new System.EventHandler(this.Btn_GuardarModificacion_Click);
            // 
            // lbl_TituloModificacion
            // 
            this.lbl_TituloModificacion.AutoSize = true;
            this.lbl_TituloModificacion.Font = new System.Drawing.Font("Bell MT", 26.25F, System.Drawing.FontStyle.Bold);
            this.lbl_TituloModificacion.Location = new System.Drawing.Point(206, 34);
            this.lbl_TituloModificacion.Name = "lbl_TituloModificacion";
            this.lbl_TituloModificacion.Size = new System.Drawing.Size(270, 40);
            this.lbl_TituloModificacion.TabIndex = 7;
            this.lbl_TituloModificacion.Text = "Modificar Datos";
            // 
            // Form3_Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.lbl_TituloModificacion);
            this.Controls.Add(this.btn_GuardarModificacion);
            this.Controls.Add(this.lbl_idBuscar);
            this.Controls.Add(this.txtBox_idBuscar);
            this.Controls.Add(this.txtBox_passModificar);
            this.Controls.Add(this.txtBox_nomModificar);
            this.Controls.Add(this.lbl_passModificar);
            this.Controls.Add(this.lbl_nomModificar);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form3_Modificar";
            this.Text = "Form3_Modificar";
            this.Load += new System.EventHandler(this.Form3_Modificar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nomModificar;
        private System.Windows.Forms.Label lbl_passModificar;
        private System.Windows.Forms.TextBox txtBox_nomModificar;
        private System.Windows.Forms.TextBox txtBox_passModificar;
        private System.Windows.Forms.TextBox txtBox_idBuscar;
        private System.Windows.Forms.Label lbl_idBuscar;
        private System.Windows.Forms.Button btn_GuardarModificacion;
        private System.Windows.Forms.Label lbl_TituloModificacion;
    }
}
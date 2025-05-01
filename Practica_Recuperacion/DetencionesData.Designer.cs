namespace Practica_Recuperacion
{
    partial class DetencionesData
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DTPFecha = new System.Windows.Forms.DateTimePicker();
            this.NUPTotal = new System.Windows.Forms.NumericUpDown();
            this.NUPEstudianteID = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CBMotivo = new System.Windows.Forms.ComboBox();
            this.CBTipo = new System.Windows.Forms.ComboBox();
            this.BGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUPTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUPEstudianteID)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Congenial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Estudiante UID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Congenial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Congenial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total:";
            // 
            // DTPFecha
            // 
            this.DTPFecha.Font = new System.Drawing.Font("Congenial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFecha.Location = new System.Drawing.Point(103, 55);
            this.DTPFecha.Name = "DTPFecha";
            this.DTPFecha.Size = new System.Drawing.Size(381, 30);
            this.DTPFecha.TabIndex = 14;
            // 
            // NUPTotal
            // 
            this.NUPTotal.Font = new System.Drawing.Font("Congenial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUPTotal.Location = new System.Drawing.Point(92, 91);
            this.NUPTotal.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUPTotal.Name = "NUPTotal";
            this.NUPTotal.Size = new System.Drawing.Size(126, 30);
            this.NUPTotal.TabIndex = 15;
            // 
            // NUPEstudianteID
            // 
            this.NUPEstudianteID.Font = new System.Drawing.Font("Congenial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUPEstudianteID.Location = new System.Drawing.Point(199, 17);
            this.NUPEstudianteID.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NUPEstudianteID.Name = "NUPEstudianteID";
            this.NUPEstudianteID.Size = new System.Drawing.Size(95, 30);
            this.NUPEstudianteID.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Congenial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "Estado:";
            // 
            // CBEstado
            // 
            this.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstado.Font = new System.Drawing.Font("Congenial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Items.AddRange(new object[] {
            "Abierta",
            "Cerrada"});
            this.CBEstado.Location = new System.Drawing.Point(330, 91);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(154, 31);
            this.CBEstado.Sorted = true;
            this.CBEstado.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Congenial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "Motivo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Congenial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Tipo:";
            // 
            // CBMotivo
            // 
            this.CBMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMotivo.Font = new System.Drawing.Font("Congenial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMotivo.FormattingEnabled = true;
            this.CBMotivo.Items.AddRange(new object[] {
            "Asignaciones Incompletas",
            "Ausencias ",
            "Infracciones repetidas",
            "Mal comportamiento ",
            "Saltar clases",
            "Tardanzas",
            "Uso del celular"});
            this.CBMotivo.Location = new System.Drawing.Point(116, 124);
            this.CBMotivo.Name = "CBMotivo";
            this.CBMotivo.Size = new System.Drawing.Size(368, 31);
            this.CBMotivo.Sorted = true;
            this.CBMotivo.TabIndex = 21;
            // 
            // CBTipo
            // 
            this.CBTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTipo.Font = new System.Drawing.Font("Congenial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTipo.FormattingEnabled = true;
            this.CBTipo.Items.AddRange(new object[] {
            "Detención durante el almuerzo",
            "Detención en clase",
            "Notificación a los padres"});
            this.CBTipo.Location = new System.Drawing.Point(92, 161);
            this.CBTipo.Name = "CBTipo";
            this.CBTipo.Size = new System.Drawing.Size(392, 31);
            this.CBTipo.Sorted = true;
            this.CBTipo.TabIndex = 22;
            // 
            // BGuardar
            // 
            this.BGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BGuardar.Font = new System.Drawing.Font("Congenial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardar.Location = new System.Drawing.Point(158, 214);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(152, 50);
            this.BGuardar.TabIndex = 23;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // DetencionesData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 292);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.CBTipo);
            this.Controls.Add(this.CBMotivo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NUPEstudianteID);
            this.Controls.Add(this.NUPTotal);
            this.Controls.Add(this.DTPFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DetencionesData";
            this.Text = "Añadir/Editar Detenciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DetencionesData_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.NUPTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUPEstudianteID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTPFecha;
        private System.Windows.Forms.NumericUpDown NUPTotal;
        private System.Windows.Forms.NumericUpDown NUPEstudianteID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBMotivo;
        private System.Windows.Forms.ComboBox CBTipo;
        private System.Windows.Forms.Button BGuardar;
    }
}
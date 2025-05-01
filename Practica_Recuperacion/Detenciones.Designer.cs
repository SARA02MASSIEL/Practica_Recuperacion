namespace Practica_Recuperacion
{
    partial class Detenciones
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BMove = new System.Windows.Forms.Button();
            this.BDelete = new System.Windows.Forms.Button();
            this.BEdit = new System.Windows.Forms.Button();
            this.BAdd = new System.Windows.Forms.Button();
            this.DGVVista = new System.Windows.Forms.DataGridView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVista)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BMove);
            this.splitContainer1.Panel1.Controls.Add(this.BDelete);
            this.splitContainer1.Panel1.Controls.Add(this.BEdit);
            this.splitContainer1.Panel1.Controls.Add(this.BAdd);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DGVVista);
            this.splitContainer1.Size = new System.Drawing.Size(800, 553);
            this.splitContainer1.SplitterDistance = 246;
            this.splitContainer1.TabIndex = 0;
            // 
            // BMove
            // 
            this.BMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.BMove.Font = new System.Drawing.Font("Congenial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMove.Location = new System.Drawing.Point(0, 414);
            this.BMove.Name = "BMove";
            this.BMove.Size = new System.Drawing.Size(246, 138);
            this.BMove.TabIndex = 4;
            this.BMove.Text = "Estudiantes";
            this.BMove.UseVisualStyleBackColor = true;
            this.BMove.Click += new System.EventHandler(this.BMove_Click);
            // 
            // BDelete
            // 
            this.BDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.BDelete.Font = new System.Drawing.Font("Congenial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDelete.Location = new System.Drawing.Point(0, 276);
            this.BDelete.Name = "BDelete";
            this.BDelete.Size = new System.Drawing.Size(246, 138);
            this.BDelete.TabIndex = 3;
            this.BDelete.Text = "Eliminar";
            this.BDelete.UseVisualStyleBackColor = true;
            // 
            // BEdit
            // 
            this.BEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.BEdit.Font = new System.Drawing.Font("Congenial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEdit.Location = new System.Drawing.Point(0, 138);
            this.BEdit.Name = "BEdit";
            this.BEdit.Size = new System.Drawing.Size(246, 138);
            this.BEdit.TabIndex = 2;
            this.BEdit.Text = "Editar";
            this.BEdit.UseVisualStyleBackColor = true;
            // 
            // BAdd
            // 
            this.BAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.BAdd.Font = new System.Drawing.Font("Congenial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAdd.Location = new System.Drawing.Point(0, 0);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(246, 138);
            this.BAdd.TabIndex = 1;
            this.BAdd.Text = "Añadir";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // DGVVista
            // 
            this.DGVVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVVista.Location = new System.Drawing.Point(0, 0);
            this.DGVVista.Name = "DGVVista";
            this.DGVVista.RowHeadersWidth = 51;
            this.DGVVista.RowTemplate.Height = 24;
            this.DGVVista.Size = new System.Drawing.Size(550, 553);
            this.DGVVista.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Detenciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Detenciones";
            this.Text = "Detenciones";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVVista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DGVVista;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Button BEdit;
        private System.Windows.Forms.Button BMove;
        private System.Windows.Forms.Button BDelete;
    }
}


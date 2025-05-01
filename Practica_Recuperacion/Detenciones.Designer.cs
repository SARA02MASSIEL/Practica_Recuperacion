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
            System.Windows.Forms.Button BMove;
            System.Windows.Forms.Button BDelete;
            System.Windows.Forms.Button BEdit;
            System.Windows.Forms.Button BAdd;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DGVVista = new System.Windows.Forms.DataGridView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            BMove = new System.Windows.Forms.Button();
            BDelete = new System.Windows.Forms.Button();
            BEdit = new System.Windows.Forms.Button();
            BAdd = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer1.Panel1.Controls.Add(BMove);
            this.splitContainer1.Panel1.Controls.Add(BDelete);
            this.splitContainer1.Panel1.Controls.Add(BEdit);
            this.splitContainer1.Panel1.Controls.Add(BAdd);
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
            BMove.BackColor = System.Drawing.SystemColors.ControlDark;
            BMove.Dock = System.Windows.Forms.DockStyle.Top;
            BMove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            BMove.Font = new System.Drawing.Font("Congenial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BMove.Location = new System.Drawing.Point(0, 414);
            BMove.Name = "BMove";
            BMove.Size = new System.Drawing.Size(246, 138);
            BMove.TabIndex = 4;
            BMove.Text = "Estudiantes";
            BMove.UseVisualStyleBackColor = false;
            BMove.Click += new System.EventHandler(this.BMove_Click);
            // 
            // BDelete
            // 
            BDelete.BackColor = System.Drawing.SystemColors.ControlDark;
            BDelete.Dock = System.Windows.Forms.DockStyle.Top;
            BDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            BDelete.Font = new System.Drawing.Font("Congenial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BDelete.Location = new System.Drawing.Point(0, 276);
            BDelete.Name = "BDelete";
            BDelete.Size = new System.Drawing.Size(246, 138);
            BDelete.TabIndex = 3;
            BDelete.Text = "Eliminar";
            BDelete.UseVisualStyleBackColor = false;
            // 
            // BEdit
            // 
            BEdit.BackColor = System.Drawing.SystemColors.ControlDark;
            BEdit.Dock = System.Windows.Forms.DockStyle.Top;
            BEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            BEdit.Font = new System.Drawing.Font("Congenial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BEdit.Location = new System.Drawing.Point(0, 138);
            BEdit.Name = "BEdit";
            BEdit.Size = new System.Drawing.Size(246, 138);
            BEdit.TabIndex = 2;
            BEdit.Text = "Editar";
            BEdit.UseVisualStyleBackColor = false;
            // 
            // BAdd
            // 
            BAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            BAdd.Dock = System.Windows.Forms.DockStyle.Top;
            BAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            BAdd.Font = new System.Drawing.Font("Congenial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BAdd.Location = new System.Drawing.Point(0, 0);
            BAdd.Name = "BAdd";
            BAdd.Size = new System.Drawing.Size(246, 138);
            BAdd.TabIndex = 1;
            BAdd.Text = "Añadir";
            BAdd.UseVisualStyleBackColor = false;
            BAdd.Click += new System.EventHandler(this.BAdd_Click);
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
    }
}


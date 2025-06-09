namespace TodoListWinForms
{
    partial class Form1
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
            this.panel = new System.Windows.Forms.Panel();
            this.btnMarcarCompletada = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNuevaTarea = new System.Windows.Forms.TextBox();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "To do list";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dgvTareas);
            this.panel.Location = new System.Drawing.Point(300, 46);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(963, 788);
            this.panel.TabIndex = 1;
            // 
            // btnMarcarCompletada
            // 
            this.btnMarcarCompletada.Location = new System.Drawing.Point(47, 338);
            this.btnMarcarCompletada.Name = "btnMarcarCompletada";
            this.btnMarcarCompletada.Size = new System.Drawing.Size(215, 39);
            this.btnMarcarCompletada.TabIndex = 3;
            this.btnMarcarCompletada.Text = "Marcar/Desmarcar";
            this.btnMarcarCompletada.UseVisualStyleBackColor = true;
            this.btnMarcarCompletada.Click += new System.EventHandler(this.btnMarcarCompletada_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(47, 258);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(215, 39);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar Tarea";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(47, 163);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(215, 39);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar Tarea";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNuevaTarea
            // 
            this.txtNuevaTarea.Location = new System.Drawing.Point(60, 109);
            this.txtNuevaTarea.Name = "txtNuevaTarea";
            this.txtNuevaTarea.Size = new System.Drawing.Size(190, 26);
            this.txtNuevaTarea.TabIndex = 6;
            // 
            // dgvTareas
            // 
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Location = new System.Drawing.Point(3, 3);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.RowHeadersWidth = 62;
            this.dgvTareas.RowTemplate.Height = 28;
            this.dgvTareas.Size = new System.Drawing.Size(957, 784);
            this.dgvTareas.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(47, 424);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(215, 39);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar Tarea";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 884);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtNuevaTarea);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnMarcarCompletada);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnMarcarCompletada;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNuevaTarea;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.Button btnEliminar;
    }
}


namespace ProjectManager_1._0
{
    partial class Servicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servicios));
            this.lblServicios = new System.Windows.Forms.Label();
            this.dataGridNiveles = new System.Windows.Forms.DataGridView();
            this.Id_nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_comercial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridServicios = new System.Windows.Forms.DataGridView();
            this.Id_prodserv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblConsultoria = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_borrar_servicios = new System.Windows.Forms.Button();
            this.btn_guardar_servicios = new System.Windows.Forms.Button();
            this.btn_borrar_niveles = new System.Windows.Forms.Button();
            this.btn_guardar_niveles = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNiveles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServicios)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblServicios
            // 
            this.lblServicios.AutoSize = true;
            this.lblServicios.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblServicios.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblServicios.Location = new System.Drawing.Point(135, 97);
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblServicios.Size = new System.Drawing.Size(619, 48);
            this.lblServicios.TabIndex = 24;
            this.lblServicios.Text = "LISTA DE SERVICIOS:\r\nPara agregar editar o eliminar los servicios hagalo mediante" +
    " la edición directa en la siguiente\r\nlista que se muestra a continuación.";
            // 
            // dataGridNiveles
            // 
            this.dataGridNiveles.AllowUserToAddRows = false;
            this.dataGridNiveles.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridNiveles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridNiveles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNiveles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_nivel,
            this.Nombre_nivel,
            this.Descripcion,
            this.Valor_comercial});
            this.dataGridNiveles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridNiveles.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridNiveles.Location = new System.Drawing.Point(9, 151);
            this.dataGridNiveles.Name = "dataGridNiveles";
            this.dataGridNiveles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridNiveles.Size = new System.Drawing.Size(726, 342);
            this.dataGridNiveles.TabIndex = 23;
            // 
            // Id_nivel
            // 
            this.Id_nivel.HeaderText = "ID";
            this.Id_nivel.Name = "Id_nivel";
            // 
            // Nombre_nivel
            // 
            this.Nombre_nivel.HeaderText = "Nivel";
            this.Nombre_nivel.Name = "Nombre_nivel";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            // 
            // Valor_comercial
            // 
            this.Valor_comercial.HeaderText = "Valor Comercial";
            this.Valor_comercial.Name = "Valor_comercial";
            // 
            // dataGridServicios
            // 
            this.dataGridServicios.AllowUserToAddRows = false;
            this.dataGridServicios.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridServicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_prodserv,
            this.Nombre,
            this.Descripcion_servicio,
            this.Valor_unitario,
            this.Id_moneda});
            this.dataGridServicios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridServicios.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridServicios.Location = new System.Drawing.Point(6, 151);
            this.dataGridServicios.Name = "dataGridServicios";
            this.dataGridServicios.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridServicios.Size = new System.Drawing.Size(726, 342);
            this.dataGridServicios.TabIndex = 25;
            // 
            // Id_prodserv
            // 
            this.Id_prodserv.HeaderText = "ID producto o servicio";
            this.Id_prodserv.Name = "Id_prodserv";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Descripcion_servicio
            // 
            this.Descripcion_servicio.HeaderText = "Descripción";
            this.Descripcion_servicio.Name = "Descripcion_servicio";
            // 
            // Valor_unitario
            // 
            this.Valor_unitario.HeaderText = "Precio unitario";
            this.Valor_unitario.Name = "Valor_unitario";
            // 
            // Id_moneda
            // 
            this.Id_moneda.HeaderText = "Moneda";
            this.Id_moneda.Name = "Id_moneda";
            // 
            // lblConsultoria
            // 
            this.lblConsultoria.AutoSize = true;
            this.lblConsultoria.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lblConsultoria.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblConsultoria.Location = new System.Drawing.Point(135, 100);
            this.lblConsultoria.Name = "lblConsultoria";
            this.lblConsultoria.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblConsultoria.Size = new System.Drawing.Size(596, 48);
            this.lblConsultoria.TabIndex = 26;
            this.lblConsultoria.Text = "TABLA DE NIVELES:\r\nPara agregar editar o eliminar la tabla de niveles hagalo dire" +
    "ctamente en la tabla que se \r\nmuestra a continuación.";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1146, 525);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.btn_borrar_servicios);
            this.tabPage1.Controls.Add(this.btn_guardar_servicios);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dataGridServicios);
            this.tabPage1.Controls.Add(this.lblServicios);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1138, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Servicios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(711, 48);
            this.label2.TabIndex = 26;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_borrar_niveles);
            this.tabPage2.Controls.Add(this.btn_guardar_niveles);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lblConsultoria);
            this.tabPage2.Controls.Add(this.dataGridNiveles);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1138, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Niveles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(704, 32);
            this.label1.TabIndex = 27;
            this.label1.Text = "Los niveles son lsa categorias en las que cada consultor puede existir según su e" +
    "xperiencia y trayectoria\r\nprofesional dentro de SYSCOM Soporte y servicios en T." +
    "I.";
            // 
            // btn_borrar_servicios
            // 
            this.btn_borrar_servicios.Image = global::ProjectManager_1._0.Properties.Resources.icons8_eliminar_50;
            this.btn_borrar_servicios.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_borrar_servicios.Location = new System.Drawing.Point(72, 92);
            this.btn_borrar_servicios.Name = "btn_borrar_servicios";
            this.btn_borrar_servicios.Size = new System.Drawing.Size(57, 53);
            this.btn_borrar_servicios.TabIndex = 27;
            this.btn_borrar_servicios.UseVisualStyleBackColor = true;
            // 
            // btn_guardar_servicios
            // 
            this.btn_guardar_servicios.Image = global::ProjectManager_1._0.Properties.Resources.icons8_guardar_50;
            this.btn_guardar_servicios.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_guardar_servicios.Location = new System.Drawing.Point(9, 92);
            this.btn_guardar_servicios.Name = "btn_guardar_servicios";
            this.btn_guardar_servicios.Size = new System.Drawing.Size(57, 53);
            this.btn_guardar_servicios.TabIndex = 28;
            this.btn_guardar_servicios.UseVisualStyleBackColor = true;
            // 
            // btn_borrar_niveles
            // 
            this.btn_borrar_niveles.Image = global::ProjectManager_1._0.Properties.Resources.icons8_eliminar_50;
            this.btn_borrar_niveles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_borrar_niveles.Location = new System.Drawing.Point(72, 92);
            this.btn_borrar_niveles.Name = "btn_borrar_niveles";
            this.btn_borrar_niveles.Size = new System.Drawing.Size(57, 53);
            this.btn_borrar_niveles.TabIndex = 29;
            this.btn_borrar_niveles.UseVisualStyleBackColor = true;
            // 
            // btn_guardar_niveles
            // 
            this.btn_guardar_niveles.Image = global::ProjectManager_1._0.Properties.Resources.icons8_guardar_50;
            this.btn_guardar_niveles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_guardar_niveles.Location = new System.Drawing.Point(9, 92);
            this.btn_guardar_niveles.Name = "btn_guardar_niveles";
            this.btn_guardar_niveles.Size = new System.Drawing.Size(57, 53);
            this.btn_guardar_niveles.TabIndex = 30;
            this.btn_guardar_niveles.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 474);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1132, 22);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel1.Text = "status";
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 575);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Servicios";
            this.Text = "Servicios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNiveles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServicios)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblServicios;
        private System.Windows.Forms.DataGridView dataGridNiveles;
        private System.Windows.Forms.DataGridView dataGridServicios;
        private System.Windows.Forms.Label lblConsultoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_prodserv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_moneda;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_nivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_nivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_comercial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_borrar_servicios;
        private System.Windows.Forms.Button btn_guardar_servicios;
        private System.Windows.Forms.Button btn_borrar_niveles;
        private System.Windows.Forms.Button btn_guardar_niveles;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}
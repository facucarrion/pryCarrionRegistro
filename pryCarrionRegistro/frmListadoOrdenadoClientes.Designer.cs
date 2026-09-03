namespace pryCarrionRegistro
{
    partial class frmListadoOrdenadoClientes
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
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.lstModo = new System.Windows.Forms.ComboBox();
            this.lstCriterio = new System.Windows.Forms.ComboBox();
            this.lblModo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.btnListar);
            this.gbListado.Controls.Add(this.dgvListado);
            this.gbListado.Controls.Add(this.lstModo);
            this.gbListado.Controls.Add(this.lstCriterio);
            this.gbListado.Controls.Add(this.lblModo);
            this.gbListado.Controls.Add(this.lblCriterio);
            this.gbListado.Location = new System.Drawing.Point(12, 12);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(457, 326);
            this.gbListado.TabIndex = 0;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listar";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(9, 288);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(439, 31);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colLimite,
            this.colDeuda});
            this.dgvListado.Location = new System.Drawing.Point(9, 62);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(439, 220);
            this.dgvListado.TabIndex = 4;
            // 
            // lstModo
            // 
            this.lstModo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstModo.FormattingEnabled = true;
            this.lstModo.Items.AddRange(new object[] {
            "Ascendente",
            "Descendente"});
            this.lstModo.Location = new System.Drawing.Point(283, 22);
            this.lstModo.Name = "lstModo";
            this.lstModo.Size = new System.Drawing.Size(165, 21);
            this.lstModo.TabIndex = 3;
            // 
            // lstCriterio
            // 
            this.lstCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCriterio.FormattingEnabled = true;
            this.lstCriterio.Items.AddRange(new object[] {
            "Código",
            "Nombre",
            "Límite",
            "Deuda"});
            this.lstCriterio.Location = new System.Drawing.Point(52, 22);
            this.lstCriterio.Name = "lstCriterio";
            this.lstCriterio.Size = new System.Drawing.Size(165, 21);
            this.lstCriterio.TabIndex = 2;
            // 
            // lblModo
            // 
            this.lblModo.AutoSize = true;
            this.lblModo.Location = new System.Drawing.Point(243, 25);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(34, 13);
            this.lblModo.TabIndex = 1;
            this.lblModo.Text = "Modo";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(6, 25);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(40, 13);
            this.lblCriterio.TabIndex = 0;
            this.lblCriterio.Text = "Campo";
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colLimite
            // 
            this.colLimite.HeaderText = "Límite de Crédito";
            this.colLimite.Name = "colLimite";
            // 
            // colDeuda
            // 
            this.colDeuda.HeaderText = "Deuda";
            this.colDeuda.Name = "colDeuda";
            // 
            // frmListadoOrdenadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 348);
            this.Controls.Add(this.gbListado);
            this.Name = "frmListadoOrdenadoClientes";
            this.Text = "Listado";
            this.gbListado.ResumeLayout(false);
            this.gbListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.ComboBox lstModo;
        private System.Windows.Forms.ComboBox lstCriterio;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeuda;
    }
}
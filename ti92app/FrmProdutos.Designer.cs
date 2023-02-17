namespace ti92app
{
    partial class FrmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskDesconto = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.Label();
            this.txtCodBar = new System.Windows.Forms.Label();
            this.cmbUn = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Consultar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.chkDescontinuado = new System.Windows.Forms.CheckBox();
            this.MASKDESCONTO = new System.Windows.Forms.MaskedTextBox();
            this.MSKPRECO = new System.Windows.Forms.MaskedTextBox();
            this.TEXTCODBAR = new System.Windows.Forms.TextBox();
            this.CMBUNIDADE = new System.Windows.Forms.ComboBox();
            this.TEXTDESCRICAO = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.dtgProdutos = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodBar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.mskDesconto);
            this.groupBox1.Controls.Add(this.txtPreco);
            this.groupBox1.Controls.Add(this.txtCodBar);
            this.groupBox1.Controls.Add(this.cmbUn);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.Consultar);
            this.groupBox1.Controls.Add(this.Editar);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.chkDescontinuado);
            this.groupBox1.Controls.Add(this.MASKDESCONTO);
            this.groupBox1.Controls.Add(this.MSKPRECO);
            this.groupBox1.Controls.Add(this.TEXTCODBAR);
            this.groupBox1.Controls.Add(this.CMBUNIDADE);
            this.groupBox1.Controls.Add(this.TEXTDESCRICAO);
            this.groupBox1.Controls.Add(this.textId);
            this.groupBox1.Location = new System.Drawing.Point(34, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // mskDesconto
            // 
            this.mskDesconto.AutoSize = true;
            this.mskDesconto.Location = new System.Drawing.Point(407, 85);
            this.mskDesconto.Name = "mskDesconto";
            this.mskDesconto.Size = new System.Drawing.Size(53, 13);
            this.mskDesconto.TabIndex = 17;
            this.mskDesconto.Text = "Desconto";
            // 
            // txtPreco
            // 
            this.txtPreco.AutoSize = true;
            this.txtPreco.Location = new System.Drawing.Point(293, 85);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(35, 13);
            this.txtPreco.TabIndex = 16;
            this.txtPreco.Text = "Preço";
            // 
            // txtCodBar
            // 
            this.txtCodBar.AutoSize = true;
            this.txtCodBar.Location = new System.Drawing.Point(179, 85);
            this.txtCodBar.Name = "txtCodBar";
            this.txtCodBar.Size = new System.Drawing.Size(62, 13);
            this.txtCodBar.TabIndex = 15;
            this.txtCodBar.Text = "Cod. Barras";
            // 
            // cmbUn
            // 
            this.cmbUn.AutoSize = true;
            this.cmbUn.Location = new System.Drawing.Point(65, 85);
            this.cmbUn.Name = "cmbUn";
            this.cmbUn.Size = new System.Drawing.Size(47, 13);
            this.cmbUn.TabIndex = 14;
            this.cmbUn.Text = "Unidade";
            // 
            // txtDesc
            // 
            this.txtDesc.AutoSize = true;
            this.txtDesc.Location = new System.Drawing.Point(179, 41);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(55, 13);
            this.txtDesc.TabIndex = 12;
            this.txtDesc.Text = "Descrição";
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(65, 41);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(18, 13);
            this.txtID.TabIndex = 11;
            this.txtID.Text = "ID";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::ti92app.Properties.Resources.Delete;
            this.btnCancelar.Location = new System.Drawing.Point(521, 161);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 48);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Consultar
            // 
            this.Consultar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consultar.Image = global::ti92app.Properties.Resources.Search;
            this.Consultar.Location = new System.Drawing.Point(372, 161);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(108, 48);
            this.Consultar.TabIndex = 9;
            this.Consultar.Text = "Consultar";
            this.Consultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // Editar
            // 
            this.Editar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editar.Image = global::ti92app.Properties.Resources.Edit;
            this.Editar.Location = new System.Drawing.Point(223, 161);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(108, 48);
            this.Editar.TabIndex = 8;
            this.Editar.Text = "Editar";
            this.Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Image = global::ti92app.Properties.Resources.Add;
            this.btnAdicionar.Location = new System.Drawing.Point(74, 161);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(108, 48);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // chkDescontinuado
            // 
            this.chkDescontinuado.AutoSize = true;
            this.chkDescontinuado.Enabled = false;
            this.chkDescontinuado.Location = new System.Drawing.Point(416, 58);
            this.chkDescontinuado.Name = "chkDescontinuado";
            this.chkDescontinuado.Size = new System.Drawing.Size(98, 17);
            this.chkDescontinuado.TabIndex = 6;
            this.chkDescontinuado.Text = "Descontinuado";
            this.chkDescontinuado.UseVisualStyleBackColor = true;
            // 
            // MASKDESCONTO
            // 
            this.MASKDESCONTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MASKDESCONTO.Location = new System.Drawing.Point(410, 99);
            this.MASKDESCONTO.Name = "MASKDESCONTO";
            this.MASKDESCONTO.Size = new System.Drawing.Size(85, 24);
            this.MASKDESCONTO.TabIndex = 5;
            this.MASKDESCONTO.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // MSKPRECO
            // 
            this.MSKPRECO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSKPRECO.Location = new System.Drawing.Point(296, 99);
            this.MSKPRECO.Name = "MSKPRECO";
            this.MSKPRECO.Size = new System.Drawing.Size(85, 24);
            this.MSKPRECO.TabIndex = 4;
            this.MSKPRECO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MSKPRECO.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // TEXTCODBAR
            // 
            this.TEXTCODBAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEXTCODBAR.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TEXTCODBAR.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TEXTCODBAR.Location = new System.Drawing.Point(182, 99);
            this.TEXTCODBAR.Name = "TEXTCODBAR";
            this.TEXTCODBAR.Size = new System.Drawing.Size(85, 24);
            this.TEXTCODBAR.TabIndex = 3;
            this.TEXTCODBAR.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // CMBUNIDADE
            // 
            this.CMBUNIDADE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBUNIDADE.FormattingEnabled = true;
            this.CMBUNIDADE.Items.AddRange(new object[] {
            "Kilo",
            "Metro",
            "Caixa",
            "Unidade"});
            this.CMBUNIDADE.Location = new System.Drawing.Point(68, 98);
            this.CMBUNIDADE.Name = "CMBUNIDADE";
            this.CMBUNIDADE.Size = new System.Drawing.Size(85, 26);
            this.CMBUNIDADE.TabIndex = 2;
            this.CMBUNIDADE.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TEXTDESCRICAO
            // 
            this.TEXTDESCRICAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEXTDESCRICAO.Location = new System.Drawing.Point(182, 55);
            this.TEXTDESCRICAO.Name = "TEXTDESCRICAO";
            this.TEXTDESCRICAO.Size = new System.Drawing.Size(220, 24);
            this.TEXTDESCRICAO.TabIndex = 0;
            // 
            // textId
            // 
            this.textId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textId.Location = new System.Drawing.Point(68, 55);
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(100, 24);
            this.textId.TabIndex = 1;
            // 
            // dtgProdutos
            // 
            this.dtgProdutos.AllowUserToAddRows = false;
            this.dtgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clmCodBar,
            this.clnDescricao,
            this.clnUnidade,
            this.clnPreco,
            this.clnDesconto,
            this.chkAtivo});
            this.dtgProdutos.Location = new System.Drawing.Point(34, 326);
            this.dtgProdutos.Name = "dtgProdutos";
            this.dtgProdutos.ReadOnly = true;
            this.dtgProdutos.RowHeadersVisible = false;
            this.dtgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProdutos.Size = new System.Drawing.Size(700, 254);
            this.dtgProdutos.TabIndex = 1;
            this.dtgProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProdutos_CellContentClick);
            this.dtgProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProdutos_CellDoubleClick);
            this.dtgProdutos.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dtgProdutos_UserDeletedRow);
            // 
            // clnId
            // 
            this.clnId.Frozen = true;
            this.clnId.HeaderText = "ID";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            this.clnId.Width = 60;
            // 
            // clmCodBar
            // 
            this.clmCodBar.Frozen = true;
            this.clmCodBar.HeaderText = "CODBAR";
            this.clmCodBar.Name = "clmCodBar";
            this.clmCodBar.ReadOnly = true;
            this.clmCodBar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmCodBar.Width = 110;
            // 
            // clnDescricao
            // 
            this.clnDescricao.Frozen = true;
            this.clnDescricao.HeaderText = "DESCRIÇÃO";
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.ReadOnly = true;
            this.clnDescricao.Width = 240;
            // 
            // clnUnidade
            // 
            this.clnUnidade.Frozen = true;
            this.clnUnidade.HeaderText = "UND";
            this.clnUnidade.Name = "clnUnidade";
            this.clnUnidade.ReadOnly = true;
            this.clnUnidade.Width = 50;
            // 
            // clnPreco
            // 
            this.clnPreco.Frozen = true;
            this.clnPreco.HeaderText = "PREÇO";
            this.clnPreco.Name = "clnPreco";
            this.clnPreco.ReadOnly = true;
            this.clnPreco.Width = 90;
            // 
            // clnDesconto
            // 
            this.clnDesconto.Frozen = true;
            this.clnDesconto.HeaderText = "DESCONTO";
            this.clnDesconto.Name = "clnDesconto";
            this.clnDesconto.ReadOnly = true;
            // 
            // chkAtivo
            // 
            this.chkAtivo.Frozen = true;
            this.chkAtivo.HeaderText = "ATIVO";
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.ReadOnly = true;
            this.chkAtivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chkAtivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chkAtivo.Width = 50;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(82, 300);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(652, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "BUSCAR";
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dtgProdutos);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProdutos";
            this.Text = "FrmProdutos";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.CheckBox chkDescontinuado;
        private System.Windows.Forms.MaskedTextBox MASKDESCONTO;
        private System.Windows.Forms.MaskedTextBox MSKPRECO;
        private System.Windows.Forms.TextBox TEXTCODBAR;
        private System.Windows.Forms.ComboBox CMBUNIDADE;
        private System.Windows.Forms.TextBox TEXTDESCRICAO;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label mskDesconto;
        private System.Windows.Forms.Label txtPreco;
        private System.Windows.Forms.Label txtCodBar;
        private System.Windows.Forms.Label cmbUn;
        private System.Windows.Forms.Label txtDesc;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.DataGridView dtgProdutos;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDesconto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkAtivo;
    }
}
namespace WinFormApp
{
    partial class FormPokemons
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPokemons));
            this.dataGridViewPokemons = new System.Windows.Forms.DataGridView();
            this.pictureBoxPokemon = new System.Windows.Forms.PictureBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminarFisico = new System.Windows.Forms.Button();
            this.buttonEliminarLogico = new System.Windows.Forms.Button();
            this.labelNombrePokemon = new System.Windows.Forms.Label();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.buttonFiltro = new System.Windows.Forms.Button();
            this.labelCampo = new System.Windows.Forms.Label();
            this.labelCriterio = new System.Windows.Forms.Label();
            this.labelFiltroAvanzado = new System.Windows.Forms.Label();
            this.comboBoxCampo = new System.Windows.Forms.ComboBox();
            this.comboBoxCriterio = new System.Windows.Forms.ComboBox();
            this.textBoxFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.textBoxFiltroRapido = new System.Windows.Forms.TextBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.groupBoxFiltroAvan = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPokemons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.groupBoxFiltroAvan.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPokemons
            // 
            this.dataGridViewPokemons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPokemons.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPokemons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPokemons.Location = new System.Drawing.Point(12, 189);
            this.dataGridViewPokemons.MultiSelect = false;
            this.dataGridViewPokemons.Name = "dataGridViewPokemons";
            this.dataGridViewPokemons.Size = new System.Drawing.Size(609, 297);
            this.dataGridViewPokemons.TabIndex = 3;
            this.dataGridViewPokemons.SelectionChanged += new System.EventHandler(this.dataGridViewPokemons_SelectionChanged);
            // 
            // pictureBoxPokemon
            // 
            this.pictureBoxPokemon.Location = new System.Drawing.Point(627, 182);
            this.pictureBoxPokemon.Name = "pictureBoxPokemon";
            this.pictureBoxPokemon.Size = new System.Drawing.Size(310, 310);
            this.pictureBoxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPokemon.TabIndex = 1;
            this.pictureBoxPokemon.TabStop = false;
            this.pictureBoxPokemon.Click += new System.EventHandler(this.pictureBoxPokemon_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.Location = new System.Drawing.Point(12, 502);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(84, 31);
            this.buttonAgregar.TabIndex = 4;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Enabled = false;
            this.buttonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.Location = new System.Drawing.Point(113, 502);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(84, 31);
            this.buttonModificar.TabIndex = 5;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminarFisico
            // 
            this.buttonEliminarFisico.Enabled = false;
            this.buttonEliminarFisico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarFisico.Location = new System.Drawing.Point(214, 502);
            this.buttonEliminarFisico.Name = "buttonEliminarFisico";
            this.buttonEliminarFisico.Size = new System.Drawing.Size(125, 31);
            this.buttonEliminarFisico.TabIndex = 6;
            this.buttonEliminarFisico.Text = "Eliminar Pokemon";
            this.buttonEliminarFisico.UseVisualStyleBackColor = true;
            this.buttonEliminarFisico.Click += new System.EventHandler(this.buttonEliminarFisico_Click);
            // 
            // buttonEliminarLogico
            // 
            this.buttonEliminarLogico.Enabled = false;
            this.buttonEliminarLogico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarLogico.Location = new System.Drawing.Point(357, 502);
            this.buttonEliminarLogico.Name = "buttonEliminarLogico";
            this.buttonEliminarLogico.Size = new System.Drawing.Size(144, 31);
            this.buttonEliminarLogico.TabIndex = 7;
            this.buttonEliminarLogico.Text = "Desactivar Pokemon";
            this.buttonEliminarLogico.UseVisualStyleBackColor = true;
            this.buttonEliminarLogico.Click += new System.EventHandler(this.buttonEliminarLogico_Click);
            // 
            // labelNombrePokemon
            // 
            this.labelNombrePokemon.AutoSize = true;
            this.labelNombrePokemon.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombrePokemon.Location = new System.Drawing.Point(733, 495);
            this.labelNombrePokemon.Name = "labelNombrePokemon";
            this.labelNombrePokemon.Size = new System.Drawing.Size(99, 26);
            this.labelNombrePokemon.TabIndex = 0;
            this.labelNombrePokemon.Text = "Pokemon";
            this.labelNombrePokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFiltro
            // 
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltro.Location = new System.Drawing.Point(81, 78);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(87, 16);
            this.labelFiltro.TabIndex = 0;
            this.labelFiltro.Text = "Filtro Rapido:";
            // 
            // buttonFiltro
            // 
            this.buttonFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltro.Location = new System.Drawing.Point(523, 18);
            this.buttonFiltro.Name = "buttonFiltro";
            this.buttonFiltro.Size = new System.Drawing.Size(75, 30);
            this.buttonFiltro.TabIndex = 3;
            this.buttonFiltro.Text = "Buscar";
            this.buttonFiltro.UseVisualStyleBackColor = true;
            this.buttonFiltro.Click += new System.EventHandler(this.buttonFiltro_Click);
            // 
            // labelCampo
            // 
            this.labelCampo.AutoSize = true;
            this.labelCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCampo.Location = new System.Drawing.Point(6, 28);
            this.labelCampo.Name = "labelCampo";
            this.labelCampo.Size = new System.Drawing.Size(54, 16);
            this.labelCampo.TabIndex = 8;
            this.labelCampo.Text = "Campo:";
            // 
            // labelCriterio
            // 
            this.labelCriterio.AutoSize = true;
            this.labelCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCriterio.Location = new System.Drawing.Point(172, 28);
            this.labelCriterio.Name = "labelCriterio";
            this.labelCriterio.Size = new System.Drawing.Size(52, 16);
            this.labelCriterio.TabIndex = 8;
            this.labelCriterio.Text = "Criterio:";
            // 
            // labelFiltroAvanzado
            // 
            this.labelFiltroAvanzado.AutoSize = true;
            this.labelFiltroAvanzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltroAvanzado.Location = new System.Drawing.Point(336, 28);
            this.labelFiltroAvanzado.Name = "labelFiltroAvanzado";
            this.labelFiltroAvanzado.Size = new System.Drawing.Size(75, 16);
            this.labelFiltroAvanzado.TabIndex = 8;
            this.labelFiltroAvanzado.Text = "Buscar por:";
            // 
            // comboBoxCampo
            // 
            this.comboBoxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCampo.FormattingEnabled = true;
            this.comboBoxCampo.Location = new System.Drawing.Point(66, 23);
            this.comboBoxCampo.Name = "comboBoxCampo";
            this.comboBoxCampo.Size = new System.Drawing.Size(100, 21);
            this.comboBoxCampo.TabIndex = 0;
            this.comboBoxCampo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCampo_SelectedIndexChanged);
            // 
            // comboBoxCriterio
            // 
            this.comboBoxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCriterio.FormattingEnabled = true;
            this.comboBoxCriterio.Location = new System.Drawing.Point(230, 23);
            this.comboBoxCriterio.Name = "comboBoxCriterio";
            this.comboBoxCriterio.Size = new System.Drawing.Size(100, 21);
            this.comboBoxCriterio.TabIndex = 1;
            this.comboBoxCriterio.SelectedIndexChanged += new System.EventHandler(this.comboBoxCriterio_SelectedIndexChanged);
            // 
            // textBoxFiltroAvanzado
            // 
            this.textBoxFiltroAvanzado.Location = new System.Drawing.Point(417, 24);
            this.textBoxFiltroAvanzado.Name = "textBoxFiltroAvanzado";
            this.textBoxFiltroAvanzado.Size = new System.Drawing.Size(100, 20);
            this.textBoxFiltroAvanzado.TabIndex = 2;
            this.textBoxFiltroAvanzado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFiltroAvanzado_KeyPress);
            // 
            // textBoxFiltroRapido
            // 
            this.textBoxFiltroRapido.Location = new System.Drawing.Point(174, 76);
            this.textBoxFiltroRapido.Name = "textBoxFiltroRapido";
            this.textBoxFiltroRapido.Size = new System.Drawing.Size(150, 20);
            this.textBoxFiltroRapido.TabIndex = 1;
            this.textBoxFiltroRapido.TextChanged += new System.EventHandler(this.textBoxFiltroRapido_TextChanged);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Pokedex.Properties.Resources.Poké_Ball_icon_svg;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 30);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(63, 64);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 9;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(81, 39);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTitulo.Size = new System.Drawing.Size(92, 26);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Pokedex";
            // 
            // groupBoxFiltroAvan
            // 
            this.groupBoxFiltroAvan.Controls.Add(this.buttonFiltro);
            this.groupBoxFiltroAvan.Controls.Add(this.textBoxFiltroAvanzado);
            this.groupBoxFiltroAvan.Controls.Add(this.labelCampo);
            this.groupBoxFiltroAvan.Controls.Add(this.comboBoxCampo);
            this.groupBoxFiltroAvan.Controls.Add(this.labelCriterio);
            this.groupBoxFiltroAvan.Controls.Add(this.comboBoxCriterio);
            this.groupBoxFiltroAvan.Controls.Add(this.labelFiltroAvanzado);
            this.groupBoxFiltroAvan.Location = new System.Drawing.Point(12, 127);
            this.groupBoxFiltroAvan.Name = "groupBoxFiltroAvan";
            this.groupBoxFiltroAvan.Size = new System.Drawing.Size(609, 58);
            this.groupBoxFiltroAvan.TabIndex = 2;
            this.groupBoxFiltroAvan.TabStop = false;
            this.groupBoxFiltroAvan.Text = "Filtro Avanzado";
            // 
            // FormPokemons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(949, 563);
            this.Controls.Add(this.groupBoxFiltroAvan);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.textBoxFiltroRapido);
            this.Controls.Add(this.labelFiltro);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelNombrePokemon);
            this.Controls.Add(this.buttonEliminarLogico);
            this.Controls.Add(this.buttonEliminarFisico);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.pictureBoxPokemon);
            this.Controls.Add(this.dataGridViewPokemons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(871, 366);
            this.Name = "FormPokemons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokedex © Godoy Nicolas";
            this.Load += new System.EventHandler(this.FormPokemons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPokemons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.groupBoxFiltroAvan.ResumeLayout(false);
            this.groupBoxFiltroAvan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPokemons;
        private System.Windows.Forms.PictureBox pictureBoxPokemon;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminarFisico;
        private System.Windows.Forms.Button buttonEliminarLogico;
        private System.Windows.Forms.Label labelNombrePokemon;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.Button buttonFiltro;
        private System.Windows.Forms.Label labelCampo;
        private System.Windows.Forms.Label labelCriterio;
        private System.Windows.Forms.Label labelFiltroAvanzado;
        private System.Windows.Forms.ComboBox comboBoxCampo;
        private System.Windows.Forms.ComboBox comboBoxCriterio;
        private System.Windows.Forms.TextBox textBoxFiltroAvanzado;
        private System.Windows.Forms.TextBox textBoxFiltroRapido;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.GroupBox groupBoxFiltroAvan;
    }
}


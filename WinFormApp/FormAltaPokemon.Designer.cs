namespace WinFormApp
{
    partial class FormAltaPokemon
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
            this.labelNumero = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelDebilidad = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.comboBoxDebilidad = new System.Windows.Forms.ComboBox();
            this.labelUrlImagen = new System.Windows.Forms.Label();
            this.textBoxUrlImagen = new System.Windows.Forms.TextBox();
            this.pictureBoxPokemon = new System.Windows.Forms.PictureBox();
            this.buttonAgregarImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(74, 59);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(47, 13);
            this.labelNumero.TabIndex = 0;
            this.labelNumero.Text = "Numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(74, 134);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(66, 13);
            this.labelDescripcion.TabIndex = 0;
            this.labelDescripcion.Text = "Descripcion:";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(167, 52);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(121, 20);
            this.textBoxNumero.TabIndex = 0;
            this.textBoxNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumero_KeyPress);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(167, 78);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(121, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(167, 104);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(121, 43);
            this.textBoxDescripcion.TabIndex = 2;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(53, 262);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 7;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(226, 262);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(74, 187);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(31, 13);
            this.labelTipo.TabIndex = 5;
            this.labelTipo.Text = "Tipo:";
            // 
            // labelDebilidad
            // 
            this.labelDebilidad.AutoSize = true;
            this.labelDebilidad.Location = new System.Drawing.Point(74, 214);
            this.labelDebilidad.Name = "labelDebilidad";
            this.labelDebilidad.Size = new System.Drawing.Size(54, 13);
            this.labelDebilidad.TabIndex = 6;
            this.labelDebilidad.Text = "Debilidad:";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(167, 179);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipo.TabIndex = 5;
            // 
            // comboBoxDebilidad
            // 
            this.comboBoxDebilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDebilidad.FormattingEnabled = true;
            this.comboBoxDebilidad.Location = new System.Drawing.Point(167, 206);
            this.comboBoxDebilidad.Name = "comboBoxDebilidad";
            this.comboBoxDebilidad.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDebilidad.TabIndex = 6;
            // 
            // labelUrlImagen
            // 
            this.labelUrlImagen.AutoSize = true;
            this.labelUrlImagen.Location = new System.Drawing.Point(74, 160);
            this.labelUrlImagen.Name = "labelUrlImagen";
            this.labelUrlImagen.Size = new System.Drawing.Size(87, 13);
            this.labelUrlImagen.TabIndex = 9;
            this.labelUrlImagen.Text = "Url de la Imagen:";
            // 
            // textBoxUrlImagen
            // 
            this.textBoxUrlImagen.Location = new System.Drawing.Point(167, 153);
            this.textBoxUrlImagen.Name = "textBoxUrlImagen";
            this.textBoxUrlImagen.Size = new System.Drawing.Size(121, 20);
            this.textBoxUrlImagen.TabIndex = 3;
            this.textBoxUrlImagen.TextChanged += new System.EventHandler(this.textBoxUrlImagen_TextChanged);
            // 
            // pictureBoxPokemon
            // 
            this.pictureBoxPokemon.Location = new System.Drawing.Point(344, 17);
            this.pictureBoxPokemon.Name = "pictureBoxPokemon";
            this.pictureBoxPokemon.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPokemon.TabIndex = 10;
            this.pictureBoxPokemon.TabStop = false;
            // 
            // buttonAgregarImagen
            // 
            this.buttonAgregarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarImagen.Location = new System.Drawing.Point(294, 153);
            this.buttonAgregarImagen.Name = "buttonAgregarImagen";
            this.buttonAgregarImagen.Size = new System.Drawing.Size(20, 20);
            this.buttonAgregarImagen.TabIndex = 4;
            this.buttonAgregarImagen.Text = "+";
            this.buttonAgregarImagen.UseVisualStyleBackColor = true;
            this.buttonAgregarImagen.Click += new System.EventHandler(this.buttonAgregarImagen_Click);
            // 
            // FormAltaPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(620, 335);
            this.Controls.Add(this.buttonAgregarImagen);
            this.Controls.Add(this.pictureBoxPokemon);
            this.Controls.Add(this.textBoxUrlImagen);
            this.Controls.Add(this.labelUrlImagen);
            this.Controls.Add(this.comboBoxDebilidad);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.labelDebilidad);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNumero);
            this.MaximizeBox = false;
            this.Name = "FormAltaPokemon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Pokemon";
            this.Load += new System.EventHandler(this.FormAltaPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        public System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelDebilidad;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.ComboBox comboBoxDebilidad;
        private System.Windows.Forms.Label labelUrlImagen;
        private System.Windows.Forms.TextBox textBoxUrlImagen;
        private System.Windows.Forms.PictureBox pictureBoxPokemon;
        private System.Windows.Forms.Button buttonAgregarImagen;
    }
}
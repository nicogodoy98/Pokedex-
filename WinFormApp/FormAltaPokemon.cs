using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;

namespace WinFormApp
{
    public partial class FormAltaPokemon : Form
    {

        private Pokemon pokemon = null;
        private OpenFileDialog archivo = null;

        public FormAltaPokemon()
        {
            InitializeComponent();
        }

        public FormAltaPokemon(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            Text = "Modificar Pokemon";  
        }

        public FormAltaPokemon(Pokemon pokemon, string info) 
        {
            InitializeComponent();
            this.pokemon = pokemon;
            Text = info;
        }

        private void FormAltaPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();

            try 
            {
                comboBoxTipo.DataSource = elementoNegocio.listar();
                comboBoxTipo.ValueMember = "Id";//va a ser el valor clave
                comboBoxTipo.DisplayMember = "Descripcion";// lo que voy a mostrar
                comboBoxDebilidad.DataSource = elementoNegocio.listar();
                comboBoxDebilidad.ValueMember = "Id";
                comboBoxDebilidad.DisplayMember = "Descripcion";
                //Sirve esto para preseleccionar valores cuando estamos modificando

                //PAra que los desplegables comiencen vacios
                comboBoxTipo.SelectedIndex = -1;
                comboBoxDebilidad.SelectedIndex = -1;
                if (pokemon != null) 
                {
                    cargarImagen(pokemon.UrlImagen);
                    textBoxNumero.Text = pokemon.Numero.ToString();
                    textBoxNombre.Text = pokemon.Nombre;
                    textBoxDescripcion.Text = pokemon.Descripcion;
                    textBoxUrlImagen.Text = pokemon.UrlImagen;
                    comboBoxTipo.SelectedValue = pokemon.Tipo.Id;
                    comboBoxDebilidad.SelectedValue = pokemon.Debilidad.Id;
                }
                if (pokemon != null && Text != "Modificar Pokemon")
                {
                    infoPokemon();
                }

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        
        private void infoPokemon() 
        {
            cargarImagen(pokemon.UrlImagen);
            textBoxNumero.Text = pokemon.Numero.ToString();
            textBoxNombre.Text = pokemon.Nombre;
            textBoxDescripcion.Text = pokemon.Descripcion;
            textBoxUrlImagen.Text = pokemon.UrlImagen;
            comboBoxTipo.SelectedValue = pokemon.Tipo.Id;
            comboBoxDebilidad.SelectedValue = pokemon.Debilidad.Id;

            textBoxNumero.Enabled = false;
            textBoxNombre.Enabled = false;
            textBoxDescripcion.Enabled = false;
            textBoxUrlImagen.Enabled = false;
            comboBoxTipo.Enabled = false;
            comboBoxDebilidad.Enabled = false;
            buttonAceptar.Enabled = false;
            buttonAceptar.Visible = false;
            buttonAgregarImagen.Enabled = false;
            buttonAgregarImagen.Visible = false;
            buttonCancelar.Text = "Ok";
        }
        
        private void buttonCancelar_Click(object sender, EventArgs e)
        {//Cuando toque el boton cancelar, se cierra la ventana
            Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            //Creo el objeto poke, porque voy a cargar un pokemon, y necesito que tenga los atributos de un pokemon.
            //Pokemon poke = new Pokemon();
            //Creo el objeto negocio, porque es el que tiene los metodos para trabajar con la base de datos
            PokemonNegocio negocio = new PokemonNegocio();

            try
            {
                if(pokemon == null) 
                    pokemon = new Pokemon();

                if ( textBoxNumero.Text != "" )
                    pokemon.Numero = int.Parse(textBoxNumero.Text);//Convierto el valor que esta en la textBox en un entero, ya que la text box trae un string
                    
                pokemon.Nombre = textBoxNombre.Text;
                pokemon.Descripcion = textBoxDescripcion.Text;
                pokemon.Tipo = (Elemento)comboBoxTipo.SelectedItem;
                pokemon.Debilidad = (Elemento)comboBoxDebilidad.SelectedItem;
                pokemon.UrlImagen = textBoxUrlImagen.Text;

                if(verificacionDatosVacios())
                    return;

                //Tengo los datos guardados en poke
                //ahora tengo que mandarlo a la base de datos usando pokemon negocio

                if (pokemon.Id == 0)
                {
                    negocio.agregar(pokemon);
                    MessageBox.Show("Se agrego exitosamente.");
                }
                else {
                    negocio.modificar(pokemon);
                    MessageBox.Show("Se modifico exitosamente.");
                }

                //Guardo la imagen local
                if(archivo != null && !(textBoxUrlImagen.Text.ToLower().Contains("http")) )
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
                Close();

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        private bool verificacionDatosVacios() 
        {
            if (textBoxNumero.Text == "")
            {
                MessageBox.Show("Tiene que ingresar el Numero del Pokemon.");
                return true;
            }

            if (textBoxNombre.Text == "")
            {
                MessageBox.Show("Tiene que ingresar el Nombre del Pokemon.");
                return true;
            }

            if (comboBoxTipo.SelectedItem == null)
            {
                MessageBox.Show("Tiene que elegir un 'Tipo'.");
                return true;
            }
            if (comboBoxDebilidad.SelectedItem == null)
            {
                MessageBox.Show("Tiene que elegir una 'Debilidad'.");
                return true;
            }
            return false;
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxPokemon.Load(imagen);
            }
            catch
            {
                pictureBoxPokemon.Load("https://cdn-icons-png.flaticon.com/512/13434/13434972.png");
            }
        }

        private void textBoxUrlImagen_TextChanged(object sender, EventArgs e)
        {
            cargarImagen(textBoxUrlImagen.Text);
        }

        private void textBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void buttonAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();//Me permite abrir una ventana de dialogo, una carperta
            archivo.Filter = "jpg|*.jpg;|png|*.png;|Todos los archivos(*.*)|*.*";
            if (archivo.ShowDialog() == DialogResult.OK )
            {
                textBoxUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
                //Hasta aqui levanto la imagen local
            }
        }
    }
}

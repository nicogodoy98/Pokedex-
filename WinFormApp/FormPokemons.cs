using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;


namespace WinFormApp
{
    public partial class FormPokemons : Form
    {
        private List<Pokemon> listaPokemons;
        public FormPokemons()
        {
            InitializeComponent();
        }

        private void cargar() 
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                listaPokemons = negocio.Listar();
                dataGridViewPokemons.DataSource = listaPokemons;
                ocultarColumnas();
                cargarImagen(listaPokemons[0].UrlImagen);
                textBoxFiltroAvanzado.Enabled = false;
                buttonFiltro.Enabled = false;
                buttonModificar.Enabled = false;
                buttonEliminarFisico.Enabled = false;
                buttonEliminarLogico.Enabled = false;
                pictureBoxPokemon.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void ocultarColumnas() 
        {
            dataGridViewPokemons.Columns["UrlImagen"].Visible = false;
            dataGridViewPokemons.Columns["Id"].Visible = false;
        }

        private void FormPokemons_Load(object sender, EventArgs e)
        {
            cargar();
            comboBoxCampo.Items.Add("Número");
            comboBoxCampo.Items.Add("Nombre");
            comboBoxCampo.Items.Add("Descripción");
            comboBoxCampo.Items.Add("Tipo");
            comboBoxCampo.Items.Add("Debilidad");
        }

        private void dataGridViewPokemons_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPokemons.CurrentRow != null)
            {
                Pokemon selecionado = (Pokemon)dataGridViewPokemons.CurrentRow.DataBoundItem;
                cargarImagen(selecionado.UrlImagen);
                labelNombrePokemon.Text = selecionado.Nombre;
                buttonModificar.Enabled = true;
                buttonEliminarFisico.Enabled = true;
                buttonEliminarLogico.Enabled = true;
                pictureBoxPokemon.Enabled = true;
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            //Creo el objeto de la ventana Alta Pokemon
            FormAltaPokemon alta = new FormAltaPokemon();
            alta.ShowDialog();//para que no pueda salir cuando este en la ventana
            cargar();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Pokemon seleccionado;
            seleccionado = (Pokemon)dataGridViewPokemons.CurrentRow.DataBoundItem;
            FormAltaPokemon modificar = new FormAltaPokemon(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void buttonEliminarFisico_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void buttonEliminarLogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }

        private void eliminar(bool logico = false) 
        {
            PokemonNegocio negocio = new PokemonNegocio();
            Pokemon seleccionado;
            try
            {
                seleccionado = (Pokemon)dataGridViewPokemons.CurrentRow.DataBoundItem;
                DialogResult resultado = MessageBox.Show("Desea eliminar a " + seleccionado.Nombre + "?", "Eliminar Pokemon", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if (resultado == DialogResult.Yes)
                {
                    if (logico)
                        negocio.eliminarLogico(seleccionado.Id);
                    else 
                        negocio.eliminarFisico(seleccionado.Id);
                    
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        private void textBoxFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> listaFiltrada;
            string filtro = textBoxFiltroRapido.Text;
            if (filtro.Length >= 1)
            {
                listaFiltrada = listaPokemons.FindAll(pokemon => pokemon.Numero.ToString().Contains(filtro) || pokemon.Nombre.ToLower().Contains(filtro.ToLower()) || (pokemon.Descripcion?.ToLower().Contains(filtro.ToLower()) ?? false) || pokemon.Tipo.Descripcion.ToLower().Contains(filtro.ToLower()));
            }
            else
            {
                listaFiltrada = listaPokemons;
            }

            dataGridViewPokemons.DataSource = null;
            dataGridViewPokemons.DataSource = listaFiltrada;
            ocultarColumnas();
        }
                
        private void buttonFiltro_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();

            try
            {
                
                string campo = comboBoxCampo.SelectedItem.ToString();
                string criterio = comboBoxCriterio.SelectedItem.ToString();
                string filtro = textBoxFiltroAvanzado.Text;
                if (filtro == "")
                {
                    MessageBox.Show("Tiene que poner un numero para buscar.");
                    return;
                }
                    
                dataGridViewPokemons.DataSource = negocio.filtrar(campo, criterio, filtro);

                textBoxFiltroAvanzado.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void comboBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = comboBoxCampo.SelectedItem.ToString();

            if (opcion == "Número")
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Igual a");
                comboBoxCriterio.Items.Add("Menor a");
                comboBoxCriterio.Items.Add("Mayor a");
            }
            else
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Contiene");
                comboBoxCriterio.Items.Add("Empieza con");
                comboBoxCriterio.Items.Add("Termina con");
            }
        }

        private void comboBoxCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxFiltroAvanzado.Enabled = true;
            buttonFiltro.Enabled = true;
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void textBoxFiltroAvanzado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBoxCampo.SelectedItem.ToString() == "Número") 
            {//Valido que no permita ingresar letras
                if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                    e.Handled = true;
            }
        }

        private void pictureBoxPokemon_Click(object sender, EventArgs e)
        {
            Pokemon seleccionado;
            seleccionado = (Pokemon)dataGridViewPokemons.CurrentRow.DataBoundItem;
            FormAltaPokemon pokeInfo = new FormAltaPokemon(seleccionado, "Info de " + seleccionado.Nombre );
            pokeInfo.ShowDialog();
            cargar();
        }
    }
}

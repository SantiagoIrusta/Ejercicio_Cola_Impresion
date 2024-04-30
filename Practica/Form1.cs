namespace Practica
{
    public partial class Form1 : Form
    {
        Cola baja = new Cola();
        Cola media = new Cola();
        Cola alta = new Cola();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtArchivo.Clear();

            cboPrioridad.Items.Clear();

            cboPrioridad.Items.Add("Baja");
            cboPrioridad.Items.Add("Media");
            cboPrioridad.Items.Add("Alta");

            cboPrioridad.SelectedIndex = 0;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtArchivo.Text))
            {
                Nodo nuevo = new Nodo(txtArchivo.Text, cboPrioridad.Text);
                switch (cboPrioridad.SelectedIndex)
                {
                    case 0:
                        baja.insertar(nuevo);
                        baja.listar(lstBaja);
                        break;

                    case 1:
                        media.insertar(nuevo);
                        media.listar(lstMedia);
                        break;

                    case 2:
                        alta.insertar(nuevo);
                        alta.listar(lstAlta);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Debe completar el campo ARCHIVO");
            }
        }

        private void btnTomar_Click(object sender, EventArgs e)
        {
            


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (alta.inicio != null)
            {
                alta.eliminar();
                alta.listar(lstAlta);
            }
            else
            {
                if (media.inicio != null)
                {
                    media.eliminar();
                    media.listar(lstMedia);
                }
                else
                {
                    if (baja.inicio != null)
                    {
                        baja.eliminar();
                        baja.listar(lstBaja);
                    }
                }
            }

        }


    }
}
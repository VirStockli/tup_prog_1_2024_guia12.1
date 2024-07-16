using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6.Factura
{
    public partial class Principal : Form
    {
        
        public Principal()
        {
            InitializeComponent();
            Codigos[0] = 10023;
            Codigos[1] = 10024;
            Codigos[2] = 10025;
            Codigos[3] = 10026;
            Codigos[4] = 10027;

            Precio[0] = 5000;
            Precio[1] = 15000;
            Precio[2] = 10000;
            Precio[3] = 35000;
            Precio[4] = 25000;

        }

        #region variables
        const int prueba = 5;
        const int pruebaItems = 10;

        string[] Nombres = new string[prueba];
        int cantNom = 0;
        int[] Codigos = new int[pruebaItems];
        int[] Precio = new int[pruebaItems];
        int Contador = pruebaItems;
        double SumTotal = 0;
        #endregion

        //método para cargar items a la factura
        public int BuscarItems(int buscado)
        {
            int pos = -1;
            for (int i = 0; i < Contador; i++)
            { if (buscado == Codigos[i])
                {
                    pos = i;
                }
            }
            return pos;
        }

        public void btnFacturar_Click(object sender, EventArgs e)
        {
            RegistrarVenta ventana = new RegistrarVenta();
            double total = 0;
            double sumCliente = 0;
            string Nombre = "p";
            while (ventana.ShowDialog() == DialogResult.Retry)
            {

                Nombre = ventana.tbNombre.Text;
                
                int codigo = Convert.ToInt32(ventana.tbCodigo.Text);
                int cantidad = Convert.ToInt32(ventana.tbCantidad.Text);
                
                int pos = BuscarItems(codigo);

                if (pos != -1)
                {
                    total = Precio[pos] * cantidad;
                    ventana.lbPrecio.Text = $"U$S {Precio[pos]}";
                    ventana.lbTotal.Text = $"U$S {total}";
                    sumCliente += total;
                    lbFactura.Items.Add($"Cod.{Codigos[pos]} - Cant: {cantidad} - U$S{total}");
                }
                else
                {
                    MessageBox.Show("Código inexistente");
                }

            }

            if (ventana.ShowDialog() == DialogResult.OK)
            {
                lbFactura.Items.Add($"Cliente: \n {Nombre} - Total a Pagar {sumCliente}");
                SumTotal += sumCliente;
            }
            
            if (ventana.ShowDialog() == DialogResult.Cancel)
            {
                lbFactura.Items.Clear();
            }
        }

        public void btnVerRec_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Total Recaudado {SumTotal}");
        }
    }
}

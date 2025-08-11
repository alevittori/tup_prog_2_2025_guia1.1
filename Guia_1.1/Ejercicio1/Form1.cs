using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalularCosto_Click(object sender, EventArgs e)
        {
            // validar que ingresen datos correctos
            string marca = tb_marca.Text;
            int modelo = int.Parse(tb_modelo.Text);
            int anoACalcular = int.Parse(tb_anoCalcular.Text);
            double tasa = double.Parse(tb_tasaDepre.Text);
            int vidaUtil = int.Parse(tb_vidaUtil.Text);
            double valorFabrica = double.Parse(tb_valorFabrica.Text);

            Moto unaMoto = new Moto(marca, modelo, valorFabrica);

            double depreLineal = unaMoto.CalcularDrepreciacionLineal(anoACalcular, vidaUtil);
            double depreAnual = unaMoto.CalcularDrepeciacionAnual(anoACalcular, tasa);

            FResultado VResultado = new FResultado();

            VResultado.listB_resultado.Items.Clear();
            VResultado.listB_resultado.Items.Add(unaMoto.VerDescripcion());
            VResultado.listB_resultado.Items.Add($"Depreciacion Lineal: {depreLineal:c}");
            VResultado.listB_resultado.Items.Add($"Depreciacion Anual: {depreAnual:c}");

            VResultado.Show();

            tb_anoCalcular.Clear();
            tb_tasaDepre.Clear();
            tb_vidaUtil.Clear();
            tb_valorFabrica.Clear();
            tb_marca.Clear();
            tb_modelo.Clear();





        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GRACIAS POR USAR NUESTRO SISTEMA");
            Close();
        }
    }
}

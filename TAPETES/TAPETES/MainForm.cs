using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TAPETES
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        void BtnCalcularClick(object sender, EventArgs e) 
        {
            try
            { 
                // Obtener valores ingresados
                decimal largo = decimal.Parse(txtLargo.Text);
                decimal ancho = decimal.Parse(txtAncho.Text);
                decimal costoAserrin = decimal.Parse(txtCosto.Text);
                decimal cantidadAserrin = decimal.Parse(txtCantidadUsada1.Text);
                decimal costoPintura = decimal.Parse(txtLitro.Text);
                decimal cantidadPintura = decimal.Parse(txtCantidadUsada2.Text);
                decimal costoFlores = decimal.Parse(txtCostoPorDocena.Text);
                decimal cantidadFlores = decimal.Parse(txtCantidadUsada4.Text);
                decimal precioFrutosSecos = decimal.Parse(txtCostoporKg.Text);
                decimal cantidadFrutosSecos = decimal.Parse(txtCantidadUsada3.Text);
                decimal costoAgua = decimal.Parse(txtCostoPorLitro.Text);
                decimal cantidadAgua = decimal.Parse(txtCantidadUsada5.Text);
                int numeroIntegrantes = int.Parse(txtNumeroDeIntegrantes.Text);
                decimal horasDiseño = decimal.Parse(txtHorasDeDiseño.Text);
                decimal costoPorHora = decimal.Parse(txtCostoDeCadaHora.Text);
                decimal costoManoObra = decimal.Parse(txtCostoManoDeObra.Text);

                // Calcular el área del tapete
                decimal area = largo * ancho;

                // Calcular costos por material
                decimal totalAserrin = costoAserrin * cantidadAserrin;
                decimal totalPintura = costoPintura * cantidadPintura;
                decimal totalFlores = cantidadFlores * costoFlores;
                decimal totalFrutosSecos = precioFrutosSecos * cantidadFrutosSecos;
                decimal totalAgua = costoAgua * cantidadAgua;

                // Calcular el costo total de los alimentos (flores + frutos secos) por integrante
                decimal totalAlimentos = numeroIntegrantes * (precioFrutosSecos + costoFlores);

                // Calcular el costo de diseño por integrante, multiplicado por horas de diseño y costo por hora
                decimal costoDiseñoPorIntegrante = numeroIntegrantes * horasDiseño * costoPorHora;

                // Sumar el costo de la mano de obra
                decimal costoTotalManoObra = numeroIntegrantes * costoManoObra;

                // Calcular el precio final sumando todo
                decimal PrecioFinal = totalAserrin + totalPintura + totalFrutosSecos + totalFlores + totalAlimentos + totalAgua + costoDiseñoPorIntegrante + costoTotalManoObra;

                // Mostrar el resultado
                lblPrecioFinal.Text = "El precio final del tapete es: " + PrecioFinal.ToString("C");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores válidos.");
            }
        } 
    }
}

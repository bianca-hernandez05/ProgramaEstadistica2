using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using MathNet.Numerics.Statistics;
using MathNet.Numerics.Distributions;
using Accord.Statistics.Visualizations;
using Accord.Math.Distances;


namespace Programa_de_estadistica
{
    public partial class Form1 : Form
    {
        private PlotView scatterPlot, scatterPlot1;

        public Form1()
        {
            InitializeComponent();

            dataGridView1.AllowUserToAddRows = false;
            lblSumX.Visible = false;
            lblSumY.Visible = false;
            lblSumx2.Visible = false;
            lblSumy2.Visible = false;
            lblSumxy.Visible = false;
            lblMedia.Visible = false;
            lblB1.Visible = false;
            lblB0.Visible = false;
            lblR.Visible = false;
            lblRcuadrado.Visible = false;
            lblX.Visible = false;
            lblY.Visible = false;
            lblGLE.Visible = false;
            lblGLR.Visible = false;
            lblMCE.Visible = false;
            lblCorrelacion.Visible = false;
            lblSCE.Visible = false;
            lblSCR.Visible = false;
            lblRVR.Visible = false;
            lblSumden.Visible = false;
            lblTstudent.Visible = false;
            lblIntervaloPredicion.Visible = false;
            lblIntervaloConfianzaxp.Visible = false;
            lblValorCritico.Visible = false;
            lblResultadoHipotesis.Visible = false;
            lblCorrelacion.Visible = false;
            lblMcr.Visible = false;

            // Inicializar el PlotView (gráfico de dispersión) programáticamente
            scatterPlot = new PlotView
            {

                Location = new Point(20, 200),  // Posición en el formulario
                Size = new Size(300, 500)  // Tamaño del gráfico
            };

            // Añadir el control PlotView al formulario
            this.Controls.Add(scatterPlot);

            scatterPlot1 = new PlotView
            {
                Location = new Point(1020, 295),
                Size = new Size(200, 200)
            };
            this.Controls.Add(scatterPlot1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void AgregarValores()
        {
            // Leer valores de los TextBox y convertirlos a double
            if (double.TryParse(txtx.Text, out double x) &&
                double.TryParse(txty.Text, out double y))
            {
                // Agregar filas con valores programáticamente
                dataGridView1.Rows.Add(x, y);
            }
            else
            {
                // Mostrar un mensaje si los valores no son válidos
                MessageBox.Show("Por favor, ingrese valores válidos en los cuadros de texto.");
            }
        }

        // Evento que se ejecuta cuando el usuario hace clic en el botón para agregar valores
        private void button1_Click(object sender, EventArgs e)
        {
            // Validar si los TextBox están vacíos o contienen solo espacios en blanco
            if (string.IsNullOrWhiteSpace(txtx.Text) || string.IsNullOrWhiteSpace(txty.Text))
            {
                MessageBox.Show("Por favor, ingrese valores en ambos cuadros de texto.");
                return; // Detener la ejecución si hay campos vacíos o solo con espacios
            }

            // Si pasa la validación, llamar al método AgregarValores
            AgregarValores();
            txtx.Clear();
            txty.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que se haya seleccionado una fila válida

            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Verificar que las celdas no estén vacías o sean null antes de cargar los valores en los TextBox
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    // Cargar los valores de la celda seleccionada en los TextBox si no están vacíos
                    txtx.Text = row.Cells[0].Value.ToString();  // Primera columna
                    txty.Text = row.Cells[1].Value.ToString();  // Segunda columna
                }
                else
                {
                    // Si la celda está vacía, limpiar los TextBox y mostrar un mensaje de advertencia
                    txtx.Clear();
                    txty.Clear();
                    MessageBox.Show("La celda seleccionada está vacía.");
                }
            }
        }

        private void GuardarCambios_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtx.Text) || string.IsNullOrWhiteSpace(txty.Text))
            {
                MessageBox.Show("Por favor, ingrese valores en ambos cuadros de texto.");
                return; // Detener la ejecución si hay campos vacíos
            }

            // Validar si los valores en los TextBox son numéricos
            if (double.TryParse(txtx.Text, out double x) && double.TryParse(txty.Text, out double y))
            {
                // Validar si el DataGridView contiene filas
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("No hay filas en el DataGridView para actualizar.");
                    return; // Detener la ejecución si no hay filas
                }

                // Validar si hay una celda seleccionada
                if (dataGridView1.CurrentCell == null)
                {
                    MessageBox.Show("Por favor, seleccione una fila para actualizar.");
                    return; // Detener la ejecución si no hay una celda seleccionada
                }

                // Obtener la fila seleccionada en el DataGridView
                int rowIndex = dataGridView1.CurrentCell.RowIndex;

                // Actualizar los valores de la fila seleccionada en el DataGridView
                dataGridView1.Rows[rowIndex].Cells[0].Value = x; // Actualizar la primera columna
                dataGridView1.Rows[rowIndex].Cells[1].Value = y; // Actualizar la segunda columna
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblSumX.Visible = true;
            lblSumY.Visible = true;
            lblSumx2.Visible = true;
            lblSumy2.Visible = true;
            lblSumxy.Visible = true;
            lblMedia.Visible = true;
            lblB1.Visible = true;
            lblR.Visible = true;
            lblRcuadrado.Visible = true;
            lblB0.Visible = true;
            lblX.Visible = true;
            lblY.Visible = true;
            lblGLE.Visible = true;
            lblGLR.Visible = true;
            lblMCE.Visible = true;
            lblCorrelacion.Visible = true;
            lblSCE.Visible = true;
            lblSCR.Visible = true;
            lblRVR.Visible = true;
            lblTstudent.Visible = true;
            lblSumden.Visible = true;
            lblIntervaloPredicion.Visible = true;
            lblIntervaloConfianzaxp.Visible = true;
            lblValorCritico.Visible = true;
            lblResultadoHipotesis.Visible = true;
            lblCorrelacion.Visible = true;
            lblMcr.Visible = true;

            double sumX = 0, sumY = 0, sumX2 = 0, sumY2 = 0, sumXY = 0, xp = 2; //xp es un numero cualquiera;
            double totalCeldasX = 0;  // Contador de celdas válidas en la columna X

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    double x = Convert.ToDouble(row.Cells[0].Value);
                    double y = Convert.ToDouble(row.Cells[1].Value);

                    // Calcular X^2, Y^2, y X*Y
                    double x2 = x * x;
                    double y2 = y * y;
                    double xy = x * y;

                    // Asignar los resultados a las columnas correspondientes
                    row.Cells[2].Value = x2;
                    row.Cells[3].Value = y2;
                    row.Cells[4].Value = xy;

                    // Sumar los valores de cada fila
                    sumX += x;
                    sumY += y;
                    sumX2 += x2;
                    sumY2 += y2;
                    sumXY += xy;

                    // Incrementar el contador de celdas válidas en X
                    totalCeldasX++;
                }
                else
                {
                    MessageBox.Show("Fila " + row.Index + " tiene valores incompletos.");
                }
            }

            //Calculos de la media
            double media = sumX / totalCeldasX;

            //Realizar los calculos de b1
            double b1p1 = sumXY - (sumX * sumY) / totalCeldasX;
            double b1p2 = sumX2 - Math.Pow(2, sumX) / 2;
            double b1F = (totalCeldasX * sumXY - sumX * sumY) / (totalCeldasX * sumX2 - Math.Pow(sumX, 2));

            //Realizar los calculos de bo
            double b0 = 1 / totalCeldasX * (sumY - b1F * sumX);
            double yc = b0 + b1F * (xp);

            //Formulas despejadas para la recta
            double Rectax = b0;
            double Rectay = -b0 / b1F;

            //metodo para mostrar la recta
            GraficarDatosYRectaAjuste();

            //realizar los calculos de r al cuadrado xd
            double rNumerador = b1F * (sumXY - (sumX * sumY / totalCeldasX));
            double rDenominador = sumY2 - (Math.Pow(sumY, 2) / totalCeldasX);

            double r2 = rNumerador / rDenominador;

            double r = Math.Sqrt(r2);
            //agregar una nota que diga podemos obsevar que entre mayor sea el puntaje de ajuste personal mayor es el coeficiente intelectual 
            //(ya que la grafica es creciente con pendiente positiva)

            // Nivel de confianza (por ejemplo, 95%)
            double nivelConfianza = 0.95;
            double alpha = 1 - nivelConfianza;
            double desviacionEstandar = Math.Sqrt((sumY2 - Math.Pow(sumY, 2) / totalCeldasX) / (totalCeldasX - 1));

            double gLE = totalCeldasX - 2;


            double tCritico;
            switch (gLE)
            {
                case 1:
                    tCritico = 12.7062;
                    break;
                case 2:
                    tCritico = 4.3027;
                    break;
                case 3:
                    tCritico = 3.1824;
                    break;
                case 4:
                    tCritico = 2.7764;
                    break;
                case 5:
                    tCritico = 2.5706;
                    break;
                case 6:
                    tCritico = 2.4469;
                    break;
                case 7:
                    tCritico = 2.3646;
                    break;
                case 8:
                    tCritico = 2.3060;
                    break;
                case 9:
                    tCritico = 2.2622;
                    break;
                case 10:
                    tCritico = 2.2281;
                    break;
                case 11:
                    tCritico = 2.2009;
                    break;
                case 12:
                    tCritico = 2.1788;
                    break;
                case 13:
                    tCritico = 2.1604;
                    break;
                case 14:
                    tCritico = 2.1448;
                    break;
                case 15:
                    tCritico = 2.1314;
                    break;
                case 16:
                    tCritico = 2.1199;
                    break;
                case 17:
                    tCritico = 2.1098;
                    break;
                case 18:
                    tCritico = 2.1009;
                    break;
                case 19:
                    tCritico = 2.0930;
                    break;
                case 20:
                    tCritico = 2.0859;
                    break;
                case 21:
                    tCritico = 2.0796;
                    break;
                case 22:
                    tCritico = 2.0739;
                    break;
                case 23:
                    tCritico = 2.0687;
                    break;
                case 24:
                    tCritico = 2.0639;
                    break;
                case 25:
                    tCritico = 2.0595;
                    break;
                case 26:
                    tCritico = 2.0555;
                    break;
                case 27:
                    tCritico = 2.0518;
                    break;
                case 28:
                    tCritico = 2.0484;
                    break;
                case 29:
                    tCritico = 2.0452;
                    break;
                case 30:
                    tCritico = 2.0423;
                    break;
                case 35:
                    tCritico = 2.0301;
                    break;
                case 40:
                    tCritico = 2.0211;
                    break;
                case 45:
                    tCritico = 2.0141;
                    break;
                case 50:
                    tCritico = 2.0086;
                    break;
                case 60:
                    tCritico = 2.0003;
                    break;
                case 70:
                    tCritico = 1.9944;
                    break;
                case 80:
                    tCritico = 1.9905;
                    break;
                case 90:
                    tCritico = 1.9867;
                    break;
                case 100:
                    tCritico = 1.9839;
                    break;
                case 120:
                    tCritico = 1.9799;
                    break;
                case 140:
                    tCritico = 1.9772;
                    break;
                case 150:
                    tCritico = 1.9759;
                    break;
                case 160:
                    tCritico = 1.9762;
                    break;
                case 180:
                    tCritico = 1.9753;
                    break;
                case 200:
                    tCritico = 1.9719;
                    break;
                default:
                    tCritico = 1.96; // Aproximación para df altos, valor Z para 95% si df > 200
                    break;
            }

            string correlacion;
            double error = rDenominador - rNumerador;
            int glr = 1;
            double mce = error / gLE;
            double mcr = rNumerador;
            double rvr = rNumerador / mce;
            double sumatoriatden = sumX2 - (Math.Pow(sumX, 2) / totalCeldasX);
            double division = mce / sumatoriatden;
            double division1 = (Math.Sqrt(division));
            double tstudent = b1F / (Math.Sqrt(division));
            double pred = (Math.Sqrt(mce));
            double pred2 = (Math.Sqrt(1 + 1 / totalCeldasX + (Math.Pow(xp - media, 2) / sumatoriatden)));
            double prediccionypositivo = yc + tCritico * pred * pred2;
            double prediccionynegativo = yc - tCritico * pred * pred2;
            double pred3 = (Math.Sqrt(1 / totalCeldasX + (Math.Pow(xp - media, 2) / sumatoriatden)));
            double prediccionxpPositivo = yc + tCritico * pred * pred3;
            double prediccionxpNegativo = yc - tCritico * pred * pred3;
            // Calcular el margen de error
            double margenError = tCritico * (division1);

            // Calcular el intervalo de confianza
            double limiteInferior = b1F - margenError;
            double limiteSuperior = b1F + margenError;

            // falta el valor de significancia para rechazar la hipotesis 
            GraficarRectaCorrelacion(r);
            scatterPlot.InvalidatePlot(true);


            // Mostrar las sumatorias y el número de celdas válidas en X
            lblSumX.Text = sumX.ToString("F4");
            lblSumY.Text = sumY.ToString("F4");
            lblSumx2.Text = sumX2.ToString("F4");
            lblSumy2.Text = sumY2.ToString("F4");
            lblSumxy.Text = sumXY.ToString("F4");
            lblMedia.Text = media.ToString("F4");
            lblB1.Text = b1F.ToString("F9");
            lblB0.Text = b0.ToString("F4");
            lblX.Text = Rectax.ToString();
            lblY.Text = Rectay.ToString();
            lblRcuadrado.Text = r2.ToString();
            lblR.Text = r.ToString();
            lblSCE.Text = error.ToString();
            lblSCR.Text = rNumerador.ToString();
            lblGLR.Text = glr.ToString();
            lblGLE.Text = gLE.ToString();
            lblCorrelacion.Text = rNumerador.ToString();
            lblMCE.Text = mce.ToString();
            lblRVR.Text = rvr.ToString();
            lblTstudent.Text = tstudent.ToString();
            lblSumden.Text = sumatoriatden.ToString();
            lblValorCritico.Text = $"{nivelConfianza * 100}% de confianza: que el intervalo esta entre ({limiteInferior} <= b1 <= {limiteSuperior})";
            lblIntervaloPredicion.Text = $"{nivelConfianza * 100}% de confianza: que el intervalo esta entre {prediccionynegativo} y {prediccionypositivo} x/y";
            lblIntervaloConfianzaxp.Text = $"{nivelConfianza * 100}% de confianza: que el intervalo esta entre {prediccionxpNegativo} y {prediccionxpPositivo} x/y";
            lblMcr.Text = mcr.ToString();

            if (r > 0.7)
            {
                correlacion = "Correlación muy fuerte y positiva";
            }
            else if (r >= 0.4 && r <= 0.7)
            {
                correlacion = "Correlación positiva y regular";
            }
            else if (r == 0)
            {
                correlacion = "No hay correlación";
            }
            else if (r == -1)
            {
                correlacion = "Correlación negativa fuerte";
            }
            else if (r < -0.4 && r > -0.7)
            {
                correlacion = "Correlación negativa regular";
            }
            else
            {
                correlacion = "Correlación negativa muy fuerte";
            }

            // Mostrar el resultado de la correlación en un label o mensaje
            lblCorrelacion.Text = correlacion;

            double tAbs = Math.Abs(tstudent);

            // Verificar si |t| > tCritico
            bool rechazoH0 = tAbs > tCritico;

            // Construir el mensaje de resultado
            string resultadoHipotesis;
            if (rechazoH0)
            {
                resultadoHipotesis = $"|t| = {tAbs:F4} > t crítico = {tCritico:F4}\n" +
                                     "Rechazamos la hipótesis nula H₀: β₁ = 0.\n" +
                                     $"Existe evidencia suficiente para afirmar que β₁ es significativamente diferente de 0 al nivel α = {alpha}.";
            }
            else
            {
                resultadoHipotesis = $"|t| = {tAbs:F4} ≤ t crítico = {tCritico:F4}\n" +
                                     "No rechazamos la hipótesis nula H₀: β₁ = 0.\n" +
                                     $"No existe evidencia suficiente para afirmar que β₁ es significativamente diferente de 0 al nivel α = {alpha}.";
            }

            // Mostrar el resultado en el Label (asegúrate de que lblResultadoHipotesis esté visible)
            lblResultadoHipotesis.Text = resultadoHipotesis;

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void plotView1_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguientesCalculos_Click(object sender, EventArgs e)
        {
            // Crear el modelo para el gráfico
            var plotModel = new PlotModel { Title = " Dispersión" };

            // Crear la serie de dispersión
            var scatterSeries = new ScatterSeries
            {
                MarkerType = MarkerType.Circle,
                MarkerStroke = OxyColors.Blue,
                MarkerFill = OxyColors.SkyBlue,
                MarkerSize = 3
            };

            // Recorrer las filas del DataGridView y agregar los puntos a la serie
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    // Obtener los valores de X y Y desde el DataGridView
                    double x = Convert.ToDouble(row.Cells[0].Value);
                    double y = Convert.ToDouble(row.Cells[1].Value);

                    // Agregar los puntos a la serie de dispersión
                    scatterSeries.Points.Add(new ScatterPoint(x, y));
                }
            }
            // Agregar la serie al modelo del gráfico
            plotModel.Series.Add(scatterSeries);

            // Asignar el modelo al control PlotView
            scatterPlot.Model = plotModel;

            // Actualizar el gráfico
            scatterPlot.InvalidatePlot(true);
        }
        private void GraficarRectaCorrelacion(double r)
        {
            // Crear un modelo de gráfico
            var plotModel = new PlotModel { Title = "Correlación" };

            // Configurar el eje X
            var xAxis = new OxyPlot.Axes.LinearAxis
            {
                Position = OxyPlot.Axes.AxisPosition.Bottom,
                Title = "Eje X",
                Minimum = -1, // Ajusta el rango mínimo del eje X
                Maximum = 1   // Ajusta el rango máximo del eje X
            };

            // Añadir el eje X al modelo
            plotModel.Axes.Add(xAxis);

            // Ocultar el eje Y (no se añade ningún eje Y)
            var yAxis = new OxyPlot.Axes.LinearAxis
            {
                Position = OxyPlot.Axes.AxisPosition.Left,
                IsAxisVisible = false // Oculta el eje Y
            };

            // Añadir el eje Y (invisible) al modelo
            plotModel.Axes.Add(yAxis);

            // Crear la serie para mostrar el punto en el valor de r
            var scatterSeries = new ScatterSeries
            {
                MarkerType = MarkerType.Circle,
                MarkerSize = 8, // Tamaño del marcador
                MarkerStroke = OxyColors.Blue,
                MarkerFill = OxyColors.Red // Color del punto
            };

            // Agregar un único punto en el valor de r (en Y=0)
            scatterSeries.Points.Add(new ScatterPoint(r, 0)); // Solo un punto en Y=0

            plotModel.Series.Add(scatterSeries);

            // Asignar el modelo al control PlotView
            scatterPlot1.Model = plotModel;

            // Actualizar el gráfico
            scatterPlot1.InvalidatePlot(true);
        }

        private void GraficarDatosYRectaAjuste()
        {
            var plotModel = new PlotModel { Title = "Gráfico de Dispersión con Línea de Ajuste" };

            // Crear la serie de puntos de dispersión
            var scatterSeries = new ScatterSeries
            {
                MarkerType = MarkerType.Circle,
                MarkerSize = 5
            };

            List<double> xValues = new List<double>();
            List<double> yValues = new List<double>();

            // Agregar puntos al gráfico
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    double x = Convert.ToDouble(row.Cells[0].Value);
                    double y = Convert.ToDouble(row.Cells[1].Value);

                    scatterSeries.Points.Add(new ScatterPoint(x, y));
                    xValues.Add(x);
                    yValues.Add(y);
                }
            }

            plotModel.Series.Add(scatterSeries);

            // Calcular los coeficientes de la recta (b1 es la pendiente, b0 es la intersección)
            double xSum = xValues.Sum();
            double ySum = yValues.Sum();
            double xAvg = xSum / xValues.Count;
            double yAvg = ySum / yValues.Count;

            double numerator = 0; // Suma de (x - xAvg) * (y - yAvg)
            double denominator = 0; // Suma de (x - xAvg)^2

            for (int i = 0; i < xValues.Count; i++)
            {
                double xDiff = xValues[i] - xAvg;
                double yDiff = yValues[i] - yAvg;

                numerator += xDiff * yDiff;
                denominator += xDiff * xDiff;
            }

            double b1 = numerator / denominator; // Pendiente
            double b0 = yAvg - b1 * xAvg; // Intersección

            // Crear la serie de la línea de ajuste
            var lineSeries = new LineSeries
            {
                Title = "Línea de Ajuste",
                Color = OxyColors.Red
            };

            // Agregar los puntos de la línea de ajuste (usamos el rango de X para trazar la línea)
            double xMin = scatterSeries.Points.Min(p => p.X);
            double xMax = scatterSeries.Points.Max(p => p.X);
            lineSeries.Points.Add(new DataPoint(xMin, b0 + b1 * xMin));
            lineSeries.Points.Add(new DataPoint(xMax, b0 + b1 * xMax));

            plotModel.Series.Add(lineSeries);

            // Configurar el gráfico
            var plotView = new PlotView
            {
                Dock = DockStyle.Fill,
                Model = plotModel
            };

            // Mostrar el gráfico en un formulario
            var form = new Form
            {
                Text = "Gráfico de Dispersión",
                Width = 800,
                Height = 600
            };
            form.Controls.Add(plotView);
            form.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void lblValorCritico_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si el DataGridView contiene filas
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("No hay filas en el DataGridView para eliminar.");
                    return; // Detener la ejecución si no hay filas
                }

                // Validar si hay una fila seleccionada
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Por favor, seleccione una fila para eliminar.");
                    return; // Detener la ejecución si no hay una fila seleccionada
                }

                // Confirmar si se desea eliminar la fila seleccionada
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar la fila seleccionada?",
                                                      "Confirmar eliminación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Eliminar la fila seleccionada
                    int rowIndex = dataGridView1.CurrentRow.Index;
                    dataGridView1.Rows.RemoveAt(rowIndex);

                    MessageBox.Show("La fila ha sido eliminada correctamente.");
                }
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje en caso de que ocurra alguna excepción
                MessageBox.Show($"Ocurrió un error al intentar eliminar la fila: {ex.Message}");
            }
        }

        private void txtx_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Permitir teclas de control como Backspace
            if (char.IsControl(e.KeyChar))
            {
                return;
            }


            // Verificar si es un número
            if (!char.IsDigit(e.KeyChar))
            {
                // Verificar si es el símbolo "-" y que solo se permita una vez al principio
                if (e.KeyChar == '-')
                {
                    if (txtx.Text.Contains("-") || txtx.SelectionStart != 0)
                    {
                        // Cancelar el evento si ya hay un "-" o si no es el primer carácter
                        e.Handled = true;
                    }
                }
                // Verificar si es un punto y que solo se permita una vez
                else if (e.KeyChar == '.')
                {
                    if (txtx.Text.Contains("."))
                    {
                        // Cancelar el evento si ya hay un punto
                        e.Handled = true;
                    }
                }
                else
                {
                    // Cancelar el evento si no es ni número, ni "-", ni "."
                    e.Handled = true;
                }
            }

        }

        private void txty_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Permitir teclas de control como Backspace
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Verificar si es un número
            if (!char.IsDigit(e.KeyChar))
            {
                // Verificar si es el símbolo "-" y que solo se permita una vez al principio
                if (e.KeyChar == '-')
                {
                    if (txty.Text.Contains("-") || txty.SelectionStart != 0)
                    {
                        // Cancelar el evento si ya hay un "-" o si no es el primer carácter
                        e.Handled = true;
                    }
                }
                // Verificar si es un punto y que solo se permita una vez
                else if (e.KeyChar == '.')
                {
                    if (txty.Text.Contains("."))
                    {
                        // Cancelar el evento si ya hay un punto
                        e.Handled = true;
                    }
                }
                else
                {
                    // Cancelar el evento si no es ni número, ni "-", ni "."
                    e.Handled = true;
                }
            }
        }
    }
}

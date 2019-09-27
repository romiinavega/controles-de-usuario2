using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ControlesDeUsuario
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboxTitulo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdParametrosFigura.Children.Clear();

            switch (comboxTitulo.SelectedIndex)
            {
                case 0: //Circulo
                    grdParametrosFigura.Children.Add(new ParametrosCirculo());
                    break;
                case 1: //Triangulo
                    grdParametrosFigura.Children.Add(new ParametrosTriangulo());
                    break;
                case 2: //Rectangulo
                    grdParametrosFigura.Children.Add(new ParametrosRectangulo());
                    break;
                case 3: //Cuadrado
                    grdParametrosFigura.Children.Add(new ParametrosCuadrado());
                    break;
                case 4: //Trapecio
                    grdParametrosFigura.Children.Add(new ParametrosTrapecio());
                    break;
                case 5: //Pentagono
                    grdParametrosFigura.Children.Add(new ParametrosPentagono());
                    break;

                default:
                    break;
            }
        }

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {

            double area = 0.0;

            switch (comboxTitulo.SelectedIndex)
            {
                case 0: //Circulo
                    double radio = double.Parse(((ParametrosCirculo)(grdParametrosFigura.Children[0])).txtRadio.Text);
                    area = Math.PI * radio * radio;
                    break;

                case 1: //Triangulo
                    double altura2 = double.Parse(((ParametrosTriangulo)(grdParametrosFigura.Children[0])).txtAlturaTri.Text);
                    double base2 = double.Parse(((ParametrosTriangulo)(grdParametrosFigura.Children[0])).txtBaseTri.Text);
                    area = ((base2 * altura2) / 2);
                    break;
                case 2: //Rectangulo
                    double altura3 = double.Parse(((ParametrosRectangulo)(grdParametrosFigura.Children[0])).txtAlturaRec.Text);
                    double base3 = double.Parse(((ParametrosRectangulo)(grdParametrosFigura.Children[0])).txtBaseRec.Text);
                    area = ((base3 * altura3));
                    break;
                case 3: //Cuadrado
                    double lado1 = double.Parse(((ParametrosCuadrado)(grdParametrosFigura.Children[0])).txtLado1.Text);
                    double lado2 = double.Parse(((ParametrosCuadrado)(grdParametrosFigura.Children[0])).txtLado2.Text);
                    area = lado1 * lado2;
                    break;
                case 4: //Trapecio
                    double basemayor = double.Parse(((ParametrosTrapecio)(grdParametrosFigura.Children[0])).txtBaseMayor.Text);
                    double basemenor = double.Parse(((ParametrosTrapecio)(grdParametrosFigura.Children[0])).txtBaseMenor.Text);
                    double altura4 = double.Parse(((ParametrosTrapecio)(grdParametrosFigura.Children[0])).txtAlturaTra.Text);
                    area = altura4 * ((basemayor + basemenor) / 2);
                    break;
                case 5: //Pentagono
                    double perimetro = double.Parse(((ParametrosPentagono)(grdParametrosFigura.Children[0])).txtPerimetro.Text);
                    double apotema = double.Parse(((ParametrosPentagono)(grdParametrosFigura.Children[0])).txtApotema.Text);
                    area = perimetro * apotema;
                    break;
                
                default:
                    break;
            }


            lblResultado.Text = area.ToString();

        }
    }
}

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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Onibus
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        private RotateTransform rotacao;
        private TranslateTransform translateTransform;
        public MainWindow()
        {
            InitializeComponent();

            rotacao = new RotateTransform(15, 32, 32);
            Roda1.RenderTransform = rotacao;
            Roda2.RenderTransform = rotacao;
            Roda3.RenderTransform = rotacao;

            translateTransform = new TranslateTransform();
            MainCanvas.RenderTransform = translateTransform;

            DoubleAnimation rodasAnimation = new DoubleAnimation();
            rodasAnimation.From = 0;
            rodasAnimation.To = -360;
            rodasAnimation.Duration = TimeSpan.FromSeconds(3.5);
            rodasAnimation.AutoReverse = true;
            rodasAnimation.RepeatBehavior = RepeatBehavior.Forever;

            rotacao.BeginAnimation(RotateTransform.AngleProperty, rodasAnimation);

            DoubleAnimation deslocamentoAnimation = new DoubleAnimation();
            deslocamentoAnimation.From = 0;
            deslocamentoAnimation.To = -150; 
            deslocamentoAnimation.Duration = TimeSpan.FromSeconds(3.5); 
            deslocamentoAnimation.AutoReverse = true;
            deslocamentoAnimation.RepeatBehavior = RepeatBehavior.Forever;

            translateTransform.BeginAnimation(TranslateTransform.XProperty, deslocamentoAnimation);
        }
    }
}

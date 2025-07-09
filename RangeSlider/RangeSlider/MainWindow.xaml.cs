using System.Windows;

namespace FunwayControls
{
    public partial class MainWindow : Window
    {
        public static readonly DependencyProperty MinProperty = DependencyProperty.Register("Min", typeof(double), typeof(MainWindow), new PropertyMetadata(0d));
        public static readonly DependencyProperty MaxProperty = DependencyProperty.Register("Max", typeof(double), typeof(MainWindow), new PropertyMetadata(1d));
        public static readonly DependencyProperty StartProperty = DependencyProperty.Register("Start", typeof(double), typeof(MainWindow), new PropertyMetadata(0.20d));
        public static readonly DependencyProperty EndProperty = DependencyProperty.Register("End", typeof(double), typeof(MainWindow), new PropertyMetadata(0.85d));

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}

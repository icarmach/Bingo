using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Bingo
{
	/// <summary>
	/// Interaction logic for Winner.xaml
	/// </summary>
	public partial class Winner : Window
	{
        public bool reset;
        DispatcherTimer dispatcherTimer;
        List<SolidColorBrush> colores;

		public Winner()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.

            reset = false;
            colores = new List<SolidColorBrush>();

            colores.Add(Brushes.Red);
            colores.Add(Brushes.Purple);
            colores.Add(Brushes.Aqua);
            colores.Add(Brushes.Bisque);
            colores.Add(Brushes.BurlyWood);
            colores.Add(Brushes.Coral);
            colores.Add(Brushes.Cyan);
            colores.Add(Brushes.Fuchsia);
            colores.Add(Brushes.Gold);
            colores.Add(Brushes.Green);
            colores.Add(Brushes.IndianRed);
            colores.Add(Brushes.Khaki);
            colores.Add(Brushes.Ivory);
            colores.Add(Brushes.LawnGreen);
            colores.Add(Brushes.LightSalmon);
            colores.Add(Brushes.Lime);
            colores.Add(Brushes.Magenta);
            colores.Add(Brushes.Moccasin);
            colores.Add(Brushes.Peru);
            colores.Add(Brushes.SkyBlue);
            colores.Add(Brushes.Blue);

            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 250);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int index = r.Next(0, colores.Count);

            bingo.Foreground = colores[index];
        }

        private void confirm_button_Click(object sender, RoutedEventArgs e)
        {
            reset = true;
            this.Close();
        }

        private void cancel_button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
	}
}
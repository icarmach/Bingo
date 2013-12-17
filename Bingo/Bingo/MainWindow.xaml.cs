using System;
using System.Collections.Generic;
using System.Linq;
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
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
        List<Label> numbers;
        List<string> salio;
        List<Label> tablero;
        DispatcherTimer dispatcherTimer;

        string s1 = "pack://application:,,/Bingo;/../../Negro.png";
        string s2 = "pack://application:,,/Bingo;/../../Gris.png";
        Uri uri1;
        Uri uri2;
        BitmapImage negro;
        BitmapImage gris;

		public MainWindow()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.

            numbers = new List<Label>();
            salio = new List<string>();
            tablero = new List<Label>();

            uri1 = new Uri(s1, UriKind.RelativeOrAbsolute);
            negro = new BitmapImage(uri1);
            uri2 = new Uri(s2, UriKind.RelativeOrAbsolute);
            gris = new BitmapImage(uri2);

            next_button.IsEnabled = false;
            bingo_button.IsEnabled = false;

            Letra.Content = "Ready";
            Numero.Content = "";
            
            Patrones.Items.Add("Elija un patrón de juego");
            Patrones.Items.Add("Cartón Completo");
            Patrones.Items.Add("Cuatro Esquinas");
            Patrones.Items.Add("Forma de Cruz");
            Patrones.Items.Add("Letra A");
            Patrones.Items.Add("Letra C");
            Patrones.Items.Add("Letra E");
            Patrones.Items.Add("Letra F");
            Patrones.Items.Add("Letra L");
            Patrones.Items.Add("Letra N");
            Patrones.Items.Add("Letra O");
            Patrones.Items.Add("Letra T");
            Patrones.Items.Add("Letra U");
            Patrones.Items.Add("Letra X");

            numbers.Add(_1);
            numbers.Add(_2);
            numbers.Add(_3);
            numbers.Add(_4);
            numbers.Add(_5);
            numbers.Add(_6);
            numbers.Add(_7);
            numbers.Add(_8);
            numbers.Add(_9);
            numbers.Add(_10);
            numbers.Add(_11);
            numbers.Add(_12);
            numbers.Add(_13);
            numbers.Add(_14);
            numbers.Add(_15);
            numbers.Add(_16);
            numbers.Add(_17);
            numbers.Add(_18);
            numbers.Add(_19);
            numbers.Add(_20);
            numbers.Add(_21);
            numbers.Add(_22);
            numbers.Add(_23);
            numbers.Add(_24);
            numbers.Add(_25);
            numbers.Add(_26);
            numbers.Add(_27);
            numbers.Add(_28);
            numbers.Add(_29);
            numbers.Add(_30);
            numbers.Add(_31);
            numbers.Add(_32);
            numbers.Add(_33);
            numbers.Add(_34);
            numbers.Add(_35);
            numbers.Add(_36);
            numbers.Add(_37);
            numbers.Add(_38);
            numbers.Add(_39);
            numbers.Add(_40);
            numbers.Add(_41);
            numbers.Add(_42);
            numbers.Add(_43);
            numbers.Add(_44);
            numbers.Add(_45);
            numbers.Add(_46);
            numbers.Add(_47);
            numbers.Add(_48);
            numbers.Add(_49);
            numbers.Add(_50);
            numbers.Add(_51);
            numbers.Add(_52);
            numbers.Add(_53);
            numbers.Add(_54);
            numbers.Add(_55);
            numbers.Add(_56);
            numbers.Add(_57);
            numbers.Add(_58);
            numbers.Add(_59);
            numbers.Add(_60);
            numbers.Add(_61);
            numbers.Add(_62);
            numbers.Add(_63);
            numbers.Add(_64);
            numbers.Add(_65);
            numbers.Add(_66);
            numbers.Add(_67);
            numbers.Add(_68);
            numbers.Add(_69);
            numbers.Add(_70);
            numbers.Add(_71);
            numbers.Add(_72);
            numbers.Add(_73);
            numbers.Add(_74);
            numbers.Add(_75);

            tablero.Add(_1);
            tablero.Add(_2);
            tablero.Add(_3);
            tablero.Add(_4);
            tablero.Add(_5);
            tablero.Add(_6);
            tablero.Add(_7);
            tablero.Add(_8);
            tablero.Add(_9);
            tablero.Add(_10);
            tablero.Add(_11);
            tablero.Add(_12);
            tablero.Add(_13);
            tablero.Add(_14);
            tablero.Add(_15);
            tablero.Add(_16);
            tablero.Add(_17);
            tablero.Add(_18);
            tablero.Add(_19);
            tablero.Add(_20);
            tablero.Add(_21);
            tablero.Add(_22);
            tablero.Add(_23);
            tablero.Add(_24);
            tablero.Add(_25);
            tablero.Add(_26);
            tablero.Add(_27);
            tablero.Add(_28);
            tablero.Add(_29);
            tablero.Add(_30);
            tablero.Add(_31);
            tablero.Add(_32);
            tablero.Add(_33);
            tablero.Add(_34);
            tablero.Add(_35);
            tablero.Add(_36);
            tablero.Add(_37);
            tablero.Add(_38);
            tablero.Add(_39);
            tablero.Add(_40);
            tablero.Add(_41);
            tablero.Add(_42);
            tablero.Add(_43);
            tablero.Add(_44);
            tablero.Add(_45);
            tablero.Add(_46);
            tablero.Add(_47);
            tablero.Add(_48);
            tablero.Add(_49);
            tablero.Add(_50);
            tablero.Add(_51);
            tablero.Add(_52);
            tablero.Add(_53);
            tablero.Add(_54);
            tablero.Add(_55);
            tablero.Add(_56);
            tablero.Add(_57);
            tablero.Add(_58);
            tablero.Add(_59);
            tablero.Add(_60);
            tablero.Add(_61);
            tablero.Add(_62);
            tablero.Add(_63);
            tablero.Add(_64);
            tablero.Add(_65);
            tablero.Add(_66);
            tablero.Add(_67);
            tablero.Add(_68);
            tablero.Add(_69);
            tablero.Add(_70);
            tablero.Add(_71);
            tablero.Add(_72);
            tablero.Add(_73);
            tablero.Add(_74);
            tablero.Add(_75);

            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 200);
            dispatcherTimer.Start();
		}

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            Randomize();
        }

        private void Randomize()
        {
            if (numbers.Count > 0)
            {
                for (int i = numbers.Count - 1; i >= 1; i--)
                {
                    Random r = new Random();
                    int j = r.Next(0, i);

                    Label aux = numbers[j];
                    numbers[j] = numbers[i];
                    numbers[i] = aux;
                }

                int n = Int32.Parse(numbers[0].Content.ToString());
                if (n <= 15)
                {
                    tombola.Content = "B\n" + n;
                }

                else if (n > 15 && n <= 30)
                {
                    tombola.Content = "I\n" + n;
                }

                else if (n > 30 && n <= 45)
                {
                    tombola.Content = "N\n" + n;
                }

                else if (n > 45 && n <= 60)
                {
                    tombola.Content = "G\n" + n;
                }

                else
                {
                    tombola.Content = "O\n" + n;
                }
            }
        }

        private void Patrones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Patrones.SelectedItem.ToString().Equals("Cartón Completo"))
            {
                L_1.Source = negro;
                L_2.Source = negro;
                L_3.Source = negro;
                L_4.Source = negro;
                L_5.Source = negro;
                L_6.Source = negro;
                L_7.Source = negro;
                L_8.Source = negro;
                L_9.Source = negro;
                L_10.Source = negro;
                L_11.Source = negro;
                L_12.Source = negro;
                L_13.Source = negro;
                L_14.Source = negro;
                L_15.Source = negro;
                L_16.Source = negro;
                L_17.Source = negro;
                L_18.Source = negro;
                L_19.Source = negro;
                L_20.Source = negro;
                L_21.Source = negro;
                L_22.Source = negro;
                L_23.Source = negro;
                L_24.Source = negro;
                L_25.Source = negro;
            }

            else if(Patrones.SelectedItem.ToString().Equals("Cuatro Esquinas"))
            {
                L_1.Source = negro;
                L_2.Source = gris;
                L_3.Source = gris;
                L_4.Source = gris;
                L_5.Source = negro;
                L_6.Source = gris;
                L_7.Source = gris;
                L_8.Source = gris;
                L_9.Source = gris;
                L_10.Source = gris;
                L_11.Source = gris;
                L_12.Source = gris;
                L_13.Source = gris;
                L_14.Source = gris;
                L_15.Source = gris;
                L_16.Source = gris;
                L_17.Source = gris;
                L_18.Source = gris;
                L_19.Source = gris;
                L_20.Source = gris;
                L_21.Source = negro;
                L_22.Source = gris;
                L_23.Source = gris;
                L_24.Source = gris;
                L_25.Source = negro;
            }

            else if(Patrones.SelectedItem.ToString().Equals("Forma de Cruz"))
            {
                L_1.Source = gris;
                L_2.Source = gris;
                L_3.Source = negro;
                L_4.Source = gris;
                L_5.Source = gris;
                L_6.Source = gris;
                L_7.Source = gris;
                L_8.Source = negro;
                L_9.Source = gris;
                L_10.Source = gris;
                L_11.Source = negro;
                L_12.Source = negro;
                L_13.Source = negro;
                L_14.Source = negro;
                L_15.Source = negro;
                L_16.Source = gris;
                L_17.Source = gris;
                L_18.Source = negro;
                L_19.Source = gris;
                L_20.Source = gris;
                L_21.Source = gris;
                L_22.Source = gris;
                L_23.Source = negro;
                L_24.Source = gris;
                L_25.Source = gris;
            }

            else if(Patrones.SelectedItem.ToString().Equals("Letra A"))
            {
                L_1.Source = negro;
                L_2.Source = negro;
                L_3.Source = negro;
                L_4.Source = negro;
                L_5.Source = negro;
                L_6.Source = negro;
                L_7.Source = gris;
                L_8.Source = gris;
                L_9.Source = gris;
                L_10.Source = negro;
                L_11.Source = negro;
                L_12.Source = negro;
                L_13.Source = negro;
                L_14.Source = negro;
                L_15.Source = negro;
                L_16.Source = negro;
                L_17.Source = gris;
                L_18.Source = gris;
                L_19.Source = gris;
                L_20.Source = negro;
                L_21.Source = negro;
                L_22.Source = gris;
                L_23.Source = gris;
                L_24.Source = gris;
                L_25.Source = negro;
            }

            else if(Patrones.SelectedItem.ToString().Equals("Letra C"))
            {
                L_1.Source = negro;
                L_2.Source = negro;
                L_3.Source = negro;
                L_4.Source = negro;
                L_5.Source = negro;
                L_6.Source = negro;
                L_7.Source = gris;
                L_8.Source = gris;
                L_9.Source = gris;
                L_10.Source = gris;
                L_11.Source = negro;
                L_12.Source = gris;
                L_13.Source = gris;
                L_14.Source = gris;
                L_15.Source = gris;
                L_16.Source = negro;
                L_17.Source = gris;
                L_18.Source = gris;
                L_19.Source = gris;
                L_20.Source = gris;
                L_21.Source = negro;
                L_22.Source = negro;
                L_23.Source = negro;
                L_24.Source = negro;
                L_25.Source = negro;
            }

            else if(Patrones.SelectedItem.ToString().Equals("Letra E"))
            {
                L_1.Source = negro;
                L_2.Source = negro;
                L_3.Source = negro;
                L_4.Source = negro;
                L_5.Source = negro;
                L_6.Source = negro;
                L_7.Source = gris;
                L_8.Source = gris;
                L_9.Source = gris;
                L_10.Source = gris;
                L_11.Source = negro;
                L_12.Source = negro;
                L_13.Source = negro;
                L_14.Source = negro;
                L_15.Source = negro;
                L_16.Source = negro;
                L_17.Source = gris;
                L_18.Source = gris;
                L_19.Source = gris;
                L_20.Source = gris;
                L_21.Source = negro;
                L_22.Source = negro;
                L_23.Source = negro;
                L_24.Source = negro;
                L_25.Source = negro;
            }

            else if(Patrones.SelectedItem.ToString().Equals("Letra F"))
            {
                L_1.Source = negro;
                L_2.Source = negro;
                L_3.Source = negro;
                L_4.Source = negro;
                L_5.Source = negro;
                L_6.Source = negro;
                L_7.Source = gris;
                L_8.Source = gris;
                L_9.Source = gris;
                L_10.Source = gris;
                L_11.Source = negro;
                L_12.Source = negro;
                L_13.Source = negro;
                L_14.Source = negro;
                L_15.Source = negro;
                L_16.Source = negro;
                L_17.Source = gris;
                L_18.Source = gris;
                L_19.Source = gris;
                L_20.Source = gris;
                L_21.Source = negro;
                L_22.Source = gris;
                L_23.Source = gris;
                L_24.Source = gris;
                L_25.Source = gris;
            }

            else if(Patrones.SelectedItem.ToString().Equals("Letra L"))
            {
                L_1.Source = negro;
                L_2.Source = gris;
                L_3.Source = gris;
                L_4.Source = gris;
                L_5.Source = gris;
                L_6.Source = negro;
                L_7.Source = gris;
                L_8.Source = gris;
                L_9.Source = gris;
                L_10.Source = gris;
                L_11.Source = negro;
                L_12.Source = gris;
                L_13.Source = gris;
                L_14.Source = gris;
                L_15.Source = gris;
                L_16.Source = negro;
                L_17.Source = gris;
                L_18.Source = gris;
                L_19.Source = gris;
                L_20.Source = gris;
                L_21.Source = negro;
                L_22.Source = negro;
                L_23.Source = negro;
                L_24.Source = negro;
                L_25.Source = negro;
            }

            else if(Patrones.SelectedItem.ToString().Equals("Letra N"))
            {
                L_1.Source = negro;
                L_2.Source = gris;
                L_3.Source = gris;
                L_4.Source = gris;
                L_5.Source = negro;
                L_6.Source = negro;
                L_7.Source = negro;
                L_8.Source = gris;
                L_9.Source = gris;
                L_10.Source = negro;
                L_11.Source = negro;
                L_12.Source = gris;
                L_13.Source = negro;
                L_14.Source = gris;
                L_15.Source = negro;
                L_16.Source = negro;
                L_17.Source = gris;
                L_18.Source = gris;
                L_19.Source = negro;
                L_20.Source = negro;
                L_21.Source = negro;
                L_22.Source = gris;
                L_23.Source = gris;
                L_24.Source = gris;
                L_25.Source = negro;
            }

            else if(Patrones.SelectedItem.ToString().Equals("Letra O"))
            {
                L_1.Source = negro;
                L_2.Source = negro;
                L_3.Source = negro;
                L_4.Source = negro;
                L_5.Source = negro;
                L_6.Source = negro;
                L_7.Source = gris;
                L_8.Source = gris;
                L_9.Source = gris;
                L_10.Source = negro;
                L_11.Source = negro;
                L_12.Source = gris;
                L_13.Source = gris;
                L_14.Source = gris;
                L_15.Source = negro;
                L_16.Source = negro;
                L_17.Source = gris;
                L_18.Source = gris;
                L_19.Source = gris;
                L_20.Source = negro;
                L_21.Source = negro;
                L_22.Source = negro;
                L_23.Source = negro;
                L_24.Source = negro;
                L_25.Source = negro;
            }

            else if(Patrones.SelectedItem.ToString().Equals("Letra T"))
            {
                L_1.Source = negro;
                L_2.Source = negro;
                L_3.Source = negro;
                L_4.Source = negro;
                L_5.Source = negro;
                L_6.Source = gris;
                L_7.Source = gris;
                L_8.Source = negro;
                L_9.Source = gris;
                L_10.Source = gris;
                L_11.Source = gris;
                L_12.Source = gris;
                L_13.Source = negro;
                L_14.Source = gris;
                L_15.Source = gris;
                L_16.Source = gris;
                L_17.Source = gris;
                L_18.Source = negro;
                L_19.Source = gris;
                L_20.Source = gris;
                L_21.Source = gris;
                L_22.Source = gris;
                L_23.Source = negro;
                L_24.Source = gris;
                L_25.Source = gris;
            }

            else if(Patrones.SelectedItem.ToString().Equals("Letra U"))
            {
                L_1.Source = negro;
                L_2.Source = gris;
                L_3.Source = gris;
                L_4.Source = gris;
                L_5.Source = negro;
                L_6.Source = negro;
                L_7.Source = gris;
                L_8.Source = gris;
                L_9.Source = gris;
                L_10.Source = negro;
                L_11.Source = negro;
                L_12.Source = gris;
                L_13.Source = gris;
                L_14.Source = gris;
                L_15.Source = negro;
                L_16.Source = negro;
                L_17.Source = gris;
                L_18.Source = gris;
                L_19.Source = gris;
                L_20.Source = negro;
                L_21.Source = negro;
                L_22.Source = negro;
                L_23.Source = negro;
                L_24.Source = negro;
                L_25.Source = negro;
            }

            else if (Patrones.SelectedItem.ToString().Equals("Letra X"))
            {
                L_1.Source = negro;
                L_2.Source = gris;
                L_3.Source = gris;
                L_4.Source = gris;
                L_5.Source = negro;
                L_6.Source = gris;
                L_7.Source = negro;
                L_8.Source = gris;
                L_9.Source = negro;
                L_10.Source = gris;
                L_11.Source = gris;
                L_12.Source = gris;
                L_13.Source = negro;
                L_14.Source = gris;
                L_15.Source = gris;
                L_16.Source = gris;
                L_17.Source = negro;
                L_18.Source = gris;
                L_19.Source = negro;
                L_20.Source = gris;
                L_21.Source = negro;
                L_22.Source = gris;
                L_23.Source = gris;
                L_24.Source = gris;
                L_25.Source = negro;
            }

            else if (Patrones.SelectedItem.ToString().Equals("Elija un patrón de juego"))
            {
                L_1.Source = gris;
                L_2.Source = gris;
                L_3.Source = gris;
                L_4.Source = gris;
                L_5.Source = gris;
                L_6.Source = gris;
                L_7.Source = gris;
                L_8.Source = gris;
                L_9.Source = gris;
                L_10.Source = gris;
                L_11.Source = gris;
                L_12.Source = gris;
                L_13.Source = gris;
                L_14.Source = gris;
                L_15.Source = gris;
                L_16.Source = gris;
                L_17.Source = gris;
                L_18.Source = gris;
                L_19.Source = gris;
                L_20.Source = gris;
                L_21.Source = gris;
                L_22.Source = gris;
                L_23.Source = gris;
                L_24.Source = gris;
                L_25.Source = gris;
            }
        }

        private void start_button_Click(object sender, RoutedEventArgs e)
        {
            if (start_button.Content.ToString().Equals("Start Game"))
            {
                start_button.Content = "Reset Game";
                next_button.IsEnabled = true;
                bingo_button.IsEnabled = true;

                next_button_Click(sender, e);
            }

            else
            {
                if (MessageBox.Show("¿Está seguro que desea reiniciar el bingo?", "Reiniciar Bingo", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    start_button.Content = "Start Game";
                    next_button.IsEnabled = false;
                    bingo_button.IsEnabled = false;

                    RestartGame();
                }
            }
        }

        private void next_button_Click(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();

            for (int times = 0; times < 3; times++)
            {
                for (int i = numbers.Count - 1; i >= 1; i--)
                {
                    Random r = new Random();
                    int j = r.Next(0, i);

                    Label aux = numbers[j];
                    numbers[j] = numbers[i];
                    numbers[i] = aux;
                }
            }

            int n = Int32.Parse(numbers[0].Content.ToString());
            if (n <= 15)
            {
                Letra.Content = "B";
            }

            else if (n > 15 && n <= 30)
            {
                Letra.Content = "I";
            }

            else if (n > 30 && n <= 45)
            {
                Letra.Content = "N";
            }

            else if (n > 45 && n <= 60)
            {
                Letra.Content = "G";
            }

            else
            {
                Letra.Content = "O";
            }

            Numero.Content = n.ToString();

            salio.Insert(0, Letra.Content.ToString() + " " + Numero.Content.ToString());
            numbers.RemoveAt(0);

            UpdateLastNumbers();
            LightUp(n);

            if (numbers.Count == 0)
            {
                EndGame();
            }

            else
            {
                dispatcherTimer.Start();
            }
        }

        private void RestartGame()
        {
            Letra.Content = "Ready";
            Numero.Content = "";

            numbers.Clear();

            numbers.Add(_1);
            numbers.Add(_2);
            numbers.Add(_3);
            numbers.Add(_4);
            numbers.Add(_5);
            numbers.Add(_6);
            numbers.Add(_7);
            numbers.Add(_8);
            numbers.Add(_9);
            numbers.Add(_10);
            numbers.Add(_11);
            numbers.Add(_12);
            numbers.Add(_13);
            numbers.Add(_14);
            numbers.Add(_15);
            numbers.Add(_16);
            numbers.Add(_17);
            numbers.Add(_18);
            numbers.Add(_19);
            numbers.Add(_20);
            numbers.Add(_21);
            numbers.Add(_22);
            numbers.Add(_23);
            numbers.Add(_24);
            numbers.Add(_25);
            numbers.Add(_26);
            numbers.Add(_27);
            numbers.Add(_28);
            numbers.Add(_29);
            numbers.Add(_30);
            numbers.Add(_31);
            numbers.Add(_32);
            numbers.Add(_33);
            numbers.Add(_34);
            numbers.Add(_35);
            numbers.Add(_36);
            numbers.Add(_37);
            numbers.Add(_38);
            numbers.Add(_39);
            numbers.Add(_40);
            numbers.Add(_41);
            numbers.Add(_42);
            numbers.Add(_43);
            numbers.Add(_44);
            numbers.Add(_45);
            numbers.Add(_46);
            numbers.Add(_47);
            numbers.Add(_48);
            numbers.Add(_49);
            numbers.Add(_50);
            numbers.Add(_51);
            numbers.Add(_52);
            numbers.Add(_53);
            numbers.Add(_54);
            numbers.Add(_55);
            numbers.Add(_56);
            numbers.Add(_57);
            numbers.Add(_58);
            numbers.Add(_59);
            numbers.Add(_60);
            numbers.Add(_61);
            numbers.Add(_62);
            numbers.Add(_63);
            numbers.Add(_64);
            numbers.Add(_65);
            numbers.Add(_66);
            numbers.Add(_67);
            numbers.Add(_68);
            numbers.Add(_69);
            numbers.Add(_70);
            numbers.Add(_71);
            numbers.Add(_72);
            numbers.Add(_73);
            numbers.Add(_74);
            numbers.Add(_75);

            salio.Clear();
            ln_1.Content = "";
            ln_2.Content = "";
            ln_3.Content = "";
            ln_4.Content = "";
            ln_5.Content = "";

            dispatcherTimer.Start();

            foreach (Label l in tablero)
            {
                l.Foreground = Brushes.White;
            }
        }

        private void LightUp(int n)
        {
            for (int i = 0; i < tablero.Count; i++)
            {
                if (tablero[i].Content.ToString().Equals(n.ToString()))
                {
                    tablero[i].Foreground = Brushes.Red;
                }
            }
        }

        private void UpdateLastNumbers()
        {
            if (salio.Count == 2)
            {
                ln_1.Content = salio[1];
            }

            else if (salio.Count == 3)
            {
                ln_1.Content = salio[1];
                ln_2.Content = salio[2];
            }

            else if (salio.Count == 4)
            {
                ln_1.Content = salio[1];
                ln_2.Content = salio[2];
                ln_3.Content = salio[3];
            }

            else if (salio.Count == 5)
            {
                ln_1.Content = salio[1];
                ln_2.Content = salio[2];
                ln_3.Content = salio[3];
                ln_4.Content = salio[4];
            }

            else if (salio.Count > 5)
            {
                ln_1.Content = salio[1];
                ln_2.Content = salio[2];
                ln_3.Content = salio[3];
                ln_4.Content = salio[4];
                ln_5.Content = salio[5];
            }
        }

        private void EndGame()
        {
            next_button.IsEnabled = false;
        }

        private void bingo_button_Click(object sender, RoutedEventArgs e)
        {
            Winner w = new Winner();
            w.ShowDialog();

            if (w.reset)
            {
                start_button.Content = "Start Game";
                next_button.IsEnabled = false;
                bingo_button.IsEnabled = false;

                RestartGame();
            }
        }
	}
}
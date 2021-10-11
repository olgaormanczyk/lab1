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

namespace lab1
{
	/// <summary>
	/// Logika interakcji dla klasy MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
		public MainWindow()
		{

			InitializeComponent();

			dispatcherTimer.Interval = new TimeSpan(0, 0, 1); /// do formatu 
			dispatcherTimer.Tick += h; 
			dispatcherTimer.Start();


		}
		private void h(object sender, EventArgs e)
		{
			timer_label.Content = DateTime.Now.ToString("HH:mm:ss"); /// format czasu
		}

		private void stopper_button_Click(object sender, RoutedEventArgs e)
		{
			stop okno = new stop();
			okno.Show();
			
		}
	}
}

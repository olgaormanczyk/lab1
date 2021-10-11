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
using System.Windows.Shapes;

namespace lab1
{
	/// <summary>
	/// Logika interakcji dla klasy stop.xaml
	/// </summary>
	public partial class stop : Window

	{
		System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
		DateTime datetime = new DateTime();


		public stop()
		{

		InitializeComponent();
		dispatcherTimer.Tick += h ;
		dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
	
	}
		private void h(object sender, EventArgs e)
		{
			datetime = datetime.AddSeconds(1);
			timer_label.Content = datetime.ToString("HH:mm:ss");
		}
		private void Button_Click(object sender, RoutedEventArgs e) /// to jest start
		{
			dispatcherTimer.Start();
		}

		private void stop1_Click(object sender, RoutedEventArgs e) /// to jest stop
		{
			dispatcherTimer.Stop();
		}
	}
}

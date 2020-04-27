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

namespace Povrsine
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			Kvadrat p = new Pravougaonik(2, 3);
			MessageBox.Show(p.Povrsina().ToString());
		}
	}

	public class Kvadrat
	{
		public int duzinaA;
		public virtual int Povrsina() => duzinaA * duzinaA;

		public Kvadrat(int a) => duzinaA = a;
	}

	public class Pravougaonik : Kvadrat
	{
		public int duzinaB;
		public override int Povrsina() => duzinaA * duzinaB;

		public Pravougaonik(int a, int b) : base(a)
		{
			duzinaB = b;
		}
	}
}

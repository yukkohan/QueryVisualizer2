using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Class1 myClass = new Class1(this.txtBox.Text);

            this.txtResult.Text = myClass.getPartTxt(0);


            //var txt = Regex.Matches(txtBox.Text ,txtReg.Text);

            //if (txt.Count > 0) {

            //    List<String> ary = new List<string>();

            //    foreach (var tx in txt)
            //    {
            //        ary.Add(tx.ToString());
            //    }

            //    //txtResult.Text = ary[0] + ary[1] ;


            }






        }
    }

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

namespace CSharpTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            ///Just a simple function that takes numbers from both text boxes and adds them together, then outputs the answer.
            int numberOne;
            int numberTwo;

            //There has to be a better, less repeditive way! But alas, this is what the 
            //'net says is the best way to check if a value is numeric.
            bool isNum = int.TryParse(txtNumberOne.Text, out numberOne);

            if (!isNum) {
                lblAnswer.Content = "Please only use numeric values! HALP!";
                return;
            }
            //Same as above.
            //Gott in HIMMEL!
            isNum = int.TryParse(txtNumberTwo.Text, out numberTwo);

            if (!isNum)
            {
                lblAnswer.Content = "Please only use numeric values! HALP!";
                return;
            }

            int finalOutPut;

            //Just a set of if's to work out which checkbox was ticked.
            if (rdAdd.IsChecked == true)
            {
                finalOutPut = addNumbers(numberOne, numberTwo);
            } else if (rdMult.IsChecked == true)
            {
                finalOutPut = multiplyNumbers(numberOne, numberTwo);
            } else if (rdSub.IsChecked == true)
            {
                finalOutPut = subNumbers(numberOne, numberTwo);
            }
            else
            {
                //Uhhhh, we're boned... :(
                //We shouldn't be here, something went horribly wrong.
                finalOutPut = 0;
            }
            //Setting the content on the output label to match what we want.
            lblAnswer.Content = Convert.ToString(finalOutPut);
        }

        private int addNumbers(int int1, int int2)
        {
            return int1 + int2;
        }

        private int multiplyNumbers(int int1, int int2)
        {
            return int1 * int2;
        }

        private int subNumbers(int int1, int int2)
        {
            return int1 - int2;
        }




    }
}

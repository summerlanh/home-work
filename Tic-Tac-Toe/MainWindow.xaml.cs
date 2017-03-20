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

namespace Tic_Tac_Toe
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
        private int x;
        private Button winBtn;

        private void uxNewGame_Click(object sender, RoutedEventArgs e)
        {
            x = 0;
            winBtn = null;
            foreach (Button btn in uxGrid.Children)
            {
                btn.Content = null;
                btn.IsEnabled = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (x % 2 == 0)
            {
                btn.Content = "X";
                x++;
                btn.IsEnabled = false;
                IsWin();
            }
            else
            {
                btn.Content = "O";
                x++;
                btn.IsEnabled = false;
                IsWin();
            }

        }

        private void IsWin()
        {
            if ((btn1.Content == btn5.Content) & (btn5.Content == btn9.Content)& (btn1.Content!=null) )
            {
                winBtn = btn1;
                Win();
            }
            else if ((btn1.Content == btn2.Content) & (btn2.Content == btn3.Content) & (btn1.Content != null))
            {
                winBtn = btn1;
                Win();
            }
            else if ((btn1.Content == btn4.Content) & (btn4.Content == btn7.Content) & (btn1.Content != null))
            {
                winBtn = btn1;
                Win();
            }
            else if ((btn2.Content == btn5.Content) &(btn5.Content== btn8.Content) & (btn2.Content != null))
            {
                winBtn = btn2;
                Win();
            }
            else if ((btn3.Content == btn6.Content) & (btn6.Content == btn9.Content) & (btn3.Content != null))
            {
                winBtn = btn3;
                Win();
            }
            else if ((btn3.Content == btn5.Content) & (btn5.Content == btn7.Content) & (btn3.Content != null))
            {
                winBtn = btn3;
                Win();
            }
            else if ((btn4.Content == btn5.Content) & (btn5.Content == btn6.Content) & (btn4.Content != null))
            {
                winBtn = btn4;
                Win();
            }
            else if ((btn7.Content == btn8.Content) & (btn8.Content == btn9.Content) & (btn7.Content != null))
            {
                winBtn = btn7;
                Win();
            }
            else if (x % 2 == 0)
            {
                uxTurn.Text = "X's turn.";
            }
            else
            {
                uxTurn.Text = "O's turn.";
            }
        }

        private void Win()
        {
            uxTurn.Text = winBtn.Content + " is a Winner!";
            foreach (Button btn in uxGrid.Children)
            {
                btn.IsEnabled = false;
            }
        }
        private void uxExit_Click(object sender, RoutedEventArgs e)
        {
            Close();         
        }
    }
}
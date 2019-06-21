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
using System.IO;

namespace klawiatura
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TextBox BehaveTextbox;
        static bool cpLon = false;
        static bool shifton = false;
        static bool alton = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void cp_but_Click(object sender, RoutedEventArgs e)
        {

            if (cpLon)
                cpLon = false;
            else
                cpLon = true;
        }


        private void F_but_Click(object sender, RoutedEventArgs e)
        {
            if (cpLon)
                pisz.Text += "F";
            else
                pisz.Text += "f";
        }
        private void backspace_Click(object sender, RoutedEventArgs e)
        {
            string s = pisz.Text;

            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            }
            else
            {
                s = "";
            }

            pisz.Text = s;
        }

        private void Zamknij_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void u_but_Click(object sender, RoutedEventArgs e)
        {
            if (cpLon)
                pisz.Text += "U";
            else
                pisz.Text += "u";
        }

        private void l_but_Click(object sender, RoutedEventArgs e)
        {
            if (alton && (shifton || cpLon))
                pisz.Text += "Ł";
            else if (alton)
                pisz.Text += "ł";
            else if (cpLon)
                pisz.Text += "L";
            else
                pisz.Text += "l";
        }

        private void p_but_Click(object sender, RoutedEventArgs e)
        {
            if (cpLon)
                pisz.Text += "P";
            else
                pisz.Text += "p";
        }

        private void d_butClick(object sender, RoutedEventArgs e)
        {
            if (cpLon)
                pisz.Text += "D";
            else
                pisz.Text += "d";
        }

        private void h_but_Click(object sender, RoutedEventArgs e)
        {
            if (cpLon)
                pisz.Text += "H";
            else
                pisz.Text += "h";
        }

        private void k_but_Click(object sender, RoutedEventArgs e)
        {
            if (cpLon)
                pisz.Text += "K";
            else
                pisz.Text += "k";
        }

        private void t_but_Click(object sender, RoutedEventArgs e)
        {
            if (cpLon)
                pisz.Text += "T";
            else
                pisz.Text += "t";
        }

        private void y_but_Click(object sender, RoutedEventArgs e)
        {
            if (cpLon)
                pisz.Text += "Y";
            else
                pisz.Text += "y";
        }

        private void a_but_Click(object sender, RoutedEventArgs e)
        {
            if (alton && (shifton || cpLon))
                pisz.Text += "Ą";
            else if (alton)
                pisz.Text += "ą";
            else if (cpLon)
                pisz.Text += "A";
            else
                pisz.Text += "a";
        }

        private void e_but_Click(object sender, RoutedEventArgs e)
        {
            if (cpLon)
                pisz.Text += "E";
            else
                pisz.Text += "e";
        }

        private void s_but_Click(object sender, RoutedEventArgs e)
        {
            if (alton && (shifton || cpLon))
                pisz.Text += "Ś";
            else if (alton)
                pisz.Text += "ś";
            else if (cpLon)
                pisz.Text += "S";
            else
                pisz.Text += "s";
        }

        private void n_but_Click(object sender, RoutedEventArgs e)
        {
            if (cpLon)
                pisz.Text += "N";
            else
                pisz.Text += "n";
        }

        private void m_but_Click(object sender, RoutedEventArgs e)
        {
            if (cpLon)
                pisz.Text += "M";
            else
                pisz.Text += "m";
        }

        private void j_but_Click(object sender, RoutedEventArgs e)
        {
            if (cpLon)
                pisz.Text += "J";
            else
                pisz.Text += "j";
        }

        private void r_but_Click(object sender, RoutedEventArgs e)
        {
            if (cpLon)
                pisz.Text += "R";
            else
                pisz.Text += "r";
        }

        private void z_but_Click(object sender, RoutedEventArgs e)
        {
            if (cpLon)
                pisz.Text += "Z";
            else
                pisz.Text += "z";
        }

        private void o_but_Click(object sender, RoutedEventArgs e)
        {
            if (alton && (shifton || cpLon))
                pisz.Text += "Ó";
            else if (alton)
                pisz.Text += "ó";
            else if (cpLon)
                pisz.Text += "O";
            else
                pisz.Text += "o";
        }

        private void i_but_Click(object sender, RoutedEventArgs e)
        {
            if (cpLon)
                pisz.Text += "I";
            else
                pisz.Text += "i";
        }

        private void w_but_Click(object sender, RoutedEventArgs e)
        {
            if (cpLon)
                pisz.Text += "W";
            else
                pisz.Text += "w";
        }

        private void b_but_Click(object sender, RoutedEventArgs e)
        {
            if (cpLon)
                pisz.Text += "B";
            else
                pisz.Text += "b";
        }

        private void q_but_Click(object sender, RoutedEventArgs e)
        {
            if (cpLon)
                pisz.Text += "Q";
            else
                pisz.Text += "q";
        }

        private void g_but_Click(object sender, RoutedEventArgs e)
        {
            if (cpLon)
                pisz.Text += "G";
            else
                pisz.Text += "g";
        }

        private void c_but_Click(object sender, RoutedEventArgs e)
        {
            if (alton && (shifton || cpLon))
                pisz.Text += "Ć";
            else if (alton)
                pisz.Text += "ć";
            else if (cpLon)
                pisz.Text += "C";
            else
                pisz.Text += "c";
        }

        private void x_but_Click(object sender, RoutedEventArgs e)
        {
            if (cpLon)
                pisz.Text += "X";
            else
                pisz.Text += "x";
        }

        private void v_but_Click(object sender, RoutedEventArgs e)
        {
            if (cpLon)
                pisz.Text += "V";
            else
                pisz.Text += "v";
        }

        private void _1_but_Click(object sender, RoutedEventArgs e)
        {
            if (shifton)
                pisz.Text += "!";
            else
                pisz.Text += "1";
        }

        private void _2_but_Click(object sender, RoutedEventArgs e)
        {
            if (shifton)
                pisz.Text += "@";
            else
                pisz.Text += "2";
        }

        private void _3_but_Click(object sender, RoutedEventArgs e)
        {
            if (shifton)
                pisz.Text += "#";
            else
                pisz.Text += "3";
        }

        private void _4_but_Click(object sender, RoutedEventArgs e)
        {
            if (shifton)
                pisz.Text += "$";
            else
                pisz.Text += "4";
        }

        private void _5_but_Click(object sender, RoutedEventArgs e)
        {
            if (shifton)
                pisz.Text += "%";
            else
                pisz.Text += "5";
        }

        private void _6_but_Click(object sender, RoutedEventArgs e)
        {
            if (shifton)
                pisz.Text += "^";
            else
                pisz.Text += "6";
        }

        private void _7_but_Click(object sender, RoutedEventArgs e)
        {
            if (shifton)
                pisz.Text += "&";
            else
                pisz.Text += "7";
        }

        private void _8_but_Click(object sender, RoutedEventArgs e)
        {
            if (shifton)
                pisz.Text += "*";
            else
                pisz.Text += "8";
        }

        private void _9_but_Click(object sender, RoutedEventArgs e)
        {
            if (shifton)
                pisz.Text += "(";
            else
                pisz.Text += "9";
        }

        private void _0_but_Click(object sender, RoutedEventArgs e)
        {
            if (shifton)
                pisz.Text += ")";
            else
                pisz.Text += "0";
        }

        private void shift_but_Click(object sender, RoutedEventArgs e)
        {
            {

                if (shifton)
                    shifton = false;

                else
                    shifton = true;
            }
        }

        private void alt_but_Click(object sender, RoutedEventArgs e)
        {
            if (alton)
                alton = false;
            else
                alton = true;
        }

        private void enter_but_Click(object sender, RoutedEventArgs e)
        {
            pisz.Text += "\r\n";
        }
    }
}

    
/* Dominic Langowski
 * 4/19/2020 
 Good Times */
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

namespace CanadianTimeZones
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

        private void BtnTimezones_Click(object sender, RoutedEventArgs e)
        {
            // Variables
            int Input;
            int Pacific;
            int Mountain;
            int Central;
            int Eastern;
            int Atlantic;
            int NewFoundLand;
           
            // Variables

            // User Input
            int.TryParse(txtInput.Text, out Input);
            // User Input

            //Time Proportions
            Pacific = Input - 300;
            Mountain = Input - 200;
            Central = Input - 100;
            Eastern = Input;
            Atlantic = Input + 100;
            NewFoundLand = Input + 130;
            //Time Proportions

            //Outputs
            if (Pacific < 0)
            {
                lblOutputPacific.Content = 2400 + Pacific + " PST" +
                    Environment.NewLine + "Monday" + 
                    Environment.NewLine + "4/20/2020 ";
                
            }
           else
            {
                lblOutputPacific.Content = Pacific + " PST" + 
                    Environment.NewLine + "Tuesday" +
                    Environment.NewLine + "4/21/2020 "; 
            }
         
            
            if(Mountain < 0)
            {
                lblOutputMountain.Content = 2400 + Mountain + " MST" +
                    Environment.NewLine + "Monday" +
                    Environment.NewLine + "4/20/2020 "; 
            }
          else
            {
                lblOutputMountain.Content = Mountain + " MST" +
                    Environment.NewLine + "Tuesday" +
                    Environment.NewLine + "4/21/2020 "; 
            }
             
            if(Central < 0)
            {
                lblOutputCentral.Content = 2400 + Central + " CST" +
                    Environment.NewLine + "Monday" +
                    Environment.NewLine + "4/20/2020 "; 
            }
            else
            {
                lblOutputCentral.Content = Central + " CST" + 
                    Environment.NewLine + "Tuesday" +
                    Environment.NewLine + "4/21/2020 "; 
            }

            if(Atlantic > 2400)
            {
                lblOutputAtlantic.Content = Atlantic - 2400 + " AST" 
                    + Environment.NewLine + "Wednesday" +
                    Environment.NewLine + "4/23/2020 ";
            }
            else
            {
                lblOutputAtlantic.Content = Atlantic + " AST"
                + Environment.NewLine + "Tuesday" +
                    Environment.NewLine + "4/21/2020 ";
            }
           
            if(NewFoundLand > 2400)
            {
                lblOutputNewFoundLand.Content = NewFoundLand - 2400 + " ST"
                + Environment.NewLine + "Wednesday" +
                    Environment.NewLine + "4/23/2020 ";
            }
            else
            {
                lblOutputNewFoundLand.Content = NewFoundLand + " ST"
               + Environment.NewLine + "Tuesday" +
                   Environment.NewLine + "4/21/2020 ";
            }

            lblOutputEastern.Content = Eastern + " EST" 
                + Environment.NewLine + "Tuesday" +
                    Environment.NewLine + "4/21/2020 ";

            
            lblOutputOttawa.Content = Input 
                + Environment.NewLine + "Tuesday" +
                    Environment.NewLine + "4/21/2020 ";
            //Outputs








        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TimeApp
{
    /*
     * at startup, want to create list of stuff in picker
     * most of the time, it's not static
     */

    public partial class MainPage : ContentPage
    {
        myTimeChangeingClass myConverter; // global level object

        public MainPage() // constructor
        {
            InitializeComponent();
            // create list of stuff here.
            InitialiseProper();
            CreateListOfStuff();

        }

        private void InitialiseProper()
        {
            // instantiate a new myTimeChangeingClass object
            if (myConverter == null)
            {
                myConverter = new myTimeChangeingClass();

            }
        }

        private void CreateListOfStuff()
        {

            pckConversions.ItemsSource = myConverter.TimeChange;
        }

        private void pckConversions_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoConversions();
        }

        private void DoConversions()
        {
            double answer;  // local to this method
            // call method in conversion class to do the work
            answer = myConverter.convert(Convert.ToDouble(Hours.Text),
                                         pckConversions.SelectedIndex);
            // display the answer
            lblOutput.Text = " is  " +
                             answer.ToString("0")+":"+ Minutes.Text + " " +
                             myConverter.OutputUnits;
            lblInputUnits.Text = myConverter.InputUnits;
        }

        private void Hours_TextChanged(object sender, TextChangedEventArgs e)
        {
            DoConversions();
        }
    }
}

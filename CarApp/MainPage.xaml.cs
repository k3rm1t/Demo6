using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CarApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

        }

        private void trucksbutton_Click(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(trucktextBlock.Text); //0 -->0
            value++;
            trucktextBlock.Text = value.ToString(); // 2->"2"
        }

        private void carsbutton_Click(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(cartextBlock.Text); //0 -->0
            value++;
            cartextBlock.Text = value.ToString(); // 2->"2"
        }
    }
}

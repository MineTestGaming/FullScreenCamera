using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace Webcam
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Cameraswitch_Clicked(object sender, EventArgs e)
        {
            if (VideoCapture.CameraOptions == Xamarin.CommunityToolkit.UI.Views.CameraOptions.Front)
            {
                VideoCapture.CameraOptions = Xamarin.CommunityToolkit.UI.Views.CameraOptions.Back;
            }
            if (VideoCapture.CameraOptions == Xamarin.CommunityToolkit.UI.Views.CameraOptions.Back)
            {
                VideoCapture.CameraOptions = Xamarin.CommunityToolkit.UI.Views.CameraOptions.Front;
            }
        }

        private void Collapose_Clicked(object sender, EventArgs e)
        {
            ButtonsPanel.IsVisible = false;
        }
        protected override bool OnBackButtonPressed()
        {
            if (ButtonsPanel.IsVisible == false)
            {
                ButtonsPanel.IsVisible = true;
                return true;
            }
            if (ButtonsPanel.IsVisible == true)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            return base.OnBackButtonPressed();
        }
    }
}

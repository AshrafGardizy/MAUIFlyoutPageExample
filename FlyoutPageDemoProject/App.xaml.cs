using FlyoutPageDemoProject.FlyoutDemopages;

namespace FlyoutPageDemoProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ExapleFlyoutDemo();
                        
        }
    }
}

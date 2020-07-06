using System;
using System.Threading;
using System.Threading.Tasks;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TwitchGameBarWidget.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class WebPage : Page
    {
        public Thread UIUpdateThread;
        public WebPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Enabled;
        }

        /// <summary>
        /// Navigates to the given Video URL and show tips as soon as frame navigates to this Webpage.
        /// </summary>
        /// <param name="e">The navigation events, may containing an InformationPayload.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
                this.VideoUIWebpage.Navigate((Uri)e.Parameter);
                base.OnNavigatedTo(e);
        }

        /// <summary>
        /// Handles the keypresses on Webpage's main grid.
        /// 
        /// In case Backspace is pressed, navigates back to the main screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="keyArgs"></param>
        private async void HandleBackspacePress(object sender, KeyRoutedEventArgs keyArgs)
        {
            if (keyArgs.Key == Windows.System.VirtualKey.Back)
            {
                this.Frame.Navigate(typeof(MainPage));
            }
        }
    }
}

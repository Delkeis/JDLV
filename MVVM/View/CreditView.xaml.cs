using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Navigation;

namespace LeJeuDeLaVie.Mvvm.View
{
    /// <summary>
    /// Logique d'interaction pour CreditView.xaml
    /// </summary>
    public partial class CreditView : UserControl
    {
        public CreditView()
        {
            InitializeComponent();
        }

        private void MyLink_OnClick(object sender, RequestNavigateEventArgs e)
        {
            var linkAnnouncement = (Hyperlink) sender;
            var site = linkAnnouncement.NavigateUri.ToString();
            var uriInfo = new ProcessStartInfo(site)
            {
                UseShellExecute = true,
            };
            Process.Start(uriInfo);
            e.Handled = true;
        }
    }
}

using AduSkin.Controls.Metro;
using AnimeManager.Core;
using AnimeManager.WindowsM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AnimeManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            AnimeListDB_Updata();
        }

        private void AnimeListDB_Updata()
        {
            if (!App.AnimeManagerDb.ProjectModels.Any())
            {
                CardList cardList = new();

                for (int i = 0; i < 20; i++)
                {
                    var card = new Card(Properties.Resources.MoeMoe, "Hello World", "Test");
                    card.EditModeEnent += Card_EditModeEnent;
                    cardList.AddCard(card);
                }
                

                CardList.Children.Clear();
                CardList.Children.Add(cardList);
            }
        }

        private void Card_EditModeEnent(Core.Enum.EditMode mode)
        {
            MessageBox.Show(mode.ToString());
        }

        private void AduFlatButton_Setting(object sender, RoutedEventArgs e)
        {
            Setting.Focus();
        }
    }
}

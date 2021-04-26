using AnimeManager.Core;
using AnimeManager.Core.Enum;
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

namespace AnimeManager.WindowsM
{
    /// <summary>
    /// Card.xaml 的交互逻辑
    /// </summary>
    public partial class Card : UserControl
    {
        public event GetEditMode EditModeEnent;
        public delegate void GetEditMode(EditMode mode);
        public Card(byte[] Imagea, string ProjectName, string Context)
        {
            InitializeComponent();

            Image.Source = App.LoadImageSource(Imagea);
            this.ProjectName.Content = ProjectName;
            ComBoBox.SelectionChanged += ComBoBox_SelectionChanged;
        }

        private void ComBoBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComBoBox.SelectedIndex == 0)
            {
                return;
            }
            ComboBoxItem Action = (ComboBoxItem)ComBoBox.SelectedItem;
            EditMode mode = (EditMode)Enum.Parse(typeof(EditMode), Action.Name);
            ComBoBox.SelectedIndex = 0;
            EditModeEnent?.Invoke(mode);
        }
    }
}

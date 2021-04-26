using AnimeManager.Core.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace AnimeManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static AnimeManagerDbContext AnimeManagerDb { get; }

        #region 弹窗标题
        public const string AnimeTitle = "动画剧集属性";
        public const string MovieTitle = "电影属性";
        #endregion

        static App()
        {
            AnimeManagerDb = new AnimeManagerDbContext();
            AnimeManagerDb.Database.EnsureCreated();
        }

        public static ImageSource LoadImageSource(byte[] b)
        {
            var Image = new BitmapImage();
            Image.BeginInit();
            Image.StreamSource = new System.IO.MemoryStream(b);
            Image.EndInit();
            return Image;
        }
    }
}

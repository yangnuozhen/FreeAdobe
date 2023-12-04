using ReFreeAdobe;
using ReFreeAdobe.Properties;
using ReFreeAdobe.src.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ReFreeAdobe.src.view
{
    /// <summary>
    /// PatchResult.xaml 的交互逻辑
    /// </summary>
    public partial class PatchResult : Window
    {
        private string title;
        private string content;
        private bool isSucc;
        string eventType;

        public PatchResult(string Title,string Content,bool isSucc)
        {
            this.title = Title;
            this.content = Content;
            this.isSucc = isSucc;
            InitializeComponent();
            initView();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        private void initView()
        {
            TitleText.Text = title;
            tbContent.Text = content;
            if(isSucc)
            {
                string imagePath = "/resources/success.png";
                Uri imageUri = new Uri(imagePath, UriKind.Relative);
                succImage.Source = new BitmapImage(imageUri);
            }
        }


        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

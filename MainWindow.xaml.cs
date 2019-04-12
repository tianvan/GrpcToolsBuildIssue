using System.Windows;
using SomeServices;

namespace GrpcToolsBuildIssue
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            new RequestMessage();
        }
    }
}

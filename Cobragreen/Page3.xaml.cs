using System.Windows.Controls;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;



namespace Cobragreen
{
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }
        
        private void OpenFile_Click(object sender, RoutedEventArgs e)
           {
               OpenFileDialog openFileDialog = new OpenFileDialog();
               openFileDialog.Filter = "JBB Files (*.jbb)|*.jbb|All Files (*.*)|*.*";
               if (openFileDialog.ShowDialog() == true)
               {
                   string filePath = openFileDialog.FileName;
                   textBox.Text = File.ReadAllText(filePath);
               }
           }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfCustomControlItemToolTip
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Items.Add(
                new Item(
                    "XItem 12345",
                    new[]
                    {
                        new SubItem("Sub1", null),
                        new SubItem("Sub2", null)
                    }));
        }

        public ObservableCollection<Item> Items { get; } = new ObservableCollection<Item>();
    }
}

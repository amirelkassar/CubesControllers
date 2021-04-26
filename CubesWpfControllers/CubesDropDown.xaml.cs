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

namespace WpfComboboxTreeview
{
    /// <summary>
    /// Interaction logic for CubesDropDown.xaml
    /// </summary>
    public partial class CubesDropDown : UserControl
    {
        private MainViewModel vm = null;
        public CubesDropDown()
        {
            InitializeComponent();
            vm = new MainViewModel();
            DataContext = vm;
        }
        public List<SomeHierarchyViewModel> Items { get=> vm.Items; } 

        public SomeHierarchyViewModel SelectedItem { get => vm.SelectedItem; }
    }
}

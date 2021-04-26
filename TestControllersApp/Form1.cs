using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Data;
using WpfComboboxTreeview;

namespace TestControllersApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var items13 = new List<SomeHierarchyViewModel>{
                                new SomeHierarchyViewModel("Item 1.3.1", null),
                                new SomeHierarchyViewModel("Item 1.3.2", null)};

            var items1 = new List<SomeHierarchyViewModel>{
                                new SomeHierarchyViewModel("Item 1.1", null),
                                new SomeHierarchyViewModel("Item 1.2", null),
                                new SomeHierarchyViewModel("Item 1.3", items13)};
            var items2 = new List<SomeHierarchyViewModel>{
                                new SomeHierarchyViewModel("Item 2.1", null),
                                new SomeHierarchyViewModel("Item 2.2", null)};

            var outerItems = new List<SomeHierarchyViewModel>{
                                new SomeHierarchyViewModel("Item 1", items1),
                                new SomeHierarchyViewModel("Item 2", items2)};
            foreach (var item in outerItems)
            {
                cubesDropDown1.Items.Add(item);
            }
            
        }
    }
}

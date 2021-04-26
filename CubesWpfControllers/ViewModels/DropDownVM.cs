using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubesWpfControllers.ViewModels
{
    public class DropDownVM
    {
        public DropDownVM()
        {
            Items = new List<SomeHierarchyViewModel>();
        }
        public List<SomeHierarchyViewModel> Items { get; set; }

        public SomeHierarchyViewModel SelectedItem { get; set; }
    }
}

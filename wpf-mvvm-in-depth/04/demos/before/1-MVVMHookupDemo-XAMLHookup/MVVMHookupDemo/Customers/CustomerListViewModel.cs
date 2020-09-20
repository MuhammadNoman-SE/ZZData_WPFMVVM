using MVVMHookupDemo.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zza.Data;

namespace MVVMHookupDemo.Customers
{
    public class CustomerListViewModel
    {
        ICustomersRepository r = new CustomersRepository();
        public CustomerListViewModel() {
            if (DesignerProperties.GetIsInDesignMode(
                new System.Windows.DependencyObject())) return;
               
            Customers = new ObservableCollection<Customer>( r.GetCustomersAsync().Result);
        }
        public ObservableCollection<Customer> Customers { get; set; }
    }
}

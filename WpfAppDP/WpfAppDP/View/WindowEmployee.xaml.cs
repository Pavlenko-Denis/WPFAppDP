using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WpfAppDP.Helper;
using WpfAppDP.Model;

namespace WpfAppDP.View
{
    /// <summary>
    /// Логика взаимодействия для WindowEmloyee.xaml
    /// </summary>
    public partial class WindowEmployee : Window
    {
        private PersonViewModel vmPerson;
        private ObservableCollection<PersonDPO> personsDPO;
        private ObservableCollection<Role> roles;
        public WindowEmployee(PersonViewModel vmPerson)
        {
            InitializeComponent();
            DataContext = vmPerson;
            this.vmPerson = vmPerson;
            lvEmployee.ItemsSource = vmPerson.ListPersonDPO;
        }
 
        public void LvEmployee_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
{

    vmPerson.SelectedPersonDPO = (PersonDPO)e.AddedItems[0];
}
     }
 }
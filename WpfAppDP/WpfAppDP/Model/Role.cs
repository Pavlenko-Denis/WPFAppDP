using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppDP.View;
using WpfAppDP.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfAppDP.Model
{
    public class Role : INotifyPropertyChanged
    {

         public int Id { get; set; }
        private string nameRole;
        public string NameRole
        {
            get
            {
                                return nameRole;
                            }
            set
            {
                nameRole = value;
                OnPropertyChanged("NameRole");
                            }
        }
        public Role() { }
        public Role(int id, string nameRole)
        {
            this.Id = id;
            this.NameRole = nameRole;
        }

        public Role ShallowCopy()
        {
                        return (Role)this.MemberwiseClone();
                    }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
         }
}
}
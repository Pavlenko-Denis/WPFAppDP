using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

 
 namespace WpfAppDP.Model
{
    public class PersonDPO : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string _roleName;
        public string RoleName
        {
            get { return _roleName; }
            set
            {
                _roleName = value;
                OnPropertyChanged("RoleName");
            }
        }

        private string firstName;        
        public string FirstName
{
            get { return firstName; }
            set
    {
        firstName = value;
        OnPropertyChanged("FirstName");
                    }
        }
public string Role { get; set; }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        private DateTime birthday;
        public DateTime Birthday
        {
            get { return birthday; }
            set
            {
                birthday = value;
                OnPropertyChanged("Birthday");
            }
        }
         public PersonDPO() { }

        public PersonDPO(int id, string roleName, string firstName, string lastName, DateTime birthday)
{
    this.Id = id;
    this.RoleName = roleName;
    this.FirstName = firstName;
    this.LastName = lastName;
    this.Birthday = birthday;
}
 
         public PersonDPO ShallowCopy()
{
    return (PersonDPO)this.MemberwiseClone();
}

public PersonDPO CopyFromPerson(Person person)
{
    PersonDPO perDPO = new PersonDPO();
    RoleViewModel vmRole = new RoleViewModel();
    string role = string.Empty;
    foreach (var r in vmRole.ListRole)
    {
        if (r.Id == person.RoleId)
        {
            role = r.NameRole;
            break;
        }
    }
    if (role != string.Empty)
    {
        perDPO.Id = person.Id;
        perDPO.Role = role;
        perDPO.FirstName = person.FirstName;
        perDPO.LastName = person.LastName;
        perDPO.Birthday = person.Birthday;
    }
    return perDPO;
}

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



     }
 }
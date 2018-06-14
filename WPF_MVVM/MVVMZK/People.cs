using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVMZK
{
    public class People : INotifyPropertyChanged
    {
        private string name;
        private string surname;
        private long mobNumb;


        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("name");
            }
        }
        public string Surname
        {
            get { return surname; }
            set
            {
                surname = value;
                OnPropertyChanged("surname");
            }
        }
        public long MobNumb
        {
            get { return mobNumb; }
            set
            {
                mobNumb = value;
                OnPropertyChanged("mobNumb");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

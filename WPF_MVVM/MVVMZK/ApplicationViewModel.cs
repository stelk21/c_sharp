using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace MVVMZK
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private People selectedPeople;
        public ObservableCollection<People> Peoples { get; set; }

        // команда добавления нового объекта
        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      People people = new People();
                      Peoples.Insert(0, people);
                      SelectedPeople = people;
                  }));
            }
        }
        // команда удаления
        private RelayCommand removeCommand;
        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ??
                  (removeCommand = new RelayCommand(obj =>
                  {
                      People people = obj as People;
                      if (people != null)
                      {
                          Peoples.Remove(people);
                      }
                  },
                 (obj) => Peoples.Count > 0));
            }
        }

        public People SelectedPeople
        {
            get { return selectedPeople; }
            set
            {
                selectedPeople = value;
                OnPropertyChanged("SelectedPeople");
            }
        }

        public ApplicationViewModel()
        {
            Peoples = new ObservableCollection<People>
            {
                new People { Name="Иван", Surname="Иванов", MobNumb=89202059712 },
                new People { Name="Петр", Surname="Петров", MobNumb=89201546123 },
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
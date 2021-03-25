using System.Collections.ObjectModel;

namespace DayPlaning.Models
{
    class MainModel
    {
        private ObservableCollection<Action> _actions = new ObservableCollection<Action>();
        public ReadOnlyObservableCollection<Action> Actions;

        public MainModel()
        {
            Actions = new ReadOnlyObservableCollection<Action>(_actions);
        }

        public void AddAction(Action action)
        {
            _actions.Add(action);
        }
        public void DeleteAction(Action action)
        {
            _actions.Remove(action);
        }
    }
}

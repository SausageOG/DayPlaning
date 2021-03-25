using DayPlaning.Models;
using Prism.Commands;
using System.Collections.ObjectModel;

namespace DayPlaning.ViewModels
{
    class MainWinVM
    {
        public string Title { get; set; }
        public int From { get; set; }
        public int To { get; set; }
        public string Color { get; set; }


        MainModel model;

        public ReadOnlyObservableCollection<Action> ActionsView => model.Actions;

        public DelegateCommand AddCommand { get; private set; }

        public MainWinVM()
        {
            model = new MainModel();


        }

        private void Add()
        {
            Action newAction = new Action();
            newAction.Title = Title;
            newAction.From = From;
            newAction.To = To;
            newAction.Color = Color;

            model.AddAction(newAction);
        }
    }
}

using DayPlaning.Models;
using Prism.Commands;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DayPlaning.ViewModels
{
    class MainWinVM
    {
        public string Title { get; set; }
        public int From { get; set; }
        public int To { get; set; }
        public string Color { get; set; }




        MainModel model;

        private ObservableCollection<ColorOfR> colorsOfR;
        public ObservableCollection<ColorOfR> ColorOfRs => colorsOfR;
        public ReadOnlyObservableCollection<Action> ActionsView => model.Actions;

        public DelegateCommand AddCommand { get; private set; }

        public MainWinVM()
        {
            model = new MainModel();

            AddCommand = new DelegateCommand(Add);


            colorsOfR = new ObservableCollection<ColorOfR>();

            InitOfColorR();
        }

        private void Add()
        {
            Action newAction = new Action();
            newAction.Title = Title;
            newAction.From = From;
            newAction.To = To;
            newAction.Color = Color;

            model.AddAction(newAction);

            Coloring(newAction);
        }

        private void Coloring(Action action)
        {
            string color = action.Color;

            for (int i = action.From; i != action.To; i++)
            {
                colorsOfR[i].Color = color;
            }
        }

        private void InitOfColorR()
        {
            ColorOfR colorOfR1 = new ColorOfR();
            ColorOfR colorOfR2 = new ColorOfR();
            ColorOfR colorOfR3 = new ColorOfR();
            ColorOfR colorOfR4 = new ColorOfR();
            ColorOfR colorOfR5 = new ColorOfR();
            ColorOfR colorOfR6 = new ColorOfR();
            ColorOfR colorOfR7 = new ColorOfR();
            ColorOfR colorOfR8 = new ColorOfR();
            ColorOfR colorOfR9 = new ColorOfR();
            ColorOfR colorOfR10 = new ColorOfR();
            ColorOfR colorOfR11 = new ColorOfR();
            ColorOfR colorOfR12 = new ColorOfR();
            ColorOfR colorOfR13 = new ColorOfR();
            ColorOfR colorOfR14 = new ColorOfR();
            ColorOfR colorOfR15 = new ColorOfR();
            ColorOfR colorOfR16 = new ColorOfR();
            ColorOfR colorOfR17 = new ColorOfR();
            ColorOfR colorOfR18 = new ColorOfR();
            ColorOfR colorOfR19 = new ColorOfR();
            ColorOfR colorOfR20 = new ColorOfR();
            ColorOfR colorOfR21 = new ColorOfR();
            ColorOfR colorOfR22 = new ColorOfR();
            ColorOfR colorOfR23 = new ColorOfR();
            ColorOfR colorOfR24 = new ColorOfR();

            colorsOfR.Add(colorOfR1);
            colorsOfR.Add(colorOfR2);
            colorsOfR.Add(colorOfR3);
            colorsOfR.Add(colorOfR4);
            colorsOfR.Add(colorOfR5);
            colorsOfR.Add(colorOfR6);
            colorsOfR.Add(colorOfR7);
            colorsOfR.Add(colorOfR8);
            colorsOfR.Add(colorOfR9);
            colorsOfR.Add(colorOfR10);
            colorsOfR.Add(colorOfR11);
            colorsOfR.Add(colorOfR12);
            colorsOfR.Add(colorOfR13);
            colorsOfR.Add(colorOfR14);
            colorsOfR.Add(colorOfR15);
            colorsOfR.Add(colorOfR16);
            colorsOfR.Add(colorOfR17);
            colorsOfR.Add(colorOfR18);
            colorsOfR.Add(colorOfR19);
            colorsOfR.Add(colorOfR20);
            colorsOfR.Add(colorOfR21);
            colorsOfR.Add(colorOfR22);
            colorsOfR.Add(colorOfR23);
            colorsOfR.Add(colorOfR24);
        }

    }
    class ColorOfR : INotifyPropertyChanged
    {
        private string color;
        public string Color
        {
            get { return color; }
            set
            {
                color = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

using DayPlaning.Models;
using Prism.Commands;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Action = DayPlaning.Models.Action;

namespace DayPlaning.ViewModels
{
    class MainWinVM : INotifyPropertyChanged
    {
        private string _title;
        private string _from;
        private string _to;
        private string _color;


        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }
        public string From
        {
            get { return _from; }
            set
            {
                _from = value;
                OnPropertyChanged();
            }
        }
        public string To
        {
            get { return _to; }
            set
            {
                _to = value;
                OnPropertyChanged();
            }
        }
        public string Color
        {
            get { return _color; }
            set
            {
                _color = value;
                OnPropertyChanged();
            }
        }




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
            if (string.IsNullOrWhiteSpace(_title))
            {
                //TODO: some alert that one of field is null or contains only whitespaces
            }


            Action newAction = new Action();
            newAction.Title = Title;
            newAction.From = From;
            newAction.To = To;
            newAction.Color = Color;




            model.AddAction(newAction);

            Coloring(newAction);

            ClearFields();
        }

        private void Coloring(Action action)
        {
            string color = action.Color;
            int from = Int32.Parse(action.From);
            int to = Int32.Parse(action.To);

            if (from < to)
            {
                for (int i = from; i != to; i++)
                {
                    colorsOfR[i].Color = color;
                }
            }
            else if (to < from)
            {
                for (int i = to; i != -1; i--)
                {
                    colorsOfR[i].Color = color;
                }
                for (int i = from; i != 24; i++)
                {
                    colorsOfR[i].Color = color;
                }
            }



        }

        private void CheckForNullOrWiteSpace(string title, string from, string to, string color)
        {

        }

        private void ClearFields()
        {
            Title = "";
            From = "";
            To = "";
            Color = "";
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

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
    class ColorOfR : INotifyPropertyChanged
    {
        private string color = "White";
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

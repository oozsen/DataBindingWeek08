﻿using System;
using System.ComponentModel;

namespace DataBindingWeek08
{
    public class MainViewModel :INotifyPropertyChanged
    {
        string name = string.Empty;
        public string Name
        {
            get => name;
            set
            {
                if (name == value)
                    return;

                name = value;
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(DisplayName));
            }
        }

        public string DisplayName => $"Name Entered: {Name}";

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged (string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}

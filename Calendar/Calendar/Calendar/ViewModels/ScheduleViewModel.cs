using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Drawing;
using Xamarin.Essentials;
using System.ComponentModel;
using Calendar.Models;

namespace Calendar.ViewModels
{
    public class ScheduleViewModel
    {
        public ObservableCollection<Schedule> schedule { get; set; }

        public ScheduleViewModel()
        {
            schedule = new ObservableCollection<Schedule>
            {
                new Schedule
                {
                    Title = "Breakfast, Food and Cereal",
                    Description = "Yogurt, banana, apple, ...",
                    Hour = "08:30AM",
                    Features = new List<Features>
                    {
                        new Features
                        {
                            Name = "Light",
                            BGColor = ColorConverters.FromHex("#F0FBF3"),
                            TxColor = ColorConverters.FromHex("#74D884")
                        },
                        new Features
                        {
                            Name = "Energized",
                            BGColor = ColorConverters.FromHex("#FEFBEC"),
                            TxColor = ColorConverters.FromHex("#FCD058")
                        },
                        new Features
                        {
                            Name = "Satisfied",
                            BGColor = ColorConverters.FromHex("#FCEEEB"),
                            TxColor = ColorConverters.FromHex("#FE4134")
                        },
                        new Features
                        {
                            Name = "Healthy",
                            BGColor = ColorConverters.FromHex("#FEFBEC"),
                            TxColor = ColorConverters.FromHex("#74D884")
                        },
                        new Features
                        {
                            Name = "Comfortable",
                            BGColor = ColorConverters.FromHex("#F0FBF3"),
                            TxColor = ColorConverters.FromHex("#74D884")
                        }
                    }
                },
                new Schedule
                {
                    Title = "Lunch, Falafel wrap",
                    Description = "Falafel, yogurt, onions, tomatoes ...",
                    Hour = "12:30PM",
                    Features = new List<Features>
                    {
                        new Features
                        {
                            Name = "Energized",
                            BGColor = ColorConverters.FromHex("#FEFBEC"),
                            TxColor = ColorConverters.FromHex("#FCD058")
                        },
                        new Features
                        {
                            Name = "Light",
                            BGColor = ColorConverters.FromHex("#F0FBF3"),
                            TxColor = ColorConverters.FromHex("#74D884")
                        },
                        new Features
                        {
                            Name = "Satisfied",
                            BGColor = ColorConverters.FromHex("#FCEEEB"),
                            TxColor = ColorConverters.FromHex("#FE4134")
                        },
                        new Features
                        {
                            Name = "Healthy",
                            BGColor = ColorConverters.FromHex("#FEFBEC"),
                            TxColor = ColorConverters.FromHex("#FCD058")
                        },
                    }
                },
                new Schedule
                {
                    Title = "Dinner, bean chili",
                    Description = "Brown rice, tomatoes, kidney beans...",
                    Hour = "07:30PM",
                    Features = new List<Features>
                    {
                        new Features
                        {
                            Name = "Light",
                            BGColor = ColorConverters.FromHex("#F0FBF3"),
                            TxColor = ColorConverters.FromHex("#74D884")
                        },
                        new Features
                        {
                            Name = "Satisfied",
                            BGColor = ColorConverters.FromHex("#FCEEEB"),
                            TxColor = ColorConverters.FromHex("#FE4134")
                        }
                    }
                }
            };
        }
    }
}
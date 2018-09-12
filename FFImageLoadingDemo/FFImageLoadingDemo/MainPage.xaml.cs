﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FFImageLoadingDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var model = new MainPageViewModel();
            BindingContext = model;
        }
    }

    public class MainPageViewModel
    {
        public string GuidesFilterImage
        {
            set;
            get;
        }

        public MainPageViewModel()
        {
            GuidesFilterImage = "resource://FFImageLoadingDemo.Resources.sample.svg";
        }
    }

}

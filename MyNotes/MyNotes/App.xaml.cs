﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyNotes
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NotesPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

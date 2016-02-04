﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace TestIcon
{
  public partial class App : Application
  {
    public App ()
    {
      InitializeComponent ();
      //var fix = typeof(UXDivers.Artina.Shared.EntryProperties);

      MainPage = new TestIcon.MainPage ();
    }

    protected override void OnStart ()
    {
      // Handle when your app starts
    }

    protected override void OnSleep ()
    {
      // Handle when your app sleeps
    }

    protected override void OnResume ()
    {
      // Handle when your app resumes
    }
  }
}
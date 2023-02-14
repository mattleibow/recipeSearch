﻿using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using Recipes.Services;
using Recipes.Views;
using System.Collections.Generic;
using Recipes.ViewModels;

namespace Recipes
{
    public partial class App : Microsoft.Maui.Controls.Application
    {

        public App()
        {
			InitializeComponent();
            DependencyService.Register<MockDataStore>();
			MainPage = new AppShell();

			//MainPage = new EditRecipePage();
			//(MainPage.BindingContext as EditRecipeViewModel).Id = "78315810-2ad0-4a54-a976-dd80fbfa8d90";
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

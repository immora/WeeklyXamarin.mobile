﻿using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Container = WeeklyXamarin.Core.Services.Container;
using WeeklyXamarin.Core.ViewModels;
using WeeklyXamarin.Core.Models;
using Microsoft.Extensions.DependencyInjection;
using WeeklyXamarin.Core.Helpers;
namespace WeeklyXamarin.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    [QueryProperty(nameof(ArticleId), Constants.Navigation.ParameterNames.ArticleId)]
    [QueryProperty(nameof(EditionId), Constants.Navigation.ParameterNames.EditionId)]
    public partial class ArticleDetailPage : PageBase<ArticleDetailViewModel>
    {
        public string ArticleId { get; set; }
        public string EditionId { get; set; }

        public ArticleDetailPage()
        {
            InitializeComponent();
        }


        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await ViewModel.Initialize(EditionId, ArticleId);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"Imma scrolling {e.ScrollY}");
        }
    }
}
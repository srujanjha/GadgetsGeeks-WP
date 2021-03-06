// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   	PageCS.tt
// Version:		2.0
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Entities=WPAppStudio.Entities;
using Ioc=WPAppStudio.Ioc;
using IServices=WPAppStudio.Services.Interfaces;
using IViewModels=WPAppStudio.ViewModel.Interfaces;
using Localization=WPAppStudio.Localization;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MyToolkit.Paging;
using Repositories=WPAppStudio.Repositories;
using WPAppStudio;
using WPAppStudio.Shared;

namespace WPAppStudio.View
{
    /// <summary>
    /// Phone application page for GeekyGadgets_Detail.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class GeekyGadgets_Detail : PhoneApplicationPage
    {       
        /// <summary>
        /// Initializes the phone application page for GeekyGadgets_Detail and all its components.
        /// </summary>
        public GeekyGadgets_Detail()
        {
            InitializeComponent();        
			if (Resources.Contains("PanoramaGeekyGadgets_Detail0AppBar"))
				PhonePage.SetApplicationBar(this, Resources["PanoramaGeekyGadgets_Detail0AppBar"] as BindableApplicationBar);                            
		}
		
        private void panoramaGeekyGadgets_Detail_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {		
			InitializeAppBarpanoramaGeekyGadgets_Detail(PanoramaGeekyGadgets_Detail.SelectedItem as PanoramaItem);
        }
		
		private void InitializeAppBarpanoramaGeekyGadgets_Detail(PanoramaItem panoramaItem)        
        {
			if (Resources.Contains(panoramaItem.Name + "AppBar"))
			{
				PhonePage.SetApplicationBar(this, Resources[panoramaItem.Name + "AppBar"] as BindableApplicationBar);            
				ApplicationBar.IsVisible = true;
            }
		    else if(ApplicationBar != null)
		        ApplicationBar.IsVisible = false;
        }
 
        /// <summary>
        /// Called when the page becomes the active page.
        /// </summary>
        /// <param name="e">Contains information about the navigation done.</param>
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            string currentId;
			
            if (NavigationContext.QueryString.TryGetValue("currentID", out currentId))
            {
				var dataSource = new Ioc.Container().Resolve<Repositories.IGeekyGadgets_s3>();
				AddHomeAppBarButton();
				var pinnedItemSpec = new FilterSpecification().AddPredicate("Title", ColumnOperatorEnum.Equals, currentId);
				var pinnedItem  = (await dataSource.Search(pinnedItemSpec)).FirstOrDefault();
				if(pinnedItem==null)
					MessageBox.Show(Localization.AppResources.PinError);
				((IViewModels.IGeekyGadgets_DetailViewModel)DataContext).CurrentRssSearchResult = pinnedItem;				
			}
		}

        private void AddHomeAppBarButton()
        {
            if (ApplicationBar.Buttons.Count >= 4 ||
                ApplicationBar.Buttons.Cast<ApplicationBarIconButton>().Any(button => button.Text == "Home")) 
                return;
						
			var homeIcon = new ApplicationBarIconButton() {IconUri = new Uri("/Images/Icons/Light/Home.png", UriKind.Relative), IsEnabled = true, Text = "Home"};
            homeIcon.Click += delegate 
			{ 
				new Ioc.Container().Resolve<IServices.INavigationService>().NavigateTo<IViewModels.INDTVGadgets_NewsViewModel>(); 
				while (NavigationService.RemoveBackEntry() != null);
			};
            ApplicationBar.Buttons.Add(homeIcon);
        }
    }
}

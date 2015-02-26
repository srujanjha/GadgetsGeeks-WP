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
    /// Phone application page for NDTVGadgets_News.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class NDTVGadgets_News : PhoneApplicationPage
    {       
        /// <summary>
        /// Initializes the phone application page for NDTVGadgets_News and all its components.
        /// </summary>
        public NDTVGadgets_News()
        {
            InitializeComponent();        
			if (Resources.Contains("PanoramaNDTVGadgets_News0AppBar"))
				PhonePage.SetApplicationBar(this, Resources["PanoramaNDTVGadgets_News0AppBar"] as BindableApplicationBar);                            
		}
		
        private void panoramaNDTVGadgets_News_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {		
			InitializeAppBarpanoramaNDTVGadgets_News(PanoramaNDTVGadgets_News.SelectedItem as PanoramaItem);
        }
		
		private void InitializeAppBarpanoramaNDTVGadgets_News(PanoramaItem panoramaItem)        
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
        protected override  void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
		
            NDTVGadgets_NewsListControl.SelectedItem = null;
		
            CNET_NewsListControl.SelectedItem = null;
		
            GeekyGadgets_NewsListControl.SelectedItem = null;
		
            CnetNEWS_NewsListControl.SelectedItem = null;
		
            Videos_VideosListControl.SelectedItem = null;
		}
    }
}
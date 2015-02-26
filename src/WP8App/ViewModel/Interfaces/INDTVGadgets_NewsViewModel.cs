// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   	IViewModel.tt
// Version:		2.0
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Entities = WPAppStudio.Entities;
using EntitiesBase = WPAppStudio.Entities.Base;

namespace WPAppStudio.ViewModel.Interfaces
{
    /// <summary>
    /// NDTVGadgets_News ViewModel interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface INDTVGadgets_NewsViewModel
    {		
        /// <summary>
        /// Gets/Sets the NDTVGadgets_NewsListControlCollection property.
        /// </summary>
		ObservableCollection<EntitiesBase.RssSearchResult> NDTVGadgets_NewsListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the SelectedNDTVGadgets_NewsListControlCollection property.
        /// </summary>
		EntitiesBase.RssSearchResult SelectedNDTVGadgets_NewsListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the CNET_NewsListControlCollection property.
        /// </summary>
		ObservableCollection<EntitiesBase.RssSearchResult> CNET_NewsListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the SelectedCNET_NewsListControlCollection property.
        /// </summary>
		EntitiesBase.RssSearchResult SelectedCNET_NewsListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the GeekyGadgets_NewsListControlCollection property.
        /// </summary>
		ObservableCollection<EntitiesBase.RssSearchResult> GeekyGadgets_NewsListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the SelectedGeekyGadgets_NewsListControlCollection property.
        /// </summary>
		EntitiesBase.RssSearchResult SelectedGeekyGadgets_NewsListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the CnetNEWS_NewsListControlCollection property.
        /// </summary>
		ObservableCollection<EntitiesBase.RssSearchResult> CnetNEWS_NewsListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the SelectedCnetNEWS_NewsListControlCollection property.
        /// </summary>
		EntitiesBase.RssSearchResult SelectedCnetNEWS_NewsListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the Videos_VideosListControlCollection property.
        /// </summary>
		ObservableCollection<EntitiesBase.YouTubeVideo> Videos_VideosListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the Videos_VideosListControlCollectionPageNumber property.
        /// </summary>
		int Videos_VideosListControlCollectionPageNumber { get; set; }
        /// <summary>
        /// Gets/Sets the SelectedVideos_VideosListControlCollection property.
        /// </summary>
		EntitiesBase.YouTubeVideo SelectedVideos_VideosListControlCollection { get; set; }
        
        /// <summary>
        /// Gets the RefreshNDTVGadgets_NewsListControlCollectionCommand command.
        /// </summary>
		ICommand RefreshNDTVGadgets_NewsListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the GetNDTVGadgets_NewsListControlCollectionCommand command.
        /// </summary>
		ICommand GetNDTVGadgets_NewsListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the RefreshCNET_NewsListControlCollectionCommand command.
        /// </summary>
		ICommand RefreshCNET_NewsListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the GetCNET_NewsListControlCollectionCommand command.
        /// </summary>
		ICommand GetCNET_NewsListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the RefreshGeekyGadgets_NewsListControlCollectionCommand command.
        /// </summary>
		ICommand RefreshGeekyGadgets_NewsListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the GetGeekyGadgets_NewsListControlCollectionCommand command.
        /// </summary>
		ICommand GetGeekyGadgets_NewsListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the RefreshCnetNEWS_NewsListControlCollectionCommand command.
        /// </summary>
		ICommand RefreshCnetNEWS_NewsListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the GetCnetNEWS_NewsListControlCollectionCommand command.
        /// </summary>
		ICommand GetCnetNEWS_NewsListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the RefreshVideos_VideosListControlCollectionCommand command.
        /// </summary>
		ICommand RefreshVideos_VideosListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the GetVideos_VideosListControlCollectionCommand command.
        /// </summary>
		ICommand GetVideos_VideosListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the SetLockScreenCommand command.
        /// </summary>
		ICommand SetLockScreenCommand { get; }

        
        /// <summary>
        /// Gets the AboutCommand command.
        /// </summary>
		ICommand AboutCommand { get; }

	}
}

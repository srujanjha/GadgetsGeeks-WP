// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   	ViewModel.tt
// Version:		2.0
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Controls = WPAppStudio.Controls;
using Entities = WPAppStudio.Entities;
using EntitiesBase = WPAppStudio.Entities.Base;
using IServices = WPAppStudio.Services.Interfaces;
using IViewModels = WPAppStudio.ViewModel.Interfaces;
using Localization = WPAppStudio.Localization;
using Repositories = WPAppStudio.Repositories;
using Services = WPAppStudio.Services;
using ViewModelsBase = WPAppStudio.ViewModel.Base;
using WPAppStudio;
using WPAppStudio.Shared;

namespace WPAppStudio.ViewModel
{
    /// <summary>
    /// Implementation of GeekyGadgets_Detail ViewModel.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class GeekyGadgets_DetailViewModel : ViewModelsBase.VMBase, IViewModels.IGeekyGadgets_DetailViewModel, ViewModelsBase.INavigable
    {       

		private readonly Repositories.GeekyGadgets_s3 _geekyGadgets_s3;
		private readonly IServices.IDialogService _dialogService;
		private readonly IServices.INavigationService _navigationService;
		private readonly IServices.ISpeechService _speechService;
		private readonly IServices.IShareService _shareService;
		private readonly IServices.ILiveTileService _liveTileService;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="GeekyGadgets_DetailViewModel" /> class.
        /// </summary>
        /// <param name="geekyGadgets_s3">The Geeky Gadgets_s3.</param>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="speechService">The Speech Service.</param>
        /// <param name="shareService">The Share Service.</param>
        /// <param name="liveTileService">The Live Tile Service.</param>
        public GeekyGadgets_DetailViewModel(Repositories.GeekyGadgets_s3 geekyGadgets_s3, IServices.IDialogService dialogService, IServices.INavigationService navigationService, IServices.ISpeechService speechService, IServices.IShareService shareService, IServices.ILiveTileService liveTileService)
        {
			_geekyGadgets_s3 = geekyGadgets_s3;
			_dialogService = dialogService;
			_navigationService = navigationService;
			_speechService = speechService;
			_shareService = shareService;
			_liveTileService = liveTileService;
        }
		
	
		private EntitiesBase.RssSearchResult _currentRssSearchResult;

        /// <summary>
        /// CurrentRssSearchResult property.
        /// </summary>		
        public EntitiesBase.RssSearchResult CurrentRssSearchResult
        {
            get
            {
				return _currentRssSearchResult;
            }
            set
            {
                SetProperty(ref _currentRssSearchResult, value);
            }
        }
	
		private bool _hasNextpanoramaGeekyGadgets_Detail0;

        /// <summary>
        /// HasNextpanoramaGeekyGadgets_Detail0 property.
        /// </summary>		
        public bool HasNextpanoramaGeekyGadgets_Detail0
        {
            get
            {
				return _hasNextpanoramaGeekyGadgets_Detail0;
            }
            set
            {
                SetProperty(ref _hasNextpanoramaGeekyGadgets_Detail0, value);
            }
        }
	
		private bool _hasPreviouspanoramaGeekyGadgets_Detail0;

        /// <summary>
        /// HasPreviouspanoramaGeekyGadgets_Detail0 property.
        /// </summary>		
        public bool HasPreviouspanoramaGeekyGadgets_Detail0
        {
            get
            {
				return _hasPreviouspanoramaGeekyGadgets_Detail0;
            }
            set
            {
                SetProperty(ref _hasPreviouspanoramaGeekyGadgets_Detail0, value);
            }
        }

        /// <summary>
        /// Delegate method for the TextToSpeechGeekyGadgets_DetailStaticControlCommand command.
        /// </summary>
        public  void TextToSpeechGeekyGadgets_DetailStaticControlCommandDelegate() 
        {
				_speechService.TextToSpeech(CurrentRssSearchResult.Title + " " + CurrentRssSearchResult.Content);
        }
		

        private ICommand _textToSpeechGeekyGadgets_DetailStaticControlCommand;

        /// <summary>
        /// Gets the TextToSpeechGeekyGadgets_DetailStaticControlCommand command.
        /// </summary>
        public ICommand TextToSpeechGeekyGadgets_DetailStaticControlCommand
        {
            get { return _textToSpeechGeekyGadgets_DetailStaticControlCommand = _textToSpeechGeekyGadgets_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(TextToSpeechGeekyGadgets_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the ShareGeekyGadgets_DetailStaticControlCommand command.
        /// </summary>
        public  void ShareGeekyGadgets_DetailStaticControlCommandDelegate() 
        {
				_shareService.Share(CurrentRssSearchResult.Title, CurrentRssSearchResult.Content, CurrentRssSearchResult.FeedUrl, CurrentRssSearchResult.ImageUrl);
        }
		

        private ICommand _shareGeekyGadgets_DetailStaticControlCommand;

        /// <summary>
        /// Gets the ShareGeekyGadgets_DetailStaticControlCommand command.
        /// </summary>
        public ICommand ShareGeekyGadgets_DetailStaticControlCommand
        {
            get { return _shareGeekyGadgets_DetailStaticControlCommand = _shareGeekyGadgets_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(ShareGeekyGadgets_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the PinToStartGeekyGadgets_DetailStaticControlCommand command.
        /// </summary>
        public  void PinToStartGeekyGadgets_DetailStaticControlCommandDelegate() 
        {
				_liveTileService.PinToStart(typeof(IViewModels.IGeekyGadgets_DetailViewModel), CreateTileInfoGeekyGadgets_DetailStaticControl());
        }
		

        private ICommand _pinToStartGeekyGadgets_DetailStaticControlCommand;

        /// <summary>
        /// Gets the PinToStartGeekyGadgets_DetailStaticControlCommand command.
        /// </summary>
        public ICommand PinToStartGeekyGadgets_DetailStaticControlCommand
        {
            get { return _pinToStartGeekyGadgets_DetailStaticControlCommand = _pinToStartGeekyGadgets_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(PinToStartGeekyGadgets_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the GoToSourceGeekyGadgets_DetailStaticControlCommand command.
        /// </summary>
        public  void GoToSourceGeekyGadgets_DetailStaticControlCommandDelegate() 
        {
				_navigationService.NavigateTo(string.IsNullOrEmpty(CurrentRssSearchResult.FeedUrl) ? null : new Uri(CurrentRssSearchResult.FeedUrl));
        }
		

        private ICommand _goToSourceGeekyGadgets_DetailStaticControlCommand;

        /// <summary>
        /// Gets the GoToSourceGeekyGadgets_DetailStaticControlCommand command.
        /// </summary>
        public ICommand GoToSourceGeekyGadgets_DetailStaticControlCommand
        {
            get { return _goToSourceGeekyGadgets_DetailStaticControlCommand = _goToSourceGeekyGadgets_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(GoToSourceGeekyGadgets_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the NextpanoramaGeekyGadgets_Detail0 command.
        /// </summary>
        public async void NextpanoramaGeekyGadgets_Detail0Delegate() 
        {
				LoadingCurrentRssSearchResult = true;
			var next = await  _geekyGadgets_s3.Next(CurrentRssSearchResult);

			if(next != null)
				CurrentRssSearchResult = next;

			RefreshHasPrevNext();
        }
		
		
        private bool _loadingCurrentRssSearchResult;
		
        public bool LoadingCurrentRssSearchResult
        {
            get { return _loadingCurrentRssSearchResult; }
            set { SetProperty(ref _loadingCurrentRssSearchResult, value); }
        }

        private ICommand _nextpanoramaGeekyGadgets_Detail0;

        /// <summary>
        /// Gets the NextpanoramaGeekyGadgets_Detail0 command.
        /// </summary>
        public ICommand NextpanoramaGeekyGadgets_Detail0
        {
            get { return _nextpanoramaGeekyGadgets_Detail0 = _nextpanoramaGeekyGadgets_Detail0 ?? new ViewModelsBase.DelegateCommand(NextpanoramaGeekyGadgets_Detail0Delegate); }
        }

        /// <summary>
        /// Delegate method for the PreviouspanoramaGeekyGadgets_Detail0 command.
        /// </summary>
        public async void PreviouspanoramaGeekyGadgets_Detail0Delegate() 
        {
				LoadingCurrentRssSearchResult = true;
			var prev = await  _geekyGadgets_s3.Previous(CurrentRssSearchResult);

			if(prev != null)
				CurrentRssSearchResult = prev;

			RefreshHasPrevNext();
        }
		

        private ICommand _previouspanoramaGeekyGadgets_Detail0;

        /// <summary>
        /// Gets the PreviouspanoramaGeekyGadgets_Detail0 command.
        /// </summary>
        public ICommand PreviouspanoramaGeekyGadgets_Detail0
        {
            get { return _previouspanoramaGeekyGadgets_Detail0 = _previouspanoramaGeekyGadgets_Detail0 ?? new ViewModelsBase.DelegateCommand(PreviouspanoramaGeekyGadgets_Detail0Delegate); }
        }

        private async void RefreshHasPrevNext()
        {
            HasPreviouspanoramaGeekyGadgets_Detail0 = await _geekyGadgets_s3.HasPrevious(CurrentRssSearchResult);
			HasNextpanoramaGeekyGadgets_Detail0 = await _geekyGadgets_s3.HasNext(CurrentRssSearchResult);
			LoadingCurrentRssSearchResult = false;
		}
		public object NavigationContext
        {
            set
            {              
                if (!(value is EntitiesBase.RssSearchResult)) { return; }
                
                CurrentRssSearchResult = value as EntitiesBase.RssSearchResult;
                RefreshHasPrevNext();
            }
        }
        /// <summary>
        /// Initializes a <see cref="Services.TileInfo" /> object for the GeekyGadgets_DetailStaticControl control.
        /// </summary>
		/// <returns>A <see cref="Services.TileInfo" /> object.</returns>
        public Services.TileInfo CreateTileInfoGeekyGadgets_DetailStaticControl()
        {
            var tileInfo = new Services.TileInfo
            {
                CurrentId = CurrentRssSearchResult.Title,
                Title = CurrentRssSearchResult.Title,
                BackTitle = CurrentRssSearchResult.Title,
                BackContent = CurrentRssSearchResult.Content,
                Count = 0,
                BackgroundImagePath = CurrentRssSearchResult.ImageUrl,
                BackBackgroundImagePath = CurrentRssSearchResult.ImageUrl,
                LogoPath = "DoWApp-Logo.png"
            };
            return tileInfo;
        }
    }
}

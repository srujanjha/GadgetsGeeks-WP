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
    /// Implementation of CNET_Detail ViewModel.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class CNET_DetailViewModel : ViewModelsBase.VMBase, IViewModels.ICNET_DetailViewModel, ViewModelsBase.INavigable
    {       

		private readonly Repositories.CNET_s2 _cNET_s2;
		private readonly IServices.IDialogService _dialogService;
		private readonly IServices.INavigationService _navigationService;
		private readonly IServices.ISpeechService _speechService;
		private readonly IServices.IShareService _shareService;
		private readonly IServices.ILiveTileService _liveTileService;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="CNET_DetailViewModel" /> class.
        /// </summary>
        /// <param name="cNET_s2">The C N E T_s2.</param>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="speechService">The Speech Service.</param>
        /// <param name="shareService">The Share Service.</param>
        /// <param name="liveTileService">The Live Tile Service.</param>
        public CNET_DetailViewModel(Repositories.CNET_s2 cNET_s2, IServices.IDialogService dialogService, IServices.INavigationService navigationService, IServices.ISpeechService speechService, IServices.IShareService shareService, IServices.ILiveTileService liveTileService)
        {
			_cNET_s2 = cNET_s2;
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
	
		private bool _hasNextpanoramaCNET_Detail0;

        /// <summary>
        /// HasNextpanoramaCNET_Detail0 property.
        /// </summary>		
        public bool HasNextpanoramaCNET_Detail0
        {
            get
            {
				return _hasNextpanoramaCNET_Detail0;
            }
            set
            {
                SetProperty(ref _hasNextpanoramaCNET_Detail0, value);
            }
        }
	
		private bool _hasPreviouspanoramaCNET_Detail0;

        /// <summary>
        /// HasPreviouspanoramaCNET_Detail0 property.
        /// </summary>		
        public bool HasPreviouspanoramaCNET_Detail0
        {
            get
            {
				return _hasPreviouspanoramaCNET_Detail0;
            }
            set
            {
                SetProperty(ref _hasPreviouspanoramaCNET_Detail0, value);
            }
        }

        /// <summary>
        /// Delegate method for the TextToSpeechCNET_DetailStaticControlCommand command.
        /// </summary>
        public  void TextToSpeechCNET_DetailStaticControlCommandDelegate() 
        {
				_speechService.TextToSpeech(CurrentRssSearchResult.Title + " " + CurrentRssSearchResult.Content);
        }
		

        private ICommand _textToSpeechCNET_DetailStaticControlCommand;

        /// <summary>
        /// Gets the TextToSpeechCNET_DetailStaticControlCommand command.
        /// </summary>
        public ICommand TextToSpeechCNET_DetailStaticControlCommand
        {
            get { return _textToSpeechCNET_DetailStaticControlCommand = _textToSpeechCNET_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(TextToSpeechCNET_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the ShareCNET_DetailStaticControlCommand command.
        /// </summary>
        public  void ShareCNET_DetailStaticControlCommandDelegate() 
        {
				_shareService.Share(CurrentRssSearchResult.Title, CurrentRssSearchResult.Content, CurrentRssSearchResult.FeedUrl, CurrentRssSearchResult.ImageUrl);
        }
		

        private ICommand _shareCNET_DetailStaticControlCommand;

        /// <summary>
        /// Gets the ShareCNET_DetailStaticControlCommand command.
        /// </summary>
        public ICommand ShareCNET_DetailStaticControlCommand
        {
            get { return _shareCNET_DetailStaticControlCommand = _shareCNET_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(ShareCNET_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the PinToStartCNET_DetailStaticControlCommand command.
        /// </summary>
        public  void PinToStartCNET_DetailStaticControlCommandDelegate() 
        {
				_liveTileService.PinToStart(typeof(IViewModels.ICNET_DetailViewModel), CreateTileInfoCNET_DetailStaticControl());
        }
		

        private ICommand _pinToStartCNET_DetailStaticControlCommand;

        /// <summary>
        /// Gets the PinToStartCNET_DetailStaticControlCommand command.
        /// </summary>
        public ICommand PinToStartCNET_DetailStaticControlCommand
        {
            get { return _pinToStartCNET_DetailStaticControlCommand = _pinToStartCNET_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(PinToStartCNET_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the GoToSourceCNET_DetailStaticControlCommand command.
        /// </summary>
        public  void GoToSourceCNET_DetailStaticControlCommandDelegate() 
        {
				_navigationService.NavigateTo(string.IsNullOrEmpty(CurrentRssSearchResult.FeedUrl) ? null : new Uri(CurrentRssSearchResult.FeedUrl));
        }
		

        private ICommand _goToSourceCNET_DetailStaticControlCommand;

        /// <summary>
        /// Gets the GoToSourceCNET_DetailStaticControlCommand command.
        /// </summary>
        public ICommand GoToSourceCNET_DetailStaticControlCommand
        {
            get { return _goToSourceCNET_DetailStaticControlCommand = _goToSourceCNET_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(GoToSourceCNET_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the NextpanoramaCNET_Detail0 command.
        /// </summary>
        public async void NextpanoramaCNET_Detail0Delegate() 
        {
				LoadingCurrentRssSearchResult = true;
			var next = await  _cNET_s2.Next(CurrentRssSearchResult);

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

        private ICommand _nextpanoramaCNET_Detail0;

        /// <summary>
        /// Gets the NextpanoramaCNET_Detail0 command.
        /// </summary>
        public ICommand NextpanoramaCNET_Detail0
        {
            get { return _nextpanoramaCNET_Detail0 = _nextpanoramaCNET_Detail0 ?? new ViewModelsBase.DelegateCommand(NextpanoramaCNET_Detail0Delegate); }
        }

        /// <summary>
        /// Delegate method for the PreviouspanoramaCNET_Detail0 command.
        /// </summary>
        public async void PreviouspanoramaCNET_Detail0Delegate() 
        {
				LoadingCurrentRssSearchResult = true;
			var prev = await  _cNET_s2.Previous(CurrentRssSearchResult);

			if(prev != null)
				CurrentRssSearchResult = prev;

			RefreshHasPrevNext();
        }
		

        private ICommand _previouspanoramaCNET_Detail0;

        /// <summary>
        /// Gets the PreviouspanoramaCNET_Detail0 command.
        /// </summary>
        public ICommand PreviouspanoramaCNET_Detail0
        {
            get { return _previouspanoramaCNET_Detail0 = _previouspanoramaCNET_Detail0 ?? new ViewModelsBase.DelegateCommand(PreviouspanoramaCNET_Detail0Delegate); }
        }

        private async void RefreshHasPrevNext()
        {
            HasPreviouspanoramaCNET_Detail0 = await _cNET_s2.HasPrevious(CurrentRssSearchResult);
			HasNextpanoramaCNET_Detail0 = await _cNET_s2.HasNext(CurrentRssSearchResult);
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
        /// Initializes a <see cref="Services.TileInfo" /> object for the CNET_DetailStaticControl control.
        /// </summary>
		/// <returns>A <see cref="Services.TileInfo" /> object.</returns>
        public Services.TileInfo CreateTileInfoCNET_DetailStaticControl()
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

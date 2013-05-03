﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using XAMLPatterns.MessageBus.Models;

namespace XAMLPatterns.MessageBus.ViewModels
{
    public class ConferenceViewModel : ViewModelBase
    {
        private readonly ConferenceService _conferenceService;
        private ObservableCollection<SessionHeaderViewModel> _sessions = new ObservableCollection<SessionHeaderViewModel>();
        private SessionHeaderViewModel _selectedSession = null;
        
        public ConferenceViewModel()
        {
            _conferenceService = new ConferenceService();

            foreach (var session in _conferenceService.GetSessions())
                _sessions.Add(new SessionHeaderViewModel
                {
                    Id = session.Id,
                    Title = session.Title
                });
        }

        public IEnumerable<SessionHeaderViewModel> Sessions
        {
            get { return _sessions; }
        }

        public SessionHeaderViewModel SelectedSession
        {
            get { return _selectedSession; }

            set
            {
                if (_selectedSession == value)
                    return;

                RaisePropertyChanging(() => this.SelectedSession);
                _selectedSession = value;
                RaisePropertyChanged(() => this.SelectedSession);
            }
        }
    }
}
﻿using System;
using XAMLPatterns.ShadowTypes.Models;

namespace XAMLPatterns.ShadowTypes.ViewModels
{
    public class SessionViewModel
    {
        private readonly Session _session;

        public SessionViewModel(Session session)
        {
            _session = session;
        }

        public string Title
        {
            get { return _session.Title; }
        }

        public string Speaker
        {
            get { return _session.Speaker.Name; }
        }

        public DateTime Time
        {
            get { return _session.Time; }
        }

        public string Room
        {
            get { return "Room: " + _session.Room.Name; }
        }

        public string Description
        {
            get { return _session.Description; }
        }
    }
}
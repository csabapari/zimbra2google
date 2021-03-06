﻿using System;
using Google.Apis.Auth.OAuth2;

namespace Pari.Ics2Google.Core.Import2Google
{
    public class Import2GoogleInput : IInput
    {
        public Import2GoogleInput(UserCredential credential, string icsPath, string googleCalendar, DateTime importFrom)
        {
            this.Credential = credential;
            this.IcsPath = icsPath;
            this.GoogleCalendar = googleCalendar;
            this.ImportFrom = importFrom;
        }

        public UserCredential Credential { get; }

        public string IcsPath { get; }

        public string GoogleCalendar { get; }

        public DateTime ImportFrom { get; }
    }
}

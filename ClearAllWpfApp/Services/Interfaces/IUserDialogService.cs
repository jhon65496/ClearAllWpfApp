﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleExampleWpfApp.Services.Interfaces
{
    interface IUserDialogService
    {
        bool Edit(object item);

        void ShowInformation(string Information, string Caption);

        void ShowWarning(string Message, string Caption);

        void ShowError(string Message, string Caption);

        bool Confirm(string Message, string Caption, bool Exclamation = false);

        string GetStringValue(string Message, string Caption, string DefaultValue = null);
    }
}

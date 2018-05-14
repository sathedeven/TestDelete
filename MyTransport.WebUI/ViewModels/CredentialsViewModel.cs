﻿using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

using MyTransport.WebUI.ViewModels.Validators;
using FluentValidation.Attributes;

namespace MyTransport.WebUI.ViewModels
{
    [Validator(typeof(CredentialsViewModelValidator))]
    public class CredentialsViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

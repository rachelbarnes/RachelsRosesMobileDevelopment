﻿
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System.Linq;
using System;

namespace RachelBarnesMobileDevelopment.Models {

    public class SplitException : Exception {
        //exceptions
        public SplitException() { }
        public SplitException(string message) : base(message) { }
    }
}

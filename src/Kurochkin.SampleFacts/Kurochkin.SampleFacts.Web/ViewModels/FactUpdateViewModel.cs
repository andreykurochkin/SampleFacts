﻿using System;
using System.Collections.Generic;

namespace Kurochkin.SampleFacts.Web.ViewModels
{
    public class FactUpdateViewModel
    {
        public Guid Id { get; set; }

        public string Content { get; set; }
        public IEnumerable<string> Tags { get; set; }
    }
}
using Kurochkin.SampleFacts.Web.Data;
using System;
using System.Collections.Generic;

namespace Kurochkin.SampleFacts.Web.ViewModels
{
    public class TagViewModel
    {
        public Guid Id { get; set; }
 
        public string Name { get; set; }
        
        public ICollection<Fact> Facts { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAPI.Core.Options
{
    public class ConnectionStringOption
    {
        public const string SectionName = "ConnectionStrings";
        public string DefaultConnection { get; set; }
    }
}

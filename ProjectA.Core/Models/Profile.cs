using ProjectA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectA.Core.Models
{
    public class Profile : BaseEntity
    {
        public enum Gender { Male, Female };
        public DateTimeOffset DOB { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Image { get; set; }

    }
}

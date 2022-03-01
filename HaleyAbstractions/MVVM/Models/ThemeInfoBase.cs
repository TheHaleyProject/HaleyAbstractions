using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Haley.Models
{
    public class ThemeInfoBase
    {
        /// <summary>
        /// A name for the theme
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Path of the resource dictionary containing the theme values.
        /// </summary>
        public Uri Path { get; set; }
        public ThemeInfoBase(string name, Uri path) 
        {
            Name = name;
            Path = path; 
        }
    }
}

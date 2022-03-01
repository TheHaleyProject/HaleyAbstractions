using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Haley.Models
{
    public class ThemeInfo
    {

        public string Id { get; }

        /// <summary>
        /// A name for the theme
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Path of the resource dictionary containing the theme values.
        /// </summary>
        public Uri Path { get; set; }
        public ThemeInfo(string name, Uri path) 
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Path = path; 
        }
    }
}

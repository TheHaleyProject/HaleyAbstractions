using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Haley.Enums;

namespace Haley.Models
{
    public class ThemeInfo
    {
        public string Id { get; }
        public string GroupId { get;}
        /// <summary>
        /// Path of the resource dictionary containing the theme values.
        /// </summary>
        public Uri Path { get; set; }
        public ThemeInfo(Uri path,string groupId) 
        {
            Id = Guid.NewGuid().ToString();
            if(groupId == null)
            {
                throw new ArgumentNullException(nameof(groupId));
            }
            GroupId = groupId;
            Path = path; 
        }

        public override string ToString()
        {
            StringBuilder sbuilder = new StringBuilder();
            if (Path != null) sbuilder.Append(Path);
            sbuilder.Append(" - " + Id);
            return sbuilder.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is ThemeInfo info)) return false;
            return this.Id.Equals(info.Id) && this.GroupId.Equals(info.GroupId);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

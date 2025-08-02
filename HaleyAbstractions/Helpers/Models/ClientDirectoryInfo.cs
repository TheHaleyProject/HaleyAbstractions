using System;
using System.Collections.Generic;
using System.Text;

namespace Haley.Models {
    public class ClientDirectoryInfo : StorageDirectoryInfo {
        public string SigningKey { get; set; }
        public string EncryptKey { get; set; }
        public string PasswordHash { get; set; }
        public string DatabaseName { get; set; }
        public void Assert() {
            if (string.IsNullOrEmpty(SigningKey) || string.IsNullOrEmpty(EncryptKey) || string.IsNullOrEmpty(PasswordHash)) throw new ArgumentNullException("Keys Cannot be empty");
            if (string.IsNullOrEmpty(DisplayName) || string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Path)) throw new ArgumentNullException("Name & Path Cannot be empty");
        }
        public ClientDirectoryInfo(string display_name) :this (display_name,null) { }
        public ClientDirectoryInfo(string display_name,string password) : this(display_name, password, null, null) { }
        public ClientDirectoryInfo(string display_name,string password, string signingkey,string encryptkey) { 
            DisplayName = display_name;
            PasswordHash = password;
            SigningKey = signingkey;
            EncryptKey = encryptkey;
        }
    }
}

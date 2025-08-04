using Haley.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Haley.Models {
    public class OSSClientInfo : OSSDirectory {
        public string SigningKey { get; set; }
        public string EncryptKey { get; set; }
        public string PasswordHash { get; set; }
        public string DatabaseName { get; set; }
        public void Assert() {
            if (string.IsNullOrEmpty(SigningKey) || string.IsNullOrEmpty(EncryptKey) || string.IsNullOrEmpty(PasswordHash)) throw new ArgumentNullException("Keys Cannot be empty");
            if (string.IsNullOrEmpty(SaveAsName) || string.IsNullOrEmpty(DisplayName) || string.IsNullOrEmpty(Path)) throw new ArgumentNullException("Name & Path Cannot be empty");
        }
        public OSSClientInfo() { }
        public OSSClientInfo(string password, string signingkey,string encryptkey) { 
            PasswordHash = password;
            SigningKey = signingkey;
            EncryptKey = encryptkey;
        }
    }
}

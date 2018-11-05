using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraSystem.Models
{
    public class FileModel
    {
        [DisplayName("File Name")]
        public string FileName { get; set; }
        [DisplayName("Extention")]
        public string Extention { get; set; }
        [DisplayName("Version")]
        public string Version { get; set; }
        [DisplayName("Current Version")]
        public string CurrentVersion { get; set; }
        [DisplayName("Create Time")]
        public DateTime CreateTime { get; set; }
        [DisplayName("Last Modify")]
        public DateTime LastModify { get; set; }
        public string FullPath { get; set; }
    }
}

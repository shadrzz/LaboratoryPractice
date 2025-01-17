using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryPractice.Models
{
    public class FileModel
    {
        public string Address { get; set; }
        public string AccessMode { get; set; }
        public string AccessDate { get; set; }

        public FileModel(string address, string accessMode, string accessDate)
        {
            Address = address;
            AccessMode = accessMode;
            AccessDate = accessDate;
        }
    }
}

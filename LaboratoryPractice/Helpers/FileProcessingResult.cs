using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaboratoryPractice.Models;

namespace LaboratoryPractice.Helpers
{
    public class FileProcessingResult
    {
        public bool IsSuccess { get; }
        public string ErrorMessage { get; }
        public List<Models.Info> Files { get; }

        private FileProcessingResult(bool isSuccess, string errorMessage, List<Models.Info> files)
        {
            IsSuccess = isSuccess;
            ErrorMessage = errorMessage;
            Files = files ?? new List<Models.Info>();
        }

        public static FileProcessingResult Success(List<Models.Info> files)
        {
            return new FileProcessingResult(true, string.Empty, files);
        }

        public static FileProcessingResult Fail(string errorMessage)
        {
            return new FileProcessingResult(false, errorMessage, null);
        }
    }
}

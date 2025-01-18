namespace LaboratoryPractice.Helpers
{
    public class FileProcessingResult
    {
        public bool IsSuccess { get; }
        public string ErrorMessage { get; }
        public List<Models.InfoModel> Files { get; }

        private FileProcessingResult(bool isSuccess, string errorMessage, List<Models.InfoModel> files)
        {
            IsSuccess = isSuccess;
            ErrorMessage = errorMessage;
            Files = files ?? new List<Models.InfoModel>();
        }

        public static FileProcessingResult Success(List<Models.InfoModel> files)
        {
            return new FileProcessingResult(true, string.Empty, files);
        }

        public static FileProcessingResult Fail(string errorMessage)
        {
            return new FileProcessingResult(false, errorMessage, null);
        }
    }
}

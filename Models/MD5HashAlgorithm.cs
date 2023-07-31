namespace HashCalc.Models
{
    public class Md5HashAlgorithm : IHashAlgorithm
    {
        public string AlgorithmName { get; set;}

        public string CalculateHashValue(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}

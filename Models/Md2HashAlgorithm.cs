namespace HashCalc.Models
{
    public class Md2HashAlgorithm : IHashAlgorithm
    {
        public string AlgorithmName { get; set; }

        public string CalculateHashValue(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}

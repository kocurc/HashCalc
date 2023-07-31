namespace HashCalc.Models
{
    public class Sha256HashAlgorithm : IHashAlgorithm
    {
        public string AlgorithmName { get; set; }

        public string CalculateHashValue(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}

namespace HashCalc.Models
{
    public class Ripemd160HashAlgorithm : IHashAlgorithm
    {
        public string AlgorithmName { get; set; }

        public string CalculateHashValue(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}

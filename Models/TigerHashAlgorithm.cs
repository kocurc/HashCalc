namespace HashCalc.Models
{
    public class TigerHashAlgorithm : IHashAlgorithm
    {
        public string AlgorithmName { get; set; }

        public string CalculateHashValue(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}

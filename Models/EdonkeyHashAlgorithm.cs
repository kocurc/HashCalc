namespace HashCalc.Models
{
    public class EdonkeyHashAlgorithm : IHashAlgorithm
    {
        public string AlgorithmName { get; set; }

        public string CalculateHashValue(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}

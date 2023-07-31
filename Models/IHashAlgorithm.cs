namespace HashCalc.Models
{
    public interface IHashAlgorithm
    {
        public string CalculateHashValue(string filePath);
    }
}

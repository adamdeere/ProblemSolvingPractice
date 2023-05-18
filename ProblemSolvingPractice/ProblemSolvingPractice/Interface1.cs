namespace ProblemSolvingPractice
{
    public interface ICalculateResults
    {
        int CalculateResults(int range);
    }

    public interface ICalulateLargeResults
    {
        long CalculateResults(int range);
    }

    public interface ICalculateProduct
    {
        char[] ReadInFile(string fileName);

        long CalculateResults(int step);
    }

    public interface ICalulateNameResults
    {
        long CalculateResults();

        long CalculateNameScore(string name);

        List<string> ReadInFile(string fileName);
    }
}
using EightQueen;

public class Program
{
    public static void Main(string[] args)
    {
        EightQueensSolver solver = new EightQueensSolver();
        int n = 8;

        int[] array = solver.CreateIntArray(n);

        solver.PermutationsHelper(array, 0);
    }
}
namespace CollectionPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 4; // Total number of chapters
            int[,] chapters = { { 1, 4 }, { 5, 7 }, { 9, 16 }, { 17, 26 } }; // Start and end pages of each chapter
            int K = 7; // Current reading page

            int remainingChapters = CountRemainingChapters(N, chapters, K);
            Console.WriteLine("Number of chapters yet to read: " + remainingChapters);
        }

        static int CountRemainingChapters(int N, int[,] chapters, int K)
        {
            int remainingChapters = 0;

            for (int i = 0; i < N; i++)
            {
                int chapterStart = chapters[i, 0];
                int chapterEnd = chapters[i, 1];

                if (chapterStart <= K && K <= chapterEnd)
                {
                    remainingChapters = N - i;
                    break;
                }
            }

            return remainingChapters;
        }
    }
}
    

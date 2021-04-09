using GradeBook;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Nobita's grade book");
            book.AddGrade(89.1);
            book.AddGrade(97.53);
            book.AddGrade(63.25);
            book.AddGrade(78.78);
            book.AddGrade(90);

            // book.showStatistics();
        }
    }
}

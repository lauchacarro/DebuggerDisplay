using System.Diagnostics;

namespace DebuggerDisplay
{
    [DebuggerDisplay("{DebuggerDisplay}")]
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        private string DebuggerDisplay
        {
            get { return string.Format("Título: {0}  Es Viejo? {1}", Title, Year < 2000); }
        }
    }
}

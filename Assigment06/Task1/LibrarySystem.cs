using static System.Reflection.Metadata.BlobBuilder;
namespace LibrarySystem
{
    public class Book
    {
        private string _title;
        private string _author;
        private int _year;
        private string _description;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
    }
    public class Library
    {
        private Book[] _library;
        public Book this[int id]
        {
            get { return _library[id]; }
            set { _library[id] = value; }
        }
        public int Size
        {
            set{ _library = new Book[value];}
        }
        public int Count
        {
            get
            {
                int c = 0;
                for (int i = 0; i < _library.Length; i++)
                {
                    if (_library[i] != null)
                    {
                        c++;
                    }
                }
                return c;
            }
        }
        public void AddBook(Book m)
        {
            for (int i = 0; i < _library.Length; i++)
            {
                if (_library[i] == null)
                {
                    _library[i] = m;
                    return;
                }
            }
        }
        public int RemoveBook(Book b)
        {
            for (int i = 0; i < _library.Length; i++)
            {
                if (_library[i] == b)
                {
                    _library[i] = null;
                    return 1;
                }
            }
            return -1;
        }
        public int  FindBook(string n)
        {
            for (int i = 0; i < _library.Length; i++)
            {
                if (_library[i].Title == n)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

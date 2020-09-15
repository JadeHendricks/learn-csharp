using System;
using System.Collections.Generic;
using System.Text;

namespace learn_csharp
{
    class BookClass
    {
        // class attributes
        public string title;
        public string author;
        public int pages;

        public BookClass(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
        public BookClass()
        {

        }

        public bool HasMoreThan500Pages()
        {
            if (pages > 500)
            {
                return true;
            } else
            {
                return false;
            }
        }

    }
}
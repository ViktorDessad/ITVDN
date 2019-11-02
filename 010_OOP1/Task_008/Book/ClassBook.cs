using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_008.BookContent;

namespace Task_008
{
    class ClassBook
    {
        ClassAutor autor = null;
        ClassContent content = null;
        ClassTitle title = null;

        void CreateBook()
        {
            autor = new ClassAutor();
            content = new ClassContent();
            title = new ClassTitle();
        }

        public ClassBook(string autor, string content, string title)
        {
            CreateBook();
            this.autor.AutorProperty = autor;
            this.content.ContentProperty = content;
            this.title.TitleProperty = title;
        }

        public void Show()
        {
            autor.Show();
            content.Show();
            title.Show();
        }
    }
}

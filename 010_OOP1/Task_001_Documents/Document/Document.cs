using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documents.Document
{
    class Document
    {
        ClassBody body = null;
        ClassFooter footer = null;
        ClassTitle title = null;

        void InitializeDocument()
        {
            body = new ClassBody();
            footer = new ClassFooter();
            title = new ClassTitle();
        }

        public Document(string title)
        {
            InitializeDocument();
            this.title.Title = title;
        }

        public void Show()
        {
            title.Show();
            footer.Show();
            body.Show();
        }

        public string Body
        {
            set
            {
                body.Body = value;
            }
        }

        public string Footer
        {
            set
            {
                footer.Footer = value;
            }
        }
    }
}

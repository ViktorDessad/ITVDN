using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Documents
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Document.Document document = new Document.Document("Contract");
            document.Body = "Document body";
            document.Footer = "Documet footer";

            document.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentBuilder.Classes
{
    public class Document
    {
        //properties for a document
        public string Name { get; set; }
        public string Address { get; set; }
        public int Pages { get; set; }
        public List<string> Documents = new List<string>();

        public void Write()
        {
            //writes out all the pieces of the document
            Console.WriteLine("Creating your documents");
            foreach (string doc in Documents)
            {
                Console.WriteLine(doc);
            }
        }

        public void Edit()
        {
            Console.WriteLine("Editing your docs");
        }

        public void Print()
        {
            Console.WriteLine("Printing your docs");
        }

    }
}

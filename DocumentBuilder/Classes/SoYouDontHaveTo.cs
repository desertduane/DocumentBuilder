using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentBuilder.Classes
{
    class SoYouDontHaveTo : Documents
    {
        protected override Document CreateDocuments(string document)
        {
            Console.WriteLine("We make your documents so you don't have to");

            return DocumentFactory.CreateDocument(document);
        }
    }
}

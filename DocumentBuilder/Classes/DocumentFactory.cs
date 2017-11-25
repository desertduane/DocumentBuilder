using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentBuilder.Classes
{
    class DocumentFactory
    {
        public static Document CreateDocument(string document)
        {
            Document doc = new Document();

            switch (document)
            {
                case "Resume":
                    Console.WriteLine("Building your Resume");
                    doc = new ResumeDoc();
                    break;

                case "Essay":
                    Console.WriteLine("Should Really write your own essay");
                    doc = new EssayDoc();
                    break;

                default:
                    break;

            }
            return doc;
        }
    }
}

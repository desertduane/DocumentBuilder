using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentBuilder.Classes
{
    class EssayDoc : Document
    {
        public EssayDoc()
        {
            Name = "Average Joe";
            Pages = 6;
            Documents.Add("Opening Paragraphs");
            Documents.Add("Lots of content here");
            Documents.Add("Conclusion of your awsome essay");


        }
    }
}

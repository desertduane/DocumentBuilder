using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentBuilder.Classes
{
    class ResumeDoc : Document
    {
        //assembles a resume
        public ResumeDoc()
        {
            Name = "Average Joe";
            Address = "12345 I Made this up Lane";
            Pages = 1;
            Documents.Add("Personal Statement");
            Documents.Add("List of skills");
            Documents.Add("Past Projects");
            Documents.Add("Education");

        }
    }
}

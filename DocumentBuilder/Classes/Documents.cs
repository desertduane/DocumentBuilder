using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentBuilder.Classes
{
    public abstract class Documents
    {
        protected abstract Document CreateDocuments(string document);

        public Document GetDocument(string document)
        {
            Document doc = null;

            doc = CreateDocuments(document);
            doc.Write();
            doc.Edit();
            doc.Print();

            return doc;

        }
    }
}

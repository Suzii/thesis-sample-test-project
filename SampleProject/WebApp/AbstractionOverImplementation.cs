using CMS.DataEngine;
using CMS.Search.Lucene3;

namespace WebApp
{
    public class AbstractionOverImplementation
    {
        private LuceneSearchDocument LuceneSearchDocument(LuceneSearchDocument doc)
        {
            LuceneSearchDocument luceneNok = new LuceneSearchDocument();
            ISearchDocument luceneOk = new LuceneSearchDocument();

            return new LuceneSearchDocument();
        }
    }
}

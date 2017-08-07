using AngleSharp.Dom.Html;

namespace ParserHTML.Core
{
    interface IParser<T> where T : class
    {
        T Parse(IHtmlDocument document);
    }
}

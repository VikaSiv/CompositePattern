using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    public class Paragraph : IDocumentComponent
    {
        private string _text;

    public Paragraph(string text)
    {
        _text = text;
    }

    void IDocumentComponent.Add(IDocumentComponent component)
    {
        throw new NotImplementedException("Cannot add to a paragraph.");
    }

        void IDocumentComponent.Remove(IDocumentComponent component)
    {
        throw new NotImplementedException("Cannot remove from a paragraph.");
    }

    public void Display(int indent)
    {
        Console.WriteLine(new string(' ', indent) + _text);
    }
    }
}

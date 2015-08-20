using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
namespace Html.Models
{
    public class Element : IElement
    {
        private string textContent;
        private IList<IElement> childElements;
        public Element(string name)
        {
            this.Name = name;
            this.childElements = new List<IElement>();
        }
        public Element(string name, string textContent)
            : this(name)
        {
            this.TextContent = textContent;
            //this.childElements = new List<IElement>();
        }
        public string Name { get; private set; }
       

        public string TextContent
        {
            get
            {
                return this.textContent;
            }
            set
            {
                this.textContent = value;
            }
        }

        public IEnumerable<IElement> ChildElements
        {
            get { return new List<IElement>(this.childElements); }
        }

        public void AddElement(IElement element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("");
            }
            this.childElements.Add(element);
        }

        public void Render(StringBuilder output)
        {

            output.Append(string.Format("<{0}>{1}", this.Name, string.IsNullOrEmpty(this.textContent) ? "" : this.textContent));
            foreach (var child in this.childElements)
            {
                output.Append(string.Format("<{0}>{1}</{2}>", child.Name, string.IsNullOrEmpty(child.TextContent) ? "" : child.TextContent, child.Name));
            }
            output.Append(string.Format("</{0}>", this.Name));
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
namespace Html.Models
{
    public class Table : ITable
    {
        public int Rows
        {
            get { throw new NotImplementedException(); }
        }

        public int Cols
        {
            get { throw new NotImplementedException(); }
        }

        public IElement this[int row, int col]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get { return "table"; }
        }

        public string TextContent
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<IElement> ChildElements
        {
            get { throw new NotImplementedException(); }
        }

        public void AddElement(IElement element)
        {
            throw new NotImplementedException();
        }

        public void Render(StringBuilder output)
        {
            throw new NotImplementedException();
        }
    }
}

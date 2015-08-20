


namespace School
{
    using System.Collections.Generic;
    
    public class School 
    {
        private List<Class> classes;

        public School()
        {
            this.classes = new List<Class>();
        }

        public List<Class> Classes
        {
            get { return this.classes; }
            private set { this.classes = value; }
        }

        public void AddClass(Class newClass)
        {
            this.classes.Add(newClass);
        }

        public void RemoveClass(string className)
        {
            foreach (var clas in this.classes)
            {
                if (clas.TextIdent == className)
                {
                    this.classes.Remove(clas);
                    break;
                }
            }
        }
    }
}

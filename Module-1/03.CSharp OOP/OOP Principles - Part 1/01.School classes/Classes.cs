

namespace School
{
    using System.Collections.Generic;

    public class Class : IComment
    {
        private string textIdentifier;
        private List<Teacher> teachersSet;

        public Class(string textIdent, Teacher teacher)
        {
            this.teachersSet = new List<Teacher>();
            this.TextIdent = textIdent;
        }
        public void AddComment(string comment)
        {
            this.Comment.Add(comment);
        }
        public List<string> Comment { get; set; }

        public string TextIdent { get; private set; }
    }
}

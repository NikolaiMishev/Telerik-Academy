namespace _9_16_18_19.Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
   
    public static class ExtensionMethods
    {
        public static List<Student> StudentsFromGroup2Ext(this List<Student> students)
        {
            var result = from st in students
                         where st.GroupNumber == 2
                         orderby st.FirstName
                         select st;

            return result.ToList();
        }
    }
}

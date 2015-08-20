namespace StringBuilder.Substring
{
    using System;
    using System.Text;

     static class SubStrigBuilderExt
    {
        public static StringBuilder SubString(this StringBuilder builder, int index, int length)
        {
            StringBuilder subStr = new StringBuilder();

            for (int i = index; i <= length + index; i++)
            {
                subStr.Append(builder[i]);
            }
            
            return subStr;
        }
    }
}

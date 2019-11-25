using System;

namespace Open_Lab_04._03
{
    public class StringTools
    {
        public string RemoveFirstLast(string original)
        {
            if (original.Length < 2)
            {
                return original;
            }

            return original.Remove(0, 1).Remove(original.Length - 2, 1);
            
        }
    }
}
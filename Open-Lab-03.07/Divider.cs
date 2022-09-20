using System;

namespace Open_Lab_03._07
{
    public class Divider
    {
        public bool EqualSlices(int total, int people, int each)
        {
            if(each*people > total)
                return false;
            else { return true; }
        }
    }
}

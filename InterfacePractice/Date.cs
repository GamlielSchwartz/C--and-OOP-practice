namespace InterfacePractice
{
    public class Date
    {
        //fields:
        private string _day;
        private string _month;
        private string _year;
        //fields^

        //constructors:
        public Date(string d, string m, string y)
        {
            _day = d;
            _month = m;
            _year = y;
        }

        public Date() :
        this("--", "--", "----") {}
        //constructors^

        //methods:
        public override string ToString()
        {
            return _day + "/" + _month + "/" + _year;
        }
        //methods^
    }
}
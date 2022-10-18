namespace Module3HM4;

    public class NewClass
    {

        public static event Func<int, int, int> myevent;

        public Program program = new Program();

        public int Sum(int x, int y)
        {
            var c = x + y;
            return 0;
        }

        public void Delegate()
        {
            myevent += Sum;
        }

        public void TryCatch(int someMethod)
        {
            try
            {
                var method = someMethod;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Count()
        {
            TryCatch(myevent(10, 14));
        }
    }
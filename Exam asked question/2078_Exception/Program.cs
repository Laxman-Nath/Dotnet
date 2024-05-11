//Illustrate with an example with your own customized exception
namespace myApplication
{
    class customException : Exception {
        public customException() { }    
        public customException(string message):base(message) { }
        public customException(string message, Exception innerException):base(message, innerException) { }
    }

    class Program { 
        public static void Main(string[] args)
        {
            try
            {
                throw new customException("This is the custom exception i have created!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught:" + ex.Message);
            }
        }
    }

}


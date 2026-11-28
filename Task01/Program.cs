namespace Task01
{

    class Book
    {
        public string Title = "";
        public int Pages;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q01. Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object.Print it.

            Console.WriteLine("the answer of question one ");

            Book myBook = new Book();
            myBook.Title = "c#basics";
            myBook.Pages = 10;
            object obj = myBook;

            Console.WriteLine(obj);


            // Q02. Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book.

            Console.WriteLine("the answer of question two");

            Console.WriteLine(myBook.ToString());
            Console.WriteLine(myBook.Equals(myBook));
            Console.WriteLine(myBook.GetHashCode());
            Console.WriteLine(myBook.GetType());

            // Q03. Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.   int pages = "464";


            // answer: it's compile time error(misMatch error) because int must have number and "464" is string cause of "" the real answ will be int pages = 464;


            //Q04. Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.
            Console.WriteLine("the answer of question four ");

            try
            {
                int number = 0;
                int results = 10 / number;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }



            // Q05.Declare an int pages = 300; then store it in a double variable without using a cast.

            Console.WriteLine("the answer of question five ");


            int pages = 300;
            double resultedPages = pages;



            // Q06.Declare a double price = 49.99; then convert it into an int using a cast.
            Console.WriteLine("the answer of question six ");


            double price = 49.99;
            int finalPrice = (int)price;
            Console.WriteLine(finalPrice);




            // Q07. Given string pagesText = "464";, convert it into an int using the Convert class.
            Console.WriteLine("the answer of question seven ");

            string pagesText = "464";
            int convertedPages = Convert.ToInt32(pagesText);
            Console.WriteLine(convertedPages);


            //Q08. Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";,
            //use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
            Console.WriteLine("the answer of question eight");

            string yearText = "2023";
            int year = int.Parse(yearText);
            Console.WriteLine(year);

            string badText = "abc";
            if (int.TryParse(badText, out int result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }



            // Q09. Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string.

            Console.WriteLine("the answer of question nine ");

            int ourPages = 464;
            string finalPages = ourPages.ToString();
            Console.WriteLine(finalPages);
            Console.WriteLine(finalPages.GetType());


            // Q10. Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int   variable, and print both.

            Console.WriteLine("the answer of question ten ");

            int copies = 100;
            object boxedCopies = copies;

            int unboxedCopies = (int)boxedCopies;
            Console.WriteLine(boxedCopies);
            Console.WriteLine(unboxedCopies);


        }
    }
}

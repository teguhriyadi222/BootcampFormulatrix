
namespace navigation
{
    class Program
    {
        static async void Main()
        {
            while (true)
            {

            
            Navigation stack = new Navigation();
            stack.MyEvents += PrintMassage ;
            string massage;

            massage = stack.NavigationTo(Page.Home);
            Console.WriteLine(massage);

            massage = stack.NavigationTo(Page.Gallery);
            Console.WriteLine(massage);

            massage = stack.NavigationTo(Page.Dashboard);
            Console.WriteLine(massage);

            massage = stack.NavigationBack();
            Console.WriteLine(massage);

            massage = stack.NavigationBack();
            Console.WriteLine(massage);

            massage = stack.NavigationBack();
            Console.WriteLine(massage);

            static void PrintMassage(Page page)
            {
                Console.WriteLine("Page Navigated to " + page);
            }
        }
        await Task.Delay(1000);
        }

    }
}

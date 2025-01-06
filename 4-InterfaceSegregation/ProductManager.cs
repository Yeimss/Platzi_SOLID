namespace InterfaceSegregation
{
    public class ProductManager : IWorkTeamActivities, IProductManager
    {
        public ProductManager()
        {
        }

        public void Plan() 
        {
            throw new ArgumentException();
        }

        public void Comunicate() 
        {
            throw new ArgumentException();
        }

        public void Negotiate() 
        {
            Console.WriteLine("I'm negotiating times with our clients");
        }
    }
}
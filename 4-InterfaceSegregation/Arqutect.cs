namespace InterfaceSegregation
{
    public class Arquitect : IActivities
    {
        public Arquitect()
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

        public void Develop()
        {
            Console.WriteLine("I'm developing the functionalities required");
        }

        public void Design()
        {
            Console.WriteLine("I'm designing new futures");
        }

        public void Test()
        {
            throw new ArgumentException();
        }
    }
}
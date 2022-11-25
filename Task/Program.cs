using Task.Moduls;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emplyee emplyee = new Emplyee("Ramal",400,false);
            Emplyee emplyee1 = new Emplyee("Araz", 500, true);
            Emplyee emplyee2 = new Emplyee("Fateh", 600, true);

            Manager manager = new Manager();


            Asistant asistant = new Asistant();
            asistant.GetFeedBack(emplyee);
            asistant.GetFeedBack(emplyee1);
            asistant.GetFeedBack(emplyee2);
        }
    }
}
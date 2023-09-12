namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which database type do you want to use?");

            string userInput = Console.ReadLine();

            IDataAccess dataAccess = DataAccessFactory.GetDataAccessType(userInput);
            Console.WriteLine();
            Console.WriteLine();
            dataAccess.LoadData();
            dataAccess.SaveData();
        }
    }
}

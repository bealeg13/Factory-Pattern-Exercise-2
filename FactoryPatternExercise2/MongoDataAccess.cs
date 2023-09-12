using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class MongoDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am reading data from the mongo database.");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to the mongo database.");
        }
    }
}

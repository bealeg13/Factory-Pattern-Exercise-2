using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class SQLDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am loading data to the sql database.");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to the sql database.");
        }
    }
}

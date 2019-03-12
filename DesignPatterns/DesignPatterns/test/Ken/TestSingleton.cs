using System;
using DesignPatterns.src;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace DesignPatterns.test.Ken
{
    [TestClass]
    public class TestSingleton
    {
        [TestMethod]
        public void CreateSingleton()
        {
            var taskFactory = new TaskFactory();
            var taskList = new List<Task>();
            var taskSet = new HashSet<Singleton>();

            for (var i = 0; i < 5; i++)
            {
                taskList.Add(taskFactory.StartNew(() =>
                {
                    var singleton = Singleton.CreateInstance();
                    Console.WriteLine(singleton.GetHashCode());
                    taskSet.Add(singleton);
                }));
            }

            Thread.Sleep(2000);
            Console.WriteLine(taskSet.Count);

        }
    }
}

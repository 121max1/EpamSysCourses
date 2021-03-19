using System;
using System.Collections.Generic;
using Task2_2.GameObjects;
using Task2_2.Interfaces;

namespace ConsoleApp1
{
    class Program
    {
        private List<IMonster> _monsters = new List<IMonster>();
        private  List<IFillingObject> _fillingObjects = new List<IFillingObject>();
        private List<ITreasure> _treasures = new List<ITreasure>();
        Player player = new Player();
        
        public static void Main()
        {

        }
    }
}

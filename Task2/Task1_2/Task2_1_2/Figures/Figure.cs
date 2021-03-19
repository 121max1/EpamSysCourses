using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    public abstract class Figure
    {
        public abstract double Square { get; }

        public abstract double Length { get; }
        public abstract void GetInfo();
    }
}

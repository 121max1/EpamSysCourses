﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_2.Interfaces;

namespace Task2_2.GameObjects.Treasures
{
    class GoldCoin : IGameObjectPosition, ITexture, ITreasure
    {
        public double X { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void SetTexture(Texture texture)
        {
            throw new NotImplementedException();
        }
    }
}

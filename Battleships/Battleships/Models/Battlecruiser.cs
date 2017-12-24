﻿using Battleships.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Battleships.Enums;


namespace Battleships.Models
{
    class Battlecruiser : Ship, IShip, IGameObject
    {
        public Battlecruiser(IList<IGameObjectElement> elements,Direction direction) : base( elements,direction)
        {
            this.ShipType = ShipType.Cruiser;
           
        }
    }
}

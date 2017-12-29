﻿using System;
using System.Collections.Generic;
using Battleships.Enums;
using Battleships.Models.Contracts;
using Battleships.Utilities;
using Battleships.Utilities.Contracts;

namespace Battleships.Models
{
	public abstract class Ship : IShip
	{
		protected Ship(IPosition origin, Direction direction, int count)
		{
			if (count <= 0)
			{
				throw new ArgumentException("Must be positive", nameof(count));
			}

			this.Elements = new List<IGameObjectElement>();
			for (int i = 0; i < count; i++)
			{
				int x = origin.Row;
				int y = origin.Col;
				switch (direction)
				{
					case Direction.Up:
						x -= i;
						break;
					case Direction.Right:
						y += i;
						break;
					case Direction.Down:
						x += i;
						break;
					case Direction.Left:
						y -= i;
						break;
				}

				var gameObjectElement = new GameObjectElement()
				{
					IsHit = false,
					ElementPosition = new Position()
					{
						Row = x,
						Col = y
					}
				};
				this.Elements.Add(gameObjectElement);
			}

			this.Health = count;
		}

		public bool IsAlive => this.Health > 0;
		public int Health { get; set; }
		public IList<IGameObjectElement> Elements { get; set; }
	}
}

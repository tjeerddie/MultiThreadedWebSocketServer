﻿using System;

namespace WebSocketTest.Datatypes
{
	class Ball : GameObject
	{
		public Ball(IVector2d position, IVector2d dimensions, IVector2d velocity) : base(position, dimensions, velocity) { }

		public Ball(IPhysicsData phys) : base(phys) { }

		public void BounceX(double offset)
		{
			Console.WriteLine(offset.ToString());
			Velocity.X -= Velocity.X * 2;

			if (Velocity.Speed < MaxSpeed)
				Velocity.IncreaseMultiplier();
		}

		public void BounceY()
		{
			Velocity.Y -= Velocity.Y * 2;
		}

		public Position2d Move()
		{
			Position.X += (int)(Velocity.X * Velocity.SpeedMultiplier);
			Position.Y += (int)(Velocity.Y * Velocity.SpeedMultiplier);

			return Position;
		}
	}
}
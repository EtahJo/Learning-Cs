﻿using System;
namespace consoleApp
{
	public interface IDrivable
	{
		int Wheels { get; set; }
		double Speed { get; set; }

		void Move();
		void Stop();
	}
}


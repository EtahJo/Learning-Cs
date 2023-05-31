using System;
namespace consoleApp
{
	public interface ICommand
	{
		void Execute();
		void Undo();
	}
}


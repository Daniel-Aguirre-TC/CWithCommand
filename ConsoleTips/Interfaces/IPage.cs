using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTips.Interfaces
{
    public interface IPage
    {
        public string Name { get; }
        // Write stuff onto the console - list of tips or menu options
        public void Display();

        // goes back to the prior screen
        public void Back();

        public void ProcessUserInput();
    }
}

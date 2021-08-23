using ConsoleTips.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTips.Pages
{
    public class InvalidSelection : IPage
    {
        public string Name
        {
            get
            {
                return null;
            }
        }
        public void Display()
        {
            ConsoleInput.Display("\nInvalid Selection.\nPlease Select a valid option.");
        }

        public void ProcessUserInput()
        {
            ConsoleKeyInfo input = ConsoleInput.GetInput();
            if (input != null)
            {
                Back();
            }
        }

        public void Back ()
        {
            Router.Back();
        }
    }
}

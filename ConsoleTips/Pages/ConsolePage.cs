using ConsoleTips.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTips.Pages
{
    public class ConsolePage : IPage
    {
        public string Name
        {
            get
            {
                return "Console";
            }
        }
        public void Display ()
        {
            List<Command> commandList = new List<Command>(){
                new Command("code .", "Open the current directory in Visual Code."),
                new Command("cd <directoryNameMovingTo>", "Move into the directory provided"),
                new Command("cd ..", "Move into the parent directory of the one you're currently in."),
                new Command("rename <fileName> <newFileName>", "Rename a specified file."),
                new Command("del <fileName>", "Delete the file provided."),
                new Command("cls", "Clear the screen."),
                new Command("mkdir <newDirectoryName>", "Make a new directory with the provided name."),
                new Command("rmdir <directoryNameDeleting>", "Delete the directory provided. Must be in the parent directory.")
            };
            ConsoleInput.Display(commandList);
        }

        public void ProcessUserInput ()
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

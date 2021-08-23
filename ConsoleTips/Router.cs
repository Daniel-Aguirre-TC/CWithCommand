using ConsoleTips.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTips
{
    public static class Router
    {
        public static List<IPage> viewStack = new List<IPage>();
        public static int Back (IPage page)
        {
            ConsoleInput.Clear();
            // Find index of page in the stack.
            int pageIndex = viewStack.IndexOf(page);
            // Remove everything past it
            viewStack.RemoveRange(pageIndex, viewStack.Count);
            // call it's display method
            page.Display();
            return viewStack.Count;
        }

        public static int Back()
        {
            ConsoleInput.Clear();
            // remove the last view in the stack
            viewStack.RemoveAt(viewStack.Count - 1);
            // get new last view in stack
            IPage lastPage = viewStack[viewStack.Count - 1];
            // call it's display method
            lastPage.Display();
            return viewStack.Count;
        }

        public static int Go (IPage page)
        {
            ConsoleInput.Clear();
            viewStack.Add(page);
            page.Display();
            return viewStack.Count;
        }
    }
}

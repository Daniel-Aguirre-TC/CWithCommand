using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTips
{
    class Menu : MenuOption
    {
        List<MenuOption> optionList = new List<MenuOption>();


        public Menu(MenuOption PageToReturnTo, MenuOption[] menuOptions)
        {
            // First option in List (0) should always return the user to previous page.
            optionList.Add(PageToReturnTo);
            foreach(MenuOption option in menuOptions)
            {
                optionList.Add(option);
            }
        }



    }
}

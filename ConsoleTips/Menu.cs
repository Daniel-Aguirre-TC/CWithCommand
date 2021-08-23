using ConsoleTips.Interfaces;
using ConsoleTips.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTips
{
    public class Menu : IPage
    {
        public List<IPage> AllPages = new List<IPage>();
        public List<IPage> SelectablePages = new List<IPage>();
        public Menu()
        {
            // Add new pages here
            AllPages.Add(new ConsolePage());
            SelectablePages = AllPages.FindAll(page => !string.IsNullOrEmpty(page.Name));
        }

        public string Name
        {
            get
            {
                return null;
            }
        }

        //public static void GetValidSelections()
        //{
        //    var type = typeof(IPage);
        //    var types = AppDomain.CurrentDomain.GetAssemblies()
        //        .SelectMany(assembly => assembly.GetTypes())
        //        .Where(p => type.IsAssignableFrom(p) && !p.IsInterface);

        //    foreach (IPage page in types)
        //    {
        //        allPages.Add(page);
        //    }
        //}

        public void Back()
        {
            ConsoleInput.EndApplication();
        }

        public void Display()
        {
            string validPageStr = "Please select on of the following: \n\n";
            for (int i = 0; i < SelectablePages.Count; i++)
            {
                IPage page = SelectablePages[i];
                validPageStr += $"{i + 1}) ";
                validPageStr += page.Name + "\n";
            }
            ConsoleInput.Display(validPageStr);
            //ConsoleInput.Display("Please select one of the following:\n\n1) Console\n2) Github\n3) DotNet\n4) C_Sharp\n");
        }

        public void ProcessUserInput()
        {
            ConsoleKeyInfo input = ConsoleInput.GetInput();
            IPage selectedPage = null;
            // if input isn't null, empty, or whitespace then find matching page at that index and go to it
            if (!string.IsNullOrEmpty(input.KeyChar.ToString()) && !string.IsNullOrWhiteSpace(input.KeyChar.ToString()))
            {
                try
                {
                    string inputKey = input.KeyChar.ToString();
                    int index = Convert.ToInt32(inputKey);
                    selectedPage = SelectablePages[index - 1];
                }
                catch (Exception ex)
                {
                    selectedPage = new InvalidSelection();
                }
            }
            else
            {
                selectedPage = new InvalidSelection();
            }
            //switch (input.KeyChar)
            //{
            //    case 'e':
            //        ConsoleInput.EndApplication();
            //        break;
            //    case '1':
            //        selectedPage = new ConsolePage();
            //        break;
            //    //case '2':
            //    //    selectedPage = TipsSection.github;
            //    //    break;
            //    //case '3':
            //    //    selectedPage = TipsSection.dotnet;
            //    //    break;
            //    //case '4':
            //    //    selectedPage = TipsSection.c_sharp;
            //    //    break;
            //    default:
            //        selectedPage = new InvalidSelection();
            //        break;
            //}
            if (selectedPage != null)
            {
                Router.Go(selectedPage);
                selectedPage.ProcessUserInput();
            }
            ProcessUserInput();
        }
    }
}

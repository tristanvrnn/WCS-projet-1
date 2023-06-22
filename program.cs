using System;
using Newtonsoft.Json;
using WCS_projet_1;

namespace WCS_projet_1;

class Program
{
    static void Main(string[] args)
    {
        MenuManager menuManager = new MenuManager();

        menuManager.ShowMainMenu();
    }
}

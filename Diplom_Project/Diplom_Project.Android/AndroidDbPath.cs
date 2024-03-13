using Diplom_Project.module;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;
[assembly: Dependency(typeof(AndroidDbPath))]
namespace Diplom_Project.module
{
    class AndroidDbPath
    {
        public string GetDatabasePath(string filename)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), filename);
        }
    }
}

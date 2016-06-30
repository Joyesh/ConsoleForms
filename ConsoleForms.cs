using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForms
{
    public class FormWindow 
    {
        // They created a new form instance, let's initalize everything.
        public List<ConsoleControl> objects;
        public bool Visible = false;
        public bool CloseButton = true;
        //public bool MinimizeButton; Not implemented yet.
        //public bool MaximizeButton; Not implemented yet.
        public string Title = "NewConsoleForm";
        public int Width = 18; //In characters, not counting window edges.
        public int Height = 7; //In characters, not counting window edges.
        public void Show()
        {
            //This code regenerates the whole form.

        }
    }

    public class ConsoleControl
    {
        //Main class for every control.
        public bool Visible = true;
    }
    public class ConsoleTextBox : ConsoleControl
    {

    }
    public class ConsoleLabel : ConsoleControl
    {

    }
}

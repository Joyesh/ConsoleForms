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
        public int Width = 20; //In characters, not counting window edges.
        public int Height = 7; //In characters, not counting window edges.
        //public bool LiveRender; //Designed so that the window renders when any event changes 
        //(Width, Height, title, etc.)  (Not yet implemented)
        public void Show()
        {
            //This code regenerates the whole form.

            //Code to add window stuff (Needs cleaning up and/or compacting)
            int y = 0;
            string spaces = "";
            while (y != Width)
            {
                y += 1;
                spaces += " ";
            }
            y = 0;
            string spacest = "";
            while (y != Width - Title.Length)
            {
                y += 1;
                spacest += " ";
            }
            int x = 0;
            string topbottom = ""; //The text that renders at the top and bottom.
            while (x != Width)
            {
                x += 1;
                topbottom = topbottom + "═";
            }
            x = 0;
            //Render the top chrome (edges) and the top part of the window
            Console.WriteLine("╔" + topbottom + "╗");
            //Render the rest of the window.
            while (x != Height)
            {
                x += 1;
                //Render the chrome for the title divider.
                if (x == 2) { Console.WriteLine("╠" + topbottom + "╣"); }
                else if (x == 1) { Console.WriteLine("║" + Title + spacest + "║"); }
                //Render the rest of the window
                else if (x > 2) { Console.WriteLine("║" + spaces + "║"); }
            }
            //Render the bottom chrome (edges) and the bottom part of the window
            Console.WriteLine("╚" + topbottom + "╝");
        }
    }

    public class ConsoleControl
    {
        //Main class for every control. (basically contains the variables that controls use, etc.
        public bool Visible = true;
        public bool Enabled = true;
        public string Text = "ConsoleControl";
    }
    public class ConsoleTextBox : ConsoleControl
    {
        public string Text = "ConsoleTextBox";
    }
    public class ConsoleLabel : ConsoleControl
    {
        public string Text = "ConsoleLabel";
    }
}

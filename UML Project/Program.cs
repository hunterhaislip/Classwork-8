using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            TextField Text = new TextField(1,2);
            BorderDecorator Bord = new BorderDecorator(Text);
            ScrollDecorator Scroll = new ScrollDecorator(Bord);
            BackgroundDecorator Back = new BackgroundDecorator(Scroll);
            // Allows them to connnect and call Draw on the last.
            Back.Draw();
        }
    }


    interface Widget
    {
        void Draw();
    }


    class TextField : Widget
    {
        private int width = 1;
        private int height = 2;
        // Random Data

        public TextField(int w, int h)
        {
            w = width;
            h = height;
        }

        public void Draw()
        {
            Console.WriteLine("I am a TextField holding: ");
        }
    }


    abstract class Decorator : Widget
    {
   
        public Decorator(Widget w)
        {

        }

        public void Draw()
        {
            Console.WriteLine("I am a Decorator holding: ");
        }
    }


    class BorderDecorator : Decorator
    {

        public BorderDecorator(Widget w) : base(w)
        {
            base.Draw();
            // Calls base draw on one function. 
            Draw();
        }

        public new void Draw()
        {
            Console.WriteLine("I am a BorderDecorator");
        }
    }


    class ScrollDecorator : Decorator
    {
        private Widget wid;

        public ScrollDecorator(Widget w) : base(w)
        {
            Draw();
        }

        public new void Draw()
        {
            Console.WriteLine("I am a ScrollDecorator");
        }
    }


    class BackgroundDecorator : Decorator
    {

        public BackgroundDecorator(Widget w) : base(w)
        {
            Draw();
        }

        public new void Draw()
        {
            Console.WriteLine("I am a BackgroundDecorator");
        }
    }
}

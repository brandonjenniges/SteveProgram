using System;
using System.Drawing;
using System.Drawing.Printing;

namespace ButcherBlock
{
    class PrintingClass : System.Drawing.Printing.PrintDocument
    {
       
        //Property variable for the font the user wishes to use
        private Font _font;

        //Property variable for the text to be printed
        private string _text;

        //Property to hold the text that is to be printed
        public string TextToPrint
        {
            get { return _text; }
            set { _text = value; }
        }

        //Property to hold the font the user wishes to use
        public Font PrinterFont
        {
            get { return _font; }
            set { _font = value; }
        }

        // Static variable to hold the current character
        // we're currently dealing with.
        static int curChar;

        // Empty constructor
        public PrintingClass()
            : base()
        {
            // set the file stream
            // Instantiate out Text property to an empty string
            _text = string.Empty;
        }

        // Constructor to initialize our printer object
        // and the text it's supposed to be printing
        public PrintingClass(string str)
            : base()
        {
            // Set the file stream
            // Set our text property value
            _text = str;
        }

        protected override void OnBeginPrint(System.Drawing.Printing.PrintEventArgs e)
        {
            // Run base code
            base.OnBeginPrint(e);

            // Check to see if the user provided a font
            // if they didn't the we default to Times New Roman
            if (_font == null)
            {
                _font = new Font("Times New Roman", 14);
            }
        }

        // Override the default OnPrintPage method of the PrintDocument
        protected override void OnPrintPage(System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Run base code
            base.OnPrintPage(e);

            PaperSize ps = new PaperSize("Custom", 100, 100);
            base.DefaultPageSettings.PaperSize = ps;

            // declare local variables needed
            int printHeight;
            int printWidth;
            int leftMargin;
            int rightMargin;
            Int32 lines;
            Int32 chars;

            // Set print area size and margins
            {                
                printHeight = base.DefaultPageSettings.PaperSize.Height - base.DefaultPageSettings.Margins.Top - base.DefaultPageSettings.Margins.Bottom;
                printWidth = base.DefaultPageSettings.PaperSize.Width = base.DefaultPageSettings.Margins.Left - base.DefaultPageSettings.Margins.Right;
                leftMargin = base.DefaultPageSettings.Margins.Left; //X
                rightMargin = base.DefaultPageSettings.Margins.Right; //Y
                System.Windows.Forms.MessageBox.Show(rightMargin.ToString());
            }

            // Check if the user selected to print in Landscape mode
            // if they did then we need to swap height/width parameters
            if (base.DefaultPageSettings.Landscape)
            {
                int tmp;
                tmp = printHeight;
                printHeight = printWidth;
                printWidth = tmp;
            }

            // Now we need to determine the total number of lines
            // we're going to be printing
            Int32 numLines = (int)printHeight / PrinterFont.Height;

            // Create a rectangle printing area for our document
            RectangleF printArea = new RectangleF(leftMargin, rightMargin, printWidth, printHeight);

            // Use StringFormat class for the text layout of our document
            StringFormat format = new StringFormat(StringFormatFlags.LineLimit);
            float[] formatTabs = { 10.0f, 20.0f };
            format.SetTabStops(10.0f, formatTabs);

            // Fit as many characters as we can into the print area

            e.Graphics.MeasureString(_text.Substring(RemoveZeros(ref curChar)), PrinterFont, new SizeF(printWidth, printHeight), format, out chars, out lines);

            // Print the page
            e.Graphics.DrawString(_text.Substring(RemoveZeros(ref curChar)), PrinterFont, Brushes.Black, printArea, format);

            // Increase current char count
            curChar += chars;

            // Determine if there is more text to print, if
            // there is then tell the printer there is more coming
            if (curChar < _text.Length)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
                curChar = 0;
            }
        }

        // Function to replace any zeros in the size to a 1
        // Zeros will mess up the printing area
        public int RemoveZeros(ref int value)
        {
            // Check the value passed into the function
            // If the value is a 0 (zero) then return a 1,
            // otherwise return the value passed in
            while (_text[value] == '\0')
            {
                value++;
            }
            return value;
        }
    }

}
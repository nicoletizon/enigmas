using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Enigma_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        bool initialState = true;
        string defaultMessage = "Your Message will appear here";
        public MainWindow()
        {
            InitializeComponent();
            InitializeEventHandlers();
            if (initialState)
                output.Content = defaultMessage;

        }

        private bool shiftKeyPressed = false;
        private bool uppercaseEnabled = false;
        private bool capsLockEnabled = false;
        private bool capsLockKeyPressed = false;


        private void InitializeEventHandlers()
        {
            KeyDown += Window_KeyDown;
            KeyUp += Window_KeyUp;
        }


        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            // Handle the Shift key
            if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
            {
                shiftKeyPressed = true;
                uppercaseEnabled = true; // Enable uppercase mode when Shift is pressed
                shift.Background = Brushes.Yellow;
                return;
            }


            if (e.Key == Key.CapsLock)
            {
                capsLockKeyPressed = true;
                capsLockEnabled = !capsLockEnabled;
                // Update your Shift Lock label text or appearance here
                shiftlock.Content = capsLockEnabled ? "Caps Lock" : "Shift Lock";
                shiftlock.Background = Brushes.Yellow;
                if (capsLockEnabled)
                {
                    // Replace letters with symbols
                    a.Content = "A";
                    b.Content = "B";
                    cc.Content = "C";
                    d.Content = "D";
                    ee.Content = "E";
                    f.Content = "F";
                    g.Content = "G";
                    h.Content = "H";
                    i.Content = "I";
                    j.Content = "J";
                    k.Content = "K";
                    el.Content = "L";
                    m.Content = "M";
                    n.Content = "N";
                    o.Content = "O";
                    p.Content = "P";
                    q.Content = "Q";
                    r.Content = "R";
                    s.Content = "S";
                    t.Content = "T";
                    u.Content = "U";
                    v.Content = "V";
                    w.Content = "W";
                    x.Content = "X";
                    y.Content = "Y";
                    z.Content = "Z";

                    // Change Symbols
                    equal.Content = "+";
                    minus.Content = "_";
                    coma.Content = "<";
                    dot.Content = ">";
                    semicolon.Content = ":";
                    quotation.Content = '"';
                    slash.Content = "?";
                    b_slash.Content = "|";
                    l_bracket.Content = "{";
                    r_bracket.Content = "}";

                    // Replace numbers with symbols
                    one.Content = "!";
                    two.Content = "@";
                    three.Content = "#";
                    four.Content = "$";
                    five.Content = "%";
                    six.Content = "^";
                    seven.Content = "&";
                    eight.Content = "*";
                    nine.Content = "(";
                    zero.Content = ")";
                }
                else
                {
                    // If Caps Lock is disabled, revert back to letters and numbers
                    a.Content = "a";
                    b.Content = "b";
                    cc.Content = "c";
                    d.Content = "d";
                    ee.Content = "e";
                    f.Content = "f";
                    g.Content = "g";
                    h.Content = "h";
                    i.Content = "i";
                    j.Content = "j";
                    k.Content = "k";
                    el.Content = "l";
                    m.Content = "m";
                    n.Content = "n";
                    o.Content = "o";
                    p.Content = "p";
                    q.Content = "q";
                    r.Content = "r";
                    s.Content = "s";
                    t.Content = "t";
                    u.Content = "u";
                    v.Content = "v";
                    w.Content = "w";
                    x.Content = "x";
                    y.Content = "y";
                    z.Content = "z";
                    equal.Content = "=";
                    minus.Content = "-";
                    coma.Content = ",";
                    dot.Content = ".";
                    semicolon.Content = ";";
                    quotation.Content = "'";
                    slash.Content = "/";
                    b_slash.Content = "\\";
                    l_bracket.Content = "[";
                    r_bracket.Content = "]";

                    // Revert numbers back to their original values
                    one.Content = "1";
                    two.Content = "2";
                    three.Content = "3";
                    four.Content = "4";
                    five.Content = "5";
                    six.Content = "6";
                    seven.Content = "7";
                    eight.Content = "8";
                    nine.Content = "9";
                    zero.Content = "0";
                }
                return;

            }




            if (uppercaseEnabled || capsLockEnabled) // Check if either Caps Lock or Shift is enabled
            {
                char character = KeyManager(e.Key);
                character = char.ToUpper(character);
                // Append the uppercase character to your output or handle it as needed.
                switch (e.Key)
                {
                    case Key.A:
                        a.Background = Brushes.Yellow;
                        break;
                    case Key.B:
                        b.Background = Brushes.Yellow;
                        break;
                    case Key.C:
                        cc.Background = Brushes.Yellow;
                        break;
                    case Key.D:
                        d.Background = Brushes.Yellow;
                        break;
                    case Key.E:
                        ee.Background = Brushes.Yellow;
                        break;
                    case Key.F:
                        f.Background = Brushes.Yellow;
                        break;
                    case Key.G:
                        g.Background = Brushes.Yellow;
                        break;
                    case Key.H:
                        h.Background = Brushes.Yellow;
                        break;
                    case Key.I:
                        i.Background = Brushes.Yellow;
                        break;
                    case Key.J:
                        j.Background = Brushes.Yellow;
                        break;
                    case Key.K:
                        k.Background = Brushes.Yellow;
                        break;
                    case Key.L:
                        el.Background = Brushes.Yellow;
                        break;
                    case Key.M:
                        m.Background = Brushes.Yellow;
                        break;
                    case Key.N:
                        n.Background = Brushes.Yellow;
                        break;
                    case Key.O:
                        o.Background = Brushes.Yellow;
                        break;
                    case Key.P:
                        p.Background = Brushes.Yellow;
                        break;
                    case Key.Q:
                        q.Background = Brushes.Yellow;
                        break;
                    case Key.R:
                        r.Background = Brushes.Yellow;
                        break;
                    case Key.S:
                        s.Background = Brushes.Yellow;
                        break;
                    case Key.T:
                        t.Background = Brushes.Yellow;
                        break;
                    case Key.U:
                        u.Background = Brushes.Yellow;
                        break;
                    case Key.V:
                        v.Background = Brushes.Yellow;
                        break;
                    case Key.W:
                        w.Background = Brushes.Yellow;
                        break;
                    case Key.X:
                        x.Background = Brushes.Yellow;
                        break;
                    case Key.Y:
                        y.Background = Brushes.Yellow;
                        break;
                    case Key.Z:
                        z.Background = Brushes.Yellow;
                        break;
                    // OTHER KEYPAD
                    case Key.Space:
                        spacebar.Background = Brushes.Yellow;
                        break;

                    case Key.Enter:
                        _return.Background = Brushes.Yellow;
                        break;

                    case Key.Tab:
                        tab.Background = Brushes.Yellow;
                        break;

                    case Key.Back:
                        back.Background = Brushes.Yellow;
                        break;

                    case Key.OemComma:
                        coma.Background = Brushes.Yellow;
                        break;

                    case Key.OemPeriod:
                        dot.Background = Brushes.Yellow;
                        break;

                    case Key.OemSemicolon:
                        semicolon.Background = Brushes.Yellow;
                        break;

                    case Key.OemQuotes:
                        quotation.Background = Brushes.Yellow;
                        break;

                    case Key.OemQuestion:
                        slash.Background = Brushes.Yellow;
                        break;

                    case Key.OemPipe:
                        b_slash.Background = Brushes.Yellow;
                        break;

                    case Key.OemOpenBrackets:
                        l_bracket.Background = Brushes.Yellow;
                        break;

                    case Key.OemCloseBrackets:
                        r_bracket.Background = Brushes.Yellow;
                        break;

                    case Key.OemPlus:
                        equal.Background = Brushes.Yellow;
                        break;

                    case Key.OemMinus:
                        minus.Background = Brushes.Yellow;
                        break;

                    case Key.D1:
                        one.Background = Brushes.Yellow;
                        break;

                    case Key.D2:
                        two.Background = Brushes.Yellow;
                        break;

                    case Key.D3:
                        three.Background = Brushes.Yellow;
                        break;

                    case Key.D4:
                        four.Background = Brushes.Yellow;
                        break;

                    case Key.D5:
                        five.Background = Brushes.Yellow;
                        break;

                    case Key.D6:
                        six.Background = Brushes.Yellow;
                        break;

                    case Key.D7:
                        seven.Background = Brushes.Yellow;
                        break;

                    case Key.D8:
                        eight.Background = Brushes.Yellow;
                        break;

                    case Key.D9:
                        nine.Background = Brushes.Yellow;
                        break;

                    case Key.D0:
                        zero.Background = Brushes.Yellow;
                        break;
                }
            }

            else
            {
                // Change the background color of the Label when a key is pressed.
                switch (e.Key)
                {
                    case Key.A:
                        a.Background = Brushes.Yellow;
                        break;
                    case Key.B:
                        b.Background = Brushes.Yellow;
                        break;
                    case Key.C:
                        cc.Background = Brushes.Yellow;
                        break;
                    case Key.D:
                        d.Background = Brushes.Yellow;
                        break;
                    case Key.E:
                        ee.Background = Brushes.Yellow;
                        break;
                    case Key.F:
                        f.Background = Brushes.Yellow;
                        break;
                    case Key.G:
                        g.Background = Brushes.Yellow;
                        break;
                    case Key.H:
                        h.Background = Brushes.Yellow;
                        break;
                    case Key.I:
                        i.Background = Brushes.Yellow;
                        break;
                    case Key.J:
                        j.Background = Brushes.Yellow;
                        break;
                    case Key.K:
                        k.Background = Brushes.Yellow;
                        break;
                    case Key.L:
                        el.Background = Brushes.Yellow;
                        break;
                    case Key.M:
                        m.Background = Brushes.Yellow;
                        break;
                    case Key.N:
                        n.Background = Brushes.Yellow;
                        break;
                    case Key.O:
                        o.Background = Brushes.Yellow;
                        break;
                    case Key.P:
                        p.Background = Brushes.Yellow;
                        break;
                    case Key.Q:
                        q.Background = Brushes.Yellow;
                        break;
                    case Key.R:
                        r.Background = Brushes.Yellow;
                        break;
                    case Key.S:
                        s.Background = Brushes.Yellow;
                        break;
                    case Key.T:
                        t.Background = Brushes.Yellow;
                        break;
                    case Key.U:
                        u.Background = Brushes.Yellow;
                        break;
                    case Key.V:
                        v.Background = Brushes.Yellow;
                        break;
                    case Key.W:
                        w.Background = Brushes.Yellow;
                        break;
                    case Key.X:
                        x.Background = Brushes.Yellow;
                        break;
                    case Key.Y:
                        y.Background = Brushes.Yellow;
                        break;
                    case Key.Z:
                        z.Background = Brushes.Yellow;
                        break;
                    // OTHER KEYPAD
                    case Key.Space:
                        spacebar.Background = Brushes.Yellow;
                        break;

                    case Key.Enter:
                        _return.Background = Brushes.Yellow;
                        break;

                    case Key.Back:
                        back.Background = Brushes.Yellow;
                        break;

                    case Key.Tab:
                        tab.Background = Brushes.Yellow;
                        break;

                    case Key.OemComma:
                        coma.Background = Brushes.Yellow;
                        break;

                    case Key.OemPeriod:
                        dot.Background = Brushes.Yellow;
                        break;

                    case Key.OemSemicolon:
                        semicolon.Background = Brushes.Yellow;
                        break;

                    case Key.OemQuotes:
                        quotation.Background = Brushes.Yellow;
                        break;

                    case Key.OemQuestion:
                        slash.Background = Brushes.Yellow;
                        break;

                    case Key.OemPipe:
                        b_slash.Background = Brushes.Yellow;
                        break;

                    case Key.OemOpenBrackets:
                        l_bracket.Background = Brushes.Yellow;
                        break;

                    case Key.OemCloseBrackets:
                        r_bracket.Background = Brushes.Yellow;
                        break;

                    case Key.OemPlus:
                        equal.Background = Brushes.Yellow;
                        break;

                    case Key.OemMinus:
                        minus.Background = Brushes.Yellow;
                        break;

                    case Key.D1:
                        one.Background = Brushes.Yellow;
                        break;

                    case Key.D2:
                        two.Background = Brushes.Yellow;
                        break;

                    case Key.D3:
                        three.Background = Brushes.Yellow;
                        break;

                    case Key.D4:
                        four.Background = Brushes.Yellow;
                        break;

                    case Key.D5:
                        five.Background = Brushes.Yellow;
                        break;

                    case Key.D6:
                        six.Background = Brushes.Yellow;
                        break;

                    case Key.D7:
                        seven.Background = Brushes.Yellow;
                        break;

                    case Key.D8:
                        eight.Background = Brushes.Yellow;
                        break;

                    case Key.D9:
                        nine.Background = Brushes.Yellow;
                        break;

                    case Key.D0:
                        zero.Background = Brushes.Yellow;
                        break;
                }
            }
        }

        private char KeyManager(Key input)
        {
            char retVal = ' ';

            if (input == Key.Space)
                retVal = ' ';
            else if (input == Key.Enter)
            {
                retVal = '\n'; // Add a newline character when Enter key is pressed                
            }

            else if (input == Key.Tab)
            {
                retVal = '\t'; // Add a tab character when Tab key is pressed
            }
            else if (capsLockEnabled || (shiftKeyPressed && !capsLockKeyPressed)) // Check if Caps Lock is enabled or Shift is pressed (but not Caps Lock)
            {
                switch (input)
                {
                    case Key.D1:
                        retVal = '!';
                        break;
                    case Key.D2:
                        retVal = '@';
                        break;
                    case Key.D3:
                        retVal = '#';
                        break;
                    case Key.D4:
                        retVal = '$';
                        break;
                    case Key.D5:
                        retVal = '%';
                        break;
                    case Key.D6:
                        retVal = '^';
                        break;
                    case Key.D7:
                        retVal = '&';
                        break;
                    case Key.D8:
                        retVal = '*';
                        break;
                    case Key.D9:
                        retVal = '(';
                        break;
                    case Key.D0:
                        retVal = ')';
                        break;
                    case Key.OemMinus:
                        retVal = '_';
                        break;
                    case Key.OemPlus:
                        retVal = '+';
                        break;
                    case Key.OemComma:
                        retVal = '<';
                        break;
                    case Key.OemPeriod:
                        retVal = '>';
                        break;
                    case Key.OemSemicolon:
                        retVal = ':';
                        break;
                    case Key.OemQuotes:
                        retVal = '"';
                        break;
                    case Key.OemQuestion:
                        retVal = '?';
                        break;
                    case Key.OemPipe:
                        retVal = '|';
                        break;
                    case Key.OemOpenBrackets:
                        retVal = '{';
                        break;
                    case Key.OemCloseBrackets:
                        retVal = '}';
                        break;
                    // Add more special characters as needed
                    default:
                        retVal = char.ToUpper(input.ToString()[0]); // Convert to uppercase
                        break;
                }
            }
            else
            {
                switch (input)
                {
                    case Key.D1:
                        retVal = '1';
                        break;
                    case Key.D2:
                        retVal = '2';
                        break;
                    case Key.D3:
                        retVal = '3';
                        break;
                    case Key.D4:
                        retVal = '4';
                        break;
                    case Key.D5:
                        retVal = '5';
                        break;
                    case Key.D6:
                        retVal = '6';
                        break;
                    case Key.D7:
                        retVal = '7';
                        break;
                    case Key.D8:
                        retVal = '8';
                        break;
                    case Key.D9:
                        retVal = '9';
                        break;
                    case Key.D0:
                        retVal = '0';
                        break;
                    case Key.OemMinus:
                        retVal = '-';
                        break;
                    case Key.OemPlus:
                        retVal = '=';
                        break;
                    case Key.OemComma:
                        retVal = ',';
                        break;
                    case Key.OemPeriod:
                        retVal = '.';
                        break;
                    case Key.OemSemicolon:
                        retVal = ';';
                        break;
                    case Key.OemQuotes:
                        retVal = '\'';
                        break;
                    case Key.OemQuestion:
                        retVal = '/';
                        break;
                    case Key.OemPipe:
                        retVal = '\\';
                        break;
                    case Key.OemOpenBrackets:
                        retVal = '[';
                        break;
                    case Key.OemCloseBrackets:
                        retVal = ']';
                        break;
                    // Add more special characters as needed
                    default:
                        retVal = char.ToLower(input.ToString()[0]); // Convert to lowercase
                        break;
                }
            }

            return retVal;

        }




        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
            {
                shiftKeyPressed = false;
                uppercaseEnabled = false; // Disable uppercase mode when Shift is released
                shift.Background = Brushes.Transparent;
                return;
            }

            if (e.Key == Key.CapsLock)
            {
                capsLockKeyPressed = false;
                shiftlock.Background = Brushes.Transparent;
                return;
            }


            if (e.Key == Key.Back)
            {
                if (!string.IsNullOrEmpty(output.Content.ToString()))
                {
                    output.Content = output.Content.ToString().Substring(0, output.Content.ToString().Length - 1);
                    back.Background = Brushes.Transparent;
                }
            }
            else
            {
                if (initialState)
                {
                    initialState = false;
                    output.Content = KeyManager(e.Key);
                }
                else
                    output.Content += KeyManager(e.Key) + "";
            }

            // Revert the background color when the key is released.
            switch (e.Key)
            {
                case Key.A:
                    a.Background = Brushes.Transparent;
                    break;
                case Key.B:
                    b.Background = Brushes.Transparent;
                    break;
                case Key.C:
                    cc.Background = Brushes.Transparent;
                    break;
                case Key.D:
                    d.Background = Brushes.Transparent;
                    break;
                case Key.E:
                    ee.Background = Brushes.Transparent;
                    break;
                case Key.F:
                    f.Background = Brushes.Transparent;
                    break;
                case Key.G:
                    g.Background = Brushes.Transparent;
                    break;
                case Key.H:
                    h.Background = Brushes.Transparent;
                    break;
                case Key.I:
                    i.Background = Brushes.Transparent;
                    break;
                case Key.J:
                    j.Background = Brushes.Transparent;
                    break;
                case Key.K:
                    k.Background = Brushes.Transparent;
                    break;
                case Key.L:
                    el.Background = Brushes.Transparent;
                    break;
                case Key.M:
                    m.Background = Brushes.Transparent;
                    break;
                case Key.N:
                    n.Background = Brushes.Transparent;
                    break;
                case Key.O:
                    o.Background = Brushes.Transparent;
                    break;
                case Key.P:
                    p.Background = Brushes.Transparent;
                    break;
                case Key.Q:
                    q.Background = Brushes.Transparent;
                    break;
                case Key.R:
                    r.Background = Brushes.Transparent;
                    break;
                case Key.S:
                    s.Background = Brushes.Transparent;
                    break;
                case Key.T:
                    t.Background = Brushes.Transparent;
                    break;
                case Key.U:
                    u.Background = Brushes.Transparent;
                    break;
                case Key.V:
                    v.Background = Brushes.Transparent;
                    break;
                case Key.W:
                    w.Background = Brushes.Transparent;
                    break;
                case Key.X:
                    x.Background = Brushes.Transparent;
                    break;
                case Key.Y:
                    y.Background = Brushes.Transparent;
                    break;
                case Key.Z:
                    z.Background = Brushes.Transparent;
                    break;
                // OTHER KEYPAD
                case Key.Space:
                    spacebar.Background = Brushes.Transparent;
                    break;
                case Key.Return:
                    _return.Background = Brushes.Transparent;
                    break;
                case Key.Tab:
                    tab.Background = Brushes.Transparent;
                    break;
                case Key.OemComma:
                    coma.Background = Brushes.Transparent;
                    break;

                case Key.OemPeriod:
                    dot.Background = Brushes.Transparent;
                    break;

                case Key.OemSemicolon:
                    semicolon.Background = Brushes.Transparent;
                    break;

                case Key.OemQuotes:
                    quotation.Background = Brushes.Transparent;
                    break;

                case Key.OemQuestion:
                    slash.Background = Brushes.Transparent;
                    break;

                case Key.OemPipe:
                    b_slash.Background = Brushes.Transparent;
                    break;

                case Key.OemOpenBrackets:
                    l_bracket.Background = Brushes.Transparent;
                    break;

                case Key.OemCloseBrackets:
                    r_bracket.Background = Brushes.Transparent;
                    break;

                case Key.OemPlus:
                    equal.Background = Brushes.Transparent;
                    break;

                case Key.OemMinus:
                    minus.Background = Brushes.Transparent;
                    break;

                case Key.D1:
                    one.Background = Brushes.Transparent;
                    break;

                case Key.D2:
                    two.Background = Brushes.Transparent;
                    break;

                case Key.D3:
                    three.Background = Brushes.Transparent;
                    break;

                case Key.D4:
                    four.Background = Brushes.Transparent;
                    break;

                case Key.D5:
                    five.Background = Brushes.Transparent;
                    break;

                case Key.D6:
                    six.Background = Brushes.Transparent;
                    break;

                case Key.D7:
                    seven.Background = Brushes.Transparent;
                    break;

                case Key.D8:
                    eight.Background = Brushes.Transparent;
                    break;

                case Key.D9:
                    nine.Background = Brushes.Transparent;
                    break;

                case Key.D0:
                    zero.Background = Brushes.Transparent;
                    break;
            }
        }
    }
}


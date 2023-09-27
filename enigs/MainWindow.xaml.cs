using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace enigs
{
    public partial class MainWindow : Window
    {
        private bool capsLockEnabled = false;
        private Dictionary<Key, Label> keyLabelMappings;

        public MainWindow()
        {
            InitializeComponent();
            InitializeEventHandlers();
            InitializeKeyLabelMappings();
        }

        private void InitializeEventHandlers()
        {
            KeyDown += Window_KeyDown;
            KeyUp += Window_KeyUp;
        }

        private void InitializeKeyLabelMappings()
        {
            // Map keys to their respective labels
            keyLabelMappings = new Dictionary<Key, Label>
    {
        { Key.A, a },
        { Key.B, b },
        { Key.C, cc },
        { Key.D, d },
        { Key.E, ee },
        { Key.F, f },
        { Key.G, g },
        { Key.H, h },
        { Key.I, i },
        { Key.J, j },
        { Key.K, k },
        { Key.L, el },
        { Key.M, m },
        { Key.N, n },
        { Key.O, o },
        { Key.P, p },
        { Key.Q, q },
        { Key.R, r },
        { Key.S, s },
        { Key.T, t },
        { Key.U, u },
        { Key.V, v },
        { Key.W, w },
        { Key.X, x },
        { Key.Y, y },
        { Key.Z, z },
        { Key.D1, one },    // 1
        { Key.D2, two },    // 2
        { Key.D3, three },  // 3
         { Key.D4, four },   // 4
        { Key.D5, five },   // 5
        { Key.D6, six },    // 6
        { Key.D7, seven },  // 7
        { Key.D8, eight },  // 8
        { Key.D9, nine },   // 9
        { Key.D0, zero },   // 0
        { Key.Oem1, semicolon }, // ;
        { Key.Oem2, slash },     // /     
        { Key.Oem3, openBracket }, // [
        { Key.Oem4, backslash },  // \
        { Key.Oem5, closeBracket }, // ]
        { Key.Oem6, singleQuote }, // '
        { Key.OemMinus, minus },  // -
        { Key.OemPlus, equals },  // =
        { Key.OemComma, comma },  // ,
        { Key.OemPeriod, period }, // .
        { Key.Space, spacebar },
        { Key.Back, _return }
    };
        }


        private void UpdateLabelContent(Key key)
        {
            if (capsLockEnabled || Keyboard.IsKeyDown(Key.CapsLock))
            {
                keyLabelMappings[key].Content = key.ToString();
            }
            else
            {
                keyLabelMappings[key].Content = key.ToString().ToLower();
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.CapsLock)
            {
                capsLockEnabled = !capsLockEnabled;
                shiftlock.Content = capsLockEnabled ? "Caps Lock" : "Shift Lock";
                shiftlock.Background = Brushes.Yellow;
                return;
            }

            if (keyLabelMappings.ContainsKey(e.Key))
            {
                keyLabelMappings[e.Key].Background = Brushes.Yellow;
                UpdateLabelContent(e.Key);

                // Append the pressed key to the output label
                string currentText = output.Content.ToString();
                output.Content = currentText + keyLabelMappings[e.Key].Content;
            }
        }


        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.CapsLock)
            {
                shiftlock.Background = Brushes.Transparent;
                return;
            }

            if (keyLabelMappings.ContainsKey(e.Key))
            {
                keyLabelMappings[e.Key].Background = Brushes.Transparent;
            }
        }
    }
}

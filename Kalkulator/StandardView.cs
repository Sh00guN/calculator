using System;
using System.Windows.Forms;

namespace Kalkulator
{
    public class StandardView : Form
    {
        static float[] _memory = new float[20];

        MainMenu _mainMenu = new MainMenu();
        MenuItem _view = new MenuItem();
        MenuItem _standard = new MenuItem();

        MenuItem _edit = new MenuItem();
        MenuItem _copy = new MenuItem();
        MenuItem _paste = new MenuItem();

        MenuItem _help = new MenuItem();
        MenuItem _help1 = new MenuItem();
        MenuItem _about = new MenuItem();

        TextBox _textBoxLeft = new TextBox();
        TextBox _textBoxMid = new TextBox();
        TextBox _textBoxRight = new TextBox();

        Button _button1 = new Button();
        Button _button2 = new Button();
        Button _button3 = new Button();
        Button _button4 = new Button();
        Button _button5 = new Button();
        Button _button6 = new Button();
        Button _button7 = new Button();
        Button _button8 = new Button();
        Button _button9 = new Button();
        Button _button0 = new Button();
        Button _buttonPoint = new Button();
        Button _buttonSummary = new Button();
        Button _buttonDivision = new Button();
        Button _buttonMultiplication = new Button();
        Button _buttonSustraction = new Button();
        Button _buttonAddition = new Button();
        Button _buttonBackspace = new Button();
        Button _buttonCE = new Button();
        Button _buttonC = new Button();
        Button _buttonReciproc = new Button();
        Button _buttonProcent = new Button();
        Button _buttonSqrt = new Button();
        Button _buttonPlusMinus = new Button();
        Button _buttonMC = new Button();
        Button _buttonMR = new Button();
        Button _buttonMS = new Button();
        Button _buttonMPlus = new Button();
        Button _buttonMMinus = new Button();


        public StandardView()
        {
            this.Text = "Kalkulator";
            this.Width = 250;
            this.Height = 290;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            _view.Text = "Widok";
            _mainMenu.MenuItems.Add(_view);
            _standard.Text = "Standard";
            _view.MenuItems.Add(_standard);


            _edit.Text = "Edycja";
            _mainMenu.MenuItems.Add(_edit);
            _copy.Text = "Kopiuj";
            _edit.MenuItems.Add(_copy);
            _paste.Text = "Wklej";
            _edit.MenuItems.Add(_paste);


            _help.Text = "Pomoc";
            _mainMenu.MenuItems.Add(_help);
            _help1.Text = "Wyświetl pomoc";
            _help.MenuItems.Add(_help1);
            _about.Text = "O autorze...";
            _help.MenuItems.Add(_about);


            this.Menu = _mainMenu;


            EventHandler ehCopy = new EventHandler(menuItemCopyClicked);
            _copy.Click += ehCopy;

            EventHandler ehPaste = new EventHandler(menuItemPasteClicked);
            _paste.Click += ehPaste;

            EventHandler ehHelp = new EventHandler(menuItemHelpClicked);
            _help1.Click += ehHelp;

            EventHandler ehAbout = new EventHandler(menuItemAboutClicked);
            _about.Click += ehAbout;


            _textBoxLeft.Top = 5;
            _textBoxLeft.Left = 20;
            _textBoxLeft.Width = 150;
            _textBoxLeft.ReadOnly = true;

            this.Controls.Add(_textBoxLeft);

            _textBoxMid.Top = 5;
            _textBoxMid.Left = 180;
            _textBoxMid.Width = 30;
            _textBoxMid.ReadOnly = true;

            this.Controls.Add(_textBoxMid);

            _textBoxRight.Top = 30;
            _textBoxRight.Left = 20;
            _textBoxRight.Width = 190;
            _textBoxRight.ReadOnly = true;

            this.Controls.Add(_textBoxRight);



            _button1.Top = 175;
            _button1.Left = 20;
            _button1.Width = 30;
            _button1.Text = "1";

            EventHandler ehOne = new EventHandler(this.button1Clicked);
            _button1.Click += ehOne;
            this.Controls.Add(_button1);



            _button2.Top = 175;
            _button2.Left = 60;
            _button2.Width = 30;
            _button2.Text = "2";

            EventHandler ehTwo = new EventHandler(this.button2Clicked);
            _button2.Click += ehTwo;
            this.Controls.Add(_button2);



            _button3.Top = 175;
            _button3.Left = 100;
            _button3.Width = 30;
            _button3.Text = "3";

            EventHandler ehThree = new EventHandler(this.button3Clicked);
            _button3.Click += ehThree;
            this.Controls.Add(_button3);



            _button4.Top = 145;
            _button4.Left = 20;
            _button4.Width = 30;
            _button4.Text = "4";

            EventHandler ehFour = new EventHandler(this.button4Clicked);
            _button4.Click += ehFour;
            this.Controls.Add(_button4);



            _button5.Top = 145;
            _button5.Left = 60;
            _button5.Width = 30;
            _button5.Text = "5";

            EventHandler ehFive = new EventHandler(this.button5Clicked);
            _button5.Click += ehFive;
            this.Controls.Add(_button5);



            _button6.Top = 145;
            _button6.Left = 100;
            _button6.Width = 30;
            _button6.Text = "6";

            EventHandler ehSix = new EventHandler(this.button6Clicked);
            _button6.Click += ehSix;
            this.Controls.Add(_button6);



            _button7.Top = 115;
            _button7.Left = 20;
            _button7.Width = 30;
            _button7.Text = "7";

            EventHandler ehSeven = new EventHandler(this.button7Clicked);
            _button7.Click += ehSeven;
            this.Controls.Add(_button7);



            _button8.Top = 115;
            _button8.Left = 60;
            _button8.Width = 30;
            _button8.Text = "8";

            EventHandler ehEight = new EventHandler(this.button8Clicked);
            _button8.Click += ehEight;
            this.Controls.Add(_button8);



            _button9.Top = 115;
            _button9.Left = 100;
            _button9.Width = 30;
            _button9.Text = "9";

            EventHandler ehNine = new EventHandler(this.button9Clicked);
            _button9.Click += ehNine;
            this.Controls.Add(_button9);



            _button0.Top = 205;
            _button0.Left = 20;
            _button0.Width = 70;
            _button0.Text = "0";

            EventHandler ehZero = new EventHandler(this.button0Clicked);
            _button0.Click += ehZero;
            this.Controls.Add(_button0);



            _buttonPoint.Top = 205;
            _buttonPoint.Left = 100;
            _buttonPoint.Width = 30;
            _buttonPoint.Text = ".";

            EventHandler ehPoint = new EventHandler(this.buttonPointClicked);
            _buttonPoint.Click += ehPoint;
            this.Controls.Add(_buttonPoint);



            _buttonSummary.Top = 175;
            _buttonSummary.Left = 180;
            _buttonSummary.Width = 30;
            _buttonSummary.Height = 53;
            _buttonSummary.Text = "=";

            EventHandler ehSummary = new EventHandler(this.buttonSummaryClicked);
            _buttonSummary.Click += ehSummary;
            this.Controls.Add(_buttonSummary);



            _buttonDivision.Top = 115;
            _buttonDivision.Left = 140;
            _buttonDivision.Width = 30;
            _buttonDivision.Text = "/";

            EventHandler ehDivision = new EventHandler(this.buttonDivisionClicked);
            _buttonDivision.Click += ehDivision;
            this.Controls.Add(_buttonDivision);



            _buttonMultiplication.Top = 145;
            _buttonMultiplication.Left = 140;
            _buttonMultiplication.Width = 30;
            _buttonMultiplication.Text = "*";

            EventHandler ehMultiplication = new EventHandler(this.buttonMultiplicationClicked);
            _buttonMultiplication.Click += ehMultiplication;
            this.Controls.Add(_buttonMultiplication);



            _buttonSustraction.Top = 175;
            _buttonSustraction.Left = 140;
            _buttonSustraction.Width = 30;
            _buttonSustraction.Text = "-";

            EventHandler ehSubstraction = new EventHandler(this.buttonSubstractionClicked);
            _buttonSustraction.Click += ehSubstraction;
            this.Controls.Add(_buttonSustraction);



            _buttonAddition.Top = 205;
            _buttonAddition.Left = 140;
            _buttonAddition.Width = 30;
            _buttonAddition.Text = "+";

            EventHandler ehAddiction = new EventHandler(this.buttonAddictionClicked);
            _buttonAddition.Click += ehAddiction;
            this.Controls.Add(_buttonAddition);



            _buttonBackspace.Top = 85;
            _buttonBackspace.Left = 20;
            _buttonBackspace.Width = 30;
            _buttonBackspace.Text = "<-";

            EventHandler ehBackspace = new EventHandler(this.buttonBackspaceClicked);
            _buttonBackspace.Click += ehBackspace;
            this.Controls.Add(_buttonBackspace);



            _buttonCE.Top = 85;
            _buttonCE.Left = 60;
            _buttonCE.Width = 30;
            _buttonCE.Text = "CE";

            EventHandler ehCE = new EventHandler(this.buttonCEClicked);
            _buttonCE.Click += ehCE;
            this.Controls.Add(_buttonCE);



            _buttonC.Top = 85;
            _buttonC.Left = 100;
            _buttonC.Width = 30;
            _buttonC.Text = "C";

            EventHandler ehC = new EventHandler(this.buttonCClicked);
            _buttonC.Click += ehC;
            this.Controls.Add(_buttonC);



            _buttonReciproc.Top = 145;
            _buttonReciproc.Left = 180;
            _buttonReciproc.Width = 30;
            _buttonReciproc.Text = "1/x";

            EventHandler ehReciproc = new EventHandler(this.buttonReciprocClicked);
            _buttonReciproc.Click += ehReciproc;
            this.Controls.Add(_buttonReciproc);



            _buttonProcent.Top = 115;
            _buttonProcent.Left = 180;
            _buttonProcent.Width = 30;
            _buttonProcent.Text = "%";

            EventHandler ehProcent = new EventHandler(buttonProcentClicked);
            _buttonProcent.Click += ehProcent;
            this.Controls.Add(_buttonProcent);



            _buttonSqrt.Top = 85;
            _buttonSqrt.Left = 180;
            _buttonSqrt.Width = 30;
            _buttonSqrt.Text = "√";

            EventHandler ehSqrt = new EventHandler(buttonSqrtClicked);
            _buttonSqrt.Click += ehSqrt;
            this.Controls.Add(_buttonSqrt);



            _buttonPlusMinus.Top = 85;
            _buttonPlusMinus.Left = 140;
            _buttonPlusMinus.Width = 30;
            _buttonPlusMinus.Text = "±";

            EventHandler ehPlusMinus = new EventHandler(buttonPlusMinusClicked);
            _buttonPlusMinus.Click += ehPlusMinus;
            this.Controls.Add(_buttonPlusMinus);



            _buttonMC.Top = 55;
            _buttonMC.Left = 20;
            _buttonMC.Width = 30;
            _buttonMC.Text = "MC";

            EventHandler ehMC = new EventHandler(buttonMCClicked);
            _buttonMC.Click += ehMC;
            this.Controls.Add(_buttonMC);



            _buttonMR.Top = 55;
            _buttonMR.Left = 60;
            _buttonMR.Width = 30;
            _buttonMR.Text = "MR";

            EventHandler ehMR = new EventHandler(buttonMRClicked);
            _buttonMR.Click += ehMR;
            this.Controls.Add(_buttonMR);



            _buttonMS.Top = 55;
            _buttonMS.Left = 100;
            _buttonMS.Width = 30;
            _buttonMS.Text = "MS";

            EventHandler ehMS = new EventHandler(buttonMSClicked);
            _buttonMS.Click += ehMS;
            this.Controls.Add(_buttonMS);



            _buttonMPlus.Top = 55;
            _buttonMPlus.Left = 140;
            _buttonMPlus.Width = 30;
            _buttonMPlus.Text = "M+";

            EventHandler ehMPlus = new EventHandler(buttonMPlusClicked);
            _buttonMPlus.Click += ehMPlus;
            this.Controls.Add(_buttonMPlus);



            _buttonMMinus.Top = 55;
            _buttonMMinus.Left = 180;
            _buttonMMinus.Width = 30;
            _buttonMMinus.Text = "M-";

            EventHandler ehMMinus = new EventHandler(buttonMMinusClicked);
            _buttonMMinus.Click += ehMMinus;
            this.Controls.Add(_buttonMMinus);
        }

        private void menuItemCopyClicked(Object sender, EventArgs e)
        {
            if (_textBoxLeft.Text == null || _textBoxLeft.Text == "")
            {

            }
            else
            {
                Clipboard.SetText(_textBoxLeft.Text);
            }
            
        }
        
        private void menuItemPasteClicked(Object sender, EventArgs e)
        {
            _textBoxLeft.Text = Clipboard.GetText();
        }

        private void menuItemHelpClicked(Object sender, EventArgs e)
        {
            MessageBox.Show("Strona powstanie wkrótce...");
        }

        private void menuItemAboutClicked(Object sender, EventArgs e)
        {
            MessageBox.Show("Dawid Bartkowiak       d.bartkowiak95@gmail.com        506-863-982");
        }

        private void Operations()
        {
            float a;
            float.TryParse(_textBoxLeft.Text, out a);
            float b;
            float.TryParse(_textBoxRight.Text, out b);
            switch (_textBoxMid.Text)
            {
                case "/":
                    if (b == 0)
                    {
                    }
                    else
                    {
                        _textBoxLeft.Text = (a / b).ToString();
                    }
                    break;
                case "*":
                    _textBoxLeft.Text = (a * b).ToString();
                    break;
                case "-":
                    _textBoxLeft.Text = (a - b).ToString();
                    break;
                case "+":
                    _textBoxLeft.Text = (a + b).ToString();
                    break;
                default:
                    if (_textBoxLeft.Text == null || _textBoxLeft.Text == "")
                    {
                        _textBoxLeft.Text = _textBoxRight.Text;
                    }
                    break;
            }
        }

        private void button1Clicked(Object sender, EventArgs e)
        {
            _textBoxRight.Text = _textBoxRight.Text + "1";
        }

        private void button2Clicked(Object sender, EventArgs e)
        {
            _textBoxRight.Text = _textBoxRight.Text + "2";
        }

        private void button3Clicked(Object sender, EventArgs e)
        {
            _textBoxRight.Text = _textBoxRight.Text + "3";
        }

        private void button4Clicked(Object sender, EventArgs e)
        {
            _textBoxRight.Text = _textBoxRight.Text + "4";
        }

        private void button5Clicked(Object sender, EventArgs e)
        {
            _textBoxRight.Text = _textBoxRight.Text + "5";
        }

        private void button6Clicked(Object sender, EventArgs e)
        {
            _textBoxRight.Text = _textBoxRight.Text + "6";
        }

        private void button7Clicked(Object sender, EventArgs e)
        {
            _textBoxRight.Text = _textBoxRight.Text + "7";
        }

        private void button8Clicked(Object sender, EventArgs e)
        {
            _textBoxRight.Text = _textBoxRight.Text + "8";
        }

        private void button9Clicked(Object sender, EventArgs e)
        {
            _textBoxRight.Text = _textBoxRight.Text + "9";
        }

        private void button0Clicked(Object sender, EventArgs e)
        {
            _textBoxRight.Text = _textBoxRight.Text + "0";
        }

        private void buttonPointClicked(Object sender, EventArgs e)
        {
            if (_textBoxRight.Text.Length == 0)
            {
                _textBoxRight.Text = "0,";
            }
            else
            {
                _textBoxRight.Text = _textBoxRight.Text + ",";
            }
        }

        private void buttonSummaryClicked(Object sender, EventArgs e)
        {
            Operations();
            _textBoxRight.Text = "";
            _textBoxMid.Text = "=";
        }

        private void buttonDivisionClicked(Object sender, EventArgs e)
        {
            Operations();
            _textBoxRight.Text = "";
            _textBoxMid.Text = "/";
        }

        private void buttonMultiplicationClicked(Object sender, EventArgs e)
        {
            Operations();
            _textBoxRight.Text = "";
            _textBoxMid.Text = "*";
        }

        private void buttonSubstractionClicked(Object sender, EventArgs e)
        {
            Operations();
            _textBoxRight.Text = "";
            _textBoxMid.Text = "-";
        }

        private void buttonAddictionClicked(Object sender, EventArgs e)
        {
            Operations();
            _textBoxRight.Text = "";
            _textBoxMid.Text = "+";
        }

        private void buttonBackspaceClicked(Object sender, EventArgs e)
        {
            _textBoxRight.Text = _textBoxRight.Text.Remove(_textBoxRight.Text.Length - 1, 1);
        }

        private void buttonCEClicked(Object sender, EventArgs e)
        {
            _textBoxRight.Text = null;
        }

        private void buttonCClicked(Object sender, EventArgs e)
        {
            _textBoxRight.Text = null;
            _textBoxLeft.Text = null;
            _textBoxMid.Text = null;
        }

        private void buttonReciprocClicked(Object sender, EventArgs e)
        {
            float a;
            Operations();
            _textBoxRight.Text = "";
            _textBoxMid.Text = "";
            float.TryParse(_textBoxRight.Text, out a);
            if (a == 0)
            {
            }
            else
            {
                _textBoxLeft.Text = (1 / a).ToString();
            }
        }

        private void buttonProcentClicked(Object sender, EventArgs e)
        {
            float a;
            Operations();
            _textBoxRight.Text = "";
            _textBoxMid.Text = "";
            if (_textBoxRight.Text == null || _textBoxRight.Text == "")
            {
                if (_textBoxLeft.Text == null || _textBoxLeft.Text == "")
                {

                }
                else
                {
                    float.TryParse(_textBoxLeft.Text, out a);
                    _textBoxLeft.Text = (a / 100).ToString();
                }
            }
            else
            {
                float.TryParse(_textBoxRight.Text, out a);
                _textBoxRight.Text = "";
                _textBoxLeft.Text = (a / 100).ToString();
            }
        }

        private void buttonSqrtClicked(Object sender, EventArgs e)
        {
            float a;
            Operations();
            _textBoxRight.Text = "";
            _textBoxMid.Text = "";
            if (_textBoxRight.Text == null || _textBoxRight.Text == "")
            {
                if (_textBoxLeft.Text == null || _textBoxLeft.Text == "")
                {

                }
                else
                {
                    float.TryParse(_textBoxLeft.Text, out a);
                    _textBoxLeft.Text = Math.Sqrt(a).ToString();
                }
            }
            else
            {
                float.TryParse(_textBoxRight.Text, out a);
                _textBoxRight.Text = "";
                _textBoxLeft.Text = Math.Sqrt(a).ToString();
            }
        }

        private void buttonPlusMinusClicked(Object sender, EventArgs e)
        {
            Operations();
            _textBoxRight.Text = "";
            _textBoxMid.Text = "";
            if (_textBoxRight.Text == null || _textBoxRight.Text == "")
            {
                if (_textBoxLeft.Text == null || _textBoxLeft.Text == "")
                {

                }
                else
                {
                    if (_textBoxLeft.Text[0] == '-')
                    {
                        _textBoxLeft.Text = _textBoxLeft.Text.Substring(1);
                    }
                    else
                    {
                        _textBoxLeft.Text = "-" + _textBoxLeft.Text;
                    }
                }
            }
            else
            {
                if (_textBoxRight.Text[0] == '-')
                {
                    _textBoxRight.Text = _textBoxRight.Text.Substring(1);
                }
                else
                {
                    _textBoxRight.Text = "-" + _textBoxRight.Text;
                }
            }
        }

        private void buttonMCClicked(Object sender, EventArgs e)
        {
            foreach (int a in _memory)
            {
                _memory[a] = 0;
            }
        }

        private void buttonMRClicked(Object sender, EventArgs e)
        {
            for (int i = _memory.Length - 1; i >= 0; i--)
            {
                if (_memory[i] != 0)
                {
                    _textBoxLeft.Text = _memory[i].ToString();
                }
            }
        }

        private void buttonMSClicked(Object sender, EventArgs e)
        {
            foreach (int i in _memory)
            {
                _memory[i] = 0;
            }
            float.TryParse(_textBoxLeft.Text, out _memory[0]);
        }

        private void buttonMPlusClicked(Object sender, EventArgs e)
        {
            for (int i = _memory.Length - 1; i >= 0; i--)
            {
                if (_memory[i] != 0)
                {
                    float.TryParse(_textBoxLeft.Text, out _memory[i + 1]);
                }
            }
        }

        private void buttonMMinusClicked(Object sender, EventArgs e)
        {
            foreach (int i in _memory)
            {
                if (_memory[i].ToString() == _textBoxLeft.Text)
                {
                    _memory[i] = 0;
                }
            }
        }
    }
}

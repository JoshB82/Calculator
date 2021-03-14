using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        private string expression;
        private string newTerm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateDisplay(string newExpression, string newTerm)
        {
            ExpressionBox.Text = newExpression;
            ResultDisplay.Text = newTerm;
        }

        private void SevenButton_Click(object sender, EventArgs e) => UpdateDisplay(expression += "7", newTerm += "7");

        private void EightButton_Click(object sender, EventArgs e) => UpdateDisplay(expression += "8", newTerm += "8");

        private void NineButton_Click(object sender, EventArgs e) => UpdateDisplay(expression += "9", newTerm += "9");

        private void FourButton_Click(object sender, EventArgs e) => UpdateDisplay(expression += "4", newTerm += "4");

        private void FiveButton_Click(object sender, EventArgs e) => UpdateDisplay(expression += "5", newTerm += "5");

        private void SixButton_Click(object sender, EventArgs e) => UpdateDisplay(expression += "6", newTerm += "6");

        private void OneButton_Click(object sender, EventArgs e) => UpdateDisplay(expression += "1", newTerm += "1");

        private void TwoButton_Click(object sender, EventArgs e) => UpdateDisplay(expression += "2", newTerm += "2");

        private void ThreeButton_Click(object sender, EventArgs e) => UpdateDisplay(expression += "3", newTerm += "3");

        private void SingleZeroButton_Click(object sender, EventArgs e) => UpdateDisplay(expression += "0", newTerm += "0");

        private void DoubleZeroButton_Click(object sender, EventArgs e) => UpdateDisplay(expression += "00", newTerm += "00");

        private void AddButton_Click(object sender, EventArgs e) => UpdateDisplay(expression += "+", newTerm);

        private void SubtractButton_Click(object sender, EventArgs e) => UpdateDisplay(expression += "-", newTerm);

        private void MultiplyButton_Click(object sender, EventArgs e) => UpdateDisplay(expression += "*", newTerm);

        private void DivideButton_Click(object sender, EventArgs e) => UpdateDisplay(expression += "/", newTerm);

        private void OpenBracketButton_Click(object sender, EventArgs e)
        {

        }

        private void CloseBracketButton_Click(object sender, EventArgs e)
        {

        }

        private void PowerButton_Click(object sender, EventArgs e)
        {

        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
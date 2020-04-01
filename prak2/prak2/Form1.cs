using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prak2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void OnFormLoad(object obj,EventArgs e)
        {
            List<Operation> operations = new List<Operation> { 
                new Add(),
                new Subtract(),
                new Multiply(),
                new Divide() };

            foreach(Operation operation in operations)
            {
                richTextBox1.Text += operation.GetInfo() + "\n";
            }
        }
        public void OnButtonClick(object obj, EventArgs e)
        {
            using (StreamReader streamReader = new StreamReader("myFile.txt"))
            {
                List<string> elements = streamReader.ReadLine().Split(' ').ToList();
                Operation operation ;
                switch (elements[1])
                {
                    case "+":
                        operation = new Add();
                        break;
                    case "-":
                        operation = new Subtract();
                        break;
                    case "*":
                        operation = new Multiply();
                        break;
                    case "/":
                        operation = new Divide();
                        break;
                    default:
                        operation = new Divide();
                        break;

                }
                operation.operator_1 = Convert.ToDouble(elements[0]);
                operation.operator_2 = Convert.ToDouble(elements[2]);
                richTextBox1.Clear();
                richTextBox1.Text = operation.Execute().ToString();
            } 

        }
    }
}

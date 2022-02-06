using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinForms.Business_Logic;

namespace WinForms
{
   internal partial class NewQuestion : Form
    {
        public NewQuestion()
        {
            InitializeComponent();
            Answers = new List<Answer>();
        }

        private void NewQuestion_Load(object sender, EventArgs e)
        {

        }

        public string QuestionText { get; private set; }

        public List<Answer> Answers { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            QuestionText = textBox1.Text;


           for (int i = 0; i< 4; i++)
            {
                var a = StoreAnswer(i); 
                if (!string.IsNullOrEmpty(a.Text))
                {
                    Answers.Add(a);
                }
            }
            this.Close();
            //Answers.Add(new Answer(textBox2.Text, checkBox1.Checked));

        }

        public Answer StoreAnswer(int index)
        {
          // var t = typeof(NewQuestion);

           //var fields = t.GetFields(System.Reflection.BindingFlags.NonPublic);

           //var answerText =  fields.Single(f => f.Name == $"textbox{index}");

            //var textProp = typeof(TextBox).GetProperty("Text");

           //var answerTextobj = answerText.GetValue(this);

            //var textPropvalue = textProp.GetValue(answerTextobj);

            //return new Answer(textPropvalue.ToString());

            switch(index)
            {
                case 0:
                    return new Answer(textBox2.Text, checkBox1.Checked);
                case 1:
                    return new Answer(textBox3.Text, checkBox2.Checked);
                case 2:
                    return new Answer(textBox4.Text, checkBox3.Checked);
                case 3:
                    return new Answer(textBox5.Text, checkBox4.Checked);
                default:
                    throw new ArgumentOutOfRangeException();

            }

        }
    }
}

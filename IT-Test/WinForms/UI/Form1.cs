using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Business_Logic;
using WinForms.Core;
using WinForms.Persistance;

namespace WinForms
{
    public partial class Form1 : Form
    {
        private IRepository<Question> _fileRepository;

        private List<Question> _questions;

        private Question _currentQuestion;

        private int _currentQuestionIndex;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you really want to exit?", "IT-Test", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            this.Close();
        }

        private void открытьToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.ShowDialog();

            var txt = File.ReadAllText(openFileDialog1.FileName);

            txtQuestionText.Text = txt;
        }

        Form2 formNext = new Form2();
        private void button1_Click_1(object sender, EventArgs e)
        {
            formNext.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void toolStripButtonLoad_Click(object sender, EventArgs e)
        {
            _questions = _fileRepository.GetAll().ToList();
            if (!_questions.Any())
                return;
            _currentQuestionIndex = 0;
            

            SetQuestion();

            this.Refresh();
        }

        private void SetQuestion()
        {
            _currentQuestion = _questions[_currentQuestionIndex];
            txtQuestionText.Text = _currentQuestion.Text;

            var i = 0;
            foreach (var item in _currentQuestion.Answers)
            {
                SetAnswer(i++, item);
            }
        }

        private void SetAnswer(int id, Answer value)
        {
            var chk = GetCheckBox(id);
            chk.Text = value.Text;
            chk.Visible = true;
        }

        private CheckBox GetCheckBox(int id)
        {
            switch (id)
            {
                case 0:
                    return checkBox1;
                case 1:
                    return checkBox2;
                case 2:
                    return checkBox3;
                case 3:
                    return checkBox4;
                default:
                    throw new IndexOutOfRangeException();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _fileRepository = new FileRepository();
        }

        private void btnCommitAnswer_Click(object sender, EventArgs e)
        {
            var i = 0;
            bool correct = true;

            foreach(var item in _currentQuestion.Answers)
            {
                var c = GetCheckBox(i++);
                correct = correct && (item.IsCorrect ? c.Checked : !c.Checked);
                if (!correct)
                    break;
            }

            MessageBox.Show(
                correct 
                ? "Congratulations" 
                : "try again", 
                _currentQuestion.Text, MessageBoxButtons.OK);
        }

        private void toolStripButtonNext_Click(object sender, EventArgs e)
        {
            _currentQuestionIndex++;

            toolStripButtonNext.Enabled = _questions.Count > _currentQuestionIndex;
            SetQuestion();

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void создатьToolStripButton_Click(object sender, EventArgs e)
        {
            
            var newQuestion = new NewQuestion();

            newQuestion.ShowDialog();

            var question = new Question(newQuestion.QuestionText, newQuestion.Answers);

            Save(question);

        }

        private void Save(Question question)
        {
            _fileRepository.Add(question);
        }
    }
}

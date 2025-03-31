using WinFormsApp2.Models;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        int questionindex = 0;
        int points = 0;

        private List<Question> questions;


        public Form1()
        {
            InitializeComponent();
            LoadQuestions();
            showQuestions();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            questionindex++;
            showQuestions();
        }


        private void showQuestions()
        {
            Question question = questions[questionindex];

            label2.Text = question.Text;

            if (question.IsMultipleChoice)
            {
                // ���������� CheckBox, �������� RadioButton
                groupBoxSingleChoice.Visible = false;
                groupBoxMultipleChoice.Visible = true;

                checkBox1.Text = question.Answers[0].Text;
                checkBox2.Text = question.Answers[1].Text;
                checkBox3.Text = question.Answers[2].Text;
            }
            else
            {
                // ���������� RadioButton, �������� CheckBox
                groupBoxSingleChoice.Visible = true;
                groupBoxMultipleChoice.Visible = false;

                radioButton1.Text = question.Answers[0].Text;
                radioButton2.Text = question.Answers[1].Text;
                radioButton3.Text = question.Answers[2].Text;
            }
        }







        private void LoadQuestions()
        {
            questions = new List<Question>
    {
        new Question("Which language is primarily used in .NET?", false, new List<Answer>
        {
            new Answer("C#", true),
            new Answer("Python", false),
            new Answer("Java", false)
        }),
        new Question("Which languages compile to IL?", true, new List<Answer>
        {
            new Answer("C#", true),
            new Answer("VB.NET", true),
            new Answer("JavaScript", false)
        }),
        new Question("What does JIT stand for in .NET?", false, new List<Answer>
        {
            new Answer("Just-In-Time", true),
            new Answer("Java Intermediate Type", false),
            new Answer("Jump Instruction Table", false)
        }),
        new Question("Which of the following are .NET core features?", true, new List<Answer>
        {
            new Answer("Cross-platform support", true),
            new Answer("Garbage collection", true),
            new Answer("Manual memory management", false)
        }),
        new Question("Which of these are value types in C#?", true, new List<Answer>
        {
            new Answer("int", true),
            new Answer("double", true),
            new Answer("string", false)
        }),
        new Question("Which class is used for file handling in .NET?", false, new List<Answer>
        {
            new Answer("FileStream", true),
            new Answer("SqlCommand", false),
            new Answer("DataReader", false)
        }),
        new Question("What is the base class of all .NET classes?", false, new List<Answer>
        {
            new Answer("System.Object", true),
            new Answer("System.Base", false),
            new Answer("System.Root", false)
        }),
        new Question("Which statement is used to handle exceptions in C#?", false, new List<Answer>
        {
            new Answer("try-catch", true),
            new Answer("if-else", false),
            new Answer("switch-case", false)
        }),
        new Question("Which of the following are reference types in C#?", true, new List<Answer>
        {
            new Answer("string", true),
            new Answer("object", true),
            new Answer("int", false)
        }),

        new Question("Which method is used to start a thread in C#?", false, new List<Answer>
        {
            new Answer("Start()", true),
            new Answer("Run()", false),
            new Answer("Execute()", false)
        })
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

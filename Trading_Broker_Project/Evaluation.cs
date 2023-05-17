using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Trading_Broker_Project
{
    public partial class Evaluation : Form
    {
        /*
        public string[] questions = new string[] { "How much capital do you have right now?","What is your employment?","What is your annual capital?","Do you have experience in trading CFD's?","How long have you been trading for in the past?"};
        private string[] ena = new string[] { "< 10k€", "Student", "< 25k €", "What do you care?", "< 6 months" };
        private string[] dva = new string[] { "10k - 25k€", "Employed", "25k - 50k €", "Yes", "6 months - 1 year" };
        private string[] tri = new string[] { "25k - 50k€", "Unemployed", "50k - 100k €", "No", "1 year - 3 years" };
        private string[] stiri = new string[] { "< 100k€", "Rather not say", "< 100k €", "A little", "Over 3 years" };
        private int[] correct = new int[] { 4, 2, 4, 2, 4 };
        private bool[] correct_answers = new bool[6];
        int i;
        */
        private int currentQuestionIndex;
        private int correctAnswers;

        private List<Question> questions;
        public Evaluation()
        {
            InitializeComponent();

            question.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right; // label sem naredil da ne overflowa

            questions = new List<Question> // list z mojimi vprašanji
            {
                new Question("Question 1: How much capital do you have right now?", new List<string> { "< 10k€", "10k - 25k€", "25k - 50k€", "< 100k€" }, 3),
                new Question("Question 2: What is your employment?", new List<string> { "Student", "Employed", "Unemployed", "Rather not say" }, 1),
                new Question("Question 3: What is your annual salary?", new List<string> { "< 10k€", "10k - 25k€", "25k - 50k€", "< 100k€" }, 3),
                new Question("Question 4: Do you have experience trading CFD's?", new List<string> { "< 6 months", "6 months - 1 year", "1 year - 3 years", "Over 3 years" }, 3),
                
            };

            currentQuestionIndex = 0;
            correctAnswers = 0;

            DisplayCurrentQuestion();
        }
        private void DisplayCurrentQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                Question currentQuestion = questions[currentQuestionIndex];

                question.Text = currentQuestion.Text;

                one.Text = currentQuestion.Answers[0];
                two.Text = currentQuestion.Answers[1];
                three.Text = currentQuestion.Answers[2];
                four.Text = currentQuestion.Answers[3];
            }
            else
            {
                // Ko je kviz narejen
                double percent = CalculatePercentage();
                if (percent > 0.49)
                {
                    MessageBox.Show($"Quiz narejen!\nŠtevilo pravilnih odgovorov: \nProcenti: {percent}%");

                    this.Hide();
                    Register r = new Register();
                    r.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show($"Žal nisi narejen za to :( in dosegel si {percent}%");
                    this.Hide();
                }
            }
        }

        private void CheckAnswer(int selectedAnswerIndex)
        {
            Question currentQuestion = questions[currentQuestionIndex];

            if (selectedAnswerIndex == currentQuestion.CorrectAnswerIndex)
            {
                correctAnswers++;
            }

            currentQuestionIndex++;
            DisplayCurrentQuestion();
        }
        private double CalculatePercentage()
        {
            double percentage = (double)correctAnswers / questions.Count * 100;

            return percentage;
        
    }
        private void button1_Click(object sender, EventArgs e)
        {
            CheckAnswer(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckAnswer(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckAnswer(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckAnswer(3);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        
        private void Evaluation_Load(object sender, EventArgs e)
        {
            //vprasanje(i);
            


        }
        /*
        private void vprasanje(int i)
        {
            
            question.Text = questions[i];

            one.Text = ena[i];
            two.Text = dva[i];
            three.Text = tri[i];
            four.Text = stiri[i];


            
        }
        private bool odgovor(int st)
        {
            
            if(i < 4)
            {
                float povp = 0;
                for(int j = 0; j < correct_answers.Length; j++)
                {
                    if (correct_answers[j])
                    {
                        povp++;
                    }
                }
                if(povp / 5 > 2.5)
                {
                    this.Hide();
                    Register r = new Register();
                    r.ShowDialog();
                    this.Show();
                    
                }
                return false;

            }
            else if (correct[i] == st)
            {
                
                return true;
            }
            else
            {
                return false;
            }


        }*/
    }
}

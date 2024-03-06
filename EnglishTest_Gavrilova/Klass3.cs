using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishTest_Gavrilova
{
    public partial class Klass3 : Form
    {
        int QuectionCount;
        int CorrectAnswers;
        int WrongAnswers;

        string[] array;

        int CorrectAnswersNumber = 0;
        int SelectedResponse = 0;


        System.IO.StreamReader FileRead;
        public Klass3()
        {
            InitializeComponent();
        }
        void Start()
        {
            var Encoding = System.Text.Encoding.GetEncoding(65001);
            try
            {

                FileRead = new System.IO.StreamReader(
                System.IO.Directory.GetCurrentDirectory() +
                                               @"\test3.txt", Encoding);
                this.Text = FileRead.ReadLine();

                QuectionCount = 0;
                CorrectAnswers = 0;
                WrongAnswers = 0;

                array = new String[10];
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильно указано имя файла", "Ошибка");
            }
            ReadQestions();

        }
        void ReadQestions()
        {
            Question1Klass3.Text = FileRead.ReadLine();

            Answer1Klass3.Text = FileRead.ReadLine();
            Answer2Klass3.Text = FileRead.ReadLine();
            Answer3Klass3.Text = FileRead.ReadLine();
            Answer4Klass3.Text = FileRead.ReadLine();

            CorrectAnswersNumber = int.Parse(FileRead.ReadLine());

            Answer1Klass3.Checked = false;
            Answer2Klass3.Checked = false;
            Answer3Klass3.Checked = false;
            Answer4Klass3.Checked = false;


            btnAnswer.Enabled = false;
            QuectionCount++;

            if (FileRead.EndOfStream == true)
            {
                btnAnswer.Text = "Завершить";
            }

        }

        void SwitchingStatus(object sender, EventArgs e)
        {
            btnAnswer.Enabled = true;
            btnAnswer.Focus();

            if (Answer1Klass3.Checked)
            {
                SelectedResponse = 1;
            }
            else if (Answer2Klass3.Checked)
            {
                SelectedResponse = 2;
            }
            else if (Answer3Klass3.Checked)
            {
                SelectedResponse = 3;
            }
            else if (Answer4Klass3.Checked)
            {
                SelectedResponse = 4;
            }
        }
        private void btnAnswer_Click_1(object sender, EventArgs e)
        {
            if (SelectedResponse == CorrectAnswersNumber)
            {
                CorrectAnswers++;

            }
            if (SelectedResponse != CorrectAnswersNumber)
            {
                WrongAnswers++;

                array[WrongAnswers] = Question1Klass3.Text;
            }
            if (btnAnswer.Text == "Начать тестирование сначала")
            {
                btnAnswer.Text = "Следующий вопрос";

                Answer1Klass3.Visible = true;
                Answer2Klass3.Visible = true;
                Answer3Klass3.Visible = true;
                Answer4Klass3.Visible = true;

                Start(); return;
            }
            if (btnAnswer.Text == "Завершить")
            {
                FileRead.Close();

                Answer1Klass3.Visible = false;
                Answer2Klass3.Visible = false;
                Answer3Klass3.Visible = false;
                Answer4Klass3.Visible = false;

                Question1Klass3.Text = String.Format("Тестирование завершено.\n" +
                    "Правильных ответов: {0} из {1}.\n" +
                    "Набранные балы: {2:F2}.", CorrectAnswers,
                    QuectionCount, (CorrectAnswers * 5.0F) / QuectionCount);

                btnAnswer.Text = "Начать тестирование сначала";

                var Str = "Список ошибок " +
                          ":\n\n";
                for (int i = 1; i <= WrongAnswers; i++)
                    Str = Str + array[i] + "\n";


                if (WrongAnswers != 0) MessageBox.Show(
                                          Str, "Тестирование завершено");
            }
            if (btnAnswer.Text == "Следующий вопрос") ReadQestions();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Klass3_Load(object sender, EventArgs e)
        {
            btnAnswer.Text = "Следующий вопрос";
            btnExit.Text = "Выход";

            Answer1Klass3.CheckedChanged += new EventHandler(SwitchingStatus);
            Answer2Klass3.CheckedChanged += new EventHandler(SwitchingStatus);
            Answer3Klass3.CheckedChanged += new EventHandler(SwitchingStatus);
            Answer4Klass3.CheckedChanged += new EventHandler(SwitchingStatus);

            Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr1 = new Form1();
            fr1.ShowDialog();
        }
    }

  
}


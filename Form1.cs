using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Max_Laba_WindowsForm_ComplexNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { textBoxCN1Rl, textBoxCN1Im, textBoxCN2Rl, textBoxCN2Im, textBoxCN3Rl, textBoxCN3Im, textBoxCN4Rl, textBoxCN4Im };
            for (int i = 0; i < textBoxes.Length; i++)
            {
                textBoxes[i] = RandomTextBox(textBoxes[i], i);
                textBoxes[i].ForeColor = Color.Black;
            }
        }

        private TextBox RandomTextBox(TextBox textBox, int b)
        {
            Random random = new Random();
            var newTextBox = textBox;
            newTextBox.Text = (Math.Round((random.Next(100) + random.NextDouble()), b)).ToString();
            return newTextBox;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { textBoxCN1Rl, textBoxCN1Im, textBoxCN2Rl, textBoxCN2Im, textBoxCN3Rl, textBoxCN3Im, textBoxCN4Rl, textBoxCN4Im };
            ComplexNumber[] complexNumbers = GetCompNums(textBoxes);
            string result = null;

            for (int i = 0; i < complexNumbers.Length; i++)
            {
                result += complexNumbers[i].ToString();
                result += "\n";
                result += new string('=', 46);
                result += "\n";
            }
            MessageBox.Show(result);
        }

        private static ComplexNumber[] GetCompNums(TextBox[] textBoxes)
        {
            ComplexNumber[] complexNumbers = new ComplexNumber[4];
            try
            {
                for (int i = 0; i < 4; i++)
                {
                    complexNumbers[i] = new ComplexNumber(Double.Parse(textBoxes[i * 2].Text), Double.Parse(textBoxes[(i * 2) + 1].Text));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            return complexNumbers;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { textBoxCN1Rl, textBoxCN1Im, textBoxCN2Rl, textBoxCN2Im, textBoxCN3Rl, textBoxCN3Im, textBoxCN4Rl, textBoxCN4Im };

            ComplexNumber[] complexNumbers = GetCompNums(textBoxes);
            if (complexNumbers[0] != null ||
                complexNumbers[1] != null ||
                complexNumbers[2] != null ||
                complexNumbers[3] != null)
            {
                ComplexNumber R = ComplexNumber.Pow(complexNumbers[1], 3) + (complexNumbers[0] + complexNumbers[1]) * complexNumbers[3] / (complexNumbers[2] - complexNumbers[0]);
                MessageBox.Show(R.ToString());
            }
            else
            {
                MessageBox.Show("Ошибка\nНажмите на кнопку рандом => Сохранить");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { textBoxCN1Rl, textBoxCN1Im, textBoxCN2Rl, textBoxCN2Im, textBoxCN3Rl, textBoxCN3Im, textBoxCN4Rl, textBoxCN4Im };
            ComplexNumber[] complexNumbers = GetCompNums(textBoxes);
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            FileStream file = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
            // Создаем двоичный поток для записи
            BinaryWriter bw = new BinaryWriter(file,System.Text.Encoding.UTF8);
            string result = null;
            for (int i = 0; i < 4; i++)
            {
                result += complexNumbers[i].BineryString();
                result += " ";
            }
            bw.Write(result);
            bw.Close();
            file.Close();
        }

        private void button2_Click(object sender, EventArgs e) // Извлечение данных(строки) из файла
        {
            TextBox[] textBoxes = { textBoxCN1Rl, textBoxCN1Im, textBoxCN2Rl, textBoxCN2Im, textBoxCN3Rl, textBoxCN3Im, textBoxCN4Rl, textBoxCN4Im };
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            FileStream file1 = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            // Создаем двоичный поток для записи
            BinaryReader binery = new BinaryReader(file1, System.Text.Encoding.UTF8);
            string result = binery.ReadString(); 
            binery.Close();
            file1.Close();
            ComplexNumber[] temp = GetFromString(result);//Перебор строки
                                                         //string @new = null;
                                                         //for (int i = 0; i < temp.Length; i++)
                                                         //{
                                                         //    @new += temp[i].ToString();
                                                         //    @new += "\n";
                                                         //}
                                                         //MessageBox.Show(@new);
            double a, b;
            for (int i = 0; i < 4; i++)
            {
                a = temp[i].RealPart;
                b = temp[i].ImaginaryPart;
                textBoxes[i * 2].Text = a.ToString();
                textBoxes[i * 2 + 1].Text = b.ToString();
            }
        }

        private ComplexNumber[] GetFromString(string result)
        {
            char temp = ' ';
            int[] indexes = new int[7];
            string temptemp = result;
            for (int i = 0; i < 7; i++)
            {
                indexes[i] = temptemp.IndexOf(temp);
                temptemp = temptemp.Substring(temptemp.IndexOf(temp) + 1);
            }
            ComplexNumber[] complexNumber = new ComplexNumber[4];

            double b = Double.Parse(result.Substring(0, indexes[0]));
            result = result.Substring(indexes[0] + 1);
            double a = double.Parse(result.Substring(0, indexes[1]));
            result = result.Substring(indexes[1] + 1);
            complexNumber[0] = new ComplexNumber(a, b);

            b = Double.Parse(result.Substring(0, indexes[2]));
            result = result.Substring(indexes[2] + 1);
            a = Double.Parse(result.Substring(0, indexes[3]));
            result = result.Substring(indexes[3] + 1);
            complexNumber[1] = new ComplexNumber(a, b);

            b = Double.Parse(result.Substring(0, indexes[4]));
            result = result.Substring(indexes[4] + 1);
            a = Double.Parse(result.Substring(0, indexes[5]));
            result = result.Substring(indexes[5] + 1);
            complexNumber[2] = new ComplexNumber(a, b);

            b = Double.Parse(result.Substring(0, indexes[6]));
            result = result.Substring(indexes[6] + 1);
            a = Double.Parse(result.Substring(0));
            complexNumber[3] = new ComplexNumber(a, b);

            return complexNumber;
        }
    }
}



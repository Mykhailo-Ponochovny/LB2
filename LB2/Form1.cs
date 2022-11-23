using Microsoft.VisualBasic.Devices;
using System;

namespace LB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Studio> studios = new List<Studio>();

        private void Form1_Load(object sender, EventArgs e) { }

        private void Form1_Load_1(object sender, EventArgs e) { }

        private void Form1_Load_2(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length == 0 || textBoxName.Text.Trim().Length == 0)
            {
                textBoxName.Text = string.Empty;
                resultLabel.ForeColor = System.Drawing.Color.Red;
                resultLabel.Text = "������ ����� ���䳿";
                return;
            }

            if (textBoxAdress.Text.Length == 0 || textBoxAdress.Text.Trim().Length == 0)
            {
                textBoxAdress.Text = string.Empty;
                resultLabel.ForeColor = System.Drawing.Color.Red;
                resultLabel.Text = "������ ������ ���䳿";
                return;
            }

            if (textBoxEmployee.Text.Length == 0 || textBoxEmployee.Text.Trim().Length == 0)
            {
                textBoxEmployee.Text = string.Empty;
                resultLabel.ForeColor = System.Drawing.Color.Red;
                resultLabel.Text = "������ ������� ����������� �� ���䳿";
                return;
            }
            else
            {
                int num;
                try
                {
                    num = Convert.ToInt32(textBoxEmployee.Text);
                }
                catch (Exception)
                {
                    textBoxEmployee.Text = string.Empty;
                    resultLabel.ForeColor = System.Drawing.Color.Red;
                    resultLabel.Text = "������� ���� ����� ���";
                    return;
                }
                if (num < 0)
                {
                    textBoxEmployee.Text = string.Empty;
                    resultLabel.ForeColor = System.Drawing.Color.Red;
                    resultLabel.Text = "ʳ������ ����������� �� ���� ���� ��'�����";
                    return;
                }
            }

            if (textBoxTrackPrice.Text.Length == 0 || textBoxTrackPrice.Text.Trim().Length == 0)
            {
                textBoxTrackPrice.Text = string.Empty;
                resultLabel.ForeColor = System.Drawing.Color.Red;
                resultLabel.Text = "������ ������� ������ �����";
                return;
            }
            else
            {
                double num;
                try
                {
                    num = Convert.ToDouble(textBoxTrackPrice.Text);
                }
                catch (Exception)
                {
                    textBoxTrackPrice.Text = string.Empty;
                    resultLabel.ForeColor = System.Drawing.Color.Red;
                    resultLabel.Text = "������� ���� �����";
                    return;
                }
                if (num < 0)
                {
                    textBoxTrackPrice.Text = string.Empty;
                    resultLabel.ForeColor = System.Drawing.Color.Red;
                    resultLabel.Text = "������� �� ���� ���� ��'�����";
                    return;
                }
            }

            if (textBoxTrackTime.Text.Length == 0 || textBoxTrackTime.Text.Trim().Length == 0)
            {
                textBoxTrackTime.Text = string.Empty;
                resultLabel.ForeColor = System.Drawing.Color.Red;
                resultLabel.Text = "������ ��� ��������� ������ �����";
                return;
            }
            else
            {
                double num;
                try
                {
                    num = Convert.ToDouble(textBoxTrackTime.Text);
                }
                catch (Exception)
                {
                    textBoxTrackTime.Text = string.Empty;
                    resultLabel.ForeColor = System.Drawing.Color.Red;
                    resultLabel.Text = "������� ���� �����";
                    return;
                }
                if (num < 0)
                {
                    textBoxTrackTime.Text = string.Empty;
                    resultLabel.ForeColor = System.Drawing.Color.Red;
                    resultLabel.Text = "��� ���������� �� ���� ���� ��'�����";
                    return;
                }
            }

            if (textBoxSalary.Text.Length == 0 || textBoxSalary.Text.Trim().Length == 0)
            {
                textBoxSalary.Text = string.Empty;
                resultLabel.ForeColor = System.Drawing.Color.Red;
                resultLabel.Text = "������ �������� ����� ������ �����������";
                return;
            }
            else
            {
                double num;
                try
                {
                    num = Convert.ToDouble(textBoxSalary.Text);
                }
                catch (Exception)
                {
                    textBoxSalary.Text = string.Empty;
                    resultLabel.ForeColor = System.Drawing.Color.Red;
                    resultLabel.Text = "������� ���� �����";
                    return;
                }
                if (num < 0)
                {
                    textBoxSalary.Text = string.Empty;
                    resultLabel.ForeColor = System.Drawing.Color.Red;
                    resultLabel.Text = "�������� ����� �� ���� ���� ��'�����";
                    return;
                }
            }

            if (textBoxInstruments.Text.Length == 0 || textBoxInstruments.Text.Trim().Length == 0)
            {
                textBoxInstruments.Text = string.Empty;
                resultLabel.ForeColor = System.Drawing.Color.Red;
                resultLabel.Text = "������ ������� ����������� �� ���䳿";
                return;
            }
            else
            {
                int num;
                try
                {
                    num = Convert.ToInt32(textBoxInstruments.Text);
                }
                catch (Exception)
                {
                    textBoxInstruments.Text = string.Empty;
                    resultLabel.ForeColor = System.Drawing.Color.Red;
                    resultLabel.Text = "������� ���� ��� �����";
                    return;
                }
                if (num < 0)
                {
                    textBoxInstruments.Text = string.Empty;
                    resultLabel.ForeColor = System.Drawing.Color.Red;
                    resultLabel.Text = "ʳ������ ����������� �� ���� ���� ��'�����";
                    return;
                }
            }

            if (textBoxRooms.Text.Length == 0 || textBoxRooms.Text.Trim().Length == 0)
            {
                textBoxInstruments.Text = string.Empty;
                resultLabel.ForeColor = System.Drawing.Color.Red;
                resultLabel.Text = "������ ������� ����� �� ���䳿";
                return;
            }
            else
            {
                int num;
                try
                {
                    num = Convert.ToInt32(textBoxRooms.Text);
                }
                catch (Exception)
                {
                    textBoxRooms.Text = string.Empty;
                    resultLabel.ForeColor = System.Drawing.Color.Red;
                    resultLabel.Text = "������� ���� ��� �����";
                    return;
                }
                if (num < 0)
                {
                    textBoxRooms.Text = string.Empty;
                    resultLabel.ForeColor = System.Drawing.Color.Red;
                    resultLabel.Text = "ʳ������ ����� �� ���� ���� ��'�����";
                    return;
                }
            }
            int numRooms = Convert.ToInt32(textBoxRooms.Text);
            int numInstruments = Convert.ToInt32(textBoxInstruments.Text);
            int numEmployee = Convert.ToInt32(textBoxEmployee.Text);

            if (numEmployee / numRooms < 2)
            {
                resultLabel.Text =
                    "� ���� ����� �� ���� �� ����� ���� �����������, ����� ������ ���";
                return;
            }
            if (numInstruments / numRooms < 2)
            {
                resultLabel.Text =
                    "� ���� ����� �� ���� �� ����� ���� �����������, ����� ������ ���";
                return;
            }
            Studio studio = new Studio(
                textBoxName.Text,
                textBoxAdress.Text,
                numEmployee,
                Convert.ToDouble(textBoxTrackPrice.Text),
                Convert.ToDouble(textBoxTrackTime.Text),
                Convert.ToDouble(textBoxSalary.Text),
                numInstruments,
                numRooms
            );

            currentStudio.Text = studio.ToString();

            studios.Add(studio);
            comboBox1.Items.Add(studio.getName());
            comboBox1.SelectedIndex = studios.Count - 1;
            resultLabel.ForeColor = System.Drawing.Color.Green;
            resultLabel.Text = "�������� ���� �����";
            clearField();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                resultLabel.Text = "�������� ������� ����� ���� �����";
                resultLabel.ForeColor = System.Drawing.Color.Red;
                return;
            }
            currentStudio.Text = studios[comboBox1.SelectedIndex].ToString();
            resultLabel.ForeColor = System.Drawing.Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                resultLabel.Text = "�������� ������� ����� ���� �����";
                resultLabel.ForeColor = System.Drawing.Color.Red;
                return;
            }
            resultLabel.Text = studios[comboBox1.SelectedIndex].addRoom();
            currentStudio.Text = studios[comboBox1.SelectedIndex].ToString();
            resultLabel.ForeColor = System.Drawing.Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                resultLabel.Text = "�������� ������� ����� ���� �����";
                resultLabel.ForeColor = System.Drawing.Color.Red;
                return;
            }
            resultLabel.Text = studios[comboBox1.SelectedIndex].removeRoom();
            currentStudio.Text = studios[comboBox1.SelectedIndex].ToString();
            resultLabel.ForeColor = System.Drawing.Color.Green;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                resultLabel.Text = "�������� ������� ����� ���� �����";
                resultLabel.ForeColor = System.Drawing.Color.Red;
                return;
            }
            resultLabel.Text = studios[comboBox1.SelectedIndex].addEmployee();
            currentStudio.Text = studios[comboBox1.SelectedIndex].ToString();
            resultLabel.ForeColor = System.Drawing.Color.Green;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                resultLabel.Text = "�������� ������� ����� ���� �����";
                resultLabel.ForeColor = System.Drawing.Color.Red;
                return;
            }
            resultLabel.Text = studios[comboBox1.SelectedIndex].removeEmployee();
            currentStudio.Text = studios[comboBox1.SelectedIndex].ToString();
            resultLabel.ForeColor = System.Drawing.Color.Green;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                resultLabel.Text = "�������� ������� ����� ���� �����";
                resultLabel.ForeColor = System.Drawing.Color.Red;
                return;
            }
            Studio newStudio = (Studio)studios[comboBox1.SelectedIndex].Clone();
            string originName = studios[comboBox1.SelectedIndex].getName();
            studios.Add(newStudio);
            comboBox1.Items.Add(newStudio.getName());
            comboBox1.SelectedIndex = studios.Count - 1;
            currentStudio.Text = studios[comboBox1.SelectedIndex].ToString();
            resultLabel.ForeColor = System.Drawing.Color.Green;
            resultLabel.Text =
                $"�������� ���� ���䳿 {originName} �� ������ {studios[comboBox1.SelectedIndex].getName()}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                resultLabel.Text = "�������� ������� ����� ���� �����";
                resultLabel.ForeColor = System.Drawing.Color.Red;
                return;
            }
            studios[comboBox1.SelectedIndex]++;
            currentStudio.Text = studios[comboBox1.SelectedIndex].ToString();
            resultLabel.ForeColor = System.Drawing.Color.Green;
            resultLabel.Text =
                $"�� ����� {studios[comboBox1.SelectedIndex].getName()} ������ ���� ������, �� ��������� 7500 ���";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                resultLabel.Text = "�������� ������� ����� ���� �����";
                resultLabel.ForeColor = System.Drawing.Color.Red;
                return;
            }
            studios[comboBox1.SelectedIndex]--;
            currentStudio.Text = studios[comboBox1.SelectedIndex].ToString();
            resultLabel.ForeColor = System.Drawing.Color.Green;
            resultLabel.Text =
                $"�� ���䳿 {studios[comboBox1.SelectedIndex].getName()} �������� ���� ������";
        }

        private void clearField()
        {
            textBoxName.Text = string.Empty;
            textBoxAdress.Text = string.Empty;
            textBoxEmployee.Text = string.Empty;
            textBoxTrackPrice.Text = string.Empty;
            textBoxTrackTime.Text = string.Empty;
            textBoxSalary.Text = string.Empty;
            textBoxInstruments.Text = string.Empty;
            textBoxRooms.Text = string.Empty;
        }
    }
}

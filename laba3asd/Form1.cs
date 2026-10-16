using System;
using System.IO;
using System.Windows.Forms;

namespace laba3asd
{
    public partial class Form1 : Form
    {
        private CustomQueue queue = new CustomQueue();
        private CustomStack stack = new CustomStack();

        public Form1()
        {
            InitializeComponent();
        }

        // Завдання 1: Додавання елементів у чергу та видалення парних
        private void btnProcessQueue_Click(object sender, EventArgs e)
        {
            txtQueueLog.Clear();
            queue.Clear();

            string input = txtQueueInput.Text;
            string[] parts = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var part in parts)
            {
                if (int.TryParse(part, out int val))
                {
                    queue.Enqueue(val);
                }
            }

            txtQueueLog.AppendText("Початковий стан черги:\r\n" + queue.PrintQueue() + "\r\n\r\n");

            queue.RemoveEvenNumbers();

            txtQueueLog.AppendText("Стан черги після видалення парних чисел:\r\n" + queue.PrintQueue() + "\r\n");
        }

        // Завдання 2: Зчитати файл у стек та знайти останній найдовший рядок
        private void btnProcessStack_Click(object sender, EventArgs e)
        {
            txtStackLog.Clear();
            stack.Clear();

            string filePath = "input.txt";

            // Створення текстового файлу, якщо він ще не існує
            if (!File.Exists(filePath))
            {
                File.WriteAllLines(filePath, new string[] {
                    "Перший рядок",
                    "Це дуже довгий рядок тексту у файлі",
                    "Короткий",
                    "Ще один дуже довгий рядок тексту у файлі",
                    "Кінець"
                });
            }

            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                stack.Push(i + 1, lines[i].Length);
            }

            txtStackLog.AppendText("Вміст стека (вершина вгорі):\r\n" + stack.PrintStack() + "\r\n\r\n");

            var result = stack.FindLastLongestLine();
            if (result.lineNum != -1)
            {
                txtStackLog.AppendText($"Останній найдовший рядок:\r\n");
                txtStackLog.AppendText($"Номер рядка: {result.lineNum}\r\n");
                txtStackLog.AppendText($"Довжина рядка: {result.maxLen} символів\r\n");
            }
        }
    }
}
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

namespace Prac_16_2
{
    public partial class Form1 : Form
    {
        Queue<string> lower = new Queue<string>();
        Queue<string> capital = new Queue<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void OutputBut_Click(object sender, EventArgs e)
        {
            StreamReader sr = File.OpenText("Text.txt");
            if (File.Exists("Text.txt"))
            {
                List<string> words = new List<string>();
                while (!sr.EndOfStream)
                {
                    string s = sr.ReadLine();
                    TextList.Items.Add(s);
                    string[] words1 = s.Split(new[] { ' ', ':', ';', '.', ',', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < words1.Length; j++)
                    {
                        words.Add(words1[j]);
                    }
                }
                sr.Close();
                for (int i = 0; i < words.Count; i++)
                {
                    string wd = words[i];
                    if (Char.IsUpper(wd[0]))
                    {
                        capital.Enqueue(wd);
                    }
                    else
                    {
                        lower.Enqueue(wd);
                    }
                }
                for (int i = 0; i < capital.Count; i++)
                {
                    CapitalizedWords.Items.Add(capital.Dequeue());
                }
                for (int i = 0; i < lower.Count; i++)
                {
                    LowerCaseWords.Items.Add(lower.Dequeue());
                }
                OutputBut.Enabled = false;
            }
            else
            {
                MessageBox.Show("Файл не найден","Внимание");
            }
            


            
        }
    }
}

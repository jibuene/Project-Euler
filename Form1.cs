using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEuler
{
    public partial class Form1 : Form
    {
        public String problemAnswer;

        public Form1()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public JArray LoadJson()
        {
            using (StreamReader r = new StreamReader("E:\\Documents\\euler\\output.json"))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                return array;
            }
        }

        private void getProblemBtn_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(problemInput.Text, out int j))
            {
                JArray problemsArray = LoadJson();
                if (problemsArray.Count < j - 1)
                {
                    errorText.Text = "The problem does not exist in current dataset";
                    return;
                }
                problemAnswer = problemsArray[j - 1]["answer"].ToString();
                problemText.Text = problemsArray[j - 1]["text"].ToString();
                errorText.Text = "";
            }
            else
            {
                problemAnswer = "";
                errorText.Text = "Could not find a problem with the number: " + problemInput.Text;
            }

        }

        private void checkAnswerBtn_Click(object sender, EventArgs e)
        {
            if (problemAnswer != "" && userAnswerText.Text != "")
            {
                // errorText.Text = problemAnswer.ToUpper() + " " + ComputeMd5Hash(userAnswerText.Text);
                errorText.Text = (ComputeMd5Hash(userAnswerText.Text) == problemAnswer.ToUpper()).ToString();
            }
        }

        public static string ComputeMd5Hash(string message)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] input = Encoding.ASCII.GetBytes(message);
                byte[] hash = md5.ComputeHash(input);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}

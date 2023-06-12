using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

using System;
using System.IO;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AmitaiHaHomo
{
    public partial class Form1 : Form
    {
        private NetSpell.SpellChecker.Dictionary.WordDictionary oDict = new NetSpell.SpellChecker.Dictionary.WordDictionary();
        private NetSpell.SpellChecker.Spelling oSpell = new NetSpell.SpellChecker.Spelling();
        public Form1()
        {
            InitializeComponent();

            oDict.DictionaryFile = "en-US.dic";
            oDict.Initialize();
            oSpell.Dictionary = oDict;

        }

        private void Check(string word)
        {
            char space = ' ';
            string [] arr = new string[999];
            int spaceCounter = 0, wordCounter = 0, i = 0;
            foreach (char character in word)
            {
                if (character != space)
                {
                    arr[i] += character.ToString();
                }
                else
                {
                    i++;
                    spaceCounter++;
                }
            }
            for (int j = 0; i < arr.Length; i++)
            {
                if (oSpell.TestWord(arr[j]))
                {
                    wordCounter++;
                }
            }
            if (spaceCounter / 2 < wordCounter)
            {
                MessageBox.Show(word);
            }
        }
        private void EncryptedBtn_Click(object sender, EventArgs e)
        {
            int num = 0;
            string name = encryptedText.Text;
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int key = 0; key < letters.Length; key++)
            {
                string translated = "";
                foreach (char symbol in name)
                {
                    if (char.IsLetter(symbol))
                    {
                        num = letters.IndexOf(symbol);
                        num = (num - key + letters.Length) % letters.Length;

                        if (num < 0)
                            num = num + letters.Length;

                        translated += letters[num];
                    }
                    else
                    {
                        translated += symbol;
                    }
                }
                Check(translated.ToLower());
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void EncryptedText_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_BackColorChanged(object sender, EventArgs e)
        {

        }
    }
}

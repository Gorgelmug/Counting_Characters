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
namespace Counting_Letters
{
    public partial class Form1 : Form
    {
        //a string that holds the text from the file
        private string text;

        //the list that holds the character
        private List<char> countList;

        public Form1()
        {
            InitializeComponent();
            countList = new List<char>();
        }

        //Button for browsing the pc for a text
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //this makes the browsing happening an sets the text to the TextBox
            DialogResult result = BrowseForTexts.ShowDialog();
            if (result == DialogResult.OK)
            {
                int size = -1;

                string file = BrowseForTexts.FileName;
                try
                {
                    text = File.ReadAllText(file);
                    size = text.Length;
                    richTextBox1.Text = text;
                }
                catch (IOException)
                {
                }
            }
        }

        //Button for searching the text for a specific character and outputs the number it is in the text
        private void btnZoek_Click(object sender, EventArgs e)
        {
            try
            {
                //clearing the variables
                lettersAantalLabel.Text = String.Empty;
                countList.Clear();

                //setting the character needed for the counting part
                char input = Convert.ToChar(txtInputLetter.Text);
               

                //sets the number of counts for the loop so input can get into the list
                string inCount = "";
                inCount.ToLower();
                inCount = Convert.ToString(input);
                inCount.Count();
                
                //this part gets the character and loops it and at the same time
                // it adds the character to the list
                //ToLower make all the chars to lowercase in order to count them all
                foreach (char count in text.ToLower())
                {
                    for (int i = 0; i < inCount.Count(); i++)
                    {
                        if (count == input)
                        {
                            countList.Add(input);
                        }
                    }

                    //output to the screen (number of characters)
                    lettersAantalLabel.Text = Convert.ToString(countList.Count);
                }
             }
            catch
            {
                MessageBox.Show("Geen of ongeldige invoer!" + Environment.NewLine + "Is er wel tekst toegevoegd?");
            }
        }
    }
}




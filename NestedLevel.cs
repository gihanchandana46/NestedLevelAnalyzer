using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NestedLevelAnalyzer
{
    public partial class NestedLevel : Form
    {
        public NestedLevel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ArrayList keywordList = new ArrayList();
            ArrayList linenumber = new ArrayList();
           
            var fileStream = new FileStream(@"test.java", FileMode.Open, FileAccess.Read);

            string identifier = "public class";
         

            string classname = "";

            int nextedlevel = 1;

            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
               
                
                string line;

                while ((line = streamReader.ReadLine()) != null)
                {

                    line = line.Trim(' ', '\t');

                    if (line.Contains(identifier))
                    {
                        classname = (line.Replace(identifier, string.Empty).Trim());
                        classname = Regex.Replace(classname, @"{", "");                  
                        
                    }



                    

                    if (line.Contains("if"))  
                    {

                        keywordList.Add("if");
                        linenumber.Add(line);
                        
                    }
                    

                    if (line.Contains("while"))
                    {
                        keywordList.Add("while");
                        linenumber.Add(line);

                    }

                                     

                     if (line.Contains("for"))
                    {
                        keywordList.Add("for");
                        linenumber.Add(line);

                    }

                     if (line.Contains("else if"))
                    {
                        keywordList.Add("else if");
                        linenumber.Add(line);

                    }

                    if (line.Contains("{"))
                    {
                        keywordList.Add("{");
                        linenumber.Add(line);


                    }

                    if (line.Contains("}"))
                    {
                        keywordList.Add("}");
                        linenumber.Add(line);


                    }



                }
            }





            for (int i = 0; i < keywordList.Count; i++)

                            
                {

                    if (keywordList[i] as string == "if" || keywordList[i] as string == "else if" || keywordList[i] as string == "while" || keywordList[i] as string == "for" && keywordList[i + 1] as string == "{" && keywordList[i + 2] as string != "}")
                    {


                        if (keywordList[i + 1] as string == "if" || keywordList[i + 1] as string == "else if" || keywordList[i + 1] as string == "while" || keywordList[i + 1] as string == "for")
                        {


                           nextedlevel = nextedlevel + 1;

                        }



                        if (keywordList[i + 2] as string == "if" || keywordList[i + 2] as string == "else if" || keywordList[i + 2] as string == "while" || keywordList[i + 2] as string == "for")
                        {


                            nextedlevel = nextedlevel + 1;
                        Console.WriteLine("increase" + nextedlevel);

                        }

                        if (keywordList[i + 2] as string == "}" )
                        {


                        if (keywordList[i + 3] as string == "}" && keywordList[i + 4] as string != "}") {

                            nextedlevel = nextedlevel -1;
                            Console.WriteLine("reduce1" + nextedlevel);

                        }

                        

                    }





                }
                
                
            }
            

            for (int i = 0; i < keywordList.Count; i++)
            {

                
                NestedArrayTestbox.AppendText("\n");
                NestedArrayTestbox.AppendText(keywordList[i] as string);

            }



          
            for(int i = 0; i < linenumber.Count; i++)
            {

             
                LineContentTextbox.AppendText("\n");
                LineContentTextbox.AppendText(linenumber[i] as string);


            }



            textBox4.Text = Convert.ToString("Class name :- " + classname);
            textBox1.Text = Convert.ToString("Class max nested level  :- " + nextedlevel);
          
            System.Console.Read();



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.CheckKeyword("{", Color.Red, 0);
            this.CheckKeyword("else if", Color.Blue, 0);
            this.CheckKeyword("for", Color.Indigo, 0);
            this.CheckKeyword("while", Color.DarkGreen, 0);
            this.CheckKeyword("if", Color.Brown, 0);
            this.CheckKeyword("}", Color.Red, 0);
        }
        private void CheckKeyword(string word, Color color, int startIndex)
        {
            if (this.LineContentTextbox.Text.Contains(word))
            {
                int index = -1;
                int selectStart = this.LineContentTextbox.SelectionStart;

                while ((index = this.LineContentTextbox.Text.IndexOf(word, (index + 1))) != -1)
                {
                    this.LineContentTextbox.Select((index + startIndex), word.Length);
                    this.LineContentTextbox.SelectionColor = color;
                    this.LineContentTextbox.Select(selectStart, 0);
                    this.LineContentTextbox.SelectionColor = Color.Black;
                }
            }
        }
    }
}

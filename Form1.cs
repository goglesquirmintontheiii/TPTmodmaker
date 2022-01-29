using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pastel;
using System.IO;
using System.Diagnostics;

namespace TPTmodmaker
{
    public partial class Form1 : Form
    {
        public List<Control> nC = new List<Control>();
        string currentfile = "";
        public int eA = 0;
        public bool MouseWithin = false;
        string currentselection = "";
        string[] args = { };
        bool fileOpen = false;
        Dictionary<string, string> Elements = new Dictionary<string, string>();
        Control cC;
        Dictionary<string, string> kV = new Dictionary<string, string>();
        bool update = false;
        public string[] insert(string[] cur, string el)
        {
            int ind = 0;
            string[] news = new string[cur.Length + 1];
            news[cur.Length] = el;
            foreach (string i in cur)
            {
                news[ind] = i;
                ind++;
            }
            return news;
        }
        public string typeify(string c)
        {
            string r = "";
            if (c == "progressbar")
            {
                r = "ProgressBar";
            }
            else
            {
                char[] cS = c.ToCharArray();
                int index = 0;
                foreach (char ch in cS)
                {
                    if (index == 0)
                    {
                        r += ch.ToString().ToUpper();
                    }
                    else
                    {
                        r += ch.ToString();
                    }
                    index++;
                }
            }
            return r;
        }
        public void refresh()
        {

            int i = 0;
            foreach (string l in richTextBox1.Lines)
            {
                if (l.StartsWith("--"))
                {
                 //  richTextBox1.Select(richTextBox1.Text.IndexOf(l),l.Length);
                 //   richTextBox1.SelectionColor = Color.FromArgb(100,100,100);
                }
                else
                {
                    // do code here
                    if (l.Contains(":new("))
                    {
                        foreach (Control c in nC)
                        {
                            c.Dispose();
                        }
                        string type = l.Split(Convert.ToChar("="))[1].Split(Convert.ToChar(":"))[0].Replace(" ", "");
                        string name = l.Split(Convert.ToChar("="))[0].Replace("local ", "").Replace(" ", "");
                        Elements[name] = type;
                        
                        foreach (string ic in Elements.Keys)
                        {
                            Console.WriteLine(Elements[ic]);
                        }
                        
                    }
                }

                
                try
                {
                   // richTextBox1.Select(richTextBox1.Text.IndexOf("if"), 2);
                  //  richTextBox1.SelectionColor = Color.FromArgb(0, 255, 0);
                }
                catch
                {

                }
             //   richTextBox1.Select(richTextBox1.Text.Length, richTextBox1.Text.Length);
                i++;
            }
         
            if (args.Length == 1 || fileOpen)
            {
               
                foreach (string k in Elements.Keys)
                {
                    Label e = new Label();
                    e.Text = k;
                    string[] split = { };
                    foreach (string l in richTextBox1.Lines)
                    {
                        if (l.Contains(k) && l.Contains($"{Elements[k]}:new"))
                        {
                            split = l.Split(Convert.ToChar(":"))[1].Replace("new(", "").Replace(")", "").Replace(" ", "").Split(Convert.ToChar(","));
                            label2.Text += "element added; ";
                        }
                        if (l.Contains($"{Elements[k]}:new"))
                        {
                            label2.Text += "element add found; ";
                        }
                        if (l.StartsWith(k))
                        {
                            label2.Text += "element define possible find; ";
                          
                        }
                    }
                    e.Size = new Size(Convert.ToInt32(split[2]), Convert.ToInt32(split[3]));
                    e.Location = new Point(Convert.ToInt32(split[0]) + 18, Convert.ToInt32(split[1]) + 27);
                    Controls.Add(e);
                    e.MouseDown += element_mousedown;
                    e.MouseMove += element_mousemove;
                    e.MouseClick += element_click;
                    e.Name = k;
                    e.BringToFront();
                    
                }
                fileOpen = false;
                args = new string[] { };
            }
        }
        public Form1(string[] argsm)
        {
            InitializeComponent();
            args = argsm;
            string[] files = {"EventsHelp", "ElementsHelp"};
            foreach (string f in files)
            {
                if (!File.Exists(f + ".txt"))
                {
                    FileStream fs = File.Create(f + ".txt");
                    fs.Close();
                    Process.Start(f + ".txt");
                   
                }
            }
            if (!File.Exists("powderref.txt"))
            {
                openFileDialog1.Title = "Setup - select TPT and click \"Open\"";
                string res = "";
                while (res == "")
                {
                    openFileDialog1.ShowDialog();
                    res = openFileDialog1.FileName;
                }
               
                File.AppendAllText("powderref.txt", openFileDialog1.FileName);
            }
            if (argsm.Length != 0)
            {
                currentfile = args[0];
                richTextBox1.Lines = System.IO.File.ReadAllLines(args[0]);
                refresh();
                this.Text = "Edit: " + args[0];
                
            }
          
            // refresh();
        }

        

        public void ModifyProperties(Control c)
        {
            string type = Elements[c.Name];
            groupBox1.Text = $"Properties: {c.Name}";
            update = false;
            sName.Text = c.Name;
            cC = c;
            currentselection = c.Name;
            lName.Visible = true;
            sName.Visible = true;
            sVisible.Visible = true;
            
            if (type == "Button" || type == "Label" || type == "Textbox" || type == "Checkbox")
            {
                lText.Visible = true;
                sText.Visible = true;
                
                sText.Text = "";
            }
            else
            {
                sText.Text = "";
                lText.Visible = false;
                sText.Visible = false;

            }
            if (type == "Button")
            {
                sEnabled.Visible = true;
            }
            else
            {
                sEnabled.Visible = false;
            }
            if (type == "ProgressBar")
            {
                lStatus.Visible = true;
                lProgress.Visible = true;
                sStatus.Visible = true;
                sProgress.Visible = true;
            }
            else
            {
                lStatus.Visible = false;
                lProgress.Visible = false;
                sStatus.Visible = false;
                sProgress.Visible = false;
            }
            if (type == "Slider")
            {
                lValue.Visible = true;
                lSteps.Visible = true;
                sSteps.Visible = true;
                sValue.Visible = true;
            }
            else
            {
                lValue.Visible = false;
                lSteps.Visible = false;
                sSteps.Visible = false;
                sValue.Visible = false;
            }
            if (type == "Checkbox")
            {
                sChecked.Visible = true;
            }
            else
            {
                sChecked.Visible = false;
            }
            if (type == "Textbox")
            {
                sReadonly.Visible = true;
            }
            else
            {
                sReadonly.Visible = false;
            }
            update = true;
            
        }
        private void tChange(object sender, EventArgs e)
        {
           refresh();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void addNewElement(object sender, TreeNodeMouseClickEventArgs e)
        {
            eA++;
            
            Label t = new Label();
            richTextBox1.Lines = insert(richTextBox1.Lines, $"--{e.Node.Name} {e.Node.Name}{eA}");
            richTextBox1.Lines = insert(richTextBox1.Lines, $"{e.Node.Name}{eA} = {e.Node.Name}:new(0,0,{t.Width},{t.Height})");
            richTextBox1.Lines = insert(richTextBox1.Lines,$"interface.addComponent({e.Node.Name}{eA})");
            richTextBox1.Lines = insert(richTextBox1.Lines, $" ");
            t.Text = $"{e.Node.Name}{eA}";
            t.Name = $"{e.Node.Name}{eA}";
            t.Location = panel1.Location;
            
            t.MouseDown += element_mousedown;
            t.MouseMove += element_mousemove;
            t.BringToFront();
            t.MouseClick += element_click;
            Controls.Add(t);
            t.BringToFront();

        }

        private Point MouseDownLocation;
        public int line = 0;

        private void element_mousedown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
                int cI = 0;
                foreach (string i in richTextBox1.Lines)
                {
                    if (sender is Control c)
                    {
                        if (i.StartsWith(c.Name) && i.Contains(":new("))
                        {
                            line = cI;
                            Console.WriteLine("found line");
                        }
                    }
                    cI++;
                }
            }
        }

        private void element_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && sender is Control c)
            {
               
                ModifyProperties(c);
            }
        }

        public string replaceNums(string str)
        {
            char[] numbers = "0123456789".ToCharArray();
            foreach (char i in numbers)
            {
                str = str.Replace(i.ToString(), "");
            }
            return str;
        }
        private void element_mousemove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (sender is Control c)
                {
                       
                      
                   // if (c.)
                  //  {
                        c.Left = e.X + c.Left - MouseDownLocation.X;
                        c.Top = e.Y + c.Top - MouseDownLocation.Y;
                    string[] lines = richTextBox1.Lines;
                    lines[line] = $"{c.Name} = {replaceNums(c.Name)}:new({c.Location.X - 18},{c.Location.Y - 27},{c.Width},{c.Height})";
                  
                    richTextBox1.Lines = lines;
                  //  }
                   // else
                    //{
                 //       c.Location = panel1.Location;
                    //}
                   c.BringToFront();
                    refresh();
                }
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void mouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void click(object sender, EventArgs e)
        {

        }

        private void click2(object sender, MouseEventArgs e)
        {
          
        }

        private void sName_TextChanged(object sender, EventArgs e)
        {
            if (update)
            {
                int i = 0;
                foreach (string l in richTextBox1.Lines)
                {
                    try
                    {
                        if (l.Contains(":new("))
                        {
                            string[] lines = richTextBox1.Lines;
                            lines[i] = l.Replace(currentselection, sName.Text);
                            richTextBox1.Lines = lines;
                        }
                        else if (l.StartsWith("interface.addComponent("))
                        {
                            string[] lines = richTextBox1.Lines;
                            lines[i] = $"interface.addComponent({sName.Text})";
                            richTextBox1.Lines = lines;
                        }
                    }
                    catch
                    {

                    }
                   
                 
                    i++;
                }
                currentselection = sName.Text;
                cC.Name = sName.Text;
            }
           
           
        }

        private void propChange(object sender, EventArgs e)
        {
            string value = "";
            if (sender is TextBox tb)
            {
                value = $"\"{tb.Text}\"";
            } else if (sender is CheckBox cb)
            {
                value = cb.Checked.ToString().ToLower();
            } else if (sender is TrackBar trb)
            {
                value = trb.Value.ToString();
            }
            if (update)
            {
                if (sender is Control c)
                {
                    char[] nC = c.Name.ToCharArray();
                    int LI = 0;
                    string prop = "";
                    foreach (char ch in nC)
                    {
                        if (LI > 0)
                        {
                            prop += ch.ToString().ToLower();
                        }
                        LI++;
                    }
                    //code to change prop
                    bool contains = false;
                    foreach (string i in richTextBox1.Lines)
                    {
                        if (i.Contains(currentselection + $":{prop}("))
                        {
                            contains = true;
                        }
                    }
                    if (!contains)
                    {

                        richTextBox1.Lines = insert(richTextBox1.Lines, $"{currentselection}:{prop}({value})");

                    }
                    else
                    {

                        int i = 0;
                        foreach (string l in richTextBox1.Lines)
                        {
                            if (l.Contains($"{currentselection}:{prop}("))
                            {
                                string[] lines = richTextBox1.Lines;
                                lines[i] = $"{currentselection}:{prop}({value})";
                                richTextBox1.Lines = lines;

                            }
                            i++;
                        }
                    }
                }
            }
        }
        
        string findscripts()
        {
            List<string> allfiles = new List<string>();
            string[] indir(string dir)
            {
                return Directory.GetFiles(dir);
            }
            long totalsize = 0;
            void foreachfile(List<string> files)
            {
                foreach (string f in files)
                {
                    try
                    {
                        if (Directory.Exists(f))
                        {
                            List<string> comb = new List<string>();
                            foreach (string f2 in Directory.GetFiles(f))
                            {
                                comb.Add(f2);
                            }
                            foreach (string f2 in Directory.GetDirectories(f))
                            {
                                comb.Add(f2);
                            }
                            foreachfile(comb);
                        }
                        else
                        {
                            allfiles.Add(f);
                            totalsize += new FileInfo(f).Length;

                        }
                    }
                    catch
                    {

                    }


                    if (allfiles.Count > 1000000)
                    {
                        Console.WriteLine($"{allfiles.Count / 1000000}M files");
                    }
                    else if (allfiles.Count > 1000)
                    {
                        Console.WriteLine($"{allfiles.Count / 1000}K files");
                    }
                    else
                    {
                        Console.WriteLine($"{allfiles.Count} files");
                    }


                    if (totalsize > 1000000000)
                    {
                        Console.WriteLine($"{totalsize / 1000000000}GB");
                    }
                    else if (totalsize > 1000000)
                    {
                        
                        Console.WriteLine($"{totalsize / 1000000}MB");
                    } else if (totalsize > 1000)
                    {
                        Console.WriteLine($"{totalsize / 1000}KB");
                    }
                    else
                    {
                        Console.WriteLine($"{totalsize}B");
                    }
                    
                }
            }
            List<string> comb2 = new List<string>();
            foreach (string f2 in Directory.GetFiles(@"C:\"))
            {
                comb2.Add(f2);
            }
            foreach (string f2 in Directory.GetDirectories(@"C:\"))
            {
                comb2.Add(f2);
            }
            foreachfile(comb2);

            Console.WriteLine(allfiles.Count);
            return "";
        }
        private void sText_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sEnabled_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddEvent(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (currentselection != "")
            {
                //newButton:action(function(sender) sender:text("Text changed") end)
                richTextBox1.Lines = insert(richTextBox1.Lines, "");
                richTextBox1.Lines = insert(richTextBox1.Lines, currentselection + ":" + e.Node.Name + "(function(sender)");
                richTextBox1.Lines = insert(richTextBox1.Lines, "--Code here");
                richTextBox1.Lines = insert(richTextBox1.Lines, "");
                richTextBox1.Lines = insert(richTextBox1.Lines, "end)");
            }
        }

        private void FileAction(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "Save")
            {
                if (currentfile == "")
                {
                    saveFileDialog1.Title = "Save..";
                    saveFileDialog1.ShowDialog();
                    try
                    {
                        File.WriteAllLines(saveFileDialog1.FileName, richTextBox1.Lines);
                    }
                    catch
                    {

                    }
                }
                else
                {
                   
                    try
                    {
                        File.WriteAllLines(currentfile, richTextBox1.Lines);
                    }
                    catch
                    {

                    }
                }





            } 
            else if (e.ClickedItem.Name == "SaveAs")
            {
                saveFileDialog1.Title = "Save as..";
                saveFileDialog1.ShowDialog();
                try
                {
                    File.WriteAllLines(saveFileDialog1.FileName, richTextBox1.Lines);
                }
                catch
                {

                }

            }
            else if (e.ClickedItem.Name == "Open")
            {
                openFileDialog1.Title = "Open TPT lua script..";
                openFileDialog1.ShowDialog();
                try
                {

                    richTextBox1.Lines = File.ReadAllLines(openFileDialog1.FileName);
                    this.Text = "Edit: " + Path.GetFileName(openFileDialog1.FileName);
                    fileOpen = true;
                    refresh();
                    currentfile = openFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
               
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void eventToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HelpClick(object sender, ToolStripItemClickedEventArgs e)
        {
            Process.Start(e.ClickedItem.Name + ".txt");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (Process p in Process.GetProcesses())
            {
                if (p.ProcessName == "Powder.exe" || p.MainWindowTitle == "The Powder Toy")
                {
                    p.Kill();
                }
            }
            try
            {
                Process.Start(File.ReadAllText("powderref.txt"));
            }
            catch
            {
                
            }
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Setup - select TPT and click \"Open\"";
            string res = "";
           
                openFileDialog1.ShowDialog();
                res = openFileDialog1.FileName;
            if (res != "")
            {
                File.AppendAllText("powderref.txt", res);
            }
        }
    }
}

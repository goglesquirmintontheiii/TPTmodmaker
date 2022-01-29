
namespace TPTmodmaker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Label");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Progressbar");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Window");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Display", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Checkbox");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Textbox");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Slider");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Button");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Interacton/Input", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Clicked");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Button", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("CheckChanged");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Checkbox", new System.Windows.Forms.TreeNode[] {
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("TextChanged");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Textbox", new System.Windows.Forms.TreeNode[] {
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("ValueChanged");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Slider", new System.Windows.Forms.TreeNode[] {
            treeNode16});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sChecked = new System.Windows.Forms.CheckBox();
            this.sReadonly = new System.Windows.Forms.CheckBox();
            this.sProgress = new System.Windows.Forms.TrackBar();
            this.lProgress = new System.Windows.Forms.Label();
            this.sStatus = new System.Windows.Forms.TextBox();
            this.lStatus = new System.Windows.Forms.Label();
            this.sSteps = new System.Windows.Forms.TextBox();
            this.lSteps = new System.Windows.Forms.Label();
            this.sValue = new System.Windows.Forms.TextBox();
            this.lValue = new System.Windows.Forms.Label();
            this.sEnabled = new System.Windows.Forms.CheckBox();
            this.sVisible = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sText = new System.Windows.Forms.TextBox();
            this.lText = new System.Windows.Forms.Label();
            this.sName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Events = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ElementsHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.EventsHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sProgress)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(634, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(350, 382);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "--Code";
            this.richTextBox1.Click += new System.EventHandler(this.click);
            this.richTextBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.click2);
            this.richTextBox1.TextChanged += new System.EventHandler(this.tChange);
            // 
            // treeView1
            // 
            this.treeView1.Indent = 19;
            this.treeView1.Location = new System.Drawing.Point(634, 467);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Label";
            treeNode1.Text = "Label";
            treeNode2.Name = "ProgressBar";
            treeNode2.Text = "Progressbar";
            treeNode3.Name = "Window";
            treeNode3.Text = "Window";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Display";
            treeNode5.Name = "Checkbox";
            treeNode5.Text = "Checkbox";
            treeNode6.Name = "Textbox";
            treeNode6.Text = "Textbox";
            treeNode7.Name = "Slider";
            treeNode7.Text = "Slider";
            treeNode8.Name = "Button";
            treeNode8.Text = "Button";
            treeNode9.Name = "Node5";
            treeNode9.Text = "Interacton/Input";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(171, 188);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.addNewElement);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Location = new System.Drawing.Point(18, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 382);
            this.panel1.TabIndex = 4;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sChecked);
            this.groupBox1.Controls.Add(this.sReadonly);
            this.groupBox1.Controls.Add(this.sProgress);
            this.groupBox1.Controls.Add(this.lProgress);
            this.groupBox1.Controls.Add(this.sStatus);
            this.groupBox1.Controls.Add(this.lStatus);
            this.groupBox1.Controls.Add(this.sSteps);
            this.groupBox1.Controls.Add(this.lSteps);
            this.groupBox1.Controls.Add(this.sValue);
            this.groupBox1.Controls.Add(this.lValue);
            this.groupBox1.Controls.Add(this.sEnabled);
            this.groupBox1.Controls.Add(this.sVisible);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sText);
            this.groupBox1.Controls.Add(this.lText);
            this.groupBox1.Controls.Add(this.sName);
            this.groupBox1.Controls.Add(this.lName);
            this.groupBox1.Location = new System.Drawing.Point(18, 415);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 240);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Object properties (right click to select object)";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // sChecked
            // 
            this.sChecked.AutoSize = true;
            this.sChecked.Location = new System.Drawing.Point(253, 144);
            this.sChecked.Name = "sChecked";
            this.sChecked.Size = new System.Drawing.Size(69, 17);
            this.sChecked.TabIndex = 16;
            this.sChecked.Text = "Checked";
            this.sChecked.UseVisualStyleBackColor = true;
            this.sChecked.Visible = false;
            this.sChecked.CheckedChanged += new System.EventHandler(this.propChange);
            // 
            // sReadonly
            // 
            this.sReadonly.AutoSize = true;
            this.sReadonly.Location = new System.Drawing.Point(253, 121);
            this.sReadonly.Name = "sReadonly";
            this.sReadonly.Size = new System.Drawing.Size(71, 17);
            this.sReadonly.TabIndex = 15;
            this.sReadonly.Text = "Readonly";
            this.sReadonly.UseVisualStyleBackColor = true;
            this.sReadonly.Visible = false;
            this.sReadonly.CheckedChanged += new System.EventHandler(this.propChange);
            // 
            // sProgress
            // 
            this.sProgress.Location = new System.Drawing.Point(307, 83);
            this.sProgress.Name = "sProgress";
            this.sProgress.Size = new System.Drawing.Size(151, 45);
            this.sProgress.TabIndex = 14;
            this.sProgress.Visible = false;
            this.sProgress.ValueChanged += new System.EventHandler(this.propChange);
            // 
            // lProgress
            // 
            this.lProgress.AutoSize = true;
            this.lProgress.Location = new System.Drawing.Point(250, 89);
            this.lProgress.Name = "lProgress";
            this.lProgress.Size = new System.Drawing.Size(51, 13);
            this.lProgress.TabIndex = 13;
            this.lProgress.Text = "Progress:";
            this.lProgress.Visible = false;
            // 
            // sStatus
            // 
            this.sStatus.Location = new System.Drawing.Point(290, 49);
            this.sStatus.Name = "sStatus";
            this.sStatus.Size = new System.Drawing.Size(168, 20);
            this.sStatus.TabIndex = 12;
            this.sStatus.Visible = false;
            this.sStatus.TextChanged += new System.EventHandler(this.propChange);
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(244, 52);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(40, 13);
            this.lStatus.TabIndex = 11;
            this.lStatus.Text = "Status:";
            this.lStatus.Visible = false;
            // 
            // sSteps
            // 
            this.sSteps.Location = new System.Drawing.Point(50, 170);
            this.sSteps.Name = "sSteps";
            this.sSteps.Size = new System.Drawing.Size(164, 20);
            this.sSteps.TabIndex = 10;
            this.sSteps.Visible = false;
            this.sSteps.TextChanged += new System.EventHandler(this.propChange);
            // 
            // lSteps
            // 
            this.lSteps.AutoSize = true;
            this.lSteps.Location = new System.Drawing.Point(7, 173);
            this.lSteps.Name = "lSteps";
            this.lSteps.Size = new System.Drawing.Size(37, 13);
            this.lSteps.TabIndex = 9;
            this.lSteps.Text = "Steps:";
            this.lSteps.Visible = false;
            // 
            // sValue
            // 
            this.sValue.Location = new System.Drawing.Point(49, 136);
            this.sValue.Name = "sValue";
            this.sValue.Size = new System.Drawing.Size(164, 20);
            this.sValue.TabIndex = 8;
            this.sValue.Visible = false;
            this.sValue.TextChanged += new System.EventHandler(this.propChange);
            // 
            // lValue
            // 
            this.lValue.AutoSize = true;
            this.lValue.Location = new System.Drawing.Point(6, 139);
            this.lValue.Name = "lValue";
            this.lValue.Size = new System.Drawing.Size(37, 13);
            this.lValue.TabIndex = 7;
            this.lValue.Text = "Value:";
            this.lValue.Visible = false;
            // 
            // sEnabled
            // 
            this.sEnabled.AutoSize = true;
            this.sEnabled.Location = new System.Drawing.Point(43, 111);
            this.sEnabled.Name = "sEnabled";
            this.sEnabled.Size = new System.Drawing.Size(65, 17);
            this.sEnabled.TabIndex = 6;
            this.sEnabled.Text = "Enabled";
            this.sEnabled.UseVisualStyleBackColor = true;
            this.sEnabled.Visible = false;
            this.sEnabled.CheckedChanged += new System.EventHandler(this.propChange);
            this.sEnabled.TextChanged += new System.EventHandler(this.propChange);
            // 
            // sVisible
            // 
            this.sVisible.AutoSize = true;
            this.sVisible.Location = new System.Drawing.Point(43, 88);
            this.sVisible.Name = "sVisible";
            this.sVisible.Size = new System.Drawing.Size(56, 17);
            this.sVisible.TabIndex = 5;
            this.sVisible.Text = "Visible";
            this.sVisible.UseVisualStyleBackColor = true;
            this.sVisible.Visible = false;
            this.sVisible.CheckedChanged += new System.EventHandler(this.propChange);
            this.sVisible.TextChanged += new System.EventHandler(this.propChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Changing name may damage your code!";
            // 
            // sText
            // 
            this.sText.Location = new System.Drawing.Point(43, 49);
            this.sText.Name = "sText";
            this.sText.Size = new System.Drawing.Size(164, 20);
            this.sText.TabIndex = 3;
            this.sText.Visible = false;
            this.sText.TextChanged += new System.EventHandler(this.propChange);
            // 
            // lText
            // 
            this.lText.AutoSize = true;
            this.lText.Location = new System.Drawing.Point(6, 52);
            this.lText.Name = "lText";
            this.lText.Size = new System.Drawing.Size(31, 13);
            this.lText.TabIndex = 2;
            this.lText.Text = "Text:";
            this.lText.Visible = false;
            // 
            // sName
            // 
            this.sName.Location = new System.Drawing.Point(50, 13);
            this.sName.Name = "sName";
            this.sName.Size = new System.Drawing.Size(164, 20);
            this.sName.TabIndex = 1;
            this.sName.Visible = false;
            this.sName.TextChanged += new System.EventHandler(this.sName_TextChanged);
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(6, 16);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(38, 13);
            this.lName.TabIndex = 0;
            this.lName.Text = "Name:";
            this.lName.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // Events
            // 
            this.Events.Indent = 19;
            this.Events.Location = new System.Drawing.Point(811, 467);
            this.Events.Name = "Events";
            treeNode10.Name = "action";
            treeNode10.Text = "Clicked";
            treeNode11.Name = "Node0";
            treeNode11.Text = "Button";
            treeNode12.Name = "action";
            treeNode12.Text = "CheckChanged";
            treeNode13.Name = "Node5";
            treeNode13.Text = "Checkbox";
            treeNode14.Name = "onTextChanged";
            treeNode14.Text = "TextChanged";
            treeNode15.Name = "Node4";
            treeNode15.Text = "Textbox";
            treeNode16.Name = "onValueChanged";
            treeNode16.Text = "ValueChanged";
            treeNode17.Name = "Node7";
            treeNode17.Text = "Slider";
            this.Events.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode13,
            treeNode15,
            treeNode17});
            this.Events.Size = new System.Drawing.Size(173, 188);
            this.Events.TabIndex = 7;
            this.Events.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.AddEvent);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(678, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Add element..";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(863, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Add event..";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckFileExists = true;
            this.saveFileDialog1.CreatePrompt = true;
            this.saveFileDialog1.DefaultExt = "lua";
            this.saveFileDialog1.Filter = "Lua files (*.lua)|";
            this.saveFileDialog1.Title = "Save..";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1356, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save,
            this.SaveAs,
            this.Open,
            this.toolStripMenuItem1});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            this.toolStripDropDownButton1.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.FileAction);
            // 
            // Save
            // 
            this.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(180, 22);
            this.Save.Text = "Save";
            // 
            // SaveAs
            // 
            this.SaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(180, 22);
            this.SaveAs.Text = "Save as..";
            // 
            // Open
            // 
            this.Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(180, 22);
            this.Open.Text = "Open";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ElementsHelp,
            this.EventsHelp});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(45, 22);
            this.toolStripDropDownButton2.Text = "Help";
            this.toolStripDropDownButton2.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.HelpClick);
            // 
            // ElementsHelp
            // 
            this.ElementsHelp.Name = "ElementsHelp";
            this.ElementsHelp.Size = new System.Drawing.Size(122, 22);
            this.ElementsHelp.Text = "Elements";
            this.ElementsHelp.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // EventsHelp
            // 
            this.EventsHelp.Name = "EventsHelp";
            this.EventsHelp.Size = new System.Drawing.Size(122, 22);
            this.EventsHelp.Text = "Events";
            this.EventsHelp.Click += new System.EventHandler(this.eventToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "lua";
            this.openFileDialog1.Filter = "Lua files (*.lua)|";
            this.openFileDialog1.Title = "Open..";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(31, 22);
            this.toolStripButton1.Text = "Test";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Specify TPT";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 749);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Events);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sProgress)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox sText;
        private System.Windows.Forms.Label lText;
        private System.Windows.Forms.TextBox sName;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox sVisible;
        private System.Windows.Forms.CheckBox sEnabled;
        private System.Windows.Forms.TextBox sSteps;
        private System.Windows.Forms.Label lSteps;
        private System.Windows.Forms.TextBox sValue;
        private System.Windows.Forms.Label lValue;
        private System.Windows.Forms.TextBox sStatus;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.CheckBox sReadonly;
        private System.Windows.Forms.TrackBar sProgress;
        private System.Windows.Forms.Label lProgress;
        private System.Windows.Forms.CheckBox sChecked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView Events;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem SaveAs;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem ElementsHelp;
        private System.Windows.Forms.ToolStripMenuItem EventsHelp;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}



namespace SortingAlgorithms
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
      this.button1 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.menuStrip2 = new System.Windows.Forms.MenuStrip();
      this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.randomArrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sortedArrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sortedBackwardsArrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.almostSortedArrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.enterArrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
      this.enterSizeOfArrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
      this.sortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.bubbleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.insertToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.mergeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.tryangleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.allTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.textBox5 = new System.Windows.Forms.TextBox();
      this.textBox6 = new System.Windows.Forms.TextBox();
      this.textBox7 = new System.Windows.Forms.TextBox();
      this.textBox8 = new System.Windows.Forms.TextBox();
      this.textBox9 = new System.Windows.Forms.TextBox();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.menuStrip2.SuspendLayout();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.White;
      this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.button1.Font = new System.Drawing.Font("Times New Roman", 14.8F, System.Drawing.FontStyle.Bold);
      this.button1.ForeColor = System.Drawing.Color.RoyalBlue;
      this.button1.Location = new System.Drawing.Point(425, 281);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(77, 47);
      this.button1.TabIndex = 0;
      this.button1.Text = "Sort";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // textBox1
      // 
      this.textBox1.BackColor = System.Drawing.Color.SteelBlue;
      this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.16F);
      this.textBox1.ForeColor = System.Drawing.Color.Black;
      this.textBox1.Location = new System.Drawing.Point(38, 132);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.Size = new System.Drawing.Size(326, 147);
      this.textBox1.TabIndex = 1;
      this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // textBox2
      // 
      this.textBox2.BackColor = System.Drawing.Color.SteelBlue;
      this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.16F);
      this.textBox2.Location = new System.Drawing.Point(558, 132);
      this.textBox2.Multiline = true;
      this.textBox2.Name = "textBox2";
      this.textBox2.ReadOnly = true;
      this.textBox2.Size = new System.Drawing.Size(321, 147);
      this.textBox2.TabIndex = 2;
      this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
      // 
      // textBox3
      // 
      this.textBox3.BackColor = System.Drawing.Color.SteelBlue;
      this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.16F);
      this.textBox3.Location = new System.Drawing.Point(38, 336);
      this.textBox3.Multiline = true;
      this.textBox3.Name = "textBox3";
      this.textBox3.ReadOnly = true;
      this.textBox3.Size = new System.Drawing.Size(326, 156);
      this.textBox3.TabIndex = 3;
      this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
      // 
      // textBox4
      // 
      this.textBox4.BackColor = System.Drawing.Color.SteelBlue;
      this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.16F);
      this.textBox4.Location = new System.Drawing.Point(558, 336);
      this.textBox4.Multiline = true;
      this.textBox4.Name = "textBox4";
      this.textBox4.ReadOnly = true;
      this.textBox4.Size = new System.Drawing.Size(321, 156);
      this.textBox4.TabIndex = 4;
      // 
      // menuStrip2
      // 
      this.menuStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.sortsToolStripMenuItem,
            this.testToolStripMenuItem,
            this.saveToolStripMenuItem});
      this.menuStrip2.Location = new System.Drawing.Point(0, 0);
      this.menuStrip2.Name = "menuStrip2";
      this.menuStrip2.Size = new System.Drawing.Size(907, 28);
      this.menuStrip2.TabIndex = 11;
      this.menuStrip2.Text = "menuStrip2";
      this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
      // 
      // menuToolStripMenuItem
      // 
      this.menuToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
      this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomArrayToolStripMenuItem,
            this.sortedArrayToolStripMenuItem,
            this.sortedBackwardsArrayToolStripMenuItem,
            this.almostSortedArrayToolStripMenuItem,
            this.enterArrayToolStripMenuItem,
            this.enterSizeOfArrayToolStripMenuItem});
      this.menuToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
      this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
      this.menuToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
      this.menuToolStripMenuItem.Text = "Choose type of array";
      this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
      // 
      // randomArrayToolStripMenuItem
      // 
      this.randomArrayToolStripMenuItem.Name = "randomArrayToolStripMenuItem";
      this.randomArrayToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
      this.randomArrayToolStripMenuItem.Text = "Random array";
      this.randomArrayToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
      this.randomArrayToolStripMenuItem.Click += new System.EventHandler(this.randomArrayToolStripMenuItem_Click);
      // 
      // sortedArrayToolStripMenuItem
      // 
      this.sortedArrayToolStripMenuItem.Name = "sortedArrayToolStripMenuItem";
      this.sortedArrayToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
      this.sortedArrayToolStripMenuItem.Text = "Sorted array";
      this.sortedArrayToolStripMenuItem.Click += new System.EventHandler(this.sortedArrayToolStripMenuItem_Click);
      // 
      // sortedBackwardsArrayToolStripMenuItem
      // 
      this.sortedBackwardsArrayToolStripMenuItem.Name = "sortedBackwardsArrayToolStripMenuItem";
      this.sortedBackwardsArrayToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
      this.sortedBackwardsArrayToolStripMenuItem.Text = "Sorted backwards array";
      this.sortedBackwardsArrayToolStripMenuItem.Click += new System.EventHandler(this.sortedBackwardsArrayToolStripMenuItem_Click);
      // 
      // almostSortedArrayToolStripMenuItem
      // 
      this.almostSortedArrayToolStripMenuItem.Name = "almostSortedArrayToolStripMenuItem";
      this.almostSortedArrayToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
      this.almostSortedArrayToolStripMenuItem.Text = "Almost sorted array";
      this.almostSortedArrayToolStripMenuItem.Click += new System.EventHandler(this.almostSortedArrayToolStripMenuItem_Click);
      // 
      // enterArrayToolStripMenuItem
      // 
      this.enterArrayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
      this.enterArrayToolStripMenuItem.Name = "enterArrayToolStripMenuItem";
      this.enterArrayToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
      this.enterArrayToolStripMenuItem.Text = "Enter array";
      this.enterArrayToolStripMenuItem.Click += new System.EventHandler(this.enterArrayToolStripMenuItem_Click);
      // 
      // toolStripTextBox1
      // 
      this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.toolStripTextBox1.Name = "toolStripTextBox1";
      this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
      this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
      // 
      // enterSizeOfArrayToolStripMenuItem
      // 
      this.enterSizeOfArrayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
      this.enterSizeOfArrayToolStripMenuItem.Name = "enterSizeOfArrayToolStripMenuItem";
      this.enterSizeOfArrayToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
      this.enterSizeOfArrayToolStripMenuItem.Text = "Enter size of array";
      // 
      // toolStripComboBox1
      // 
      this.toolStripComboBox1.Name = "toolStripComboBox1";
      this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
      this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
      // 
      // sortsToolStripMenuItem
      // 
      this.sortsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bubbleToolStripMenuItem1,
            this.insertToolStripMenuItem1,
            this.mergeToolStripMenuItem1,
            this.tryangleToolStripMenuItem1,
            this.allTypesToolStripMenuItem});
      this.sortsToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.sortsToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
      this.sortsToolStripMenuItem.Name = "sortsToolStripMenuItem";
      this.sortsToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
      this.sortsToolStripMenuItem.Text = "Sorts";
      // 
      // bubbleToolStripMenuItem1
      // 
      this.bubbleToolStripMenuItem1.Name = "bubbleToolStripMenuItem1";
      this.bubbleToolStripMenuItem1.Size = new System.Drawing.Size(148, 26);
      this.bubbleToolStripMenuItem1.Text = "Bubble";
      this.bubbleToolStripMenuItem1.Click += new System.EventHandler(this.bubbleToolStripMenuItem1_Click);
      // 
      // insertToolStripMenuItem1
      // 
      this.insertToolStripMenuItem1.Name = "insertToolStripMenuItem1";
      this.insertToolStripMenuItem1.Size = new System.Drawing.Size(148, 26);
      this.insertToolStripMenuItem1.Text = "Insert";
      this.insertToolStripMenuItem1.Click += new System.EventHandler(this.insertToolStripMenuItem1_Click);
      // 
      // mergeToolStripMenuItem1
      // 
      this.mergeToolStripMenuItem1.Name = "mergeToolStripMenuItem1";
      this.mergeToolStripMenuItem1.Size = new System.Drawing.Size(148, 26);
      this.mergeToolStripMenuItem1.Text = "Merge";
      this.mergeToolStripMenuItem1.Click += new System.EventHandler(this.mergeToolStripMenuItem1_Click);
      // 
      // tryangleToolStripMenuItem1
      // 
      this.tryangleToolStripMenuItem1.Name = "tryangleToolStripMenuItem1";
      this.tryangleToolStripMenuItem1.Size = new System.Drawing.Size(148, 26);
      this.tryangleToolStripMenuItem1.Text = "Pyramid";
      this.tryangleToolStripMenuItem1.Click += new System.EventHandler(this.tryangleToolStripMenuItem1_Click);
      // 
      // allTypesToolStripMenuItem
      // 
      this.allTypesToolStripMenuItem.Name = "allTypesToolStripMenuItem";
      this.allTypesToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
      this.allTypesToolStripMenuItem.Text = "All types";
      this.allTypesToolStripMenuItem.Click += new System.EventHandler(this.allTypesToolStripMenuItem_Click);
      // 
      // testToolStripMenuItem
      // 
      this.testToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.testToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
      this.testToolStripMenuItem.Name = "testToolStripMenuItem";
      this.testToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
      this.testToolStripMenuItem.Text = "Test";
      this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
      this.saveToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue;
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
      this.saveToolStripMenuItem.Text = "Save";
      this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
      // 
      // textBox5
      // 
      this.textBox5.BackColor = System.Drawing.Color.SteelBlue;
      this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.16F);
      this.textBox5.Location = new System.Drawing.Point(38, 43);
      this.textBox5.Multiline = true;
      this.textBox5.Name = "textBox5";
      this.textBox5.ReadOnly = true;
      this.textBox5.Size = new System.Drawing.Size(841, 42);
      this.textBox5.TabIndex = 12;
      this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
      // 
      // textBox6
      // 
      this.textBox6.Enabled = false;
      this.textBox6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
      this.textBox6.ForeColor = System.Drawing.Color.DodgerBlue;
      this.textBox6.Location = new System.Drawing.Point(38, 107);
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new System.Drawing.Size(100, 28);
      this.textBox6.TabIndex = 13;
      this.textBox6.Text = "Bubble sort";
      // 
      // textBox7
      // 
      this.textBox7.Enabled = false;
      this.textBox7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
      this.textBox7.ForeColor = System.Drawing.Color.DodgerBlue;
      this.textBox7.Location = new System.Drawing.Point(38, 312);
      this.textBox7.Name = "textBox7";
      this.textBox7.Size = new System.Drawing.Size(100, 28);
      this.textBox7.TabIndex = 14;
      this.textBox7.Text = "Merge sort";
      // 
      // textBox8
      // 
      this.textBox8.Enabled = false;
      this.textBox8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
      this.textBox8.ForeColor = System.Drawing.Color.DodgerBlue;
      this.textBox8.Location = new System.Drawing.Point(558, 107);
      this.textBox8.Name = "textBox8";
      this.textBox8.Size = new System.Drawing.Size(110, 28);
      this.textBox8.TabIndex = 15;
      this.textBox8.Text = "Insert sort";
      // 
      // textBox9
      // 
      this.textBox9.Enabled = false;
      this.textBox9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
      this.textBox9.ForeColor = System.Drawing.Color.DodgerBlue;
      this.textBox9.Location = new System.Drawing.Point(558, 312);
      this.textBox9.Name = "textBox9";
      this.textBox9.Size = new System.Drawing.Size(110, 28);
      this.textBox9.TabIndex = 16;
      this.textBox9.Text = "Pyramid sort";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = global::SortingAlgorithms.Properties.Resources.Background_3;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(907, 536);
      this.Controls.Add(this.textBox9);
      this.Controls.Add(this.textBox8);
      this.Controls.Add(this.textBox7);
      this.Controls.Add(this.textBox6);
      this.Controls.Add(this.textBox5);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox4);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.menuStrip2);
      this.Name = "Form1";
      this.menuStrip2.ResumeLayout(false);
      this.menuStrip2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.MenuStrip menuStrip2;
    private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem randomArrayToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sortedArrayToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sortedBackwardsArrayToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem almostSortedArrayToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem enterArrayToolStripMenuItem;
    private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    private System.Windows.Forms.ToolStripMenuItem sortsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem bubbleToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem mergeToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem tryangleToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem allTypesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem enterSizeOfArrayToolStripMenuItem;
    private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
    private System.Windows.Forms.TextBox textBox6;
    private System.Windows.Forms.TextBox textBox7;
    private System.Windows.Forms.TextBox textBox8;
    private System.Windows.Forms.TextBox textBox9;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
  }
}


namespace howto_tooltip_user_equation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGraph = new System.Windows.Forms.Button();
            this.txtYmax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYmin = new System.Windows.Forms.TextBox();
            this.txtXmax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXmin = new System.Windows.Forms.TextBox();
            this.txtEquation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picGraph = new System.Windows.Forms.PictureBox();
            this.tipPoint = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.drToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logFunctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGraph
            // 
            this.btnGraph.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGraph.Location = new System.Drawing.Point(209, 109);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(89, 28);
            this.btnGraph.TabIndex = 30;
            this.btnGraph.Text = "Graph";
            this.btnGraph.UseVisualStyleBackColor = false;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // txtYmax
            // 
            this.txtYmax.Location = new System.Drawing.Point(140, 135);
            this.txtYmax.Name = "txtYmax";
            this.txtYmax.Size = new System.Drawing.Size(63, 20);
            this.txtYmax.TabIndex = 29;
            this.txtYmax.Text = "20";
            this.txtYmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "<= y <=";
            // 
            // txtYmin
            // 
            this.txtYmin.Location = new System.Drawing.Point(23, 135);
            this.txtYmin.Name = "txtYmin";
            this.txtYmin.Size = new System.Drawing.Size(63, 20);
            this.txtYmin.TabIndex = 27;
            this.txtYmin.Text = "-20";
            this.txtYmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtXmax
            // 
            this.txtXmax.Location = new System.Drawing.Point(140, 104);
            this.txtXmax.Name = "txtXmax";
            this.txtXmax.Size = new System.Drawing.Size(63, 20);
            this.txtXmax.TabIndex = 26;
            this.txtXmax.Text = "20";
            this.txtXmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "<= x <=";
            // 
            // txtXmin
            // 
            this.txtXmin.Location = new System.Drawing.Point(23, 109);
            this.txtXmin.Name = "txtXmin";
            this.txtXmin.Size = new System.Drawing.Size(63, 20);
            this.txtXmin.TabIndex = 24;
            this.txtXmin.Text = "-20";
            this.txtXmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEquation
            // 
            this.txtEquation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquation.BackColor = System.Drawing.Color.GreenYellow;
            this.txtEquation.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquation.Location = new System.Drawing.Point(71, 71);
            this.txtEquation.Name = "txtEquation";
            this.txtEquation.Size = new System.Drawing.Size(389, 24);
            this.txtEquation.TabIndex = 23;
            this.txtEquation.Text = "x";
            this.txtEquation.TextChanged += new System.EventHandler(this.TxtEquation_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(20, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "F(x)=";
            // 
            // picGraph
            // 
            this.picGraph.BackColor = System.Drawing.Color.Silver;
            this.picGraph.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picGraph.Image = ((System.Drawing.Image)(resources.GetObject("picGraph.Image")));
            this.picGraph.Location = new System.Drawing.Point(0, 24);
            this.picGraph.Name = "picGraph";
            this.picGraph.Size = new System.Drawing.Size(974, 468);
            this.picGraph.TabIndex = 21;
            this.picGraph.TabStop = false;
            this.picGraph.Click += new System.EventHandler(this.PicGraph_Click);
            this.picGraph.MouseEnter += new System.EventHandler(this.PicGraph_MouseEnter);
            this.picGraph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picGraph_MouseMove);
            this.picGraph.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicGraph_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "Number(to Log)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "Base of (number)";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.GreenYellow;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.Location = new System.Drawing.Point(119, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 33;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.GreenYellow;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox2.Location = new System.Drawing.Point(333, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 34;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(439, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Translation to function";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drToolStripMenuItem,
            this.logFunctionToolStripMenuItem,
            this.binaryNumberToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 24);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // drToolStripMenuItem
            // 
            this.drToolStripMenuItem.Name = "drToolStripMenuItem";
            this.drToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.drToolStripMenuItem.Text = "Drawing Graph";
            this.drToolStripMenuItem.Click += new System.EventHandler(this.DrToolStripMenuItem_Click);
            // 
            // logFunctionToolStripMenuItem
            // 
            this.logFunctionToolStripMenuItem.Name = "logFunctionToolStripMenuItem";
            this.logFunctionToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.logFunctionToolStripMenuItem.Text = "Log Function";
            this.logFunctionToolStripMenuItem.Click += new System.EventHandler(this.LogFunctionToolStripMenuItem_Click);
            // 
            // binaryNumberToolStripMenuItem
            // 
            this.binaryNumberToolStripMenuItem.Name = "binaryNumberToolStripMenuItem";
            this.binaryNumberToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.binaryNumberToolStripMenuItem.Text = "Binary number";
            this.binaryNumberToolStripMenuItem.Click += new System.EventHandler(this.BinaryNumberToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.GreenYellow;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(409, 161);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(134, 29);
            this.textBox3.TabIndex = 37;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.richTextBox1.Location = new System.Drawing.Point(613, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(126, 122);
            this.richTextBox1.TabIndex = 38;
            this.richTextBox1.Text = "";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(613, 15);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(35, 20);
            this.textBox4.TabIndex = 39;
            this.textBox4.Text = "0";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(699, 18);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(33, 20);
            this.textBox5.TabIndex = 40;
            this.textBox5.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(654, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 41;
            this.label6.Text = "range";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 492);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.txtYmax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYmin);
            this.Controls.Add(this.txtXmax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtXmin);
            this.Controls.Add(this.txtEquation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picGraph);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "Form1";
            this.Text = "Drawing Log grafh";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.TextBox txtYmax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYmin;
        private System.Windows.Forms.TextBox txtXmax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXmin;
        private System.Windows.Forms.TextBox txtEquation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picGraph;
        private System.Windows.Forms.ToolTip tipPoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem drToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logFunctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryNumberToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
    }
}


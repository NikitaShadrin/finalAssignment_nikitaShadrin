namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.PnlHistory = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnHistory = new System.Windows.Forms.Button();
            this.TxtDisplay2 = new System.Windows.Forms.TextBox();
            this.TxtDisplay1 = new System.Windows.Forms.TextBox();
            this.BtnClearHistory = new System.Windows.Forms.Button();
            this.RtBoxDisplayHistory = new System.Windows.Forms.RichTextBox();
            this.BtnBackSpace = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.BtnPercent = new System.Windows.Forms.Button();
            this.BtnCE = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnSquare = new System.Windows.Forms.Button();
            this.BtnX2 = new System.Windows.Forms.Button();
            this.Btn1X = new System.Windows.Forms.Button();
            this.BtnDivision = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.BtnSubtraction = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDesimal = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnPM = new System.Windows.Forms.Button();
            this.BtnEquals = new System.Windows.Forms.Button();
            this.PnlTitle.SuspendLayout();
            this.PnlHistory.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTitle
            // 
            this.PnlTitle.Controls.Add(this.button2);
            this.PnlTitle.Controls.Add(this.BtnExit);
            this.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(350, 40);
            this.PnlTitle.TabIndex = 0;
            // 
            // PnlHistory
            // 
            this.PnlHistory.Controls.Add(this.RtBoxDisplayHistory);
            this.PnlHistory.Controls.Add(this.BtnClearHistory);
            this.PnlHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlHistory.Location = new System.Drawing.Point(0, 565);
            this.PnlHistory.Margin = new System.Windows.Forms.Padding(0);
            this.PnlHistory.Name = "PnlHistory";
            this.PnlHistory.Size = new System.Drawing.Size(350, 5);
            this.PnlHistory.TabIndex = 1;
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(300, 0);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(50, 40);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(250, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 40);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnHistory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 40);
            this.panel1.TabIndex = 2;
            // 
            // BtnHistory
            // 
            this.BtnHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnHistory.FlatAppearance.BorderSize = 0;
            this.BtnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistory.Image = ((System.Drawing.Image)(resources.GetObject("BtnHistory.Image")));
            this.BtnHistory.Location = new System.Drawing.Point(300, 0);
            this.BtnHistory.Margin = new System.Windows.Forms.Padding(0);
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.Size = new System.Drawing.Size(50, 40);
            this.BtnHistory.TabIndex = 0;
            this.BtnHistory.UseVisualStyleBackColor = true;
            this.BtnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            // 
            // TxtDisplay2
            // 
            this.TxtDisplay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TxtDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay2.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtDisplay2.Font = new System.Drawing.Font("Gadugi", 14F);
            this.TxtDisplay2.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtDisplay2.Location = new System.Drawing.Point(0, 80);
            this.TxtDisplay2.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay2.Multiline = true;
            this.TxtDisplay2.Name = "TxtDisplay2";
            this.TxtDisplay2.Size = new System.Drawing.Size(350, 25);
            this.TxtDisplay2.TabIndex = 3;
            this.TxtDisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtDisplay1
            // 
            this.TxtDisplay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TxtDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtDisplay1.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisplay1.ForeColor = System.Drawing.Color.LightGray;
            this.TxtDisplay1.Location = new System.Drawing.Point(0, 105);
            this.TxtDisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay1.Multiline = true;
            this.TxtDisplay1.Name = "TxtDisplay1";
            this.TxtDisplay1.Size = new System.Drawing.Size(350, 50);
            this.TxtDisplay1.TabIndex = 4;
            this.TxtDisplay1.Text = "0";
            this.TxtDisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnClearHistory
            // 
            this.BtnClearHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnClearHistory.FlatAppearance.BorderSize = 0;
            this.BtnClearHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearHistory.Image = ((System.Drawing.Image)(resources.GetObject("BtnClearHistory.Image")));
            this.BtnClearHistory.Location = new System.Drawing.Point(0, -35);
            this.BtnClearHistory.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClearHistory.Name = "BtnClearHistory";
            this.BtnClearHistory.Size = new System.Drawing.Size(350, 40);
            this.BtnClearHistory.TabIndex = 3;
            this.BtnClearHistory.UseVisualStyleBackColor = true;
            this.BtnClearHistory.Click += new System.EventHandler(this.BtnClearHistory_Click);
            // 
            // RtBoxDisplayHistory
            // 
            this.RtBoxDisplayHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.RtBoxDisplayHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtBoxDisplayHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtBoxDisplayHistory.ForeColor = System.Drawing.Color.Silver;
            this.RtBoxDisplayHistory.Location = new System.Drawing.Point(0, 0);
            this.RtBoxDisplayHistory.Margin = new System.Windows.Forms.Padding(0);
            this.RtBoxDisplayHistory.Name = "RtBoxDisplayHistory";
            this.RtBoxDisplayHistory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.RtBoxDisplayHistory.Size = new System.Drawing.Size(350, 0);
            this.RtBoxDisplayHistory.TabIndex = 4;
            this.RtBoxDisplayHistory.Text = "";
            // 
            // BtnBackSpace
            // 
            this.BtnBackSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.BtnBackSpace.FlatAppearance.BorderSize = 0;
            this.BtnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackSpace.ForeColor = System.Drawing.Color.White;
            this.BtnBackSpace.Image = ((System.Drawing.Image)(resources.GetObject("BtnBackSpace.Image")));
            this.BtnBackSpace.Location = new System.Drawing.Point(270, 194);
            this.BtnBackSpace.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBackSpace.Name = "BtnBackSpace";
            this.BtnBackSpace.Size = new System.Drawing.Size(80, 50);
            this.BtnBackSpace.TabIndex = 6;
            this.BtnBackSpace.UseVisualStyleBackColor = false;
            this.BtnBackSpace.Click += new System.EventHandler(this.BtnBackSpace_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(0, 155);
            this.button10.Margin = new System.Windows.Forms.Padding(0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(0, 0);
            this.button10.TabIndex = 12;
            this.button10.Text = "M~";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // BtnPercent
            // 
            this.BtnPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.BtnPercent.FlatAppearance.BorderSize = 0;
            this.BtnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPercent.ForeColor = System.Drawing.Color.White;
            this.BtnPercent.Location = new System.Drawing.Point(0, 194);
            this.BtnPercent.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPercent.Name = "BtnPercent";
            this.BtnPercent.Size = new System.Drawing.Size(80, 50);
            this.BtnPercent.TabIndex = 13;
            this.BtnPercent.Text = "%";
            this.BtnPercent.UseVisualStyleBackColor = false;
            this.BtnPercent.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // BtnCE
            // 
            this.BtnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.BtnCE.FlatAppearance.BorderSize = 0;
            this.BtnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCE.ForeColor = System.Drawing.Color.White;
            this.BtnCE.Location = new System.Drawing.Point(90, 194);
            this.BtnCE.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(80, 50);
            this.BtnCE.TabIndex = 14;
            this.BtnCE.Text = "CE";
            this.BtnCE.UseVisualStyleBackColor = false;
            this.BtnCE.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // BtnC
            // 
            this.BtnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.BtnC.FlatAppearance.BorderSize = 0;
            this.BtnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnC.ForeColor = System.Drawing.Color.White;
            this.BtnC.Location = new System.Drawing.Point(180, 194);
            this.BtnC.Margin = new System.Windows.Forms.Padding(0);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(80, 50);
            this.BtnC.TabIndex = 15;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = false;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnSquare
            // 
            this.BtnSquare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.BtnSquare.FlatAppearance.BorderSize = 0;
            this.BtnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSquare.ForeColor = System.Drawing.Color.White;
            this.BtnSquare.Location = new System.Drawing.Point(180, 260);
            this.BtnSquare.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSquare.Name = "BtnSquare";
            this.BtnSquare.Size = new System.Drawing.Size(80, 50);
            this.BtnSquare.TabIndex = 19;
            this.BtnSquare.Text = "√x";
            this.BtnSquare.UseVisualStyleBackColor = false;
            this.BtnSquare.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // BtnX2
            // 
            this.BtnX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.BtnX2.FlatAppearance.BorderSize = 0;
            this.BtnX2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnX2.ForeColor = System.Drawing.Color.White;
            this.BtnX2.Location = new System.Drawing.Point(90, 260);
            this.BtnX2.Margin = new System.Windows.Forms.Padding(0);
            this.BtnX2.Name = "BtnX2";
            this.BtnX2.Size = new System.Drawing.Size(80, 50);
            this.BtnX2.TabIndex = 18;
            this.BtnX2.Text = "^2";
            this.BtnX2.UseVisualStyleBackColor = false;
            this.BtnX2.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // Btn1X
            // 
            this.Btn1X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Btn1X.FlatAppearance.BorderSize = 0;
            this.Btn1X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1X.ForeColor = System.Drawing.Color.White;
            this.Btn1X.Location = new System.Drawing.Point(0, 260);
            this.Btn1X.Margin = new System.Windows.Forms.Padding(0);
            this.Btn1X.Name = "Btn1X";
            this.Btn1X.Size = new System.Drawing.Size(80, 50);
            this.Btn1X.TabIndex = 17;
            this.Btn1X.Text = "1/x";
            this.Btn1X.UseVisualStyleBackColor = false;
            this.Btn1X.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // BtnDivision
            // 
            this.BtnDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.BtnDivision.FlatAppearance.BorderSize = 0;
            this.BtnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDivision.ForeColor = System.Drawing.Color.White;
            this.BtnDivision.Location = new System.Drawing.Point(270, 260);
            this.BtnDivision.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(80, 50);
            this.BtnDivision.TabIndex = 16;
            this.BtnDivision.Text = "÷";
            this.BtnDivision.UseVisualStyleBackColor = false;
            this.BtnDivision.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Btn9.FlatAppearance.BorderSize = 0;
            this.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn9.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.ForeColor = System.Drawing.Color.White;
            this.Btn9.Location = new System.Drawing.Point(180, 326);
            this.Btn9.Margin = new System.Windows.Forms.Padding(0);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(80, 50);
            this.Btn9.TabIndex = 23;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Btn8.FlatAppearance.BorderSize = 0;
            this.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn8.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.ForeColor = System.Drawing.Color.White;
            this.Btn8.Location = new System.Drawing.Point(90, 326);
            this.Btn8.Margin = new System.Windows.Forms.Padding(0);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(80, 50);
            this.Btn8.TabIndex = 22;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Btn7.FlatAppearance.BorderSize = 0;
            this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn7.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.ForeColor = System.Drawing.Color.White;
            this.Btn7.Location = new System.Drawing.Point(0, 326);
            this.Btn7.Margin = new System.Windows.Forms.Padding(0);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(80, 50);
            this.Btn7.TabIndex = 21;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.BtnMultiply.FlatAppearance.BorderSize = 0;
            this.BtnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMultiply.ForeColor = System.Drawing.Color.White;
            this.BtnMultiply.Location = new System.Drawing.Point(270, 326);
            this.BtnMultiply.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(80, 50);
            this.BtnMultiply.TabIndex = 20;
            this.BtnMultiply.Text = "×";
            this.BtnMultiply.UseVisualStyleBackColor = false;
            this.BtnMultiply.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Btn6.FlatAppearance.BorderSize = 0;
            this.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn6.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.ForeColor = System.Drawing.Color.White;
            this.Btn6.Location = new System.Drawing.Point(180, 389);
            this.Btn6.Margin = new System.Windows.Forms.Padding(0);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(80, 50);
            this.Btn6.TabIndex = 27;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Btn5.FlatAppearance.BorderSize = 0;
            this.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn5.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.ForeColor = System.Drawing.Color.White;
            this.Btn5.Location = new System.Drawing.Point(90, 389);
            this.Btn5.Margin = new System.Windows.Forms.Padding(0);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(80, 50);
            this.Btn5.TabIndex = 26;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Btn4.FlatAppearance.BorderSize = 0;
            this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.ForeColor = System.Drawing.Color.White;
            this.Btn4.Location = new System.Drawing.Point(0, 389);
            this.Btn4.Margin = new System.Windows.Forms.Padding(0);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(80, 50);
            this.Btn4.TabIndex = 25;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnSubtraction
            // 
            this.BtnSubtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.BtnSubtraction.FlatAppearance.BorderSize = 0;
            this.BtnSubtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubtraction.ForeColor = System.Drawing.Color.White;
            this.BtnSubtraction.Location = new System.Drawing.Point(270, 389);
            this.BtnSubtraction.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSubtraction.Name = "BtnSubtraction";
            this.BtnSubtraction.Size = new System.Drawing.Size(80, 50);
            this.BtnSubtraction.TabIndex = 24;
            this.BtnSubtraction.Text = "-";
            this.BtnSubtraction.UseVisualStyleBackColor = false;
            this.BtnSubtraction.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Btn3.FlatAppearance.BorderSize = 0;
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.ForeColor = System.Drawing.Color.White;
            this.Btn3.Location = new System.Drawing.Point(180, 452);
            this.Btn3.Margin = new System.Windows.Forms.Padding(0);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(80, 50);
            this.Btn3.TabIndex = 31;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Btn2.FlatAppearance.BorderSize = 0;
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.ForeColor = System.Drawing.Color.White;
            this.Btn2.Location = new System.Drawing.Point(90, 452);
            this.Btn2.Margin = new System.Windows.Forms.Padding(0);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(80, 50);
            this.Btn2.TabIndex = 30;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Btn1.FlatAppearance.BorderSize = 0;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.ForeColor = System.Drawing.Color.White;
            this.Btn1.Location = new System.Drawing.Point(0, 452);
            this.Btn1.Margin = new System.Windows.Forms.Padding(0);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(80, 50);
            this.Btn1.TabIndex = 29;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(270, 452);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(80, 50);
            this.BtnAdd.TabIndex = 28;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // BtnDesimal
            // 
            this.BtnDesimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.BtnDesimal.FlatAppearance.BorderSize = 0;
            this.BtnDesimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDesimal.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDesimal.ForeColor = System.Drawing.Color.White;
            this.BtnDesimal.Location = new System.Drawing.Point(180, 515);
            this.BtnDesimal.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDesimal.Name = "BtnDesimal";
            this.BtnDesimal.Size = new System.Drawing.Size(80, 50);
            this.BtnDesimal.TabIndex = 35;
            this.BtnDesimal.Text = ".";
            this.BtnDesimal.UseVisualStyleBackColor = false;
            this.BtnDesimal.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Btn0.FlatAppearance.BorderSize = 0;
            this.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn0.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.ForeColor = System.Drawing.Color.White;
            this.Btn0.Location = new System.Drawing.Point(90, 515);
            this.Btn0.Margin = new System.Windows.Forms.Padding(0);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(80, 50);
            this.Btn0.TabIndex = 34;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnPM
            // 
            this.BtnPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.BtnPM.FlatAppearance.BorderSize = 0;
            this.BtnPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPM.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPM.ForeColor = System.Drawing.Color.White;
            this.BtnPM.Location = new System.Drawing.Point(0, 515);
            this.BtnPM.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPM.Name = "BtnPM";
            this.BtnPM.Size = new System.Drawing.Size(80, 50);
            this.BtnPM.TabIndex = 33;
            this.BtnPM.Text = "±";
            this.BtnPM.UseVisualStyleBackColor = false;
            this.BtnPM.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // BtnEquals
            // 
            this.BtnEquals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.BtnEquals.FlatAppearance.BorderSize = 0;
            this.BtnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEquals.ForeColor = System.Drawing.Color.White;
            this.BtnEquals.Location = new System.Drawing.Point(270, 515);
            this.BtnEquals.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEquals.Name = "BtnEquals";
            this.BtnEquals.Size = new System.Drawing.Size(80, 50);
            this.BtnEquals.TabIndex = 32;
            this.BtnEquals.Text = "=";
            this.BtnEquals.UseVisualStyleBackColor = false;
            this.BtnEquals.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(350, 570);
            this.Controls.Add(this.PnlHistory);
            this.Controls.Add(this.BtnDesimal);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.BtnPM);
            this.Controls.Add(this.BtnEquals);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.BtnSubtraction);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.BtnMultiply);
            this.Controls.Add(this.BtnSquare);
            this.Controls.Add(this.BtnX2);
            this.Controls.Add(this.Btn1X);
            this.Controls.Add(this.BtnDivision);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnCE);
            this.Controls.Add(this.BtnPercent);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.BtnBackSpace);
            this.Controls.Add(this.TxtDisplay1);
            this.Controls.Add(this.TxtDisplay2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlTitle);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PnlTitle.ResumeLayout(false);
            this.PnlHistory.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Panel PnlHistory;
        private System.Windows.Forms.RichTextBox RtBoxDisplayHistory;
        private System.Windows.Forms.Button BtnClearHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnHistory;
        private System.Windows.Forms.TextBox TxtDisplay2;
        private System.Windows.Forms.TextBox TxtDisplay1;
        private System.Windows.Forms.Button BtnBackSpace;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button BtnPercent;
        private System.Windows.Forms.Button BtnCE;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnSquare;
        private System.Windows.Forms.Button BtnX2;
        private System.Windows.Forms.Button Btn1X;
        private System.Windows.Forms.Button BtnDivision;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button BtnMultiply;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button BtnSubtraction;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDesimal;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnPM;
        private System.Windows.Forms.Button BtnEquals;
    }
}


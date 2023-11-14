namespace Bivens_StudentFormDemo
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
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txbStudentID = new System.Windows.Forms.TextBox();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbProgramming = new System.Windows.Forms.RadioButton();
            this.rbWebDesign = new System.Windows.Forms.RadioButton();
            this.rbIT = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCIS101 = new System.Windows.Forms.CheckBox();
            this.cbxCIS102 = new System.Windows.Forms.CheckBox();
            this.cbxCIS103 = new System.Windows.Forms.CheckBox();
            this.cbxCIS104 = new System.Windows.Forms.CheckBox();
            this.txbScore1 = new System.Windows.Forms.TextBox();
            this.txbScore2 = new System.Windows.Forms.TextBox();
            this.txbScore3 = new System.Windows.Forms.TextBox();
            this.txbScore4 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.txbResults = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(41, 41);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(58, 13);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "Student ID";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(41, 68);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(41, 95);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // txbStudentID
            // 
            this.txbStudentID.Location = new System.Drawing.Point(106, 37);
            this.txbStudentID.Name = "txbStudentID";
            this.txbStudentID.Size = new System.Drawing.Size(100, 20);
            this.txbStudentID.TabIndex = 3;
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(106, 64);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(100, 20);
            this.txbFirstName.TabIndex = 4;
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(105, 91);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(100, 20);
            this.txbLastName.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbIT);
            this.groupBox1.Controls.Add(this.rbWebDesign);
            this.groupBox1.Controls.Add(this.rbProgramming);
            this.groupBox1.Location = new System.Drawing.Point(44, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Major";
            // 
            // rbProgramming
            // 
            this.rbProgramming.AutoSize = true;
            this.rbProgramming.Location = new System.Drawing.Point(7, 20);
            this.rbProgramming.Name = "rbProgramming";
            this.rbProgramming.Size = new System.Drawing.Size(86, 17);
            this.rbProgramming.TabIndex = 0;
            this.rbProgramming.TabStop = true;
            this.rbProgramming.Text = "Programming";
            this.rbProgramming.UseVisualStyleBackColor = true;
            // 
            // rbWebDesign
            // 
            this.rbWebDesign.AutoSize = true;
            this.rbWebDesign.Location = new System.Drawing.Point(7, 43);
            this.rbWebDesign.Name = "rbWebDesign";
            this.rbWebDesign.Size = new System.Drawing.Size(84, 17);
            this.rbWebDesign.TabIndex = 1;
            this.rbWebDesign.TabStop = true;
            this.rbWebDesign.Text = "Web Design";
            this.rbWebDesign.UseVisualStyleBackColor = true;
            // 
            // rbIT
            // 
            this.rbIT.AutoSize = true;
            this.rbIT.Location = new System.Drawing.Point(7, 66);
            this.rbIT.Name = "rbIT";
            this.rbIT.Size = new System.Drawing.Size(35, 17);
            this.rbIT.TabIndex = 2;
            this.rbIT.TabStop = true;
            this.rbIT.Text = "IT";
            this.rbIT.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Courses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Scores";
            // 
            // cbxCIS101
            // 
            this.cbxCIS101.AutoSize = true;
            this.cbxCIS101.Location = new System.Drawing.Point(44, 295);
            this.cbxCIS101.Name = "cbxCIS101";
            this.cbxCIS101.Size = new System.Drawing.Size(64, 17);
            this.cbxCIS101.TabIndex = 9;
            this.cbxCIS101.Text = "CIS 101";
            this.cbxCIS101.UseVisualStyleBackColor = true;
            // 
            // cbxCIS102
            // 
            this.cbxCIS102.AutoSize = true;
            this.cbxCIS102.Location = new System.Drawing.Point(44, 321);
            this.cbxCIS102.Name = "cbxCIS102";
            this.cbxCIS102.Size = new System.Drawing.Size(64, 17);
            this.cbxCIS102.TabIndex = 10;
            this.cbxCIS102.Text = "CIS 102";
            this.cbxCIS102.UseVisualStyleBackColor = true;
            // 
            // cbxCIS103
            // 
            this.cbxCIS103.AutoSize = true;
            this.cbxCIS103.Location = new System.Drawing.Point(44, 347);
            this.cbxCIS103.Name = "cbxCIS103";
            this.cbxCIS103.Size = new System.Drawing.Size(64, 17);
            this.cbxCIS103.TabIndex = 11;
            this.cbxCIS103.Text = "CIS 103";
            this.cbxCIS103.UseVisualStyleBackColor = true;
            // 
            // cbxCIS104
            // 
            this.cbxCIS104.AutoSize = true;
            this.cbxCIS104.Location = new System.Drawing.Point(44, 373);
            this.cbxCIS104.Name = "cbxCIS104";
            this.cbxCIS104.Size = new System.Drawing.Size(64, 17);
            this.cbxCIS104.TabIndex = 12;
            this.cbxCIS104.Text = "CIS 104";
            this.cbxCIS104.UseVisualStyleBackColor = true;
            // 
            // txbScore1
            // 
            this.txbScore1.Location = new System.Drawing.Point(131, 292);
            this.txbScore1.Name = "txbScore1";
            this.txbScore1.Size = new System.Drawing.Size(100, 20);
            this.txbScore1.TabIndex = 13;
            // 
            // txbScore2
            // 
            this.txbScore2.Location = new System.Drawing.Point(131, 318);
            this.txbScore2.Name = "txbScore2";
            this.txbScore2.Size = new System.Drawing.Size(100, 20);
            this.txbScore2.TabIndex = 14;
            // 
            // txbScore3
            // 
            this.txbScore3.Location = new System.Drawing.Point(131, 344);
            this.txbScore3.Name = "txbScore3";
            this.txbScore3.Size = new System.Drawing.Size(100, 20);
            this.txbScore3.TabIndex = 15;
            // 
            // txbScore4
            // 
            this.txbScore4.Location = new System.Drawing.Point(131, 370);
            this.txbScore4.Name = "txbScore4";
            this.txbScore4.Size = new System.Drawing.Size(100, 20);
            this.txbScore4.TabIndex = 16;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(47, 406);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txbResult
            // 
            this.txbResult.Location = new System.Drawing.Point(288, 292);
            this.txbResult.Multiline = true;
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(235, 98);
            this.txbResult.TabIndex = 18;
            // 
            // txbResults
            // 
            this.txbResults.AutoSize = true;
            this.txbResults.Location = new System.Drawing.Point(288, 273);
            this.txbResults.Name = "txbResults";
            this.txbResults.Size = new System.Drawing.Size(42, 13);
            this.txbResults.TabIndex = 19;
            this.txbResults.Text = "Results";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(291, 40);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txbResults);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txbScore4);
            this.Controls.Add(this.txbScore3);
            this.Controls.Add(this.txbScore2);
            this.Controls.Add(this.txbScore1);
            this.Controls.Add(this.cbxCIS104);
            this.Controls.Add(this.cbxCIS103);
            this.Controls.Add(this.cbxCIS102);
            this.Controls.Add(this.cbxCIS101);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txbLastName);
            this.Controls.Add(this.txbFirstName);
            this.Controls.Add(this.txbStudentID);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblStudentID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txbStudentID;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbIT;
        private System.Windows.Forms.RadioButton rbWebDesign;
        private System.Windows.Forms.RadioButton rbProgramming;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbxCIS101;
        private System.Windows.Forms.CheckBox cbxCIS102;
        private System.Windows.Forms.CheckBox cbxCIS103;
        private System.Windows.Forms.CheckBox cbxCIS104;
        private System.Windows.Forms.TextBox txbScore1;
        private System.Windows.Forms.TextBox txbScore2;
        private System.Windows.Forms.TextBox txbScore3;
        private System.Windows.Forms.TextBox txbScore4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.Label txbResults;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}


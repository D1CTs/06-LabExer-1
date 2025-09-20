namespace StudentList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            sID = new TextBox();
            slName = new TextBox();
            sfName = new TextBox();
            submit = new Button();
            lnlist = new ListBox();
            IDlist = new ListBox();
            fnlist = new ListBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 65);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Student ID *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(285, 65);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 1;
            label2.Text = "Last Name *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(519, 65);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "First Name *";
            // 
            // sID
            // 
            sID.Location = new Point(50, 83);
            sID.Name = "sID";
            sID.Size = new Size(218, 23);
            sID.TabIndex = 3;
            // 
            // slName
            // 
            slName.Location = new Point(285, 83);
            slName.Name = "slName";
            slName.Size = new Size(218, 23);
            slName.TabIndex = 4;
            // 
            // sfName
            // 
            sfName.Location = new Point(519, 83);
            sfName.Name = "sfName";
            sfName.Size = new Size(218, 23);
            sfName.TabIndex = 5;
            // 
            // submit
            // 
            submit.Location = new Point(363, 128);
            submit.Name = "submit";
            submit.Size = new Size(75, 23);
            submit.TabIndex = 6;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // lnlist
            // 
            lnlist.FormattingEnabled = true;
            lnlist.ItemHeight = 15;
            lnlist.Location = new Point(324, 182);
            lnlist.Name = "lnlist";
            lnlist.Size = new Size(151, 229);
            lnlist.TabIndex = 7;
            // 
            // IDlist
            // 
            IDlist.FormattingEnabled = true;
            IDlist.ItemHeight = 15;
            IDlist.Location = new Point(150, 182);
            IDlist.Name = "IDlist";
            IDlist.Size = new Size(151, 229);
            IDlist.TabIndex = 8;
            // 
            // fnlist
            // 
            fnlist.FormattingEnabled = true;
            fnlist.ItemHeight = 15;
            fnlist.Location = new Point(495, 182);
            fnlist.Name = "fnlist";
            fnlist.Size = new Size(151, 229);
            fnlist.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(185, 164);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 10;
            label4.Text = "Student ID List";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(359, 164);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 11;
            label5.Text = "Last Name List";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(529, 164);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 12;
            label6.Text = "First Name List";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(fnlist);
            Controls.Add(IDlist);
            Controls.Add(lnlist);
            Controls.Add(submit);
            Controls.Add(sfName);
            Controls.Add(slName);
            Controls.Add(sID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox sID;
        private TextBox slName;
        private TextBox sfName;
        private Button submit;
        private ListBox lnlist;
        private ListBox IDlist;
        private ListBox fnlist;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}

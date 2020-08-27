namespace RestAPIWeek6
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.Btn_ActiveThreshHold = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnHighestComment = new System.Windows.Forms.Button();
            this.Btn_RecordDate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxActiveUsers = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox.Location = new System.Drawing.Point(440, 29);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(480, 566);
            this.textBox.TabIndex = 0;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_ActiveThreshHold
            // 
            this.Btn_ActiveThreshHold.BackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_ActiveThreshHold.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_ActiveThreshHold.FlatAppearance.BorderSize = 2;
            this.Btn_ActiveThreshHold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ActiveThreshHold.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_ActiveThreshHold.Location = new System.Drawing.Point(46, 78);
            this.Btn_ActiveThreshHold.Name = "Btn_ActiveThreshHold";
            this.Btn_ActiveThreshHold.Size = new System.Drawing.Size(336, 48);
            this.Btn_ActiveThreshHold.TabIndex = 1;
            this.Btn_ActiveThreshHold.Text = "Most Active Users By ThreshHold";
            this.Btn_ActiveThreshHold.UseVisualStyleBackColor = false;
            this.Btn_ActiveThreshHold.Click += new System.EventHandler(this.BtnActiveThreshHold_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Set ThreshHold";
            // 
            // BtnHighestComment
            // 
            this.BtnHighestComment.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnHighestComment.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnHighestComment.FlatAppearance.BorderSize = 2;
            this.BtnHighestComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHighestComment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnHighestComment.Location = new System.Drawing.Point(46, 205);
            this.BtnHighestComment.Name = "BtnHighestComment";
            this.BtnHighestComment.Size = new System.Drawing.Size(336, 48);
            this.BtnHighestComment.TabIndex = 1;
            this.BtnHighestComment.Text = "User With Highest Comment Count";
            this.BtnHighestComment.UseVisualStyleBackColor = false;
            this.BtnHighestComment.Click += new System.EventHandler(this.BtnHighest_click);
            // 
            // Btn_RecordDate
            // 
            this.Btn_RecordDate.BackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_RecordDate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_RecordDate.FlatAppearance.BorderSize = 2;
            this.Btn_RecordDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_RecordDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_RecordDate.Location = new System.Drawing.Point(46, 381);
            this.Btn_RecordDate.Name = "Btn_RecordDate";
            this.Btn_RecordDate.Size = new System.Drawing.Size(336, 48);
            this.Btn_RecordDate.TabIndex = 1;
            this.Btn_RecordDate.Text = "Users Sorted By RecordDate";
            this.Btn_RecordDate.UseVisualStyleBackColor = false;
            this.Btn_RecordDate.Click += new System.EventHandler(this.Btn_RecordDate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Set ThreshHold";
            // 
            // textBoxActiveUsers
            // 
            this.textBoxActiveUsers.Location = new System.Drawing.Point(174, 35);
            this.textBoxActiveUsers.Multiline = true;
            this.textBoxActiveUsers.Name = "textBoxActiveUsers";
            this.textBoxActiveUsers.Size = new System.Drawing.Size(82, 37);
            this.textBoxActiveUsers.TabIndex = 3;
            this.textBoxActiveUsers.TextChanged += new System.EventHandler(this.textBoxActiveUsers_TextChanged);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Crimson;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(162, 475);
            this.clearBtn.MaximumSize = new System.Drawing.Size(94, 41);
            this.clearBtn.MinimumSize = new System.Drawing.Size(94, 41);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(94, 41);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_click);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(128, 350);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(250, 27);
            this.datePicker.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(958, 619);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.textBoxActiveUsers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_RecordDate);
            this.Controls.Add(this.BtnHighestComment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_ActiveThreshHold);
            this.Controls.Add(this.textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(980, 670);
            this.MinimumSize = new System.Drawing.Size(980, 670);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Loaded);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button Btn_ActiveThreshHold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnHighestComment;
        private System.Windows.Forms.Button Btn_RecordDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxActiveUsers;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.DateTimePicker datePicker;
    }
}


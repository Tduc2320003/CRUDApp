namespace _21110765_DinhThanhDuc_HomeWork
{
    partial class FStudent
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
            ucInfo = new UCInfo();
            label1 = new Label();
            btnToggle = new Button();
            SuspendLayout();
            // 
            // ucInfo
            // 
            ucInfo.Address = "";
            ucInfo.DOB = new DateTime(2024, 3, 3, 15, 1, 19, 103);
            ucInfo.Email = "";
            ucInfo.Gender = null;
            ucInfo.IdCard = "";
            ucInfo.Location = new Point(14, 117);
            ucInfo.Name = "ucInfo";
            ucInfo.Phone = "";
            ucInfo.Size = new Size(1566, 542);
            ucInfo.TabIndex = 0;
           
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(574, 24);
            label1.Name = "label1";
            label1.Size = new Size(342, 45);
            label1.TabIndex = 1;
            label1.Text = "STUDENT FORM";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnToggle
            // 
            btnToggle.BackColor = Color.White;
            btnToggle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnToggle.Location = new Point(1281, 24);
            btnToggle.Name = "btnToggle";
            btnToggle.Size = new Size(188, 32);
            btnToggle.TabIndex = 2;
            btnToggle.Text = "To teacher form";
            btnToggle.UseVisualStyleBackColor = false;
            btnToggle.Click += btnToggle_Click;
            // 
            // FStudent
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1540, 665);
            Controls.Add(btnToggle);
            Controls.Add(label1);
            Controls.Add(ucInfo);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UCInfo ucInfo;
        private Label label1;
        private Button btnToggle;
    }
}

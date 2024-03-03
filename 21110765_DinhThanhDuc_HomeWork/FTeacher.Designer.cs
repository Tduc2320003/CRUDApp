namespace _21110765_DinhThanhDuc_HomeWork
{
    partial class FTeacher
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
            ucInfo1 = new UCInfo();
            label1 = new Label();
            btnToggle = new Button();
            SuspendLayout();
            // 
            // ucInfo1
            // 
            ucInfo1.Address = "";
            ucInfo1.DOB = new DateTime(2024, 3, 3, 14, 41, 54, 384);
            ucInfo1.Email = "";
            ucInfo1.Gender = null;
            ucInfo1.IdCard = "";
            ucInfo1.Location = new Point(14, 87);
            ucInfo1.Name = "ucInfo1";
            ucInfo1.Phone = "";
            ucInfo1.Size = new Size(1696, 496);
            ucInfo1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(641, 24);
            label1.Name = "label1";
            label1.Size = new Size(352, 45);
            label1.TabIndex = 1;
            label1.Text = "TEACHER FORM";
            // 
            // btnToggle
            // 
            btnToggle.BackColor = Color.White;
            btnToggle.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnToggle.Location = new Point(1354, 24);
            btnToggle.Name = "btnToggle";
            btnToggle.Size = new Size(178, 29);
            btnToggle.TabIndex = 2;
            btnToggle.Text = "To student page";
            btnToggle.UseVisualStyleBackColor = false;
            btnToggle.Click += btnToggle_Click;
            // 
            // FTeacher
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1594, 648);
            Controls.Add(btnToggle);
            Controls.Add(label1);
            Controls.Add(ucInfo1);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FTeacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FTeacher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UCInfo ucInfo1;
        private Label label1;
        private Button btnToggle;
    }
}
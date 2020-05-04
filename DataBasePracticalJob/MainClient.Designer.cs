namespace DataBasePracticalJob
{
    partial class MainClient
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.profileTab = new System.Windows.Forms.TabPage();
            this.idLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.clientsTab = new System.Windows.Forms.TabPage();
            this.checkedClients = new System.Windows.Forms.CheckedListBox();
            this.instructorsTab = new System.Windows.Forms.TabPage();
            this.checkedInstructors = new System.Windows.Forms.CheckedListBox();
            this.pilotsTab = new System.Windows.Forms.TabPage();
            this.checkedPilots = new System.Windows.Forms.CheckedListBox();
            this.scheduleTab = new System.Windows.Forms.TabPage();
            this.checkedSchedule = new System.Windows.Forms.CheckedListBox();
            this.equipment = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.profileTab.SuspendLayout();
            this.clientsTab.SuspendLayout();
            this.instructorsTab.SuspendLayout();
            this.pilotsTab.SuspendLayout();
            this.scheduleTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.profileTab);
            this.tabControl1.Controls.Add(this.clientsTab);
            this.tabControl1.Controls.Add(this.instructorsTab);
            this.tabControl1.Controls.Add(this.pilotsTab);
            this.tabControl1.Controls.Add(this.scheduleTab);
            this.tabControl1.Controls.Add(this.equipment);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // profileTab
            // 
            this.profileTab.Controls.Add(this.label8);
            this.profileTab.Controls.Add(this.label7);
            this.profileTab.Controls.Add(this.idLabel);
            this.profileTab.Controls.Add(this.label6);
            this.profileTab.Controls.Add(this.numberLabel);
            this.profileTab.Controls.Add(this.label1);
            this.profileTab.Controls.Add(this.label5);
            this.profileTab.Controls.Add(this.label4);
            this.profileTab.Controls.Add(this.label3);
            this.profileTab.Controls.Add(this.label2);
            this.profileTab.Controls.Add(this.emailLabel);
            this.profileTab.Controls.Add(this.lastnameLabel);
            this.profileTab.Controls.Add(this.usernameLabel);
            this.profileTab.Controls.Add(this.nameLabel);
            this.profileTab.Location = new System.Drawing.Point(4, 22);
            this.profileTab.Name = "profileTab";
            this.profileTab.Padding = new System.Windows.Forms.Padding(3);
            this.profileTab.Size = new System.Drawing.Size(768, 400);
            this.profileTab.TabIndex = 0;
            this.profileTab.Text = "Profile";
            this.profileTab.UseVisualStyleBackColor = true;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(100, 42);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(0, 13);
            this.idLabel.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID:";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(100, 184);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(0, 13);
            this.numberLabel.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lastname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "UserName:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(100, 154);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(0, 13);
            this.emailLabel.TabIndex = 3;
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Location = new System.Drawing.Point(100, 126);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(0, 13);
            this.lastnameLabel.TabIndex = 2;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(100, 67);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(0, 13);
            this.usernameLabel.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(100, 96);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 13);
            this.nameLabel.TabIndex = 0;
            // 
            // clientsTab
            // 
            this.clientsTab.Controls.Add(this.checkedClients);
            this.clientsTab.Location = new System.Drawing.Point(4, 22);
            this.clientsTab.Name = "clientsTab";
            this.clientsTab.Padding = new System.Windows.Forms.Padding(3);
            this.clientsTab.Size = new System.Drawing.Size(768, 400);
            this.clientsTab.TabIndex = 1;
            this.clientsTab.Text = "Clients";
            this.clientsTab.UseVisualStyleBackColor = true;
            // 
            // checkedClients
            // 
            this.checkedClients.FormattingEnabled = true;
            this.checkedClients.Location = new System.Drawing.Point(3, 3);
            this.checkedClients.Name = "checkedClients";
            this.checkedClients.Size = new System.Drawing.Size(392, 394);
            this.checkedClients.TabIndex = 1;
            // 
            // instructorsTab
            // 
            this.instructorsTab.Controls.Add(this.checkedInstructors);
            this.instructorsTab.Location = new System.Drawing.Point(4, 22);
            this.instructorsTab.Name = "instructorsTab";
            this.instructorsTab.Size = new System.Drawing.Size(768, 400);
            this.instructorsTab.TabIndex = 2;
            this.instructorsTab.Text = "Instructors";
            this.instructorsTab.UseVisualStyleBackColor = true;
            // 
            // checkedInstructors
            // 
            this.checkedInstructors.FormattingEnabled = true;
            this.checkedInstructors.Location = new System.Drawing.Point(3, 3);
            this.checkedInstructors.Name = "checkedInstructors";
            this.checkedInstructors.Size = new System.Drawing.Size(392, 394);
            this.checkedInstructors.TabIndex = 2;
            // 
            // pilotsTab
            // 
            this.pilotsTab.Controls.Add(this.checkedPilots);
            this.pilotsTab.Location = new System.Drawing.Point(4, 22);
            this.pilotsTab.Name = "pilotsTab";
            this.pilotsTab.Size = new System.Drawing.Size(768, 400);
            this.pilotsTab.TabIndex = 3;
            this.pilotsTab.Text = "Pilots";
            this.pilotsTab.UseVisualStyleBackColor = true;
            // 
            // checkedPilots
            // 
            this.checkedPilots.FormattingEnabled = true;
            this.checkedPilots.Location = new System.Drawing.Point(3, 3);
            this.checkedPilots.Name = "checkedPilots";
            this.checkedPilots.Size = new System.Drawing.Size(392, 394);
            this.checkedPilots.TabIndex = 3;
            // 
            // scheduleTab
            // 
            this.scheduleTab.Controls.Add(this.checkedSchedule);
            this.scheduleTab.Location = new System.Drawing.Point(4, 22);
            this.scheduleTab.Name = "scheduleTab";
            this.scheduleTab.Size = new System.Drawing.Size(768, 400);
            this.scheduleTab.TabIndex = 4;
            this.scheduleTab.Text = "Schedule";
            this.scheduleTab.UseVisualStyleBackColor = true;
            // 
            // checkedSchedule
            // 
            this.checkedSchedule.FormattingEnabled = true;
            this.checkedSchedule.Location = new System.Drawing.Point(3, 3);
            this.checkedSchedule.Name = "checkedSchedule";
            this.checkedSchedule.Size = new System.Drawing.Size(328, 199);
            this.checkedSchedule.TabIndex = 0;
            // 
            // equipment
            // 
            this.equipment.Location = new System.Drawing.Point(4, 22);
            this.equipment.Name = "equipment";
            this.equipment.Size = new System.Drawing.Size(768, 400);
            this.equipment.TabIndex = 5;
            this.equipment.Text = "Equipment";
            this.equipment.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Weight:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Height:";
            // 
            // MainClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainClient";
            this.Text = "MainClient";
            this.tabControl1.ResumeLayout(false);
            this.profileTab.ResumeLayout(false);
            this.profileTab.PerformLayout();
            this.clientsTab.ResumeLayout(false);
            this.instructorsTab.ResumeLayout(false);
            this.pilotsTab.ResumeLayout(false);
            this.scheduleTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage profileTab;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TabPage clientsTab;
        private System.Windows.Forms.CheckedListBox checkedClients;
        private System.Windows.Forms.TabPage instructorsTab;
        private System.Windows.Forms.CheckedListBox checkedInstructors;
        private System.Windows.Forms.TabPage pilotsTab;
        private System.Windows.Forms.CheckedListBox checkedPilots;
        private System.Windows.Forms.TabPage scheduleTab;
        private System.Windows.Forms.CheckedListBox checkedSchedule;
        private System.Windows.Forms.TabPage equipment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
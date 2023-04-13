namespace hotel_system
{
    partial class Roominfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Datelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RoomPhone = new System.Windows.Forms.TextBox();
            this.RoomId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.YesRadio = new System.Windows.Forms.RadioButton();
            this.NoRadio = new System.Windows.Forms.RadioButton();
            this.Add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.RoomSearch = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.RoomGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Datelbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 100);
            this.panel1.TabIndex = 20;
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Datelbl.Location = new System.Drawing.Point(887, 62);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(67, 29);
            this.Datelbl.TabIndex = 1;
            this.Datelbl.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(309, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(56, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Room Number";
            // 
            // RoomPhone
            // 
            this.RoomPhone.Location = new System.Drawing.Point(235, 389);
            this.RoomPhone.Name = "RoomPhone";
            this.RoomPhone.Size = new System.Drawing.Size(100, 22);
            this.RoomPhone.TabIndex = 22;
            // 
            // RoomId
            // 
            this.RoomId.Location = new System.Drawing.Point(235, 314);
            this.RoomId.Name = "RoomId";
            this.RoomId.Size = new System.Drawing.Size(100, 22);
            this.RoomId.TabIndex = 21;
            this.RoomId.TextChanged += new System.EventHandler(this.Room_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightCoral;
            this.label4.Location = new System.Drawing.Point(65, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Room Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(64, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "Free";
            // 
            // YesRadio
            // 
            this.YesRadio.AutoSize = true;
            this.YesRadio.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesRadio.ForeColor = System.Drawing.Color.DodgerBlue;
            this.YesRadio.Location = new System.Drawing.Point(166, 478);
            this.YesRadio.Name = "YesRadio";
            this.YesRadio.Size = new System.Drawing.Size(60, 23);
            this.YesRadio.TabIndex = 26;
            this.YesRadio.TabStop = true;
            this.YesRadio.Text = "Yes";
            this.YesRadio.UseVisualStyleBackColor = true;
            this.YesRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // NoRadio
            // 
            this.NoRadio.AutoSize = true;
            this.NoRadio.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoRadio.ForeColor = System.Drawing.Color.DodgerBlue;
            this.NoRadio.Location = new System.Drawing.Point(262, 478);
            this.NoRadio.Name = "NoRadio";
            this.NoRadio.Size = new System.Drawing.Size(54, 23);
            this.NoRadio.TabIndex = 27;
            this.NoRadio.TabStop = true;
            this.NoRadio.Text = "No";
            this.NoRadio.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.Info;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Add.Location = new System.Drawing.Point(51, 572);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(95, 37);
            this.Add.TabIndex = 28;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.SystemColors.Info;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Edit.Location = new System.Drawing.Point(193, 572);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(95, 37);
            this.Edit.TabIndex = 29;
            this.Edit.Text = "EDIT";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.Info;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Delete.Location = new System.Drawing.Point(305, 572);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(143, 37);
            this.Delete.TabIndex = 30;
            this.Delete.Text = "DELETE";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // RoomSearch
            // 
            this.RoomSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.RoomSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoomSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomSearch.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.RoomSearch.Location = new System.Drawing.Point(715, 174);
            this.RoomSearch.Name = "RoomSearch";
            this.RoomSearch.Size = new System.Drawing.Size(119, 47);
            this.RoomSearch.TabIndex = 34;
            this.RoomSearch.Text = "Search";
            this.RoomSearch.UseVisualStyleBackColor = false;
            this.RoomSearch.Click += new System.EventHandler(this.RoomSearch_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(579, 189);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(140, 22);
            this.textBox4.TabIndex = 33;
            // 
            // RoomGridView
            // 
            this.RoomGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomGridView.Location = new System.Drawing.Point(466, 236);
            this.RoomGridView.Name = "RoomGridView";
            this.RoomGridView.RowHeadersWidth = 51;
            this.RoomGridView.RowTemplate.Height = 24;
            this.RoomGridView.Size = new System.Drawing.Size(595, 373);
            this.RoomGridView.TabIndex = 32;
            this.RoomGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomGridView_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Roominfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 698);
            this.Controls.Add(this.RoomSearch);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.RoomGridView);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.NoRadio);
            this.Controls.Add(this.YesRadio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RoomPhone);
            this.Controls.Add(this.RoomId);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Roominfo";
            this.Text = "Roominfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RoomPhone;
        private System.Windows.Forms.TextBox RoomId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton YesRadio;
        private System.Windows.Forms.RadioButton NoRadio;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button RoomSearch;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView RoomGridView;
        private System.Windows.Forms.Button button1;
    }
}
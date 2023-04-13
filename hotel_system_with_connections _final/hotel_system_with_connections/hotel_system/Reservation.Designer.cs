namespace hotel_system
{
    partial class RoomNo
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
            this.Datelbl = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.ReservationGridView = new System.Windows.Forms.DataGridView();
            this.Rooms = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RoomNos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.ReservationId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DateIn = new System.Windows.Forms.DateTimePicker();
            this.DateOut = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.SystemColors.Info;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Edit.Location = new System.Drawing.Point(138, 612);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(95, 37);
            this.Edit.TabIndex = 38;
            this.Edit.Text = "EDIT";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.Info;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Add.Location = new System.Drawing.Point(13, 612);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(95, 37);
            this.Add.TabIndex = 37;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ReservationGridView
            // 
            this.ReservationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservationGridView.Location = new System.Drawing.Point(418, 217);
            this.ReservationGridView.Name = "ReservationGridView";
            this.ReservationGridView.RowHeadersWidth = 51;
            this.ReservationGridView.RowTemplate.Height = 24;
            this.ReservationGridView.Size = new System.Drawing.Size(595, 373);
            this.ReservationGridView.TabIndex = 36;
            this.ReservationGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReservationGridView_CellContentClick);
            // 
            // Rooms
            // 
            this.Rooms.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rooms.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Rooms.FormattingEnabled = true;
            this.Rooms.Items.AddRange(new object[] {
            "Free ",
            "Busy"});
            this.Rooms.Location = new System.Drawing.Point(430, 158);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(192, 31);
            this.Rooms.TabIndex = 35;
            this.Rooms.Text = "Rooms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(248, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation Information";
            // 
            // RoomNos
            // 
            this.RoomNos.Location = new System.Drawing.Point(200, 365);
            this.RoomNos.Name = "RoomNos";
            this.RoomNos.Size = new System.Drawing.Size(100, 22);
            this.RoomNos.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightCoral;
            this.label3.Location = new System.Drawing.Point(28, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "Room Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(33, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Reservation Id";
            // 
            // ClientName
            // 
            this.ClientName.Location = new System.Drawing.Point(200, 291);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(100, 22);
            this.ClientName.TabIndex = 30;
            // 
            // ReservationId
            // 
            this.ReservationId.Location = new System.Drawing.Point(200, 218);
            this.ReservationId.Name = "ReservationId";
            this.ReservationId.Size = new System.Drawing.Size(100, 22);
            this.ReservationId.TabIndex = 29;
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
            this.panel1.Size = new System.Drawing.Size(1068, 100);
            this.panel1.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightCoral;
            this.label4.Location = new System.Drawing.Point(46, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Client Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(28, 492);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 42;
            this.label5.Text = "DateOut";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(28, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 43;
            this.label6.Text = "DateIn";
            // 
            // DateIn
            // 
            this.DateIn.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateIn.Location = new System.Drawing.Point(138, 439);
            this.DateIn.Name = "DateIn";
            this.DateIn.Size = new System.Drawing.Size(200, 22);
            this.DateIn.TabIndex = 44;
            this.DateIn.ValueChanged += new System.EventHandler(this.DateIn_ValueChanged);
            // 
            // DateOut
            // 
            this.DateOut.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOut.Location = new System.Drawing.Point(138, 492);
            this.DateOut.Name = "DateOut";
            this.DateOut.Size = new System.Drawing.Size(200, 22);
            this.DateOut.TabIndex = 45;
            this.DateOut.ValueChanged += new System.EventHandler(this.DateOut_ValueChanged);
            // 
            // RoomNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 709);
            this.Controls.Add(this.DateOut);
            this.Controls.Add(this.DateIn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ReservationGridView);
            this.Controls.Add(this.Rooms);
            this.Controls.Add(this.RoomNos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.ReservationId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomNo";
            this.Text = "Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView ReservationGridView;
        private System.Windows.Forms.ComboBox Rooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RoomNos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.TextBox ReservationId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DateIn;
        private System.Windows.Forms.DateTimePicker DateOut;
        private System.Windows.Forms.Button button1;
    }
}
namespace ilk
{
    partial class SalonDuzenle
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxadd = new System.Windows.Forms.ComboBox();
            this.labeladd = new System.Windows.Forms.Label();
            this.textBoxsehir = new System.Windows.Forms.TextBox();
            this.labelsehir = new System.Windows.Forms.Label();
            this.textBoxkap = new System.Windows.Forms.TextBox();
            this.textBoxsalon = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttondel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonupd = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(86, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose City";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(174, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.buttonupd);
            this.groupBox1.Controls.Add(this.labelMessage);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 368);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SalonDetails";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboBoxadd);
            this.groupBox2.Controls.Add(this.labeladd);
            this.groupBox2.Controls.Add(this.textBoxsehir);
            this.groupBox2.Controls.Add(this.labelsehir);
            this.groupBox2.Controls.Add(this.textBoxkap);
            this.groupBox2.Controls.Add(this.textBoxsalon);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.buttondel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.buttonadd);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(11, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 239);
            this.groupBox2.TabIndex = 95;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(418, 35);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(116, 24);
            this.comboBox3.TabIndex = 96;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(25, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 18);
            this.label9.TabIndex = 126;
            this.label9.Text = "Capacity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(25, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 18);
            this.label8.TabIndex = 125;
            this.label8.Text = "Salon Name";
            // 
            // comboBoxadd
            // 
            this.comboBoxadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxadd.FormattingEnabled = true;
            this.comboBoxadd.Location = new System.Drawing.Point(268, 35);
            this.comboBoxadd.Name = "comboBoxadd";
            this.comboBoxadd.Size = new System.Drawing.Size(121, 26);
            this.comboBoxadd.TabIndex = 124;
            this.comboBoxadd.SelectedIndexChanged += new System.EventHandler(this.comboBoxadd_SelectedIndexChanged);
            // 
            // labeladd
            // 
            this.labeladd.AutoSize = true;
            this.labeladd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeladd.Location = new System.Drawing.Point(25, 38);
            this.labeladd.Name = "labeladd";
            this.labeladd.Size = new System.Drawing.Size(212, 18);
            this.labeladd.TabIndex = 123;
            this.labeladd.Text = "Select the data you want to edit\r\n";
            // 
            // textBoxsehir
            // 
            this.textBoxsehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxsehir.Location = new System.Drawing.Point(187, 180);
            this.textBoxsehir.Name = "textBoxsehir";
            this.textBoxsehir.Size = new System.Drawing.Size(100, 24);
            this.textBoxsehir.TabIndex = 122;
            // 
            // labelsehir
            // 
            this.labelsehir.AutoSize = true;
            this.labelsehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsehir.Location = new System.Drawing.Point(25, 183);
            this.labelsehir.Name = "labelsehir";
            this.labelsehir.Size = new System.Drawing.Size(33, 18);
            this.labelsehir.TabIndex = 121;
            this.labelsehir.Text = "City";
            this.labelsehir.Click += new System.EventHandler(this.labelsehir_Click);
            // 
            // textBoxkap
            // 
            this.textBoxkap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxkap.Location = new System.Drawing.Point(187, 134);
            this.textBoxkap.Multiline = true;
            this.textBoxkap.Name = "textBoxkap";
            this.textBoxkap.Size = new System.Drawing.Size(100, 20);
            this.textBoxkap.TabIndex = 120;
            // 
            // textBoxsalon
            // 
            this.textBoxsalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxsalon.Location = new System.Drawing.Point(187, 83);
            this.textBoxsalon.Multiline = true;
            this.textBoxsalon.Name = "textBoxsalon";
            this.textBoxsalon.Size = new System.Drawing.Size(100, 20);
            this.textBoxsalon.TabIndex = 119;
            this.textBoxsalon.TextChanged += new System.EventHandler(this.textBoxsalon_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label14.Location = new System.Drawing.Point(484, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 16);
            this.label14.TabIndex = 118;
            this.label14.Text = "Update";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // button3
            // 
            this.button3.Image = global::ilk.Properties.Resources.icons8_restart_32;
            this.button3.Location = new System.Drawing.Point(487, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 45);
            this.button3.TabIndex = 117;
            this.button3.Text = " ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(415, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 114;
            this.label5.Text = "Delete";
            // 
            // buttondel
            // 
            this.buttondel.Image = global::ilk.Properties.Resources.icons8_delete_24;
            this.buttondel.Location = new System.Drawing.Point(418, 106);
            this.buttondel.Name = "buttondel";
            this.buttondel.Size = new System.Drawing.Size(45, 45);
            this.buttondel.TabIndex = 113;
            this.buttondel.UseVisualStyleBackColor = true;
            this.buttondel.Click += new System.EventHandler(this.buttondel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label6.Location = new System.Drawing.Point(353, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 116;
            this.label6.Text = "Add";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.Image = global::ilk.Properties.Resources.icons8_plus_math_32;
            this.buttonadd.Location = new System.Drawing.Point(344, 106);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(45, 45);
            this.buttonadd.TabIndex = 115;
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttonupd
            // 
            this.buttonupd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonupd.Location = new System.Drawing.Point(779, 371);
            this.buttonupd.Name = "buttonupd";
            this.buttonupd.Size = new System.Drawing.Size(121, 40);
            this.buttonupd.TabIndex = 94;
            this.buttonupd.Text = "UPDATE";
            this.buttonupd.UseVisualStyleBackColor = true;
            this.buttonupd.Visible = false;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMessage.Location = new System.Drawing.Point(480, 371);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(54, 18);
            this.labelMessage.TabIndex = 93;
            this.labelMessage.Text = "label21";
            this.labelMessage.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.Location = new System.Drawing.Point(11, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(237, 96);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Salon-Ad";
            this.columnHeader1.Width = 102;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Salon-Kapasite";
            this.columnHeader2.Width = 126;
            // 
            // SalonDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 414);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "SalonDuzenle";
            this.Text = "SalonDuzenle";
            this.Load += new System.EventHandler(this.SalonDuzenle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button buttonupd;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxadd;
        private System.Windows.Forms.Label labeladd;
        private System.Windows.Forms.TextBox textBoxsehir;
        private System.Windows.Forms.Label labelsehir;
        private System.Windows.Forms.TextBox textBoxkap;
        private System.Windows.Forms.TextBox textBoxsalon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttondel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}
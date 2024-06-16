namespace CarRental
{
    partial class RentCar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rentIDTxt = new System.Windows.Forms.TextBox();
            this.custoNameTxt = new System.Windows.Forms.TextBox();
            this.pickDate = new System.Windows.Forms.DateTimePicker();
            this.retDate = new System.Windows.Forms.DateTimePicker();
            this.feeTxt = new System.Windows.Forms.TextBox();
            this.carCombo = new System.Windows.Forms.ComboBox();
            this.dataGridRental = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentBtn = new System.Windows.Forms.Button();
            this.customerCombo = new System.Windows.Forms.ComboBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rentalCombo = new System.Windows.Forms.ComboBox();
            this.returnedDate = new System.Windows.Forms.DateTimePicker();
            this.extraTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.returnBtn = new System.Windows.Forms.Button();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.carModTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRental)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pickup Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Return Date";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rental ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 284);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Rental Fee (Rs)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // rentIDTxt
            // 
            this.rentIDTxt.Location = new System.Drawing.Point(192, 66);
            this.rentIDTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rentIDTxt.Name = "rentIDTxt";
            this.rentIDTxt.Size = new System.Drawing.Size(92, 20);
            this.rentIDTxt.TabIndex = 7;
            // 
            // custoNameTxt
            // 
            this.custoNameTxt.Location = new System.Drawing.Point(192, 187);
            this.custoNameTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.custoNameTxt.Name = "custoNameTxt";
            this.custoNameTxt.Size = new System.Drawing.Size(182, 20);
            this.custoNameTxt.TabIndex = 9;
            // 
            // pickDate
            // 
            this.pickDate.Location = new System.Drawing.Point(192, 218);
            this.pickDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pickDate.Name = "pickDate";
            this.pickDate.Size = new System.Drawing.Size(182, 20);
            this.pickDate.TabIndex = 10;
            // 
            // retDate
            // 
            this.retDate.Location = new System.Drawing.Point(192, 249);
            this.retDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.retDate.Name = "retDate";
            this.retDate.Size = new System.Drawing.Size(182, 20);
            this.retDate.TabIndex = 11;
            // 
            // feeTxt
            // 
            this.feeTxt.Location = new System.Drawing.Point(192, 280);
            this.feeTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.feeTxt.Name = "feeTxt";
            this.feeTxt.Size = new System.Drawing.Size(76, 20);
            this.feeTxt.TabIndex = 12;
            // 
            // carCombo
            // 
            this.carCombo.BackColor = System.Drawing.SystemColors.Window;
            this.carCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carCombo.FormattingEnabled = true;
            this.carCombo.Location = new System.Drawing.Point(192, 98);
            this.carCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carCombo.Name = "carCombo";
            this.carCombo.Size = new System.Drawing.Size(92, 21);
            this.carCombo.TabIndex = 13;
            this.carCombo.SelectedIndexChanged += new System.EventHandler(this.carCombo_SelectedIndexChanged);
            // 
            // dataGridRental
            // 
            this.dataGridRental.AllowUserToAddRows = false;
            this.dataGridRental.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRental.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRental.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridRental.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridRental.EnableHeadersVisualStyles = false;
            this.dataGridRental.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridRental.Location = new System.Drawing.Point(57, 422);
            this.dataGridRental.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridRental.Name = "dataGridRental";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRental.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridRental.RowHeadersWidth = 51;
            this.dataGridRental.RowTemplate.Height = 24;
            this.dataGridRental.Size = new System.Drawing.Size(1181, 275);
            this.dataGridRental.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Rent ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Car ID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Customer ID";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Customer Name";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Pickup Date";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Return Date";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Rental Fee (Rs)";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Extra Charges (Rs)";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Rental Status";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // rentBtn
            // 
            this.rentBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.rentBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rentBtn.Location = new System.Drawing.Point(191, 316);
            this.rentBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rentBtn.Name = "rentBtn";
            this.rentBtn.Size = new System.Drawing.Size(112, 29);
            this.rentBtn.TabIndex = 15;
            this.rentBtn.Text = "Confirm Rental";
            this.rentBtn.UseVisualStyleBackColor = false;
            this.rentBtn.Click += new System.EventHandler(this.rentBtn_Click);
            // 
            // customerCombo
            // 
            this.customerCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerCombo.FormattingEnabled = true;
            this.customerCombo.Location = new System.Drawing.Point(192, 155);
            this.customerCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerCombo.Name = "customerCombo";
            this.customerCombo.Size = new System.Drawing.Size(92, 21);
            this.customerCombo.TabIndex = 16;
            this.customerCombo.SelectedIndexChanged += new System.EventHandler(this.customerCombo_SelectedIndexChanged);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.statusLabel.Location = new System.Drawing.Point(304, 113);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 14);
            this.statusLabel.TabIndex = 17;
            this.statusLabel.Click += new System.EventHandler(this.statusLabel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(137, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "ADD NEW RENTAL";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(709, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "CONCLUDE RENTAL";
            // 
            // rentalCombo
            // 
            this.rentalCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rentalCombo.FormattingEnabled = true;
            this.rentalCombo.Location = new System.Drawing.Point(789, 65);
            this.rentalCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rentalCombo.Name = "rentalCombo";
            this.rentalCombo.Size = new System.Drawing.Size(92, 21);
            this.rentalCombo.TabIndex = 21;
            this.rentalCombo.SelectedIndexChanged += new System.EventHandler(this.rentalCombo_SelectedIndexChanged);
            // 
            // returnedDate
            // 
            this.returnedDate.Location = new System.Drawing.Point(789, 108);
            this.returnedDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.returnedDate.Name = "returnedDate";
            this.returnedDate.Size = new System.Drawing.Size(183, 20);
            this.returnedDate.TabIndex = 22;
            // 
            // extraTxt
            // 
            this.extraTxt.Location = new System.Drawing.Point(789, 149);
            this.extraTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.extraTxt.Name = "extraTxt";
            this.extraTxt.Size = new System.Drawing.Size(92, 20);
            this.extraTxt.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(658, 71);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "Rental ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(658, 109);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "Returned Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(658, 152);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 15);
            this.label12.TabIndex = 26;
            this.label12.Text = "Extra Charges (Rs)";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.returnBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.returnBtn.Location = new System.Drawing.Point(789, 186);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(115, 30);
            this.returnBtn.TabIndex = 27;
            this.returnBtn.Text = "Confirm Return";
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // reloadBtn
            // 
            this.reloadBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.reloadBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reloadBtn.Location = new System.Drawing.Point(1151, 378);
            this.reloadBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(80, 33);
            this.reloadBtn.TabIndex = 28;
            this.reloadBtn.Text = "Reload";
            this.reloadBtn.UseVisualStyleBackColor = false;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(83, 131);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 15);
            this.label13.TabIndex = 29;
            this.label13.Text = "Car Model";
            // 
            // carModTxt
            // 
            this.carModTxt.Location = new System.Drawing.Point(192, 128);
            this.carModTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carModTxt.Name = "carModTxt";
            this.carModTxt.Size = new System.Drawing.Size(92, 20);
            this.carModTxt.TabIndex = 30;
            // 
            // RentCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1296, 737);
            this.Controls.Add(this.carModTxt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.reloadBtn);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.extraTxt);
            this.Controls.Add(this.returnedDate);
            this.Controls.Add(this.rentalCombo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.customerCombo);
            this.Controls.Add(this.rentBtn);
            this.Controls.Add(this.dataGridRental);
            this.Controls.Add(this.carCombo);
            this.Controls.Add(this.feeTxt);
            this.Controls.Add(this.retDate);
            this.Controls.Add(this.pickDate);
            this.Controls.Add(this.custoNameTxt);
            this.Controls.Add(this.rentIDTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RentCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rentals";
            this.Load += new System.EventHandler(this.RentCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRental)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rentIDTxt;
        private System.Windows.Forms.TextBox custoNameTxt;
        private System.Windows.Forms.DateTimePicker pickDate;
        private System.Windows.Forms.DateTimePicker retDate;
        private System.Windows.Forms.TextBox feeTxt;
        private System.Windows.Forms.ComboBox carCombo;
        private System.Windows.Forms.DataGridView dataGridRental;
        private System.Windows.Forms.Button rentBtn;
        private System.Windows.Forms.ComboBox customerCombo;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox rentalCombo;
        private System.Windows.Forms.DateTimePicker returnedDate;
        private System.Windows.Forms.TextBox extraTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox carModTxt;
    }
}
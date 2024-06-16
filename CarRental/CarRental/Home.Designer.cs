namespace CarRental
{
    partial class Home
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
            this.carRegBtn = new System.Windows.Forms.Button();
            this.custRegBtn = new System.Windows.Forms.Button();
            this.rentBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.paymentBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            // 
            // carRegBtn
            // 
            this.carRegBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.carRegBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carRegBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.carRegBtn.Location = new System.Drawing.Point(75, 151);
            this.carRegBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carRegBtn.Name = "carRegBtn";
            this.carRegBtn.Size = new System.Drawing.Size(211, 41);
            this.carRegBtn.TabIndex = 1;
            this.carRegBtn.Text = "Cars";
            this.carRegBtn.UseVisualStyleBackColor = false;
            this.carRegBtn.Click += new System.EventHandler(this.carRegBtn_Click);
            // 
            // custRegBtn
            // 
            this.custRegBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.custRegBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custRegBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.custRegBtn.Location = new System.Drawing.Point(455, 149);
            this.custRegBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.custRegBtn.Name = "custRegBtn";
            this.custRegBtn.Size = new System.Drawing.Size(209, 43);
            this.custRegBtn.TabIndex = 2;
            this.custRegBtn.Text = "Customers";
            this.custRegBtn.UseVisualStyleBackColor = false;
            this.custRegBtn.Click += new System.EventHandler(this.custRegBtn_Click);
            // 
            // rentBtn
            // 
            this.rentBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.rentBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rentBtn.Location = new System.Drawing.Point(77, 295);
            this.rentBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rentBtn.Name = "rentBtn";
            this.rentBtn.Size = new System.Drawing.Size(209, 41);
            this.rentBtn.TabIndex = 3;
            this.rentBtn.Text = "Rentals";
            this.rentBtn.UseVisualStyleBackColor = false;
            this.rentBtn.Click += new System.EventHandler(this.rentBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Manage Cars";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(494, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Manage Customers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 272);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Manage Rentals";
            // 
            // paymentBtn
            // 
            this.paymentBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.paymentBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.paymentBtn.Location = new System.Drawing.Point(455, 295);
            this.paymentBtn.Name = "paymentBtn";
            this.paymentBtn.Size = new System.Drawing.Size(209, 41);
            this.paymentBtn.TabIndex = 7;
            this.paymentBtn.Text = "Payments";
            this.paymentBtn.UseVisualStyleBackColor = false;
            this.paymentBtn.Click += new System.EventHandler(this.paymentBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(509, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "View Payments";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.paymentBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rentBtn);
            this.Controls.Add(this.custRegBtn);
            this.Controls.Add(this.carRegBtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button carRegBtn;
        private System.Windows.Forms.Button custRegBtn;
        private System.Windows.Forms.Button rentBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button paymentBtn;
        private System.Windows.Forms.Label label5;
    }
}
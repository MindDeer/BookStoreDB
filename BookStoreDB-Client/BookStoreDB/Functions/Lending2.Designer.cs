namespace BookStoreDB.Functions
{
    partial class Lending2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lending2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDZID = new System.Windows.Forms.TextBox();
            this.tbQKID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "借书证号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "期刊编号：";
            // 
            // tbDZID
            // 
            this.tbDZID.Location = new System.Drawing.Point(131, 50);
            this.tbDZID.Name = "tbDZID";
            this.tbDZID.Size = new System.Drawing.Size(147, 21);
            this.tbDZID.TabIndex = 2;
            this.tbDZID.Text = "95002";
            // 
            // tbQKID
            // 
            this.tbQKID.Location = new System.Drawing.Point(131, 96);
            this.tbQKID.Name = "tbQKID";
            this.tbQKID.Size = new System.Drawing.Size(147, 21);
            this.tbQKID.TabIndex = 3;
            this.tbQKID.Text = "QK28001";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "借出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(37, 204);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(41, 12);
            this.lbMessage.TabIndex = 5;
            this.lbMessage.Text = "label3";
            // 
            // Lending2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 235);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbQKID);
            this.Controls.Add(this.tbDZID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lending2";
            this.Text = "期刊租出";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDZID;
        private System.Windows.Forms.TextBox tbQKID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbMessage;
    }
}
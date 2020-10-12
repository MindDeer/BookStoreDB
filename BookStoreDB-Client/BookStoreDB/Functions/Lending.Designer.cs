namespace BookStoreDB.Functions
{
    partial class Lending
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lending));
            this.label1 = new System.Windows.Forms.Label();
            this.tbDZID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTSID = new System.Windows.Forms.TextBox();
            this.btLending = new System.Windows.Forms.Button();
            this.lbMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "借书证号：";
            // 
            // tbDZID
            // 
            this.tbDZID.Location = new System.Drawing.Point(121, 38);
            this.tbDZID.Name = "tbDZID";
            this.tbDZID.Size = new System.Drawing.Size(167, 21);
            this.tbDZID.TabIndex = 1;
            this.tbDZID.Text = "95001";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "图书编号：";
            // 
            // tbTSID
            // 
            this.tbTSID.Location = new System.Drawing.Point(121, 90);
            this.tbTSID.Name = "tbTSID";
            this.tbTSID.Size = new System.Drawing.Size(167, 21);
            this.tbTSID.TabIndex = 3;
            this.tbTSID.Text = "TS27001";
            // 
            // btLending
            // 
            this.btLending.Location = new System.Drawing.Point(135, 150);
            this.btLending.Name = "btLending";
            this.btLending.Size = new System.Drawing.Size(75, 23);
            this.btLending.TabIndex = 4;
            this.btLending.Text = "借书";
            this.btLending.UseVisualStyleBackColor = true;
            this.btLending.Click += new System.EventHandler(this.btLending_Click);
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(36, 189);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(41, 12);
            this.lbMessage.TabIndex = 5;
            this.lbMessage.Text = "label3";
            // 
            // Lending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 219);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.btLending);
            this.Controls.Add(this.tbTSID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDZID);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lending";
            this.Text = "图书租出";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDZID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTSID;
        private System.Windows.Forms.Button btLending;
        private System.Windows.Forms.Label lbMessage;
    }
}
namespace NullTeam_Bank_Management
{
    partial class nullbank
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nullbank));
            this.nullbankmanagement = new System.Windows.Forms.Label();
            this.addcustomers = new System.Windows.Forms.Button();
            this.showcustomers = new System.Windows.Forms.Button();
            this.customerscontrol = new System.Windows.Forms.Panel();
            this.customerscontroltext = new System.Windows.Forms.Label();
            this.staffpanel = new System.Windows.Forms.Panel();
            this.showstaff = new System.Windows.Forms.Button();
            this.addstaff = new System.Windows.Forms.Button();
            this.stafftext = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.programmedby = new System.Windows.Forms.Label();
            this.customerscontrol.SuspendLayout();
            this.staffpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nullbankmanagement
            // 
            this.nullbankmanagement.BackColor = System.Drawing.Color.Transparent;
            this.nullbankmanagement.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nullbankmanagement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nullbankmanagement.Location = new System.Drawing.Point(78, 32);
            this.nullbankmanagement.Name = "nullbankmanagement";
            this.nullbankmanagement.Size = new System.Drawing.Size(438, 68);
            this.nullbankmanagement.TabIndex = 0;
            this.nullbankmanagement.Text = "Null Bank Management";
            // 
            // addcustomers
            // 
            this.addcustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.addcustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addcustomers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.addcustomers.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addcustomers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addcustomers.Location = new System.Drawing.Point(126, 13);
            this.addcustomers.Name = "addcustomers";
            this.addcustomers.Size = new System.Drawing.Size(197, 55);
            this.addcustomers.TabIndex = 0;
            this.addcustomers.Text = "Add Customers";
            this.addcustomers.UseVisualStyleBackColor = false;
            this.addcustomers.Click += new System.EventHandler(this.addcustomers_Click);
            // 
            // showcustomers
            // 
            this.showcustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.showcustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showcustomers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.showcustomers.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.showcustomers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.showcustomers.Location = new System.Drawing.Point(126, 74);
            this.showcustomers.Name = "showcustomers";
            this.showcustomers.Size = new System.Drawing.Size(197, 59);
            this.showcustomers.TabIndex = 1;
            this.showcustomers.Text = "Show Customers";
            this.showcustomers.UseVisualStyleBackColor = false;
            this.showcustomers.Click += new System.EventHandler(this.showcustomers_Click);
            // 
            // customerscontrol
            // 
            this.customerscontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.customerscontrol.Controls.Add(this.showcustomers);
            this.customerscontrol.Controls.Add(this.addcustomers);
            this.customerscontrol.Location = new System.Drawing.Point(37, 142);
            this.customerscontrol.Name = "customerscontrol";
            this.customerscontrol.Size = new System.Drawing.Size(459, 145);
            this.customerscontrol.TabIndex = 2;
            // 
            // customerscontroltext
            // 
            this.customerscontroltext.AutoSize = true;
            this.customerscontroltext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerscontroltext.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.customerscontroltext.Location = new System.Drawing.Point(40, 117);
            this.customerscontroltext.Name = "customerscontroltext";
            this.customerscontroltext.Size = new System.Drawing.Size(164, 22);
            this.customerscontroltext.TabIndex = 3;
            this.customerscontroltext.Text = "Customers Control:";
            // 
            // staffpanel
            // 
            this.staffpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.staffpanel.Controls.Add(this.showstaff);
            this.staffpanel.Controls.Add(this.addstaff);
            this.staffpanel.Location = new System.Drawing.Point(37, 335);
            this.staffpanel.Name = "staffpanel";
            this.staffpanel.Size = new System.Drawing.Size(459, 145);
            this.staffpanel.TabIndex = 4;
            // 
            // showstaff
            // 
            this.showstaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.showstaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showstaff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.showstaff.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.showstaff.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.showstaff.Location = new System.Drawing.Point(126, 74);
            this.showstaff.Name = "showstaff";
            this.showstaff.Size = new System.Drawing.Size(197, 59);
            this.showstaff.TabIndex = 1;
            this.showstaff.Text = "Show Staff";
            this.showstaff.UseVisualStyleBackColor = false;
            this.showstaff.Click += new System.EventHandler(this.showstaff_Click);
            // 
            // addstaff
            // 
            this.addstaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.addstaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addstaff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.addstaff.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addstaff.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addstaff.Location = new System.Drawing.Point(126, 13);
            this.addstaff.Name = "addstaff";
            this.addstaff.Size = new System.Drawing.Size(197, 55);
            this.addstaff.TabIndex = 0;
            this.addstaff.Text = "Add Staff";
            this.addstaff.UseVisualStyleBackColor = false;
            this.addstaff.Click += new System.EventHandler(this.addstaff_Click);
            // 
            // stafftext
            // 
            this.stafftext.AutoSize = true;
            this.stafftext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stafftext.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stafftext.Location = new System.Drawing.Point(40, 310);
            this.stafftext.Name = "stafftext";
            this.stafftext.Size = new System.Drawing.Size(115, 22);
            this.stafftext.TabIndex = 5;
            this.stafftext.Text = "Staff Control:";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Red;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exit.Location = new System.Drawing.Point(129, 525);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(274, 66);
            this.exit.TabIndex = 6;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // programmedby
            // 
            this.programmedby.AutoSize = true;
            this.programmedby.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.programmedby.Location = new System.Drawing.Point(184, 597);
            this.programmedby.Name = "programmedby";
            this.programmedby.Size = new System.Drawing.Size(166, 16);
            this.programmedby.TabIndex = 7;
            this.programmedby.Text = "Programmed by NullTeam";
            // 
            // nullbank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(544, 622);
            this.Controls.Add(this.programmedby);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.stafftext);
            this.Controls.Add(this.staffpanel);
            this.Controls.Add(this.customerscontroltext);
            this.Controls.Add(this.customerscontrol);
            this.Controls.Add(this.nullbankmanagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "nullbank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Null Bank Management";
            this.customerscontrol.ResumeLayout(false);
            this.staffpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nullbankmanagement;
        private System.Windows.Forms.Button showcustomers;
        private System.Windows.Forms.Button addcustomers;
        private System.Windows.Forms.Panel customerscontrol;
        private System.Windows.Forms.Label customerscontroltext;
        private System.Windows.Forms.Panel staffpanel;
        private System.Windows.Forms.Button showstaff;
        private System.Windows.Forms.Button addstaff;
        private System.Windows.Forms.Label stafftext;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label programmedby;
    }
}


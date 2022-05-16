namespace Trivago
{
    partial class Admin
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
            this.hotelid = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.offer = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.ComboBox();
            this.update_btn1 = new System.Windows.Forms.Button();
            this.insert_btn1 = new System.Windows.Forms.Button();
            this.delete_btn1 = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hotelid
            // 
            this.hotelid.FormattingEnabled = true;
            this.hotelid.Location = new System.Drawing.Point(378, 97);
            this.hotelid.Name = "hotelid";
            this.hotelid.Size = new System.Drawing.Size(143, 24);
            this.hotelid.TabIndex = 0;
            this.hotelid.SelectedIndexChanged += new System.EventHandler(this.hotelid_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hotels";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "offer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "price day";
            // 
            // offer
            // 
            this.offer.Location = new System.Drawing.Point(379, 199);
            this.offer.Name = "offer";
            this.offer.Size = new System.Drawing.Size(142, 22);
            this.offer.TabIndex = 4;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(378, 248);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(142, 22);
            this.price.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(378, 151);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(142, 22);
            this.name.TabIndex = 10;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(271, 299);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(62, 17);
            this.lab.TabIndex = 11;
            this.lab.Text = "Location";
            // 
            // location
            // 
            this.location.FormattingEnabled = true;
            this.location.Location = new System.Drawing.Point(377, 296);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(143, 24);
            this.location.TabIndex = 12;
            // 
            // update_btn1
            // 
            this.update_btn1.Location = new System.Drawing.Point(377, 382);
            this.update_btn1.Name = "update_btn1";
            this.update_btn1.Size = new System.Drawing.Size(75, 36);
            this.update_btn1.TabIndex = 16;
            this.update_btn1.Text = "update";
            this.update_btn1.UseVisualStyleBackColor = true;
            this.update_btn1.Click += new System.EventHandler(this.update_btn1_Click_1);
            // 
            // insert_btn1
            // 
            this.insert_btn1.Location = new System.Drawing.Point(221, 382);
            this.insert_btn1.Name = "insert_btn1";
            this.insert_btn1.Size = new System.Drawing.Size(75, 36);
            this.insert_btn1.TabIndex = 17;
            this.insert_btn1.Text = "insert";
            this.insert_btn1.UseVisualStyleBackColor = true;
            this.insert_btn1.Click += new System.EventHandler(this.insert_btn1_Click_1);
            // 
            // delete_btn1
            // 
            this.delete_btn1.Location = new System.Drawing.Point(582, 382);
            this.delete_btn1.Name = "delete_btn1";
            this.delete_btn1.Size = new System.Drawing.Size(75, 36);
            this.delete_btn1.TabIndex = 18;
            this.delete_btn1.Text = "delete";
            this.delete_btn1.UseVisualStyleBackColor = true;
            this.delete_btn1.Click += new System.EventHandler(this.delete_btn1_Click_1);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(0, 0);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 19;
            this.back_btn.Text = "back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.delete_btn1);
            this.Controls.Add(this.insert_btn1);
            this.Controls.Add(this.update_btn1);
            this.Controls.Add(this.location);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.price);
            this.Controls.Add(this.offer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hotelid);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox hotelid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox offer;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.ComboBox location;
        private System.Windows.Forms.Button update_btn1;
        private System.Windows.Forms.Button insert_btn1;
        private System.Windows.Forms.Button delete_btn1;
        private System.Windows.Forms.Button back_btn;
    }
}
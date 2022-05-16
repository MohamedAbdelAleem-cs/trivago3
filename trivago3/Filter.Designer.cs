
namespace Trivago
{
    partial class Filter
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
            this.radioButton_Rating = new System.Windows.Forms.RadioButton();
            this.radioButton_price = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_lower = new System.Windows.Forms.TextBox();
            this.txt_upper = new System.Windows.Forms.TextBox();
            this.btn_filter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioButton_offer = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_Rating
            // 
            this.radioButton_Rating.AutoSize = true;
            this.radioButton_Rating.Location = new System.Drawing.Point(6, 31);
            this.radioButton_Rating.Name = "radioButton_Rating";
            this.radioButton_Rating.Size = new System.Drawing.Size(70, 21);
            this.radioButton_Rating.TabIndex = 0;
            this.radioButton_Rating.TabStop = true;
            this.radioButton_Rating.Text = "Rating";
            this.radioButton_Rating.UseVisualStyleBackColor = true;
            // 
            // radioButton_price
            // 
            this.radioButton_price.AutoSize = true;
            this.radioButton_price.Location = new System.Drawing.Point(6, 58);
            this.radioButton_price.Name = "radioButton_price";
            this.radioButton_price.Size = new System.Drawing.Size(61, 21);
            this.radioButton_price.TabIndex = 1;
            this.radioButton_price.TabStop = true;
            this.radioButton_price.Text = "Price";
            this.radioButton_price.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_offer);
            this.groupBox1.Controls.Add(this.radioButton_Rating);
            this.groupBox1.Controls.Add(this.radioButton_price);
            this.groupBox1.Location = new System.Drawing.Point(97, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 109);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter Method";
            // 
            // txt_lower
            // 
            this.txt_lower.Location = new System.Drawing.Point(97, 53);
            this.txt_lower.Name = "txt_lower";
            this.txt_lower.Size = new System.Drawing.Size(100, 22);
            this.txt_lower.TabIndex = 3;
            // 
            // txt_upper
            // 
            this.txt_upper.Location = new System.Drawing.Point(231, 52);
            this.txt_upper.Name = "txt_upper";
            this.txt_upper.Size = new System.Drawing.Size(100, 22);
            this.txt_upper.TabIndex = 4;
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(359, 415);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(75, 23);
            this.btn_filter.TabIndex = 5;
            this.btn_filter.Text = "Filter";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(97, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(615, 172);
            this.dataGridView1.TabIndex = 6;
            // 
            // radioButton_offer
            // 
            this.radioButton_offer.AutoSize = true;
            this.radioButton_offer.Location = new System.Drawing.Point(6, 82);
            this.radioButton_offer.Name = "radioButton_offer";
            this.radioButton_offer.Size = new System.Drawing.Size(68, 21);
            this.radioButton_offer.TabIndex = 7;
            this.radioButton_offer.TabStop = true;
            this.radioButton_offer.Text = "Offers";
            this.radioButton_offer.UseVisualStyleBackColor = true;
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.txt_upper);
            this.Controls.Add(this.txt_lower);
            this.Controls.Add(this.groupBox1);
            this.Name = "Filter";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_Rating;
        private System.Windows.Forms.RadioButton radioButton_price;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_lower;
        private System.Windows.Forms.TextBox txt_upper;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButton_offer;
    }
}
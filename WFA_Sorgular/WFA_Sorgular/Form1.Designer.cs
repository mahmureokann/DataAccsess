namespace WFA_Sorgular
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSorgu = new System.Windows.Forms.Button();
            this.btnSorgu2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(851, 441);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSorgu
            // 
            this.btnSorgu.Location = new System.Drawing.Point(43, 44);
            this.btnSorgu.Name = "btnSorgu";
            this.btnSorgu.Size = new System.Drawing.Size(97, 50);
            this.btnSorgu.TabIndex = 1;
            this.btnSorgu.Text = "Sorgu";
            this.btnSorgu.UseVisualStyleBackColor = true;
            this.btnSorgu.Click += new System.EventHandler(this.btnSorgu_Click);
            // 
            // btnSorgu2
            // 
            this.btnSorgu2.Location = new System.Drawing.Point(169, 44);
            this.btnSorgu2.Name = "btnSorgu2";
            this.btnSorgu2.Size = new System.Drawing.Size(97, 50);
            this.btnSorgu2.TabIndex = 1;
            this.btnSorgu2.Text = "Sorgu2";
            this.btnSorgu2.UseVisualStyleBackColor = true;
            this.btnSorgu2.Click += new System.EventHandler(this.btnSorgu2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(303, 44);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(97, 50);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "Sorgu3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(435, 44);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(97, 50);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "Sorgu4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 578);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnSorgu2);
            this.Controls.Add(this.btnSorgu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSorgu;
        private System.Windows.Forms.Button btnSorgu2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
    }
}


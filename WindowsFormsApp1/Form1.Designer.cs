namespace WindowsFormsApp1
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
            this.button_D = new System.Windows.Forms.Button();
            this.button_U = new System.Windows.Forms.Button();
            this.button_R = new System.Windows.Forms.Button();
            this.button_C = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_D
            // 
            this.button_D.Location = new System.Drawing.Point(255, 12);
            this.button_D.Name = "button_D";
            this.button_D.Size = new System.Drawing.Size(75, 23);
            this.button_D.TabIndex = 7;
            this.button_D.Text = "D";
            this.button_D.UseVisualStyleBackColor = true;
            // 
            // button_U
            // 
            this.button_U.Location = new System.Drawing.Point(174, 12);
            this.button_U.Name = "button_U";
            this.button_U.Size = new System.Drawing.Size(75, 23);
            this.button_U.TabIndex = 6;
            this.button_U.Text = "U";
            this.button_U.UseVisualStyleBackColor = true;
            // 
            // button_R
            // 
            this.button_R.Location = new System.Drawing.Point(93, 12);
            this.button_R.Name = "button_R";
            this.button_R.Size = new System.Drawing.Size(75, 23);
            this.button_R.TabIndex = 5;
            this.button_R.Text = "R";
            this.button_R.UseVisualStyleBackColor = true;
            // 
            // button_C
            // 
            this.button_C.Location = new System.Drawing.Point(12, 12);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(75, 23);
            this.button_C.TabIndex = 4;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = true;
            this.button_C.Click += new System.EventHandler(this.button_C_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(89, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(610, 150);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_D);
            this.Controls.Add(this.button_U);
            this.Controls.Add(this.button_R);
            this.Controls.Add(this.button_C);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_D;
        private System.Windows.Forms.Button button_U;
        private System.Windows.Forms.Button button_R;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


namespace PresentationLayer
{
    partial class RestaurantsForm
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
            this.foundTBox = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.readBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.creaeteBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.incomeTBox = new System.Windows.Forms.TextBox();
            this.addressTBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // foundTBox
            // 
            this.foundTBox.AutoSize = true;
            this.foundTBox.Location = new System.Drawing.Point(244, 324);
            this.foundTBox.Name = "foundTBox";
            this.foundTBox.Size = new System.Drawing.Size(0, 13);
            this.foundTBox.TabIndex = 24;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(646, 356);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(115, 51);
            this.closeBtn.TabIndex = 23;
            this.closeBtn.Text = "Exit";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // readBtn
            // 
            this.readBtn.Location = new System.Drawing.Point(646, 253);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(115, 51);
            this.readBtn.TabIndex = 22;
            this.readBtn.Text = "Find";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(444, 253);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(115, 51);
            this.deleteBtn.TabIndex = 21;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(247, 253);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(115, 51);
            this.updateBtn.TabIndex = 20;
            this.updateBtn.Text = "Edit";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // creaeteBtn
            // 
            this.creaeteBtn.Location = new System.Drawing.Point(43, 253);
            this.creaeteBtn.Name = "creaeteBtn";
            this.creaeteBtn.Size = new System.Drawing.Size(115, 51);
            this.creaeteBtn.TabIndex = 19;
            this.creaeteBtn.Text = "Create";
            this.creaeteBtn.UseVisualStyleBackColor = true;
            this.creaeteBtn.Click += new System.EventHandler(this.creaeteBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(201, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 174);
            this.dataGridView1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Income";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Address";
            // 
            // incomeTBox
            // 
            this.incomeTBox.Location = new System.Drawing.Point(40, 125);
            this.incomeTBox.Name = "incomeTBox";
            this.incomeTBox.Size = new System.Drawing.Size(100, 20);
            this.incomeTBox.TabIndex = 15;
            // 
            // addressTBox
            // 
            this.addressTBox.Location = new System.Drawing.Point(40, 60);
            this.addressTBox.Name = "addressTBox";
            this.addressTBox.Size = new System.Drawing.Size(100, 20);
            this.addressTBox.TabIndex = 14;
            // 
            // Restaurants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.foundTBox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.readBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.creaeteBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.incomeTBox);
            this.Controls.Add(this.addressTBox);
            this.Name = "Restaurants";
            this.Text = "Restaurants";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label foundTBox;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button creaeteBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox incomeTBox;
        private System.Windows.Forms.TextBox addressTBox;
    }
}
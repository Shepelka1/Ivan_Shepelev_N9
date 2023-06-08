namespace PresentationLayer
{
    partial class MainForm
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
            this.clientsBtn = new System.Windows.Forms.Button();
            this.reservationsBtn = new System.Windows.Forms.Button();
            this.restaurantsBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientsBtn
            // 
            this.clientsBtn.Location = new System.Drawing.Point(138, 64);
            this.clientsBtn.Name = "clientsBtn";
            this.clientsBtn.Size = new System.Drawing.Size(170, 285);
            this.clientsBtn.TabIndex = 0;
            this.clientsBtn.Text = "Clients";
            this.clientsBtn.UseVisualStyleBackColor = true;
            this.clientsBtn.Click += new System.EventHandler(this.clientsBtn_Click);
            // 
            // reservationsBtn
            // 
            this.reservationsBtn.Location = new System.Drawing.Point(314, 64);
            this.reservationsBtn.Name = "reservationsBtn";
            this.reservationsBtn.Size = new System.Drawing.Size(170, 285);
            this.reservationsBtn.TabIndex = 1;
            this.reservationsBtn.Text = "Reservations";
            this.reservationsBtn.UseVisualStyleBackColor = true;
            // 
            // restaurantsBtn
            // 
            this.restaurantsBtn.Location = new System.Drawing.Point(490, 64);
            this.restaurantsBtn.Name = "restaurantsBtn";
            this.restaurantsBtn.Size = new System.Drawing.Size(170, 285);
            this.restaurantsBtn.TabIndex = 2;
            this.restaurantsBtn.Text = "Restaurants";
            this.restaurantsBtn.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(657, 382);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(131, 56);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "Exit";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.restaurantsBtn);
            this.Controls.Add(this.reservationsBtn);
            this.Controls.Add(this.clientsBtn);
            this.Name = "MainForm";
            this.Text = "Hotel DB";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clientsBtn;
        private System.Windows.Forms.Button reservationsBtn;
        private System.Windows.Forms.Button restaurantsBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}


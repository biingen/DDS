namespace DDS
{
    partial class CAN_Write
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
            this.Before_value = new System.Windows.Forms.TextBox();
            this.After_value = new System.Windows.Forms.TextBox();
            this.Gear_engaged = new System.Windows.Forms.TextBox();
            this.Vehicle_speed = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Before_value
            // 
            this.Before_value.Location = new System.Drawing.Point(23, 27);
            this.Before_value.Name = "Before_value";
            this.Before_value.Size = new System.Drawing.Size(142, 22);
            this.Before_value.TabIndex = 0;
            this.Before_value.Text = "FFFFFFFFFFFFFFFF";
            // 
            // After_value
            // 
            this.After_value.Location = new System.Drawing.Point(23, 66);
            this.After_value.Name = "After_value";
            this.After_value.Size = new System.Drawing.Size(142, 22);
            this.After_value.TabIndex = 1;
            // 
            // Gear_engaged
            // 
            this.Gear_engaged.Location = new System.Drawing.Point(192, 27);
            this.Gear_engaged.Name = "Gear_engaged";
            this.Gear_engaged.Size = new System.Drawing.Size(65, 22);
            this.Gear_engaged.TabIndex = 2;
            this.Gear_engaged.Text = "6";
            // 
            // Vehicle_speed
            // 
            this.Vehicle_speed.Location = new System.Drawing.Point(192, 66);
            this.Vehicle_speed.Name = "Vehicle_speed";
            this.Vehicle_speed.Size = new System.Drawing.Size(65, 22);
            this.Vehicle_speed.TabIndex = 3;
            this.Vehicle_speed.Text = "200";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CAN_Write
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 452);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Vehicle_speed);
            this.Controls.Add(this.Gear_engaged);
            this.Controls.Add(this.After_value);
            this.Controls.Add(this.Before_value);
            this.Name = "CAN_Write";
            this.Text = "CAN_Write";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Before_value;
        private System.Windows.Forms.TextBox After_value;
        private System.Windows.Forms.TextBox Gear_engaged;
        private System.Windows.Forms.TextBox Vehicle_speed;
        private System.Windows.Forms.Button button1;
    }
}
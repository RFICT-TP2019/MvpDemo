namespace Demo
{
    partial class BuildingView
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
            this.btn_SetUp = new System.Windows.Forms.Button();
            this.lbl_numberOfFloors = new System.Windows.Forms.Label();
            this.gb_Floors = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_SetUp
            // 
            this.btn_SetUp.Location = new System.Drawing.Point(263, 16);
            this.btn_SetUp.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SetUp.Name = "btn_SetUp";
            this.btn_SetUp.Size = new System.Drawing.Size(100, 28);
            this.btn_SetUp.TabIndex = 0;
            this.btn_SetUp.Text = "Set Up";
            this.btn_SetUp.UseVisualStyleBackColor = true;
            this.btn_SetUp.Click += new System.EventHandler(this.btn_SetUp_Click);
            // 
            // lbl_numberOfFloors
            // 
            this.lbl_numberOfFloors.AutoSize = true;
            this.lbl_numberOfFloors.Location = new System.Drawing.Point(17, 16);
            this.lbl_numberOfFloors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numberOfFloors.Name = "lbl_numberOfFloors";
            this.lbl_numberOfFloors.Size = new System.Drawing.Size(0, 17);
            this.lbl_numberOfFloors.TabIndex = 1;
            // 
            // gb_Floors
            // 
            this.gb_Floors.Location = new System.Drawing.Point(21, 71);
            this.gb_Floors.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Floors.Name = "gb_Floors";
            this.gb_Floors.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Floors.Size = new System.Drawing.Size(341, 501);
            this.gb_Floors.TabIndex = 2;
            this.gb_Floors.TabStop = false;
            this.gb_Floors.Text = "Floors";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 599);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(390, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_Status
            // 
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(0, 17);
            // 
            // BuildingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 621);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gb_Floors);
            this.Controls.Add(this.lbl_numberOfFloors);
            this.Controls.Add(this.btn_SetUp);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BuildingView";
            this.Text = "Building";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SetUp;
        private System.Windows.Forms.Label lbl_numberOfFloors;
        private System.Windows.Forms.GroupBox gb_Floors;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Status;
    }
}
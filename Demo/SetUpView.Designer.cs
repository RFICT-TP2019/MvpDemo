namespace Demo
{
    partial class SetUpView
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
            this.tb_NumberOfFloors = new System.Windows.Forms.TextBox();
            this.btn_SetUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_NumberOfFloors
            // 
            this.tb_NumberOfFloors.Location = new System.Drawing.Point(21, 34);
            this.tb_NumberOfFloors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_NumberOfFloors.Name = "tb_NumberOfFloors";
            this.tb_NumberOfFloors.Size = new System.Drawing.Size(196, 22);
            this.tb_NumberOfFloors.TabIndex = 0;
            // 
            // btn_SetUp
            // 
            this.btn_SetUp.Location = new System.Drawing.Point(227, 31);
            this.btn_SetUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SetUp.Name = "btn_SetUp";
            this.btn_SetUp.Size = new System.Drawing.Size(100, 28);
            this.btn_SetUp.TabIndex = 1;
            this.btn_SetUp.Text = "Set Up";
            this.btn_SetUp.UseVisualStyleBackColor = true;
            this.btn_SetUp.Click += new System.EventHandler(this.btn_SetUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество этажей";
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Location = new System.Drawing.Point(21, 68);
            this.lbl_Error.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(0, 17);
            this.lbl_Error.TabIndex = 3;
            // 
            // SetUpView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 103);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SetUp);
            this.Controls.Add(this.tb_NumberOfFloors);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(358, 150);
            this.MinimumSize = new System.Drawing.Size(358, 150);
            this.Name = "SetUpView";
            this.Text = "Building set up window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_NumberOfFloors;
        private System.Windows.Forms.Button btn_SetUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Error;
    }
}


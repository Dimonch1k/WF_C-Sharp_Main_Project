namespace MainProject
{
    partial class Form_Start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            start_label = new Label();
            SuspendLayout();
            // 
            // start_label
            // 
            start_label.AutoSize = true;
            start_label.Font = new Font("Verdana", 72F, FontStyle.Regular, GraphicsUnit.Point, 204);
            start_label.Location = new Point(297, 82);
            start_label.Name = "start_label";
            start_label.Size = new Size(673, 116);
            start_label.TabIndex = 0;
            start_label.Text = "START GAME";
            // 
            // Form_Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(start_label);
            Name = "Form_Start";
            Text = "Form_Start";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label start_label;
    }
}

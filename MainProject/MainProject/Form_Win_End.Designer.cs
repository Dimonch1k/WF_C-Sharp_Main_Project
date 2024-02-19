namespace MainProject
{
    partial class Form_Win_End
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
            winner_label = new Label();
            end_game_label = new Label();
            SuspendLayout();
            // 
            // winner_label
            // 
            winner_label.AutoSize = true;
            winner_label.Font = new Font("Verdana", 72F, FontStyle.Italic, GraphicsUnit.Point, 204);
            winner_label.Location = new Point(221, 64);
            winner_label.Name = "winner_label";
            winner_label.Size = new Size(456, 116);
            winner_label.TabIndex = 0;
            winner_label.Text = "WINNER";
            // 
            // end_game_label
            // 
            end_game_label.AccessibleRole = AccessibleRole.IpAddress;
            end_game_label.AutoSize = true;
            end_game_label.Font = new Font("Verdana", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            end_game_label.Location = new Point(194, 501);
            end_game_label.Name = "end_game_label";
            end_game_label.Size = new Size(619, 116);
            end_game_label.TabIndex = 1;
            end_game_label.Text = "END GAME";
            // 
            // Form_Win_End
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(end_game_label);
            Controls.Add(winner_label);
            Name = "Form_Win_End";
            Text = "Form_Winner_End";
            Load += Form_Win_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label winner_label;
        private Label end_game_label;
    }
}
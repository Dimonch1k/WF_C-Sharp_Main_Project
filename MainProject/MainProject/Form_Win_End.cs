namespace MainProject
{
    public partial class Form_Win_End : Form
    {
        public Form_Win_End()
        {
            InitializeComponent();
        }

        private void Form_Win_Load(object sender, EventArgs e)
        {

        }



        public void Label_End_Game()
        {
            end_game_label.Text = "END GAME";
            end_game_label.BackColor = Color.OrangeRed;
            end_game_label.ForeColor = Color.Black;
            end_game_label.Left = (this.ClientSize.Width - end_game_label.Size.Width) / 2;
            end_game_label.Top = (this.ClientSize.Height - end_game_label.Size.Height) * 13 / 10;
            end_game_label.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}

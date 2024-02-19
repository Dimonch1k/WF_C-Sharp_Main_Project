namespace MainProject
{
    public partial class Form_Start : Form
    {
        public Form_Start()
        {
            InitializeComponent();

            Create_Label_Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void Create_Label_Start()
        {
            start_label.BackColor = Color.DarkOrange;
            start_label.ForeColor = Color.Black;
            start_label.Left = (this.ClientSize.Width - start_label.Size.Width) / 2;
            start_label.Top = (this.ClientSize.Height - start_label.Size.Height) / 20;
            start_label.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void start_label_Click(object sender, EventArgs e)
        {
        }
    }
}

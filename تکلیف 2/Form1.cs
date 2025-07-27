namespace تکلیف_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Removeblanks(string txt)
        {
            if (txt != "")
            {
                txt = Convert.ToString(txt);
                int i = txt.IndexOf(" ");
                while (i >= 0)
                {
                    txt = txt.Remove(i, 1);
                    i = txt.IndexOf(" ");
                }
            }
            return txt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(Removeblanks(textBox1.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
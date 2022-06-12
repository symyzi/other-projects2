namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            string[] strings = str.Split(' ');
            for (int i = 0; i < strings.Length; i++)
            {
                char[] chars = strings[i].ToCharArray();
                char temp = chars[0];
                chars[0] = chars[chars.Length-1];
                chars[chars.Length-1] = temp;
                string s = new string(chars);
                strings[i] = s;
            }
            string p = string.Join(" ", strings);
            label1.Text = "result:" + p;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
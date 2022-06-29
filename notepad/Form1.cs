namespace notepad
{
    public partial class Form1 : Form
    {
        public string? fileName;

        public Form1()
        {
            InitializeComponent();
            fileName = String.Empty;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName==String.Empty)
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else 
            {
                File.WriteAllText(fileName, richTextBox1.Text);
            }
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = openFileDialog1.ShowDialog();
            if(DialogResult == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                Text = fileName;
                File.ReadAllText(fileName);
                richTextBox1.Text = File.ReadAllText(fileName);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult=saveFileDialog1.ShowDialog();
            if (DialogResult!=DialogResult.Abort && DialogResult != DialogResult.None && DialogResult != DialogResult.Cancel)
            {
                fileName = saveFileDialog1.FileName;
                Text = fileName;
            }
            if (DialogResult == DialogResult.OK)
            {
                File.WriteAllText(fileName, richTextBox1.Text);
            }
        }
    }
}
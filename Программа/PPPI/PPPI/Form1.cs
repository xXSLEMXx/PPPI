namespace PPPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //������ ���� � ������� ��������� ����.
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        //������ ���� � �������� ���������� ��� �������������� ����.
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }

        //������ ���� � �����������.
        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.ShowDialog();
        }

        //����� �� ����.
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
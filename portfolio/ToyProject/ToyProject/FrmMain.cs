namespace ToyProject
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnTakeOut_Click(object sender, EventArgs e)   // ����ũ�ƿ��̳� ���忡�� �Ļ��ư�� ������ �޴���ư���� �Ѿ
        {
            FrmMenu menuForm = new FrmMenu();
            menuForm.ShowDialog();
        }

        private void BtnHere_Click(object sender, EventArgs e)
        {
            FrmMenu menuForm = new FrmMenu();
            menuForm.ShowDialog();
        }
    }
}

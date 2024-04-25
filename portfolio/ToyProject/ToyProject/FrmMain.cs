namespace ToyProject
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnTakeOut_Click(object sender, EventArgs e)   // 테이크아웃이나 매장에서 식사버튼을 누르면 메뉴버튼으로 넘어감
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

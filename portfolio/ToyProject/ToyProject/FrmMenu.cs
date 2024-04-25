using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToyProject.Properties;

namespace ToyProject
{
    public partial class FrmMenu : Form
    {
        private int totalPrice;

        public FrmMenu()
        {

            InitializeComponent();
            totalPrice = 0;

            InitButtons();
        }

        private void InitButtons()
        {
            SetBugger();
        }

        void SetBugger()
        {
            BtnMenu01.Image = Resources.HB01;
            BtnMenu02.Image = Resources.HB02;
            BtnMenu03.Image = Resources.HB03;
            BtnMenu04.Image = Resources.HB04;
            BtnMenu05.Image = Resources.HB05;
            BtnMenu06.Image = Resources.HB06;
            BtnMenu01.Text = "빅맥";
            BtnMenu02.Text = "상하이스파이시버거";
            BtnMenu03.Text = "더블불고기버거";
            BtnMenu04.Text = "베이컨토마토디럭스";
            BtnMenu05.Text = "슈비버거";
            BtnMenu06.Text = "맥치킨모짜렐라";
            BtnMenu01.Tag = "BMB|6300"; //가격
            BtnMenu02.Tag = "SHB|6300";
            BtnMenu01.Tag = "DDB|5400";
            BtnMenu01.Tag = "BTB|6600";
            BtnMenu01.Tag = "SBB|6600"; 
            BtnMenu01.Tag = "MCB|5800";
        }
        private void SetDrink()
        {
            BtnMenu01.Image = Resources.BV01;
            BtnMenu02.Image = Resources.BV02;
            BtnMenu03.Image = Resources.BV03;
            BtnMenu04.Image = Resources.BV04;
            BtnMenu05.Image = Resources.BV05;
            BtnMenu06.Image = Resources.BV06;
            BtnMenu01.Text = "코카콜라";
            BtnMenu02.Text = "코카콜라제로";
            BtnMenu03.Text = "스프라이트";
            BtnMenu04.Text = "환타";
            BtnMenu05.Text = "바닐라쉐이크";
            BtnMenu06.Text = "딸기쉐이크";
            BtnMenu01.Tag = "COC|1900"; //가격
            BtnMenu02.Tag = "COZ|2200";
            BtnMenu03.Tag = "SPT|1900";
            BtnMenu04.Tag = "FNT|1900";
            BtnMenu05.Tag = "VSK|2500";
            BtnMenu06.Tag = "SSK|2500";
        }
        private void Setside()
        {
            BtnMenu01.Image = Resources.SD01;
            BtnMenu02.Image = Resources.SD02;
            BtnMenu03.Image = Resources.SD03;
            BtnMenu04.Image = Resources.SD04;
            BtnMenu05.Image = Resources.SD05;
            BtnMenu06.Image = Resources.SD06;
            BtnMenu01.Text = "맥윙";
            BtnMenu02.Text = "맥윙콤보";
            BtnMenu03.Text = "코울슬로";
            BtnMenu04.Text = "상하이치킨스낵랩";
            BtnMenu05.Text = "골드모짜렐라치즈스틱";
            BtnMenu06.Text = "후렌치후라이";
            BtnMenu01.Tag = "MCW|4200"; //가격
            BtnMenu02.Tag = "MCC|5200";
            BtnMenu03.Tag = "CLS|2700";
            BtnMenu04.Tag = "SCS|3800";
            BtnMenu05.Tag = "GMC|5000";
            BtnMenu06.Tag = "FCF|3000";
        }

        // 각 버거를 클릭했을 때 발생하는 이벤트 핸들러

        private void BtnMenu01_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string tagString = btn.Tag.ToString();
            int price = Convert.ToInt32(tagString.Split('|').Last());
            string menuName = btn.Text;

            // 리스트박스에 메뉴 이름과 가격 추가
            PriceList.Items.Add($"{menuName}: {price}원");

            // 총 가격 업데이트
            totalPrice += price;

        }

        private void BtnMenu02_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string tagString = btn.Tag.ToString();
            int price = Convert.ToInt32(tagString.Split('|').Last());
            string menuName = btn.Text;

            // 리스트박스에 메뉴 이름과 가격 추가
            PriceList.Items.Add($"{menuName}: {price}원");

            // 총 가격 업데이트
            totalPrice += price;
        }

        private void BtnMenu03_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string tagString = btn.Tag.ToString();
            int price = Convert.ToInt32(tagString.Split('|').Last());
            string menuName = btn.Text;

            // 리스트박스에 메뉴 이름과 가격 추가
            PriceList.Items.Add($"{menuName}: {price}원");

            // 총 가격 업데이트
            totalPrice += price;
        }

        private void BtnMenu04_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string tagString = btn.Tag.ToString();
            int price = Convert.ToInt32(tagString.Split('|').Last());
            string menuName = btn.Text;

            // 리스트박스에 메뉴 이름과 가격 추가
            PriceList.Items.Add($"{menuName}: {price}원");

            // 총 가격 업데이트
            totalPrice += price;
        }

        private void BtnMenu05_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string tagString = btn.Tag.ToString();
            int price = Convert.ToInt32(tagString.Split('|').Last());
            string menuName = btn.Text;

            // 리스트박스에 메뉴 이름과 가격 추가
            PriceList.Items.Add($"{menuName}: {price}원");

            // 총 가격 업데이트
            totalPrice += price;
        }

        private void BtnMenu06_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string tagString = btn.Tag.ToString();
            int price = Convert.ToInt32(tagString.Split('|').Last());
            string menuName = btn.Text;

            // 리스트박스에 메뉴 이름과 가격 추가
            PriceList.Items.Add($"{menuName}: {price}원");

            // 총 가격 업데이트
            totalPrice += price;
        }
        private void MnuBurger_Click(object sender, EventArgs e)
        {
            SetBugger();
        }

        private void MnuDrink_Click(object sender, EventArgs e)
        {
            SetDrink();
        }

        private void MnuSide_Click(object sender, EventArgs e)
        {
            Setside();
        }
        private void BtnPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"총 가격: {totalPrice}원", "결제", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}


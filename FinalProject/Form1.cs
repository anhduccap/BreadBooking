using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            HomePanel.BringToFront();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            HomePanel.BringToFront();
        }

        private void btn_mainOrder_Click(object sender, EventArgs e)
        {
            MenuPanel.BringToFront();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            DialogResult ExitResult = MessageBox.Show("Bạn muốn thoát chương trình?","Thông báo", MessageBoxButtons.YesNo);
            if (ExitResult == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_paymentReject_Click(object sender, EventArgs e)
        {
            DialogResult payResult = MessageBox.Show("Bạn có chắc chắn muốn hủy giao dịch này?", "Thông báo", MessageBoxButtons.YesNo);
            if(payResult == DialogResult.Yes)
                PaymentPanel.Visible = false;
        }

        private void btn_paymentAccept_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mua thành công!", "Thông báo");
            PaymentPanel.Visible = false;
        }

        private void getText(string type)
        {
            BM_Base newBread;
            switch (type)
            {
                case "BoTieuDen":
                    newBread = new BM_BoTieuDen();
                    break;
                case "ChaCa":
                    newBread = new BM_ChaCa();
                    break;
                case "GaCay":
                    newBread = new BM_GaCay();
                    break;
                case "GaNuongMatOng":
                    newBread = new BM_GaNuongMatOng();
                    break;
                case "GaSotNhat":
                    newBread = new BM_GaSotNhat();
                    break;
                case "HeoQuay":
                    newBread = new BM_HeoQuay();
                    break;
                case "BoSotNam":
                    newBread = new BM_BoSotNam();
                    break;
                case "Trung":
                    newBread = new BM_Trung();
                    break;
                case "ThapCam":
                    newBread = new BM_ThapCam();
                    break;
                default:
                    newBread = null;
                    break;
            }

            label_payment_name_input.Text = newBread.getName();
            label_payment_MainIngredient_input.Text = newBread.getMainIngredient();
            label_payment_sauce_input.Text = newBread.getSauce();
            label_payment_toppings_input1.Text = newBread.getToppings()[0];
            label_payment_toppings_input2.Text = newBread.getToppings()[1];
            label_payment_toppings_input3.Text = newBread.getToppings()[2];
            label_payment_price_input.Text = Convert.ToString(newBread.getPrice());
        }

        private void btn_BoTieuDen_Click(object sender, EventArgs e)
        {

            getText("BoTieuDen");
            PaymentPanel.Visible = true;
        }

        private void btn_ChaCa_Click(object sender, EventArgs e)
        {
            getText("ChaCa");
            PaymentPanel.Visible = true;
        }

        private void btn_GaNuongMatOng_Click(object sender, EventArgs e)
        {
            getText("GaNuongMatOng");
            PaymentPanel.Visible = true;
        }


        private void btn_GaSotNhat_Click(object sender, EventArgs e)
        {
            getText("GaSotNhat");
            PaymentPanel.Visible = true;
        }

        private void btn_HeoQuay_Click(object sender, EventArgs e)
        {
            getText("HeoQuay");
            PaymentPanel.Visible = true;
        }

        private void btn_BoSotNam_Click(object sender, EventArgs e)
        {
            getText("BoSotNam");
            PaymentPanel.Visible = true;
        }

        private void btn_Trung_Click(object sender, EventArgs e)
        {
            getText("Trung");
            PaymentPanel.Visible = true;
        }

        private void btn_GaCay_Click(object sender, EventArgs e)
        {
            getText("GaCay");
            PaymentPanel.Visible = true;
        }

        private void btn_ThapCam_Click(object sender, EventArgs e)
        {
            getText("ThapCam");
            PaymentPanel.Visible = true;
        }
    }
}

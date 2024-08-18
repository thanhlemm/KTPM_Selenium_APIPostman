using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NUnit_32_ThanhLam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_32_bptong_Click(object sender, EventArgs e)
        {
            int a, b;
            double kq;
            a = int.Parse(txt_32_soA.Text);
            b = int.Parse(txt_32_soB.Text);
            Calculation_32_Lam c = new Calculation_32_Lam(a, b);
            kq = c.Excute_32_Lam("(A+B)^2");
            txt_bptong_32_Lam.Text = kq.ToString();
        }

        private void btn_32_bphieu_Click(object sender, EventArgs e)
        {
            int a, b;
            double kq;
            a = int.Parse(txt_32_soA.Text);
            b = int.Parse(txt_32_soB.Text);
            Calculation_32_Lam c = new Calculation_32_Lam(a, b);
            kq = c.Excute_32_Lam("(A-B)^2");
            txt_bphieu_32_Lam.Text = kq.ToString();
        }

        private void btn_32_hieu2bp_Click(object sender, EventArgs e)
        {
            int a, b;
            double kq;
            a = int.Parse(txt_32_soA.Text);
            b = int.Parse(txt_32_soB.Text);
            Calculation_32_Lam c = new Calculation_32_Lam(a, b);
            kq = c.Excute_32_Lam("A^2 - B^2");
            txt_hieu2bp_32_Lam.Text = kq.ToString();
        }

        private void btn_32_lptong_Click(object sender, EventArgs e)
        {
            int a, b;
            double kq;
            a = int.Parse(txt_32_soA.Text);
            b = int.Parse(txt_32_soB.Text);
            Calculation_32_Lam c = new Calculation_32_Lam(a, b);
            kq = c.Excute_32_Lam("(A+B)^3");
            txt_lptong_32_Lam.Text = kq.ToString();
        }

        private void btn_32_lphieu_Click(object sender, EventArgs e)
        {
            int a, b;
            double kq;
            a = int.Parse(txt_32_soA.Text);
            b = int.Parse(txt_32_soB.Text);
            Calculation_32_Lam c = new Calculation_32_Lam(a, b);
            kq = c.Excute_32_Lam("(A-B)^3");
            txt_lphieu_32_Lam.Text = kq.ToString();
        }

        

        private void btn_32_tong2lp_Click(object sender, EventArgs e)
        {
            int a, b;
            double kq;
            a = int.Parse(txt_32_soA.Text);
            b = int.Parse(txt_32_soB.Text);
            Calculation_32_Lam c = new Calculation_32_Lam(a, b);
            kq = c.Excute_32_Lam("A^3 + B^3");
            txt_tong2lp_32_Lam.Text = kq.ToString();
           
        }

        private void btn_32_hieu2lp_Click(object sender, EventArgs e)
        {
            int a, b;
            double kq;
            a = int.Parse(txt_32_soA.Text);
            b = int.Parse(txt_32_soB.Text);
            Calculation_32_Lam c = new Calculation_32_Lam(a, b);
            kq = c.Excute_32_Lam("A^3 - B^3");
            txt_hieu2lp_32_Lam.Text = kq.ToString();
        }

        private void btn_cacKQ_32_Lam_Click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(txt_32_soA.Text);
            b = int.Parse(txt_32_soB.Text);
            Calculation_32_Lam c = new Calculation_32_Lam(a, b);

            //Bình phương tổng
            double kq_bptong_32_Lam;
            kq_bptong_32_Lam = c.Excute_32_Lam("(A+B)^2");
            txt_bptong_32_Lam.Text = kq_bptong_32_Lam.ToString();

            //Bình phương hiệu
            double kq_bphieu_32_Lam;
            kq_bphieu_32_Lam = c.Excute_32_Lam("(A-B)^2");
            txt_bphieu_32_Lam.Text = kq_bphieu_32_Lam.ToString();

            //Hiệu 2 bình phương
            double kq_hieu2bp_32_Lam;
            kq_hieu2bp_32_Lam = c.Excute_32_Lam("A^2 - B^2");
            txt_hieu2bp_32_Lam.Text = kq_hieu2bp_32_Lam.ToString();

            //Lập phương tổng
            double kq_lptong_32_Lam;
            kq_lptong_32_Lam = c.Excute_32_Lam("(A+B)^3");
            txt_lptong_32_Lam.Text = kq_lptong_32_Lam.ToString();

            //Lập phương hiệu
            double kq_lphieu_32_Lam;
            kq_lphieu_32_Lam = c.Excute_32_Lam("(A-B)^3");
            txt_lphieu_32_Lam.Text = kq_lphieu_32_Lam.ToString();

            //Tổng 2 lập phương
            double kq_tong2lp_32_Lam;
            kq_tong2lp_32_Lam = c.Excute_32_Lam("A^3 + B^3");
            txt_tong2lp_32_Lam.Text = kq_tong2lp_32_Lam.ToString();

            //Hiệu 2 lập phương
            double kq_hieu2lp_32_Lam;
            kq_hieu2lp_32_Lam = c.Excute_32_Lam("A^3 - B^3");
            txt_hieu2lp_32_Lam.Text = kq_hieu2lp_32_Lam.ToString();

        }

        
    }
}

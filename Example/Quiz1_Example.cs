using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class Quiz1_Example : Form
    {
        public Quiz1_Example()
        {
            InitializeComponent();
        }

        // THINGS TO CHECK / FIX:
        // LAGYAN NG VARIABLES IMBIS REKTA COMPUTE TAS ASSIGN SA TEXT
        // 
        // NOTE: Pinduten lang compute button if may value na lahat ng textbox sa lec units pati lab units para indi mag error
        // - Sa dalawang button na clear, pede ding i set variables back to 0 para mag reset talaga ung program

        double CompLabFee = 0;
        double SAPFee = 2000;
        double CISCOLabFee = 4500;
        double ExamBookletFee = 450;


        private void Lesson3_Activity_Load(object sender, EventArgs e)
        {
            // extra
            StudYearLevel.Items.Add("1st Year");
            StudYearLevel.Items.Add("2nd Year");
            StudYearLevel.Items.Add("3rd Year");
            StudYearLevel.Items.Add("4th Year");

            StudScholar.Items.Add("Academic Scholar");
            StudScholar.Items.Add("None");

            // question 2 a.
            StudProgram.Items.Add("BS Information Technology");
            StudProgram.Items.Add("BS Computer Engineering");
            StudProgram.Items.Add("BS Electrical Engineering");
            StudProgram.Items.Add("BS Computer Science");
            StudProgram.Items.Add("BS Mechanical Engineering");
            StudProgram.Items.Add("BS Industrial Engineering");


            // set other school fees
            textBox6.Text = CompLabFee.ToString();
            textBox5.Text = SAPFee.ToString();
            textBox8.Text = CISCOLabFee.ToString();
            textBox7.Text = ExamBookletFee.ToString();

            // m.
            StudMode.Items.Add("Installment");
            textBox13.Text = "Installment";
            textBox11.Text = "8000";
        }

        // question 2b.        
        private void LecU1_TextChanged(object sender, EventArgs e)
        {
            if (LecU1.Text != "" && LabU1.Text != "")
            {
                CU1.Text = (Convert.ToInt32(LecU1.Text) + Convert.ToInt32(LabU1.Text)).ToString();
            }
        }

        private void LabU1_TextChanged(object sender, EventArgs e)
        {
            if (LecU1.Text != "" && LabU1.Text != "")
            {
                CU1.Text = (Convert.ToInt32(LecU1.Text) + Convert.ToInt32(LabU1.Text)).ToString();
            }
        }

        private void LecU2_TextChanged(object sender, EventArgs e)
        {
            if (LecU2.Text != "" && LabU2.Text != "")
            {
                CU2.Text = (Convert.ToInt32(LecU2.Text) + Convert.ToInt32(LabU2.Text)).ToString();
            }
        }

        private void LabU2_TextChanged(object sender, EventArgs e)
        {
            if (LecU2.Text != "" && LabU2.Text != "")
            {
                CU2.Text = (Convert.ToInt32(LecU2.Text) + Convert.ToInt32(LabU2.Text)).ToString();
            }
        }

        private void LecU3_TextChanged(object sender, EventArgs e)
        {
            if (LecU3.Text != "" && LabU3.Text != "")
            {
                CU3.Text = (Convert.ToInt32(LecU3.Text) + Convert.ToInt32(LabU3.Text)).ToString();
            }
        }

        private void LabU3_TextChanged(object sender, EventArgs e)
        {
            if (LecU3.Text != "" && LabU3.Text != "")
            {
                CU3.Text = (Convert.ToInt32(LecU3.Text) + Convert.ToInt32(LabU3.Text)).ToString();
            }
        }

        private void LecU4_TextChanged(object sender, EventArgs e)
        {
            if (LecU4.Text != "" && LabU4.Text != "")
            {
                CU4.Text = (Convert.ToInt32(LecU4.Text) + Convert.ToInt32(LabU4.Text)).ToString();
            }
        }

        private void LabU4_TextChanged(object sender, EventArgs e)
        {
            if (LecU4.Text != "" && LabU4.Text != "")
            {
                CU4.Text = (Convert.ToInt32(LecU4.Text) + Convert.ToInt32(LabU4.Text)).ToString();
            }
        }

        private void LecU5_TextChanged(object sender, EventArgs e)
        {
            if (LecU5.Text != "" && LabU5.Text != "")
            {
                CU5.Text = (Convert.ToInt32(LecU5.Text) + Convert.ToInt32(LabU5.Text)).ToString();
            }
        }

        private void LabU5_TextChanged(object sender, EventArgs e)
        {
            if (LecU5.Text != "" && LabU5.Text != "")
            {
                CU5.Text = (Convert.ToInt32(LecU5.Text) + Convert.ToInt32(LabU5.Text)).ToString();
            }
        }

        private void LecU6_TextChanged(object sender, EventArgs e)
        {
            if (LecU6.Text != "" && LabU6.Text != "")
            {
                CU6.Text = (Convert.ToInt32(LecU6.Text) + Convert.ToInt32(LabU6.Text)).ToString();
            }
        }

        private void LabU6_TextChanged(object sender, EventArgs e)
        {
            if (LecU6.Text != "" && LabU6.Text != "")
            {
                CU6.Text = (Convert.ToInt32(LecU6.Text) + Convert.ToInt32(LabU6.Text)).ToString();
            }
        }

        private void LecU7_TextChanged(object sender, EventArgs e)
        {
            if (LecU7.Text != "" && LabU7.Text != "")
            {
                CU7.Text = (Convert.ToInt32(LecU7.Text) + Convert.ToInt32(LabU7.Text)).ToString();
            }
        }

        private void LabU7_TextChanged(object sender, EventArgs e)
        {
            if (LecU7.Text != "" && LabU7.Text != "")
            {
                CU7.Text = (Convert.ToInt32(LecU7.Text) + Convert.ToInt32(LabU7.Text)).ToString();
            }
        }

        private void CU7_TextChanged(object sender, EventArgs e)
        {
            if (CU7.Text != "" && CU6.Text != "" && CU5.Text != "" && CU4.Text != "" && CU3.Text != "" && CU2.Text != "" && CU1.Text != "")
            {
                txtbox_totalcreditunit.Text = (Convert.ToInt32(CU1.Text) + Convert.ToInt32(CU2.Text) + Convert.ToInt32(CU3.Text) + Convert.ToInt32(CU4.Text) + Convert.ToInt32(CU5.Text) + Convert.ToInt32(CU6.Text) + Convert.ToInt32(CU7.Text)).ToString();
            }
        }

        private void CU6_TextChanged(object sender, EventArgs e)
        {
            if (CU7.Text != "" && CU6.Text != "" && CU5.Text != "" && CU4.Text != "" && CU3.Text != "" && CU2.Text != "" && CU1.Text != "")
            {
                txtbox_totalcreditunit.Text = (Convert.ToInt32(CU1.Text) + Convert.ToInt32(CU2.Text) + Convert.ToInt32(CU3.Text) + Convert.ToInt32(CU4.Text) + Convert.ToInt32(CU5.Text) + Convert.ToInt32(CU6.Text) + Convert.ToInt32(CU7.Text)).ToString();
            }
        }

        private void CU5_TextChanged(object sender, EventArgs e)
        {
            if (CU7.Text != "" && CU6.Text != "" && CU5.Text != "" && CU4.Text != "" && CU3.Text != "" && CU2.Text != "" && CU1.Text != "")
            {
                txtbox_totalcreditunit.Text = (Convert.ToInt32(CU1.Text) + Convert.ToInt32(CU2.Text) + Convert.ToInt32(CU3.Text) + Convert.ToInt32(CU4.Text) + Convert.ToInt32(CU5.Text) + Convert.ToInt32(CU6.Text) + Convert.ToInt32(CU7.Text)).ToString();
            }
        }

        private void CU4_TextChanged(object sender, EventArgs e)
        {
            if (CU7.Text != "" && CU6.Text != "" && CU5.Text != "" && CU4.Text != "" && CU3.Text != "" && CU2.Text != "" && CU1.Text != "")
            {
                txtbox_totalcreditunit.Text = (Convert.ToInt32(CU1.Text) + Convert.ToInt32(CU2.Text) + Convert.ToInt32(CU3.Text) + Convert.ToInt32(CU4.Text) + Convert.ToInt32(CU5.Text) + Convert.ToInt32(CU6.Text) + Convert.ToInt32(CU7.Text)).ToString();
            }
        }

        private void CU3_TextChanged(object sender, EventArgs e)
        {
            if (CU7.Text != "" && CU6.Text != "" && CU5.Text != "" && CU4.Text != "" && CU3.Text != "" && CU2.Text != "" && CU1.Text != "")
            {
                txtbox_totalcreditunit.Text = (Convert.ToInt32(CU1.Text) + Convert.ToInt32(CU2.Text) + Convert.ToInt32(CU3.Text) + Convert.ToInt32(CU4.Text) + Convert.ToInt32(CU5.Text) + Convert.ToInt32(CU6.Text) + Convert.ToInt32(CU7.Text)).ToString();
            }
        }

        private void CU2_TextChanged(object sender, EventArgs e)
        {
            if (CU7.Text != "" && CU6.Text != "" && CU5.Text != "" && CU4.Text != "" && CU3.Text != "" && CU2.Text != "" && CU1.Text != "")
            {
                txtbox_totalcreditunit.Text = (Convert.ToInt32(CU1.Text) + Convert.ToInt32(CU2.Text) + Convert.ToInt32(CU3.Text) + Convert.ToInt32(CU4.Text) + Convert.ToInt32(CU5.Text) + Convert.ToInt32(CU6.Text) + Convert.ToInt32(CU7.Text)).ToString();
            }
        }

        private void CU1_TextChanged(object sender, EventArgs e)
        {
            if (CU7.Text != "" && CU6.Text != "" && CU5.Text != "" && CU4.Text != "" && CU3.Text != "" && CU2.Text != "" && CU1.Text != "")
            {
                txtbox_totalcreditunit.Text = (Convert.ToInt32(CU1.Text) + Convert.ToInt32(CU2.Text) + Convert.ToInt32(CU3.Text) + Convert.ToInt32(CU4.Text) + Convert.ToInt32(CU5.Text) + Convert.ToInt32(CU6.Text) + Convert.ToInt32(CU7.Text)).ToString();
            }
        }

        // question 2c.
        private void btn_clrstudentinfo_Click(object sender, EventArgs e)
        {
            StudName.Clear();
            StudNo.Clear();
        }

        // question 2d.
        private void btn_ClearScheduleOfCourses_Click(object sender, EventArgs e)
        {
            // clear all course code
            CC1.Clear();
            CC2.Clear();
            CC3.Clear();
            CC4.Clear();
            CC5.Clear();
            CC6.Clear();
            CC7.Clear();

            // Clear all section
            Sec1.Clear();
            Sec2.Clear();
            Sec3.Clear();
            Sec4.Clear();
            Sec5.Clear();
            Sec6.Clear();
            Sec7.Clear();

            // clear all desc
            Desc1.Clear();
            Desc2.Clear();
            Desc3.Clear();
            Desc4.Clear();
            Desc5.Clear();
            Desc6.Clear();
            Desc7.Clear();

            // clear all lec
            LecU1.Clear();
            LecU2.Clear();
            LecU3.Clear();
            LecU4.Clear();
            LecU5.Clear();
            LecU6.Clear();
            LecU7.Clear();

            // clear all lab
            LabU1.Clear();
            LabU2.Clear();
            LabU3.Clear();
            LabU4.Clear();
            LabU5.Clear();
            LabU6.Clear();
            LabU7.Clear();

            // Clear all credit unit
            CU1.Clear();
            CU2.Clear();
            CU3.Clear();
            CU4.Clear();
            CU5.Clear();
            CU6.Clear();
            CU7.Clear();
            txtbox_totalcreditunit.Clear();

            // clear all time
            Time1.Clear();
            Time2.Clear();
            Time3.Clear();
            Time4.Clear();
            Time5.Clear();
            Time6.Clear();
            Time7.Clear();

            // clear all day
            Day1.Clear();
            Day2.Clear();
            Day3.Clear();
            Day4.Clear();
            Day5.Clear();
            Day6.Clear();
            Day7.Clear();

            // clear all room
            Room1.Clear();
            Room2.Clear();
            Room3.Clear();
            Room4.Clear();
            Room5.Clear();
            Room6.Clear();
            Room7.Clear();
        }

        //question 2e.
        private void btn_CalculateFees_Click(object sender, EventArgs e)
        {
            // i. total tuition
            double total_lecunits = Convert.ToInt32(LecU1.Text) + Convert.ToInt32(LecU2.Text) + Convert.ToInt32(LecU3.Text) + Convert.ToInt32(LecU4.Text) + Convert.ToInt32(LecU5.Text) + Convert.ToInt32(LecU6.Text) + Convert.ToInt32(LecU7.Text);
            double totalTuition = Convert.ToInt32(txtbox_totalcreditunit.Text) * 1500;
            textBox3.Text = totalTuition.ToString();

            // j total misc = 
            double total_labunits = Convert.ToInt32(LabU1.Text) + Convert.ToInt32(LabU2.Text) + Convert.ToInt32(LabU3.Text) + Convert.ToInt32(LabU4.Text) + Convert.ToInt32(LabU5.Text) + Convert.ToInt32(LabU6.Text) + Convert.ToInt32(LabU7.Text);
            CompLabFee = 2500 * (total_labunits);
            textBox6.Text = CompLabFee.ToString();
            double totalMisc = CompLabFee + SAPFee + CISCOLabFee + ExamBookletFee;

            // same as total others fee
            textBox4.Text = totalMisc.ToString();
            textBox9.Text = totalMisc.ToString();

            // k. computer laboratory fee
            CompLabFee = (Convert.ToDouble(LabU1.Text) + Convert.ToDouble(LabU2.Text) + Convert.ToDouble(LabU3.Text) + Convert.ToDouble(LabU4.Text) + Convert.ToDouble(LabU5.Text) + Convert.ToDouble(LabU6.Text) + Convert.ToDouble(LabU7.Text)) * 2500;

            // final
            double total_tuition_and_fees = totalTuition + totalMisc;
            textBox14.Text = total_tuition_and_fees.ToString();

            double installment_fee = (total_tuition_and_fees - 8000) / 3;
            textBox16.Text = installment_fee.ToString("C");
            textBox15.Text = installment_fee.ToString("C");
            textBox10.Text = installment_fee.ToString("C");
        }
    }
}

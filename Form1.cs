using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_app01
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        Boolean opercheck = false; //연산기호버튼 눌렸는지
        Boolean pluscheck = false; // + 버튼 눌렸는지
        Boolean minuscheck = false; // - 버튼 눌렸는지
        Boolean multiplycheck = false; // × 버튼 눌렸는지
        Boolean dividecheck = false; // ÷ 버튼 눌렸는지
        Boolean resultcheck = false; // = 버튼 눌렸는지

        List<int> foper = new List<int>();
        List<int> soper = new List<int>();
        List<int> roper = new List<int>();

        int firstoper = 0;
        int secondoper = 0;

        int resultClickCount { get; set; } = 0;

        /// <summary>
        /// 설명
        /// </summary>
        /// <param name="btnNum"></param>
        void ZeroClear(String btnNum)
        {
            if (main_num.Text == "0")
            {
                main_num.Text = btnNum;
            }
            else
            {
                if (opercheck == true)
                {
                    main_num.Text = "";
                    opercheck = false;
                }
                else if (resultcheck == true)
                {
                    main_num.Text = "";
                    calculation.Text = "";
                    resultcheck = false;
                }
                
                main_num.Text += btnNum;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }

        void Init()
        {
            button0.Click += Button_Click;
            button1.Click += Button_Click;
            button2.Click += Button_Click;
            button3.Click += Button_Click;
            button4.Click += Button_Click;
            button5.Click += Button_Click;
            button6.Click += Button_Click;
            button7.Click += Button_Click;
            button8.Click += Button_Click;
            button9.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string name = btn.Name;

            switch (name)
            {
                case "button0":
                    ZeroClear($"{btn.Text}");
                    break;
                case "button1":
                    ZeroClear($"{btn.Text}");
                    break;
                case "button2":
                    ZeroClear($"{btn.Text}");
                    break;
                case "button3":
                    ZeroClear($"{btn.Text}");
                    break;
                case "button4":
                    ZeroClear($"{btn.Text}");
                    break;
                case "button5":
                    ZeroClear($"{btn.Text}");
                    break;
                case "button6":
                    ZeroClear($"{btn.Text}");
                    break;
                case "button7":
                    ZeroClear($"{btn.Text}");
                    break;
                case "button8":
                    ZeroClear($"{btn.Text}");
                    break;
                case "button9":
                    ZeroClear($"{btn.Text}");
                    break;
            }
        }

        // =
        private void result_Click(object sender, EventArgs e)
        {
            resultClickCount++;

            secondoper = Int32.Parse(main_num.Text);
            string tmp = string.Empty;
            
            int mnt = Int32.Parse(main_num.Text);


            int lastele;// 첫번째 수 마지막값
            int lasteles; // 두번째 수 마지막값
            int lasteler; // 결과값 마지막값
            int rele; // 결과값 저장 변수
            

            if (pluscheck == true)
            {
                if (resultClickCount == 1)
                {
                    resultcheck = true;
                    soper.Add(secondoper);
                    lastele = foper.Last();
                    lasteles = soper.Last();
                    calculation.Text += main_num.Text + " =";
                    rele = lastele += lasteles;
                    roper.Add(rele);
                    main_num.Text = rele.ToString();
                    //Console.WriteLine(roper.Count);
                }
                else
                {
                    resultcheck = true;
                    lasteles = soper.Last();
                    lasteler = Int32.Parse(main_num.Text);
                    calculation.Text = lasteler + " + " + lasteles + " =";
                    rele = lasteles + lasteler;
                    roper.Add(rele);
                    main_num.Text = rele.ToString();
                }
            }
            else if (minuscheck == true)
            {
                if (resultClickCount == 1)
                {
                    resultcheck = true;
                    soper.Add(secondoper);
                    lastele = foper.Last();
                    lasteles = soper.Last();
                    calculation.Text += main_num.Text + " =";
                    rele = lastele -= lasteles;
                    roper.Add(rele);
                    main_num.Text = rele.ToString();
                    //Console.WriteLine(roper.Count);
                }
                else
                {
                    resultcheck = true;
                    lastele = foper.Last();
                    lasteles = soper.Last();
                    lasteler = Int32.Parse(main_num.Text);
                    calculation.Text = lasteler + " - " + lasteles + " =";
                    rele = lasteles - lasteler;
                    Console.WriteLine(soper.Last().ToString());
                    roper.Add(rele);
                    main_num.Text = rele.ToString();
                }
            }
            else if (multiplycheck == true)
            {
                if (resultClickCount == 1)
                {
                    resultcheck = true;
                    soper.Add(secondoper);
                    lastele = foper.Last();
                    lasteles = soper.Last();
                    calculation.Text += main_num.Text + " =";
                    rele = lastele *= lasteles;
                    roper.Add(rele);
                    main_num.Text = rele.ToString();
                    //Console.WriteLine(roper.Count);
                }
                else
                {
                    resultcheck = true;
                    lastele = foper.Last();
                    lasteles = soper.Last();
                    lasteler = Int32.Parse(main_num.Text);
                    calculation.Text = lasteler + " × " + lasteles + " =";
                    rele = lasteles * lasteler;
                    roper.Add(rele);
                    main_num.Text = rele.ToString();
                }
            }
            else if (dividecheck == true)
            {
                if (resultClickCount == 1)
                {
                    resultcheck = true;
                    soper.Add(secondoper);
                    lastele = foper.Last();
                    lasteles = soper.Last();
                    calculation.Text += main_num.Text + " =";
                    rele = lastele /= lasteles;
                    roper.Add(rele);
                    main_num.Text = rele.ToString();
                    //Console.WriteLine(roper.Count);
                }
                else
                {
                    resultcheck = true;
                    lastele = foper.Last();
                    lasteles = soper.Last();
                    lasteler = Int32.Parse(main_num.Text);
                    calculation.Text = lasteler + " ÷ " + lasteles + " =";
                    rele = lasteles / lasteler;
                    roper.Add(rele);
                    main_num.Text = rele.ToString();
                }
            }
        }

        // +
        private void plus_Click(object sender, EventArgs e)
        {
            int cstrNum = Int32.Parse(main_num.Text);
            if (main_num.Text != "0")
            {
                calculation.Text = cstrNum + "" + plus.Text;
                opercheck = true;
                pluscheck = true;
                foper.Add(cstrNum);
                //Console.WriteLine(foper.Count);
            }
            else
            {
                return;
            }
            minuscheck = false;
            multiplycheck = false;
            dividecheck = false;
        }

        // -
        private void minus_Click(object sender, EventArgs e)
        {
            int cstrNum = Int32.Parse(main_num.Text);
            if (main_num.Text != "0")
            {
                calculation.Text = cstrNum + "" + minus.Text + "";
                opercheck = true;
                minuscheck = true;
                firstoper = cstrNum;
            }
            else
            {
                return;
            }

            pluscheck = false;
            multiplycheck = false;
            dividecheck = false;
        }

        // *
        private void multiply_Click(object sender, EventArgs e)
        {
            int cstrNum = Int32.Parse(main_num.Text);
            if (main_num.Text != "0")
            {
                calculation.Text = cstrNum + "" + multiply.Text + "";
                opercheck = true;
                multiplycheck = true;
                firstoper = cstrNum;
            }
            else
            {
                return;
            }

            pluscheck = false;
            minuscheck = false;
            dividecheck = false;

        }

        // /
        private void division_Click(object sender, EventArgs e)
        {
            int cstrNum = Int32.Parse(main_num.Text);
            if (main_num.Text != "0")
            {
                calculation.Text = cstrNum + "" + division.Text + "";
                opercheck = true;
                dividecheck = true;
                firstoper = cstrNum;
            }
            else
            {
                return;
            }

            pluscheck = false;
            minuscheck = false;
            dividecheck = false;

        }

        // delete
        private void delete_Click(object sender, EventArgs e)
        {
            if(resultcheck == true)
            {
                calculation.Text = "";
            }
            else
            {
                if(main_num.Text.Length != 0)
                {
                    main_num.Text = main_num.Text.Substring(0, main_num.Text.Length - 1);
                }
                else if (main_num.Text == "0" && main_num.Text.Length == 0)
                {
                    main_num.Text = "0";
                }
            }
        }

        private void all_reset_Click(object sender, EventArgs e)
        {
            opercheck = false; //연산기호버튼 눌렸는지
            pluscheck = false; // + 버튼 눌렸는지
            minuscheck = false; // - 버튼 눌렸는지
            multiplycheck = false; // × 버튼 눌렸는지
            dividecheck = false; // ÷ 버튼 눌렸는지
            resultcheck = false; // = 버튼 눌렸는지

            foper.Clear();
            soper.Clear();
            roper.Clear();

            resultcheck = false;
            main_num.Text = "0";
            calculation.Text = "";
        }
    }
}

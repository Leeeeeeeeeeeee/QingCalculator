namespace QingCalculator
{
    public partial class Calculator : Form
    {
        public static string GlobalExpression = "";
        public Calculator()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void AppendNumber(string str)
        {
            string validStr = ".0123456789";
            if (validStr.IndexOf(str) >-1)
            {
                //进入数字操作
                GlobalExpression += str;
            }
            else {
                //进入符号操作
                if (!string.IsNullOrEmpty(GlobalExpression))
                {
                    //不为空时走解析逻辑
                    string lastStr = GlobalExpression.Substring(GlobalExpression.Length - 1, 1);

                    if (validStr.IndexOf(lastStr) > -1)
                    {
                        //如果最后一位是数字，则把之前的算数都做一遍然后追加符号
                        GlobalExpression = operate(str);
                    }
                }
            }
            btn_input.Text = GlobalExpression;

        }

        public string operate(string str)
        {
            if (GlobalExpression.Contains("+"))
            {
                string[] temps = GlobalExpression.Split(new char[] { '+' }, StringSplitOptions.RemoveEmptyEntries);
                GlobalExpression = (Convert.ToDecimal(temps[0]) + Convert.ToDecimal(temps[1])).ToString();
            }
            else if (GlobalExpression.Contains("-"))
            {
                string[] temps = GlobalExpression.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                GlobalExpression = (Convert.ToDecimal(temps[0]) - Convert.ToDecimal(temps[1])).ToString();
            }
            else if (GlobalExpression.Contains("*")){
                string[] temps = GlobalExpression.Split(new char[] { '*' }, StringSplitOptions.RemoveEmptyEntries);
                GlobalExpression = (Convert.ToDecimal(temps[0]) * Convert.ToDecimal(temps[1])).ToString();
            }
            else if (GlobalExpression.Contains("/"))
            {
                string[] temps = GlobalExpression.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                GlobalExpression = (Convert.ToDecimal(temps[0]) / Convert.ToDecimal(temps[1])).ToString();
            }
            else if (GlobalExpression.Contains("%"))
            {
                string[] temps = GlobalExpression.Split(new char[] { '%' }, StringSplitOptions.RemoveEmptyEntries);
                GlobalExpression = (Convert.ToDecimal(temps[0]) % Convert.ToDecimal(temps[1])).ToString();
            }

            if (str != "=")
            {
                GlobalExpression += str;
            }
            return GlobalExpression;
        }
        #region 按键事件

        private void btn_1_Click(object sender, EventArgs e)
        {
            AppendNumber("1");
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            AppendNumber("2");
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            AppendNumber("3");
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            AppendNumber("4");
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            AppendNumber("5");
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            AppendNumber("6");
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            AppendNumber("7");
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            AppendNumber("8");
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            AppendNumber("9");
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            AppendNumber("0");
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            AppendNumber(".");
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            AppendNumber("=");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AppendNumber("+");
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            AppendNumber("-");
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            AppendNumber("*");
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            AppendNumber("/");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            GlobalExpression = "";
            btn_input.Text = GlobalExpression;
        }

        private void btn_surplus_Click(object sender, EventArgs e)
        {
            AppendNumber("%");
        }

        private void btn_input_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
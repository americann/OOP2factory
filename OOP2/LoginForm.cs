using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OOP2.MemberFactory;

namespace OOP2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //ログイン後は自分が何アカウントでログインしたかを考える必要がないようになっている
        //
        private void ExecutionButton_Click(object sender, EventArgs e)
        {
            //シルバーなら割引率 0
            //ゴールドら割引率 20
            //プラチナなら割引率 40


            MemberKind memberKind = MemberKind.Silver;
            
            
            //実際は下記のifは関数やデータベース接続関数にする
            if (SilverRadioButton.Checked)
            {
                memberKind = MemberKind.Gold;
            }
            else if (GoldRadioButton.Checked)
            {
                memberKind = MemberKind.Platinum;
            }
            else
            {
                memberKind = MemberKind.Silver;
            }

            LoginInfo.Member = MemberFactory.Create(memberKind);

            using (var f = new Form1())
            {
                f.ShowDialog();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var f = new Form2())
            {
                f.ShowDialog();
            }
        }
    }
}


//基本的にインターフェースを作成したらそれを生成するためのfactoryを一つ作ると
//生成する定義は一か所にまとまるため見やすいプログラムになる
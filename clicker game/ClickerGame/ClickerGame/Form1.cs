using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ClickerGame
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 프로그램이 시작될 때 실행됩니다.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            // 몬스터 사진이 있는 경로
            string monsterURL = Directory.GetCurrentDirectory() + "\\monster\\1.png";

            // 몬스터 사진 설정
            MonsterImage.ImageLocation = monsterURL;
        }
    }
}

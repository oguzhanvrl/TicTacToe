using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TicTacDeneme
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        

        Thread thread;

        GameTypeEnum.GameType gtype = (GameTypeEnum.GameType)0;

        List<RadioButton> rbList=new List<RadioButton>();
        string[] rbStrings = { "İnsan vs İnsan", "İnsan vs AI", "Sunucu Ol", "Sunucuya Katıl" };

        private void MainMenu_Load(object sender, EventArgs e)
        {
            SetVisibility();
            for (int i = 0; i < 4; i++)
            {               
                RadioButton rb = new RadioButton();
                rb.Location = new Point(0, 10+(i*30));
                rb.Font = new Font("Montserrat", 18);
                rb.AutoSize = true;
                rb.Name = "rb" + i;
                rb.Text = rbStrings[i];
                rb.Click += new EventHandler(RBClick);
                this.Controls.Add(rb);
                rbList.Add(rb);
            }
        }

        private void RBClick(object sender,EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            gtype = (GameTypeEnum.GameType)Int32.Parse(rb.Name.Substring(rb.Name.Length - 1, 1));
            if(gtype== GameTypeEnum.GameType.PvAIX)
            {
                SetVisibility();
                pnlPvAI.Visible = true;
            }
            else if(gtype== GameTypeEnum.GameType.Client)
            {
                SetVisibility();
                pnlIpAddress.Visible = true;
            }
            else if(gtype== GameTypeEnum.GameType.PvP)
            {
                SetVisibility();
                cboxTimed.Visible = true;
            }
            else
            {
                SetVisibility();
            }
            //MessageBox.Show(""+gtype); enum string'i
        }

        private void SetVisibility()
        {
            pnlIpAddress.Visible = false;
            pnlPvAI.Visible = false;
            cboxTimed.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenGame);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenGame()
        {
            Application.Run(new PvP(gtype));
        }

        private void cboxTimed_Click(object sender, EventArgs e)
        {
            gtype = cboxTimed.Checked? GameTypeEnum.GameType.PvPTimed:GameTypeEnum.GameType.PvP;
        }

        private void rbX_Click(object sender, EventArgs e)
        {
            gtype = GameTypeEnum.GameType.PvAIX;
        }

        private void rbO_Click(object sender, EventArgs e)
        {
            gtype = GameTypeEnum.GameType.PvAIO;
        }
    }
}

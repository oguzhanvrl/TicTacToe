using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacDeneme
{
    public partial class PvP : Form
    {
        bool isTurnX = true;
        int time = 10;
        List<Button> squares;
        GameEngine ge;
        AIMove AI;
        GameTypeEnum.GameType gtype;
        Thread thread;
        Scores scores;
        string[] isClicked = { " ", " ", " ", " ", " ", " ", " ", " ", " " };

        public PvP(GameTypeEnum.GameType gtype)
        {
            InitializeComponent();
            this.gtype = gtype;
            this.Width = 468;
            this.Height = 750;
            this.StartPosition = FormStartPosition.Manual;
            this.Left = 200;
            this.Top = 10;
            BuildGameField();
        }

        void BuildGameField()
        {
            squares = new List<Button>();
            int xPoint = 0;
            int yPoint = 0;
            for (int i = 0; i < 3; i++)
            {
                xPoint = 0;
                for (int j = 0; j < 3; j++)
                {
                    Button newButton = new Button();
                    newButton.Name = "square" + i + "" + j;
                    newButton.Font = new Font(newButton.Font.FontFamily, 30);
                    newButton.Height = 150;
                    newButton.Width = 150;
                    newButton.Location = new Point(xPoint, yPoint);
                    xPoint += 150;
                    squares.Add(newButton);
                    newButton.Click += new EventHandler(SquareClick);
                    this.Controls.Add(newButton);
                    newButton.BackColor = Color.AliceBlue;
                }
                yPoint += 150;
            }
            GamePanel.Location = new Point(0, 468);
        }


        private void SquareClick(object sender, EventArgs e)
        {
            PlayerTurn((Button)sender);
        }

        void PlayerTurn(Button button)
        {
            int buttonRow = Int32.Parse(button.Name.Substring(button.Name.Length - 2, 1));
            int buttonColumn = Int32.Parse(button.Name.Substring(button.Name.Length - 1, 1));
            if (isClicked[ge.IndexToPath(buttonRow, buttonColumn)] == " ")
            {
                button.ForeColor = isTurnX ? Color.Red : Color.Blue;
                string currPlayer = isTurnX ? "X" : "O";
                isClicked[ge.IndexToPath(buttonRow, buttonColumn)] = currPlayer;
                GameField();

                if (gtype == GameTypeEnum.GameType.PvP || gtype == GameTypeEnum.GameType.PvPTimed)
                    PlayPvP();

                if (ge.CheckWin(currPlayer, isClicked))
                {
                    scores.ScoreUp(currPlayer);
                    EndGame(currPlayer + " kazandı");
                }

                else if(gtype==GameTypeEnum.GameType.PvAIX||gtype==GameTypeEnum.GameType.PvAIO)
                {
                    AITurn();
                }

                else if (ge.CheckTie(isClicked))
                {
                    if (gtype == GameTypeEnum.GameType.PvPTimed)
                    {
                        string winner= time < 10 ? "X" : "O";
                        scores.ScoreUp(winner);
                        ScoreLabels();
                        EndGame(winner + " zaman farkıyla kazandı");
                    }
                    else
                    {
                        scores.ScoreUp("T");
                        EndGame("Berabere kaldınız");
                    }
                }
            }
        }

        void PlayPvP()
        {
            isTurnX = (isTurnX ? false : true);
            if (gtype == GameTypeEnum.GameType.PvPTimed)
                timerBar.Text = isTurnX ? "X" : "O";
        }

        void AITurn()
        {
            int winPos = -1;
            List<int> emptyPos = ge.EmptyList(isClicked);
            int[] empty = emptyPos.ToArray();
            winPos = AI.CheckWinningMove(AI.AI, isClicked);

            if (winPos != -1)
                isClicked[winPos] = AI.AI; // AI için kazanan hamle var demek

            else if (winPos == -1 && empty.Length != 0) //  AI için Kazanan hamle yoksa
            {
                winPos = AI.CheckWinningMove(AI.Player, isClicked); // Oyuncu için kazanan hamle var mı kontrol ediyor

                if (winPos != -1)   // Oyuncu için kazanan hamle varsa dolduruyor
                    isClicked[winPos] = AI.AI;

                else // Kimse kazanamıyorsa rastgele bir yere koyuyor
                {
                    winPos = new Random().Next(0, empty.Length);
                    isClicked[empty[winPos]] = AI.AI;
                }
            }
            GameField();
            if (ge.CheckTie(isClicked))
            {
                scores.ScoreUp("T");
                ScoreLabels();
                EndGame("Berabere bitti");
            }
            
            if (ge.CheckWin(AI.AI, isClicked))
            {
                scores.ScoreUp(AI.AI);
                EndGame("Kaybettin");
            }
        }



        public void GameField()
        {
            int i = 0;
            foreach (Button item in squares)
            {
                item.Text = isClicked[i];
                i++;
            }
        }

        void RestartGame()
        {
            /*isTurnX = true;
            for (int i = 0; i < 9; i++)
            {
                isClicked[i] = " ";
                Button btn = squares.Find(x => x.Name == "square" + (i / 3) + "" + (i % 3));
                btn.ForeColor = Color.Black;
            }
            GameField();
            if (gtype==GameTypeEnum.GameType.PvPTimed)
            {               
                /*timer.Enabled = true;
                time = 10;
                timerBar.Value = time;
                timerBar.Text = "X";
            }
            else if(gtype==GameTypeEnum.GameType.PvP)
            {

            }

            else if (gtype == GameTypeEnum.GameType.PvAIX)
            {
                //AI = new AIMove("O", "X");
            }

            else if (gtype == GameTypeEnum.GameType.PvAIO)
            {
                /*isTurnX = false;
                AI = new AIMove("X", "O");
                AITurn();
            }*/
            this.Close();
            thread = new Thread(Reset);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        void Reset()
        {
            Application.Run(new PvP(gtype));
        }

        private void btnGameReset_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void btnScoreReset_Click(object sender, EventArgs e)
        {
            scores.ResetScores();
            ScoreLabels();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            scores.ResetScores();
            thread = new Thread(OpenMenu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        void OpenMenu()
        {
            Application.Run(new MainMenu());
        }

        void ScoreLabels()
        {
            lblScoreO.Text = "O : "+ scores.ScoreO();
            lblScoreX.Text = "X : " + scores.ScoreX();
            lblScoreTie.Text = "Tie : " + scores.ScoreT();
        }

        public void EndGame(string message)
        {
            timer.Stop();
            ScoreLabels();
            var result = MessageBox.Show(message + " . Tekrar oynamak ister misiniz ?", "Mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
                RestartGame();
            else
                Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (isTurnX)
            {
                time++;
            }

            else
            {
                time--;
            }

            timerBar.Value = time;

            if (time <= 0||time>=20)
            {
                timer.Stop();
                EndGame((isTurnX ? "X" : "O") + " oyuncusunun zamanı bittiği için "+ (isTurnX ? "O" : "X")+" kazandı" );
            }
        }

        private void PvP_Load(object sender, EventArgs e)
        {
            ge = new GameEngine();
            timerBar.Visible = false;
            if (gtype == GameTypeEnum.GameType.PvPTimed)
            {
                timer.Start();
                timerBar.Visible = true;
                timerBar.Width = 150;
                timerBar.Height = 150;
                timerBar.Maximum = 20;
                timerBar.Minimum = 0;
                timeBar.Value = time;
                timerBar.Text = "X";             
            }
                
            if (gtype == GameTypeEnum.GameType.PvP)
            {
                
            }

            if(gtype == GameTypeEnum.GameType.PvAIX)
            {
                AI = new AIMove("O", "X");
                isTurnX = true;
            }

            else if(gtype==GameTypeEnum.GameType.PvAIO)
            {
                AI = new AIMove("X", "O");
                isTurnX = false;
                AITurn();
            }
            scores = Scores.Instance;
            ScoreLabels();
        }
    }
}

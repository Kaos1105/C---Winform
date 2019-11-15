using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro
{
    class ChessBoard
    {
        const int BTN_HEIGHT = 30;
        const int BTN_WIDTH = 30;
        const int BOARD_HEIGHT = 22;
        const int BOARD_WIDTH = 22;
        public static int step = 100;
        public static int timer = 25000;
        public static int interval = 100;
        public List<Player> players { get; set; }
        private int currPlayer;

        public PictureBox picAvatar { get; set; }
        public TextBox nameAvatar { get; set; }
        public List<List<Button>> Matrix { get; set; }
        public Stack<Point> PlayedPoint { get; set; }

        public ChessBoard(PictureBox pic, TextBox name)
        {

            nameAvatar = name;
            picAvatar = pic;

            this.players = new List<Player>()
            {
                new Player("Ngáooo", Image.FromFile(@"E:\Study\C#\K-Solution\Caro\Source\p1.png"), Image.FromFile(@"E:\Study\C#\K-Solution\Caro\Source\avatar1.jpg")),
                new Player("Méoooo", Image.FromFile(@"E:\Study\C#\K-Solution\Caro\Source\p2.png"), Image.FromFile(@"E:\Study\C#\K-Solution\Caro\Source\avatar2.jpg"))
            };
            showPlayer();
        }
        public void DrawChessBoard(Panel chessBoard)
        { 
            PlayedPoint = new Stack<Point>();
            currPlayer = 0;
            Matrix = new List<List<Button>>();
            Button anchor = new Button()
            {
                Width = 0,
                Location = new Point(0, 0)
            };
            for (int i = 0; i < BOARD_HEIGHT; ++i)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < BOARD_WIDTH; ++j)
                {
                    Button btn = new Button()
                    {
                        Width = BTN_WIDTH,
                        Height = BTN_HEIGHT,
                        Location = new Point(anchor.Location.X + anchor.Width, anchor.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };
                    chessBoard.Controls.Add(btn);
                    btn.Click += Btn_Click;
                    anchor = btn;
                    Matrix[i].Add(btn);
                }
                anchor.Location = new Point(0, anchor.Location.Y + BTN_HEIGHT);
                anchor.Width = 0;
                anchor.Height = 0;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Button btn = (Button)sender;
            PlayedPoint.Push(chessPoint(btn));
            if (btn.BackgroundImage != null)
                return;
            changePlayer(btn);
            changingPlayer?.Invoke(this, new EventArgs());
            if (isEndGame(btn))
            {
                if (btn.BackgroundImage == players[0].image)
                    MessageBox.Show(players[0].playerName + " Win", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(players[1].playerName + " Win", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                endGame?.Invoke(this, new EventArgs());
            }
            showPlayer();
        }
        private Point chessPoint(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);
            Point point = new Point(horizontal, vertical);
            return point;
        }
        private event EventHandler endGame;
        public event EventHandler EndGame
        {
            add
            {
                endGame += value;
            }
            remove
            {
                endGame -= value;
            }
        }
        private bool isEndGame(Button btn)
        {
            return (isEndGameHorizontal(btn) || isEndGameVertical(btn) || isEndGamePrimaryDiagonal(btn) || isEndGameAntiDiagonal(btn));
        }
        private bool isEndGameHorizontal(Button btn)
        {
            Point ptn = chessPoint(btn);
            int countLeft = 0;
            for (int i = ptn.X; i >= 0; --i)
            {
                if (Matrix[ptn.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else break;
            }
            int countRight = 0;
            for (int i = ptn.X + 1; i < BOARD_WIDTH; ++i)
            {
                if (Matrix[ptn.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else break;
            }
            return countLeft + countRight == 5;
        }
        private bool isEndGameVertical(Button btn)
        {
            Point ptn = chessPoint(btn);
            int countUp = 0;
            for (int i = ptn.Y; i >= 0; --i)
            {
                if (Matrix[i][ptn.X].BackgroundImage == btn.BackgroundImage)
                {
                    countUp++;
                }
                else break;
            }
            int countDown = 0;
            for (int i = ptn.Y + 1; i < BOARD_HEIGHT; ++i)
            {
                if (Matrix[i][ptn.X].BackgroundImage == btn.BackgroundImage)
                {
                    countDown++;
                }
                else break;
            }
            return countUp + countDown == 5;
        }
        private bool isEndGamePrimaryDiagonal(Button btn)
        {
            Point ptn = chessPoint(btn);
            int countUp = 0;
            for (int i = 0; i <= ptn.X; ++i)
            {
                if (ptn.X - i < 0 || ptn.Y - i < 0)
                    break;
                if (Matrix[ptn.Y - i][ptn.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countUp++;
                }
                else break;
            }
            int countDown = 0;
            for (int i = 1; i <= BOARD_WIDTH - ptn.X; ++i)
            {
                if (ptn.X + i >= BOARD_WIDTH || ptn.Y + i >= BOARD_HEIGHT)
                    break;
                if (Matrix[ptn.Y + i][ptn.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countDown++;
                }
                else break;
            }
            return countUp + countDown == 5;
        }
        private bool isEndGameAntiDiagonal(Button btn)
        {
            Point ptn = chessPoint(btn);
            int countUp = 0;
            for (int i = 0; i <= ptn.X; ++i)
            {
                if (ptn.X + i >= BOARD_WIDTH || ptn.Y - i < 0)
                    break;
                if (Matrix[ptn.Y - i][ptn.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countUp++;
                }
                else break;
            }
            int countDown = 0;
            for (int i = 1; i <= BOARD_WIDTH - ptn.X; ++i)
            {
                if (ptn.X - i < 0 || ptn.Y + i >= BOARD_HEIGHT)
                    break;
                if (Matrix[ptn.Y + i][ptn.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countDown++;
                }
                else break;
            }
            return countUp + countDown == 5;
        }
        private event EventHandler changingPlayer;
        public event EventHandler ChangePlayer
        {
            add
            {
                changingPlayer += value;
            }
            remove
            {
                changingPlayer -= value;
            }
        }
        public void changePlayer(Button btn)
        {
            btn.BackgroundImage = players[currPlayer].image;
            currPlayer = currPlayer == 1 ? 0 : 1;
        }
        public void showPlayer()
        {
            this.nameAvatar.Text = players[currPlayer].playerName;
            this.picAvatar.Image = players[currPlayer].avatar;
        }
        public bool Undo()
        {
            if (PlayedPoint.Count <= 0)
                return false;
            Point played = PlayedPoint.Pop();
            Button btn = Matrix[played.Y][played.X];
            changePlayer(btn);
            showPlayer();
            btn.BackgroundImage = null;
            return true;
        }
    }
}

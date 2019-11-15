using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro
{
    public partial class Caro : Form
    {
        ChessBoard chessBoard; 
        public Caro()
        {
            InitializeComponent();
            chessBoard = new ChessBoard(pictureBoxAva, textBoxplayerName);
            progressBarcoolDown.Step = ChessBoard.step;
            progressBarcoolDown.Maximum = ChessBoard.timer;
            timerCoolDown.Interval = ChessBoard.interval;
            chessBoard.ChangePlayer += ChessBoard_ChangePlayer;
            chessBoard.EndGame += ChessBoard_EndGame;
            NewGame();
        }

        private void ChessBoard_EndGame(object sender, EventArgs e)
        {
            button2.Enabled=false;
            //throw new NotImplementedException();
            timerCoolDown.Stop();
            panelChessBoard.Enabled = false;
            MessageBox.Show("Kết thúc", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void ChessBoard_ChangePlayer(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            timerCoolDown.Start();
            progressBarcoolDown.Value = 0;
        }

        private void timerCoolDown_Tick(object sender, EventArgs e)
        {
            progressBarcoolDown.PerformStep();
            if(progressBarcoolDown.Value==progressBarcoolDown.Maximum)
            {
                ChessBoard_EndGame(this, e);
            }
        }

        private void Caro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                e.Cancel = true;
        }

        private void NewGame()
        {
            button2.Enabled = true;
            panelChessBoard.Controls.Clear();
            timerCoolDown.Stop();
            progressBarcoolDown.Value = 0;
            chessBoard.DrawChessBoard(panelChessBoard);
            chessBoard.showPlayer();
            timerCoolDown.Start();
            panelChessBoard.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!chessBoard.Undo())
                MessageBox.Show("Bạn không thể Undo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

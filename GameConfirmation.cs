using System;
using System.Windows.Forms;
using System.IO;


namespace Task_1
{
    public partial class GameConfirmation : Form
    {
        public string ScoreFilePath;
        public bool NewGame = false;
        public GameConfirmation()
        {
            InitializeComponent();
        }

        private void yes_Click(object sender, System.EventArgs e)
        {
            NewGame = true;
            this.Close();
        }

        private void no_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void SuccesRemember_Click(object sender, System.EventArgs e)
        {
            String WriteDataScore = PlayerName.Text + "|" + DateTime.Now.ToShortDateString() + "|" + TimeSolving.Text.Replace(" sec", "") + "|" + GuessedChances.Text + "|" + "\r\n";
            //read file and save data
            if (ScoreFilePath.Length > 10)
            {
                try
                { 
                    ScoreFilePath = ScoreFilePath.Replace("Words.txt", "BestScore.txt");
                    if (System.IO.File.Exists(ScoreFilePath))
                    {
                        using (StreamReader WordsRead = new StreamReader(ScoreFilePath))
                        {
                            String FileData = WordsRead.ReadToEnd();
                            WriteDataScore = FileData + WriteDataScore;
                        }
                        using (StreamWriter WriteFile = new StreamWriter(ScoreFilePath))
                        {
                            WriteFile.Write(WriteDataScore);
                        }
                    }
                    else
                    {
                        using (StreamWriter WriteFile = new StreamWriter(ScoreFilePath))
                        {
                            WriteFile.Write(PlayerName.Text + "|" + DateTime.Now.ToShortDateString() + "|" + TimeSolving.Text.Replace(" sec", "") + "|" + GuessedChances.Text + "|" + "\r\n");
                        }
                    }
                }
                catch (Exception ex)
                { 
                    MessageBox.Show("Saving data error: " + ex.Message);
                }
            }
            PlayerName.Enabled = false;
            SuccesRemember.Enabled = false;
        }

        private void PlayerName_TextChanged(object sender, EventArgs e)
        {
            if (PlayerName.Text.Length > 1)
                SuccesRemember.Enabled = true;
            else
                SuccesRemember.Enabled = false;
        }
    }
}

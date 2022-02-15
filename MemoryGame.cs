using System;
//using System.Collections.Generic;
//using System.ComponentModel;
using System.Drawing;
//using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Task_1
{
    public partial class MemoryGame : Form
    {
        #region variable settings
        public String LevelConfirmation = "", SavedDataPath;
        public String[] WordSelected;
        public int[] RandomIndexWordSelected, RandomWordPlace;
        public String [] RandomWordLocation;
        public int iPosition = 0, iChancesQuantity, WordsSelectedQuantity;
        private int ActiveFieldClicked = -1, FieldsSolved, SolvingTimeinSeconds = 0;
        private Button FirstFieldChecked;
        public DateTime BeginTime;
        #endregion

        public MemoryGame()
        {
            InitializeComponent();

            //data gathering from the existing file
            if (DataGathering() == "OK")
            {
                //select difficulty level
                DifficultyLevelSelecting wDiffSel = new DifficultyLevelSelecting();
                wDiffSel.ShowDialog();
                LevelConfirmation = wDiffSel.LevelConfirmation;

                try
                {
                    switch (LevelConfirmation)
                    {
                        case "EASY":
                            iChancesQuantity = 10;
                            GetRandomIndex(4);

                            Field1.Text = Field2.Text = Field3.Text = Field4.Text =
                                Field5.Text = Field6.Text = Field7.Text = Field8.Text = "";
                            Field9.Visible = Field10.Visible = Field11.Visible = Field12.Visible =
                                Field13.Visible = Field14.Visible = Field15.Visible = Field16.Visible = false;
                            this.Height -= 220;
                            break;
                        case "HARD":
                            iChancesQuantity = 15;
                            GetRandomIndex(8);
                            Field1.Text = Field2.Text = Field3.Text = Field4.Text =
                                Field5.Text = Field6.Text = Field7.Text = Field8.Text = "";
                            Field9.Visible = Field10.Visible = Field11.Visible = Field12.Visible =
                                Field13.Visible = Field14.Visible = Field15.Visible = Field16.Visible = true;
                            Field9.Text = Field10.Text = Field11.Text = Field12.Text =
                                Field13.Text = Field14.Text = Field15.Text = Field16.Text = "";
                            break;
                        default:
                            break;
                    }
                    //int iPossss = RandomIndexWordSelected[0];
                    LeftChanches.Text = iChancesQuantity.ToString();
                    lDifficultyLevelInfo.Text += LevelConfirmation;
                }
                catch (Exception e)
                {
                    //MessageBox.Show("Exception: " + e.Message);
                }
            }
        }

        private String DataGathering()
        {
            OpenFileDialog ReadDataFile = new OpenFileDialog();
            String Confirmation = "";
            if ((ReadDataFile.ShowDialog() == DialogResult.OK) & (ReadDataFile.SafeFileName == "Words.txt"))
            {
                try
                {
                    SavedDataPath = ReadDataFile.InitialDirectory;
                    using (StreamReader WordsRead = new StreamReader(ReadDataFile.FileName))
                    {
                        String FileData = WordsRead.ReadToEnd();
                        if (FileData != "")
                        {
                            //selecting gathered data
                            String sFileData = FileData.Replace("\r", "");    //only for tests
                            WordSelected = sFileData.Split('\n');
                            if (WordSelected.Length > 8)
                            {
                                Confirmation = "OK";
                            }
                            else
                            {
                                MessageBox.Show("Not enough data in the file (Word.txt).", "Unfortunately the game cannot be started");
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("The correct file was not loaded (Word.txt). Start program again.", "Unfortunately the game cannot be started");
                    this.Close();
                }
            }
            else 
            {
                MessageBox.Show("The correct file was not loaded (Word.txt). Start program again.", "Unfortunately the game cannot be started");
                this.Close();
            }
            return Confirmation;
        }

        private void Field_MouseLeave(object sender, EventArgs e)
        {
            if (ActiveFieldClicked == 2)          //fields texts are different, close open fields
            {
                ActiveFieldClicked = 0;
                Button bInfo = (Button)sender;
                bInfo.Text = "";
                bInfo.BackColor = Color.LightGray;
                bInfo.ForeColor = Color.Black;

                FirstFieldChecked.Text = "";
                FirstFieldChecked.BackColor = Color.LightGray;
                FirstFieldChecked.ForeColor = Color.Black;
                FirstFieldChecked = new Button();
            }
        }

        private void NewGameSelection_Click(object sender, EventArgs e)
        {
            DifficultyLevelSelecting wDiffSel = new DifficultyLevelSelecting();
            wDiffSel.ShowDialog();
            LevelConfirmation = wDiffSel.LevelConfirmation;
        }

        private void HallOfFame_Click(object sender, EventArgs e)
        {

        }

        private void PlayingTime_Tick(object sender, EventArgs e)
        {
            TimeSpan PlayedTime = DateTime.Now - BeginTime;
            lTimer.Text = ((int)PlayedTime.TotalSeconds).ToString() + " s";
        }

        private void FieldChooseClick(object sender, EventArgs e)
        {
            Button FieldClicked = (Button)sender;
            if (FirstFieldChecked != FieldClicked) //double clicking possibly situation cancel
            {
                FieldClicked.Text = RandomWordLocation[(int.Parse(FieldClicked.Name.Substring(5)))-1];
                switch (ActiveFieldClicked)
                {
                    case 0:
                        ActiveFieldClicked = 1;
                        FieldClicked.BackColor = Color.FloralWhite;
                        FieldClicked.ForeColor = Color.Black;
                        FirstFieldChecked = FieldClicked;               //remember first field clicked
                        break;
                    case 1:
                        //second field was ticked, checking fields if there are the same words
                        if (FieldClicked.Text == FirstFieldChecked.Text)
                        {
                            ActiveFieldClicked = 0;
                            FieldClicked.BackColor = Color.FloralWhite;
                            FieldClicked.ForeColor = Color.Black;
                            FieldClicked.Enabled = false;
                            FirstFieldChecked.Enabled = false;
                            FirstFieldChecked = new Button();
                            FieldsSolved += 2;
                            if (((LevelConfirmation == "EASY") & (FieldsSolved == 8)) | ((LevelConfirmation == "HARD") & (FieldsSolved == 16))) //last field selected
                            {
                                PlayingTime.Stop();
                                TimeSpan PlayedTime = DateTime.Now - BeginTime;
                                SolvingTimeinSeconds = (int)PlayedTime.TotalSeconds;
                                FieldsSolved = 0;
                            }
                        }
                        else
                        {
                            ActiveFieldClicked = 2;
                            FieldClicked.BackColor = Color.FloralWhite;
                            FieldClicked.ForeColor = Color.Black;
                        }
                        //left chances quantity and minimal guess chances achieving time (game over) showing
                        iChancesQuantity--;
                        LeftChanches.Text = iChancesQuantity.ToString();
                        if (iChancesQuantity == 0)
                        {
                            Field1.Enabled = Field2.Enabled = Field3.Enabled = Field4.Enabled = Field5.Enabled = Field6.Enabled = Field7.Enabled = Field8.Enabled = 
                                Field9.Enabled = Field10.Enabled = Field11.Enabled = Field12.Enabled = Field13.Enabled = Field14.Enabled = Field15.Enabled = Field16.Enabled = false;

                            PlayingTime.Stop();

                            if (SolvingTimeinSeconds > 0)
                            {
                                var result = MessageBox.Show("Would You like to play again?", "Congratulations, success just in time.",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    //play again choosed

                                }

                            }
                            else
                            {
                                var result1 = MessageBox.Show("Would You like to play again?", "Unfortunately, guess chances are over.",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result1 == DialogResult.Yes)
                                {
                                    //play again choosed

                                }
                            }
                        }
                        break;
                    case -1:
                        ActiveFieldClicked = 1;
                        FieldsSolved = 0;
                        BeginTime = DateTime.Now;
                        PlayingTime.Start();
                        FieldClicked.BackColor = Color.FloralWhite;
                        FieldClicked.ForeColor = Color.Black;
                        FirstFieldChecked = FieldClicked;               //remember first field clicked
                        break;
                    default:
                        break;
                }
            }
        }

        public void GetRandomIndex (int WordQuantity)
        {
            try
            {
                if (WordSelected.Length > 8)
                {
                    RandomIndexWordSelected = new int [WordQuantity];
                    RandomWordPlace = new int [WordQuantity * 2];
                    RandomWordLocation = new String [WordQuantity * 2];
                    Random RandomWordIndex = new Random();
                    int iRanWorInd;
                    String sIndexCollection;

                    sIndexCollection = "";
                    for (int position = 0; position < WordQuantity; position++)
                    {
                        //excluding possibility of random index duplicate 
                        do
                        {
                            iRanWorInd = RandomWordIndex.Next(WordSelected.Length);
                        }
                        while (sIndexCollection.StartsWith(iRanWorInd.ToString() + ",") | sIndexCollection.Contains("," + iRanWorInd.ToString() + ","));
                        sIndexCollection += iRanWorInd.ToString() + ",";
                        RandomIndexWordSelected[position] = iRanWorInd;
                    }

                    sIndexCollection = "";
                    int iBegining = 0;
                    int iEnding = WordQuantity * 2;
                    for (int position = 0; position < WordQuantity * 2; position++)
                    {
                        //excluding possibility of random index duplicate
                        do
                        {
                            iRanWorInd = RandomWordIndex.Next(iBegining, iEnding);
                            if (((iBegining == iRanWorInd) | sIndexCollection.StartsWith(iBegining.ToString() + ",") | sIndexCollection.Contains("," + iBegining.ToString() + ",")) & (iBegining < iEnding - 1))
                                iBegining++;
                            if (((iEnding - 1 == iRanWorInd) | sIndexCollection.StartsWith((iEnding - 1).ToString() + ",") | sIndexCollection.Contains("," + (iEnding - 1).ToString() + ",")) & (iEnding - 1 > iBegining))
                                iEnding--;
                        }
                        while (sIndexCollection.StartsWith(iRanWorInd.ToString() + ",") | sIndexCollection.Contains("," + iRanWorInd.ToString() + ","));
                        sIndexCollection += iRanWorInd.ToString() + ",";
                        RandomWordPlace[position] = iRanWorInd;
                    }
                    //RandomWordLocation (random word in the random field located); WordSelected
                    RandomWordLocation[RandomWordPlace[0]] = RandomWordLocation[RandomWordPlace[1]] = WordSelected[RandomIndexWordSelected[0]];
                    RandomWordLocation[RandomWordPlace[2]] = RandomWordLocation[RandomWordPlace[3]] = WordSelected[RandomIndexWordSelected[1]];
                    RandomWordLocation[RandomWordPlace[4]] = RandomWordLocation[RandomWordPlace[5]] = WordSelected[RandomIndexWordSelected[2]];
                    RandomWordLocation[RandomWordPlace[6]] = RandomWordLocation[RandomWordPlace[7]] = WordSelected[RandomIndexWordSelected[3]];
                    if (WordQuantity == 8)
                    {
                        RandomWordLocation[RandomWordPlace[8]] = RandomWordLocation[RandomWordPlace[9]] = WordSelected[RandomIndexWordSelected[4]];
                        RandomWordLocation[RandomWordPlace[10]] = RandomWordLocation[RandomWordPlace[11]] = WordSelected[RandomIndexWordSelected[5]];
                        RandomWordLocation[RandomWordPlace[12]] = RandomWordLocation[RandomWordPlace[13]] = WordSelected[RandomIndexWordSelected[6]];
                        RandomWordLocation[RandomWordPlace[14]] = RandomWordLocation[RandomWordPlace[15]] = WordSelected[RandomIndexWordSelected[7]];
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Exception: ");
            }
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Task_1
{
    public partial class MemoryGame : Form
    {
        #region variable settings
        public String LevelConfirmation, SavedDataPath;
        public String[] WordSelected;
        public String[] RandomWordLocation;
        public int[] RandomIndexWordSelected, RandomWordPlace;
        public int iPosition = 0, iChancesQuantity, WordsSelectedQuantity;
        private int ActiveFieldClicked = -1, FieldsSolved, SolvingTimeinSeconds = 0;
        private Button FirstFieldChecked;
        public DateTime BeginTime;
        #endregion

        public MemoryGame()
        {
            InitializeComponent();

            //data gathering from the file
            if (DataGathering() == "OK")
            {
                NewGameStart();
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
                    using (StreamReader WordsRead = new StreamReader(ReadDataFile.FileName))
                    {
                        SavedDataPath = ReadDataFile.FileName;
                        String FileData = WordsRead.ReadToEnd();
                        if (FileData != "")
                        {
                            //selecting gathered data
                            String sFileData = FileData.Replace("\r", "");
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

        private void Field_MouseLeave(object sender, EventArgs e)
        {
            if (ActiveFieldClicked == 2)          //fields texts are different, close the open fields
            {
                ActiveFieldClicked = 0;
                Button bInfo = (Button)sender;
                bInfo.Text = "";
                bInfo.BackColor = Color.LightGray;

                FirstFieldChecked.Text = "";
                FirstFieldChecked.BackColor = Color.LightGray;
                FirstFieldChecked = new Button();
            }
        }

        private void NewGameSelection_Click(object sender, EventArgs e)
        {
            NewGameStart();
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
                FieldClicked.Text = RandomWordLocation[(int.Parse(FieldClicked.Name.Substring(5)))-1];      //taking number of the field clicked
                switch (ActiveFieldClicked)
                {
                    case 0:
                        ActiveFieldClicked = 1;
                        FieldClicked.BackColor = Color.FloralWhite;
                        FirstFieldChecked = FieldClicked;                       //remember first field clicked
                        break;
                    case 1:
                        iChancesQuantity--;
                        LeftChanches.Text = iChancesQuantity.ToString();
                        if ((FieldClicked.Text == FirstFieldChecked.Text) & (iChancesQuantity == 0))
                        {
                            ActiveFieldClicked = 0;
                            FieldClicked.BackColor = Color.FloralWhite;
                            FieldClicked.Enabled = false;
                            FirstFieldChecked.Enabled = false;
                            FirstFieldChecked = new Button();
                            FieldsSolved += 2;
                            if (((LevelConfirmation == "EASY") & (FieldsSolved == 8)) | ((LevelConfirmation == "HARD") & (FieldsSolved == 16))) //last field selected
                            {
                                PlayingTime.Stop();
                                TimeSpan PlayedTime = DateTime.Now - BeginTime;
                                SolvingTimeinSeconds = (int)PlayedTime.TotalSeconds;
                                lTimer.Text = SolvingTimeinSeconds.ToString() + " s";
                                FieldsSolved = 0;
                                //game confirmation
                                GameConfirmation GamCon = new GameConfirmation();
                                GamCon.ScoreFilePath = SavedDataPath;
                                GamCon.Level.Text = LevelConfirmation;
                                switch (LevelConfirmation)
                                {
                                    case "EASY":
                                        GamCon.GuessedChances.Text = (10 - iChancesQuantity).ToString();
                                        break;
                                    case "HARD":
                                        GamCon.GuessedChances.Text = (15 - iChancesQuantity).ToString();
                                        break;
                                    default:
                                        break;
                                }
                                GamCon.TimeSolving.Text = SolvingTimeinSeconds.ToString() + " sec";
                                GamCon.ShowDialog();
                                if (GamCon.NewGame)
                                {
                                    NewGameStart();
                                }
                            }
                            else
                            {
                                switch (MessageBox.Show("Would You like to play again?", "Unfortunately, guess chances are over.", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                                {
                                    case DialogResult.Yes:
                                        NewGameStart();
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                        else if (FieldClicked.Text == FirstFieldChecked.Text)        //second field was ticked, checking fields if there are the same words
                        {
                            ActiveFieldClicked = 0;
                            FieldClicked.BackColor = Color.FloralWhite;
                            FieldClicked.Enabled = false;
                            FirstFieldChecked.Enabled = false;
                            FirstFieldChecked = new Button();
                            FieldsSolved += 2;
                            if (((LevelConfirmation == "EASY") & (FieldsSolved == 8)) | ((LevelConfirmation == "HARD") & (FieldsSolved == 16))) //last field selected
                            {
                                PlayingTime.Stop();
                                TimeSpan PlayedTime = DateTime.Now - BeginTime;
                                SolvingTimeinSeconds = (int)PlayedTime.TotalSeconds;
                                lTimer.Text = SolvingTimeinSeconds.ToString() + " s";
                                FieldsSolved = 0;
                                //game confirmation
                                GameConfirmation GamCon = new GameConfirmation();
                                GamCon.ScoreFilePath = SavedDataPath;
                                GamCon.Level.Text = LevelConfirmation;
                                switch (LevelConfirmation)
                                {
                                    case "EASY":
                                        GamCon.GuessedChances.Text = (10 - iChancesQuantity).ToString();
                                        break;
                                    case "HARD":
                                        GamCon.GuessedChances.Text = (15 - iChancesQuantity).ToString();
                                        break;
                                    default:
                                        break;
                                }
                                GamCon.TimeSolving.Text = SolvingTimeinSeconds.ToString() + " sec";
                                GamCon.ShowDialog();
                                if (GamCon.NewGame) {
                                    NewGameStart();
                                }
                            }
                        }
                        else if (iChancesQuantity == 0)         //left chances quantity and minimal guess chances achieving time (game over) showing
                        {
                            PlayingTime.Stop();
                            FieldClicked.BackColor = Color.FloralWhite;
                            Field1.Enabled = Field2.Enabled = Field3.Enabled = Field4.Enabled = Field5.Enabled = Field6.Enabled = 
                                Field7.Enabled = Field8.Enabled = Field9.Enabled = Field10.Enabled = Field11.Enabled = Field12.Enabled = 
                                Field13.Enabled = Field14.Enabled = Field15.Enabled = Field16.Enabled = false;

                            switch (MessageBox.Show("Would You like to play again?", "Unfortunately, guess chances are over.2", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                            {
                                case DialogResult.Yes:
                                    NewGameStart();
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            ActiveFieldClicked = 2;
                            FieldClicked.BackColor = Color.FloralWhite;
                        }
                        break;
                    case -1:
                        ActiveFieldClicked = 1;
                        FieldsSolved = 0;
                        BeginTime = DateTime.Now;
                        PlayingTime.Start();
                        FieldClicked.BackColor = Color.FloralWhite;
                         FirstFieldChecked = FieldClicked;               //remember first field clicked
                        break;
                    default:
                        break;
                }
            }
        }

        public void NewGameStart ()
        {
            //select difficulty level
            DifficultyLevelSelecting wDiffSel = new DifficultyLevelSelecting();
            wDiffSel.ShowDialog();
            LevelConfirmation = wDiffSel.LevelConfirmation;
            LevelPlayed.Text = LevelConfirmation;

            PlayingTime.Stop();
            lTimer.Text = "0 s";
            FieldsSolved = 0;
            ActiveFieldClicked = -1;

            Field1.Enabled = Field2.Enabled = Field3.Enabled = Field4.Enabled = 
                Field5.Enabled = Field6.Enabled = Field7.Enabled = Field8.Enabled =
                Field9.Enabled = Field10.Enabled = Field11.Enabled = Field12.Enabled = 
                Field13.Enabled = Field14.Enabled = Field15.Enabled = Field16.Enabled = true;

            Field1.BackColor = Field2.BackColor = Field3.BackColor = Field4.BackColor =
                Field5.BackColor = Field6.BackColor = Field7.BackColor = Field8.BackColor =
                Field9.BackColor = Field10.BackColor = Field11.BackColor = Field12.BackColor =
                Field13.BackColor = Field14.BackColor = Field15.BackColor = Field16.BackColor = Color.LightGray;

            try
            {
                switch (LevelConfirmation)
                {
                    case "EASY":
                        iChancesQuantity = 10;
                        GetRandomIndex(4);             //gathered data are randomly treated
                        Field1.Text = Field2.Text = Field3.Text = Field4.Text =
                            Field5.Text = Field6.Text = Field7.Text = Field8.Text = "";
                        Field9.Visible = Field10.Visible = Field11.Visible = Field12.Visible =
                            Field13.Visible = Field14.Visible = Field15.Visible = Field16.Visible = false;
                        this.Height = 530;
                        break;
                    case "HARD":
                        iChancesQuantity = 15;
                        GetRandomIndex(8);            //gathered data are randomly treated
                        Field1.Text = Field2.Text = Field3.Text = Field4.Text =
                            Field5.Text = Field6.Text = Field7.Text = Field8.Text =
                        Field9.Text = Field10.Text = Field11.Text = Field12.Text =
                            Field13.Text = Field14.Text = Field15.Text = Field16.Text = "";
                        Field9.Visible = Field10.Visible = Field11.Visible = Field12.Visible =
                            Field13.Visible = Field14.Visible = Field15.Visible = Field16.Visible = true;
                        Field9.Text = Field10.Text = Field11.Text = Field12.Text =
                            Field13.Text = Field14.Text = Field15.Text = Field16.Text = "";
                        this.Height = 730;
                        break;
                    default:
                        break;
                }
                LeftChanches.Text = iChancesQuantity.ToString();
            }
            catch (Exception e)
            {
                //MessageBox.Show("Exception: " + e.Message);
            }
        }
    }
}

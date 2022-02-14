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

namespace Task_1
{
    public partial class MemoryGame : Form
    {
        #region variable settings
        public string LevelConfirmation = "";
        public string[] WordSelected;
        public int[] RandomIndexWordSelected;
        public int iPosition = 0;
        string strDat = @"profit
smell
deserted
evasive
pull
share
achiever
ignore
pest
donkey
unbiased
confuse
bike
receptive
feeling
soak
sturdy
muddled
pump
room
stale
event
hospitable
claim
string
jellyfish
cover
equable
cute
cheap
efficacious
confused
neck
quickest
maid
zippy
hilarious
frail
supreme
phobic
welcome
buzz
axiomatic
telephone
daughter
vulgar
hateful
income
surround
curious
reading
fluttering
chalk
irritate
woozy
battle
ray
rat
tap
false
thunder
melted
pack
assorted
box
earth
committee
remarkable
memorize
jam
beginner
entertain
elfin
end
teeny
imminent
puzzled
near
yam
addition
picture
probable
painstaking
doctor
diligent
cynical
trade
half
burn
comparison
grade
few
productive
jelly
shaky
sort
action
materialistic
skin
little";
        #endregion

        public MemoryGame()
        {
            InitializeComponent();

            //select difficulty level
            DifficultyLevelSelecting wDiffSel = new DifficultyLevelSelecting();
            wDiffSel.ShowDialog();
            LevelConfirmation = wDiffSel.LevelConfirmation;

            //gathering data from the existing file
            try
            {
                //String sFileMark = Path.Combine("Words.txt");
                //if (System.IO.File.Exists(sFileMark))
                //{
                //    using (StreamReader srStrRea = new StreamReader(sFileMark))
                //    {
                //        String strFileData = srStrRea.ReadToEnd();
                //        if (strFileData != "")
                //        {
                //            //selecting gathered data
                //            tBFileData.Text = strFileData;
                tBFileData.Text = strDat;       //only for tests
                String strFileData = strDat.Replace("\r","");    //only for tests
                WordSelected = strFileData.Split('\n');
                if (WordSelected.Length > 0) 
                {
                    //tB2.Text = "first" + WordSelected[0] + "' all together" + WordSelected.Length.ToString();
                    
                    //random words selection
                    switch (LevelConfirmation)
                    {
                        case "EASY":
                            GetRandomIndex(4); break;
                        case "HARD":
                            GetRandomIndex(8); break;
                        default:
                            break;
                    }
                    int iPossss = RandomIndexWordSelected[0];

                }

                else
                    {
                        //choose another random data
                    }
                //        }
                //        else
                //        {
                //            //choose another random data
                //        }
                //    }
                //}
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
        }

        private void GetRandomIndex (int WordQuantity)
        {
            RandomIndexWordSelected = new int[WordQuantity];
            Random RandomWordIndex = new Random();
            for (int position = 0; position < WordQuantity; position++)
                RandomIndexWordSelected[position] = RandomWordIndex.Next(100);
        }
    }
}

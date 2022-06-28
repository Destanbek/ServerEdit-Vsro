using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerEditVsro
{
    public partial class gorevekleme : Form
    {
        public gorevekleme()
        {
            InitializeComponent();
        }

        private void gorevekleme_Load(object sender, EventArgs e)
        {
            if (Language.Default.language == "English")
            {
             richTextBox1.Text =
             "part 1; It is the function of our task. The name of this function must be the same as the codename in the line we will add to _RefQuest.\r\n" +
             "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------->\r\n" +
             "part number 2; It is the command that allows to get the ID of our task. The ID of the task with the codename QNO_VENUS_ROC is retrieved and processed with this command. It has to be the same as the codename in the line we will add to _RefQuest.\r\n" +
             "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------->\r\n" +
             "part number 3; It is the starting condition of our task. QSC_LEVEL, the first part of 1.1 is the max level, the second is the min level requirement. If you do 1.1, the quest is available at all levels.\r\n" +
             "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------->\r\n" +
             "part number 4; Conversation window is active/inactive, 1 means active.\r\n" +
             "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------->\r\n" +
             "part 5; Initiation method means QM_CONVERSATION in speech form. The number 1 is the number of npc, and in the next section the code of the corresponding npc.\r\n" +
             "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------->\r\n" +
             "part 6; Mission completion npc. and this npc's code\r\n" +
             "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------->\r\n" +
             "part 7; The number of npc the quest will appear on and the code of the npc\r\n" +
             "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------->\r\n" +
             "part 8; The number of times to complete the task, 0 means it can be done an unlimited number of times.\r\n" +
             "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------->\r\n" +
             "part number 9; The limit of the data size in the code part of the task, based on the QuestID here. The number 1 also indicates the number of definitions based on. Only Quest here\r\n" +
             "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------->\r\n" +
             "part 10; MISSION_TYPE_GATHER_ITEM_FROM_MONSTER The way the task is done means collecting items from the mob, all parts starting with SN_ are talking about the articles that will appear in the game. We will use them later in the media section. The code of our NPC is also here, the code of the item to drop and how much of this item should be collected are available in 1.1, if we make 1.20, we need to collect 20. The mob's code and the last 100 digits are the probability of the item dropping from this mob. 100 means 100% probability.\r\n" +
             "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------->\r\n" +
             "part 11; NPC and the part of the quest window with the conversation windows\r\n" +
             "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------->\r\n" +
             "part number 12; The number of times to complete the task, 0 means it can be done an unlimited number of times.\r\n" +
             "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------->\r\n" +
             "part 13; The way the quest rewards are given, 1 means getting it with a pop-up window from an npc.\r\n" +
             "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------->\r\n" +
             "part 15; The part where quest rewards are defined. The first 4 zeros have to be there, different mission rewards such as exp, gold, zerk are used in this area. In the next part, the number 1 before the item code indicates whether this item is active as a reward, and how many of these items will be given in the number after the item code.\r\n" +
             "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------->\r\n" +
             "section 16; The part where you can give skill points as a quest reward\r\n" +
             "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------->\r\n" +
             "part 17; If our end command is not the end where the function ends, gameserver will say that our lua is wrong and will not process the task.\r\n" +
             "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------->";
             label1.Text = "Do not forget that in the next database and media sections, our item numbers, QuestID and task codename must be consistent with lua.\r\n2 - Database; ";
             linkLabel1.Text = "download link";
             linkLabel1.Location = new Point(781,31);
             button1.Text = "Back";
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.mediafire.com/file/f0wen11kevlvmri/G%25C3%25B6rev_ekleme.rar/file");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

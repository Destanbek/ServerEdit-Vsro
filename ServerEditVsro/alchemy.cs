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
    public partial class alchemy : Form
    {
        public alchemy()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            radioButton9.Checked = radioButton10.Checked = radioButton11.Checked = radioButton12.Checked = radioButton13.Checked = radioButton14.Checked = radioButton15.Checked = radioButton16.Checked = radioButton17.Checked = radioButton18.Checked = radioButton19.Checked = radioButton20.Checked = radioButton21.Checked = radioButton22.Checked = radioButton23.Checked = radioButton24.Checked = radioButton25.Checked = radioButton26.Checked = radioButton27.Checked = radioButton28.Checked = radioButton29.Checked = radioButton30.Checked = radioButton31.Checked = radioButton32.Checked = radioButton33.Checked = radioButton34.Checked = radioButton35.Checked = radioButton36.Checked = radioButton37.Checked = radioButton38.Checked = radioButton39.Checked = radioButton40.Checked = radioButton41.Checked = radioButton42.Checked = radioButton43.Checked = radioButton44.Checked = radioButton45.Checked = radioButton46.Checked = radioButton47.Checked = radioButton48.Checked = false;
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
            radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = radioButton4.Checked = radioButton5.Checked = radioButton6.Checked = radioButton7.Checked = radioButton8.Checked = radioButton27.Checked = radioButton28.Checked = radioButton29.Checked = radioButton30.Checked = radioButton31.Checked = radioButton32.Checked = radioButton33.Checked = radioButton34.Checked = radioButton35.Checked = radioButton36.Checked = radioButton37.Checked = radioButton38.Checked = radioButton39.Checked = radioButton40.Checked = radioButton41.Checked = radioButton42.Checked = radioButton43.Checked = radioButton44.Checked = radioButton45.Checked = radioButton46.Checked = radioButton47.Checked = radioButton48.Checked = radioButton49.Checked = false;
        }
        private void groupBox4_Enter(object sender, EventArgs e)
        {
            radioButton9.Checked = radioButton10.Checked = radioButton11.Checked = radioButton12.Checked = radioButton13.Checked = radioButton14.Checked = radioButton15.Checked = radioButton16.Checked = radioButton17.Checked = radioButton18.Checked = radioButton19.Checked = radioButton20.Checked = radioButton21.Checked = radioButton22.Checked = radioButton23.Checked = radioButton24.Checked = radioButton25.Checked = radioButton26.Checked = radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = radioButton4.Checked = radioButton5.Checked = radioButton6.Checked = radioButton7.Checked = radioButton8.Checked = radioButton35.Checked = radioButton36.Checked = radioButton37.Checked = radioButton38.Checked = radioButton39.Checked = radioButton40.Checked = radioButton41.Checked = radioButton42.Checked = radioButton43.Checked = radioButton44.Checked = radioButton45.Checked = radioButton46.Checked = radioButton47.Checked = radioButton48.Checked = radioButton49.Checked = false;
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {
            radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = radioButton4.Checked = radioButton5.Checked = radioButton6.Checked = radioButton7.Checked = radioButton8.Checked = radioButton9.Checked = radioButton10.Checked = radioButton11.Checked = radioButton12.Checked = radioButton13.Checked = radioButton14.Checked = radioButton15.Checked = radioButton16.Checked = radioButton17.Checked = radioButton18.Checked = radioButton19.Checked = radioButton20.Checked = radioButton21.Checked = radioButton22.Checked = radioButton23.Checked = radioButton24.Checked = radioButton25.Checked = radioButton26.Checked = radioButton27.Checked = radioButton28.Checked = radioButton29.Checked = radioButton30.Checked = radioButton31.Checked = radioButton32.Checked = radioButton33.Checked = radioButton34.Checked = radioButton49.Checked = false;
        }
        private void alchemy_Load(object sender, EventArgs e)
        {
            ToolTip Aciklama = new ToolTip();
            Aciklama.ToolTipTitle = "Magic Stone of Strikes!";
            Aciklama.SetToolTip(pictureBox12, "Basılan iteme saldırı hızı özelliği ekler.");
            ToolTip Aciklama1 = new ToolTip();
            Aciklama1.ToolTipTitle = "Magic Stone of Discipline!";
            Aciklama1.SetToolTip(pictureBox14, "Basılan iteme bloke etme oran özelliği ekler.");
            ToolTip Aciklama2 = new ToolTip();
            Aciklama2.ToolTipTitle = "Magic Stone of Penetration!";
            Aciklama2.SetToolTip(pictureBox15, "Basılan iteme kritik özelliği ekler.");
            ToolTip Aciklama3 = new ToolTip();
            Aciklama3.ToolTipTitle = "Magic Stone of Dodging!";
            Aciklama3.SetToolTip(pictureBox13, "Basılan iteme parry rate özelliği ekler.");
            ToolTip Aciklama4 = new ToolTip();
            Aciklama4.ToolTipTitle = "Magic Stone of Stamina!";
            Aciklama4.SetToolTip(pictureBox16, "Basılan iteme HP özelliği ekler. Eklenen özellik karakterin canını arttırır.");
            ToolTip Aciklama5 = new ToolTip();
            Aciklama5.ToolTipTitle = "Magic Stone of Magic!";
            Aciklama5.SetToolTip(pictureBox17, "Basılan iteme MP özelliği ekler. Eklenen özellik karakterin manasını arttırır.");
            ToolTip Aciklama6 = new ToolTip();
            Aciklama6.ToolTipTitle = "Magic Stone of Master!";
            Aciklama6.SetToolTip(pictureBox11, "Basılan iteme dayanıklılık özelliği ekler. Eklenen özellik itemin dayanıklılık süresini uzatır.");
            ToolTip Aciklama7 = new ToolTip();
            Aciklama7.ToolTipTitle = "Magic Stone of Str!";
            Aciklama7.SetToolTip(pictureBox9, "Basılan iteme str özelliği ekler. Eklenen özellik karakterin str'sini ve hp arttırır.");
            ToolTip Aciklama8 = new ToolTip();
            Aciklama8.ToolTipTitle = "Magic Stone of Int!";
            Aciklama8.SetToolTip(pictureBox10, "Basılan iteme int özelliği ekler. Eklenen özellik karakterin int'ini ve mp arttırır.");
            ToolTip Aciklama9 = new ToolTip();
            Aciklama9.ToolTipTitle = "Magic Stone of Fogs!";
            Aciklama9.SetToolTip(pictureBox18, "Basılan iteme buzdan korunma özelliği ekler.");
            ToolTip Aciklama10 = new ToolTip();
            Aciklama10.ToolTipTitle = "Magic Stone of Air!";
            Aciklama10.SetToolTip(pictureBox19, "Basılan iteme elektrikten korunma özelliği ekler.");
            ToolTip Aciklama11 = new ToolTip();
            Aciklama11.ToolTipTitle = "Magic Stone of Fire!";
            Aciklama11.SetToolTip(pictureBox20, "Basılan iteme ateşten korunma özelliği ekler.");
            ToolTip Aciklama12 = new ToolTip();
            Aciklama12.ToolTipTitle = "Magic Stone of Immunity!";
            Aciklama12.SetToolTip(pictureBox21, "Basılan iteme zehirden korunma özelliği ekler.");
            ToolTip Aciklama13 = new ToolTip();
            Aciklama13.ToolTipTitle = "Magic Stone of Revival!";
            Aciklama13.SetToolTip(pictureBox22, "Basılan iteme zombiden korunma özelliği ekler.");
            ToolTip Aciklama14 = new ToolTip();
            Aciklama14.ToolTipTitle = "Magic Stone of Immortal!";
            Aciklama14.SetToolTip(pictureBox23, "Basılan itemin +5'ten sonra kaybolmasını engeller.");
            ToolTip Aciklama15 = new ToolTip();
            Aciklama15.ToolTipTitle = "Magic Stone of Astral!";
            Aciklama15.SetToolTip(pictureBox26, "Basılan itemin +5'ten sonra patlaması halinde +4 halinde kalır.");
            ToolTip Aciklama16 = new ToolTip();
            Aciklama16.ToolTipTitle = "Magic Stone of Steady!";
            Aciklama16.SetToolTip(pictureBox25, "Basılan iteme steady özelliği ekler. Eklenen özellik +5'ten sonra patlaması halinde item Kırılmasını önler.");
            ToolTip Aciklama17 = new ToolTip();
            Aciklama17.ToolTipTitle = "Magic Stone of Luck!";
            Aciklama17.SetToolTip(pictureBox24, "Basılan iteme şans özelliği ekler. Eklenen özellik artı basma anında tutma şansını arttırır.");
            ToolTip Aciklama18 = new ToolTip();
            Aciklama18.ToolTipTitle = "Magic stone of Courage!";
            Aciklama18.SetToolTip(pictureBox27, "Silahınızın fiziksel atağını özelliğini değiştirir.");
            ToolTip Aciklama19 = new ToolTip();
            Aciklama19.ToolTipTitle = "Magic stone of Warriors!";
            Aciklama19.SetToolTip(pictureBox28, "Silahınızın fiziksel reinforce özelliğini değiştirir.");
            ToolTip Aciklama20 = new ToolTip();
            Aciklama20.ToolTipTitle = "Magic stone of Philosophy!";
            Aciklama20.SetToolTip(pictureBox29, "Silahınızın magic atağını özelliğini değiştirir.");
            ToolTip Aciklama21 = new ToolTip();
            Aciklama21.ToolTipTitle = "Magic stone of Meditation!";
            Aciklama21.SetToolTip(pictureBox30, "Silahınızın magic reinforce özelliğini değiştirir.");
            ToolTip Aciklama22 = new ToolTip();
            Aciklama22.ToolTipTitle = "Magic stone of Challenge!";
            Aciklama22.SetToolTip(pictureBox31, "Silahınızın critical özelliğini değiştirir.");
            ToolTip Aciklama23 = new ToolTip();
            Aciklama23.ToolTipTitle = "Magic stone of Focus!";
            Aciklama23.SetToolTip(pictureBox32, "Silahınızın attack rate özelliğini değiştirir.");
            ToolTip Aciklama24 = new ToolTip();
            Aciklama24.ToolTipTitle = "Magic stone of Flesh!";
            Aciklama24.SetToolTip(pictureBox33, "Kıyafetinizin ve kalkanınızın fiziksel defans özelliğini değiştirir.");
            ToolTip Aciklama25 = new ToolTip();
            Aciklama25.ToolTipTitle = "Magic stone of Life!";
            Aciklama25.SetToolTip(pictureBox37, "Kıyafetinizin ve kalkanınızın fiziksel takviye özelliğini değiştirir.");
            ToolTip Aciklama26 = new ToolTip();
            Aciklama26.ToolTipTitle = "Magic stone of Mind!";
            Aciklama26.SetToolTip(pictureBox36, "Kıyafetinizin ve kalkanınızın büyü defans özelliğini değiştirir.");
            ToolTip Aciklama27 = new ToolTip();
            Aciklama27.ToolTipTitle = "Magic stone of Spirit!";
            Aciklama27.SetToolTip(pictureBox34, "Kıyafetinizin ve kalkanınızın büyü takviye özelliğini değiştirir.");
            ToolTip Aciklama28 = new ToolTip();
            Aciklama28.ToolTipTitle = "Magic stone of Dodging!";
            Aciklama28.SetToolTip(pictureBox38, "Kıyafetinizin parry rate özelliğini değiştirir.");
            ToolTip Aciklama29 = new ToolTip();
            Aciklama29.ToolTipTitle = "Magic stone of Agility!";
            Aciklama29.SetToolTip(pictureBox35, "Kalkanınızın blocking rate özelliğini değiştirir.");
            ToolTip Aciklama30 = new ToolTip();
            Aciklama30.ToolTipTitle = "Magic stone of Training!";
            Aciklama30.SetToolTip(pictureBox39, "Takınızın fiziksel emilim özelliğini değiştirir.");
            ToolTip Aciklama31 = new ToolTip();
            Aciklama31.ToolTipTitle = "Magic stone of Prayer!";
            Aciklama31.SetToolTip(pictureBox40, "Kalkanınızın büyü emilim özelliğini değiştirir.");
            ToolTip Aciklama32 = new ToolTip();
            Aciklama32.ToolTipTitle = "Magic stone of Sharpness!";
            Aciklama32.SetToolTip(pictureBox41, "Basılan iteme kritik özelliği ekler.");
            ToolTip Aciklama33 = new ToolTip();
            Aciklama33.ToolTipTitle = "Magic stone of Iron Shield!";
            Aciklama33.SetToolTip(pictureBox43, "Basılan iteme engelleme oranı özelliği ekler.");
            ToolTip Aciklama34 = new ToolTip();
            Aciklama34.ToolTipTitle = "Magic stone of Devil!";
            Aciklama34.SetToolTip(pictureBox45, "Basılan iteme HP & MP geri kazanım özelliği ekler.");
            ToolTip Aciklama35 = new ToolTip();
            Aciklama35.ToolTipTitle = "Magic stone of Guardian!";
            Aciklama35.SetToolTip(pictureBox42, "Basılan kolye eşyasına sersemlemeden (zayıf durum)'dan koruma özelliği ekler.");
            ToolTip Aciklama36 = new ToolTip();
            Aciklama36.ToolTipTitle = "Magic stone of Abyss!";
            Aciklama36.SetToolTip(pictureBox44, "Basılan küpe eşyasına yanmadan (yanma durumu)'dan koruma özelliği ekler.");
            ToolTip Aciklama37 = new ToolTip();
            Aciklama37.ToolTipTitle = "Magic stone of Incandescence!";
            Aciklama37.SetToolTip(pictureBox46, "Basılan yüzük eşyasına zehirlenmeden (hastalık durumu)'dan koruma özelliği ekler.");
            ToolTip Aciklama38 = new ToolTip();
            Aciklama38.ToolTipTitle = "Magic stone of Sorrow!";
            Aciklama38.SetToolTip(pictureBox47, "Basılan yüzük eşyasına uykudan (uyku durumu)'dan koruma özelliği ekler.");
            ToolTip Aciklama39 = new ToolTip();
            Aciklama39.ToolTipTitle = "Magic stone of Iron Heard!";
            Aciklama39.SetToolTip(pictureBox48, "Basılan yüzük eşyasına korkudan (korku durumu)'dan koruma özelliği ekler.");
            ToolTip Aciklama40 = new ToolTip();
            Aciklama40.ToolTipTitle = "Elixer Weapon!";
            Aciklama40.SetToolTip(pictureBox1, "Basılan Silah'a Artı(+) özelliği ekler.");
            ToolTip Aciklama41 = new ToolTip();
            Aciklama41.ToolTipTitle = "Elixer Shield!";
            Aciklama41.SetToolTip(pictureBox2, "Basılan Kalkan'a Artı(+) özelliği ekler.");
            ToolTip Aciklama42 = new ToolTip();
            Aciklama42.ToolTipTitle = "Elixer Protector!";
            Aciklama42.SetToolTip(pictureBox3, "Basılan Item'e (Giysi) Artı(+) özelliği ekler.");
            ToolTip Aciklama43 = new ToolTip();
            Aciklama43.ToolTipTitle = "Elixer Accessory!";
            Aciklama43.SetToolTip(pictureBox4, "Basılan Takı'ya (küpe,yüzük,kolye) Artı(+) özelliği ekler.");
            ToolTip Aciklama44 = new ToolTip();
            Aciklama44.ToolTipTitle = "Adv. Weapon!";
            Aciklama44.SetToolTip(pictureBox5, "Basılan Silah'a +2 ve üzeri özellik ekler.");
            ToolTip Aciklama45 = new ToolTip();
            Aciklama45.ToolTipTitle = "Adv. Shield!";
            Aciklama45.SetToolTip(pictureBox6, "Basılan Kalkan'a +2 ve üzeri özellik ekler.");
            ToolTip Aciklama46 = new ToolTip();
            Aciklama46.ToolTipTitle = "Adv. Protector!";
            Aciklama46.SetToolTip(pictureBox7, "Basılan Item'e +2 ve üzeri özellik ekler.");
            ToolTip Aciklama47 = new ToolTip();
            Aciklama47.ToolTipTitle = "Adv. Accessory!";
            Aciklama47.SetToolTip(pictureBox8, "Basılan Takı'ya +2 ve üzeri özellik ekler.");
            ToolTip Aciklama48 = new ToolTip();
            Aciklama48.ToolTipTitle = "Lucky Powder!";
            Aciklama48.SetToolTip(pictureBox49, "Artı Basarken Elixirlerin yanına konarak Basılar itemlerin Şans Oranını Artırır.");
           
            if (Language.Default.language == "English")
            {
                Aciklama.ToolTipTitle = "Magic Stone of Strikes!";
                Aciklama.SetToolTip(pictureBox12, "Adds attack speed to the pressed item.");
                Aciklama1.ToolTipTitle = "Magic Stone of Discipline!";
                Aciklama1.SetToolTip(pictureBox14, "Adds blocking rate feature to the pressed item.");
                Aciklama2.ToolTipTitle = "Magic Stone of Penetration!";
                Aciklama2.SetToolTip(pictureBox15, "Adds critical feature to the pressed item.");
                Aciklama3.ToolTipTitle = "Magic Stone of Dodging!";
                Aciklama3.SetToolTip(pictureBox13, "Adds parry rate feature to the pressed item.");
                Aciklama4.ToolTipTitle = "Magic Stone of Stamina!";
                Aciklama4.SetToolTip(pictureBox16, "Adds HP feature to the printed item. The added feature increases the character's health.");
                Aciklama5.ToolTipTitle = "Magic Stone of Magic!";
                Aciklama5.SetToolTip(pictureBox17, "Adds MP feature to the pressed item. The added feature increases the mana of the character.");
                Aciklama6.ToolTipTitle = "Magic Stone of Master!";
                Aciklama6.SetToolTip(pictureBox11, "Adds durability to the pressed item. The added feature extends the durability of the item.");
                Aciklama7.ToolTipTitle = "Magic Stone of Str!";
                Aciklama7.SetToolTip(pictureBox9, "Adds str property to the printed item. The added feature increases the character's str and hp.");
                Aciklama8.ToolTipTitle = "Magic Stone of Int!";
                Aciklama8.SetToolTip(pictureBox10, "Adds an int property to the printed item. Added property increments character's int and mp.");
                Aciklama9.ToolTipTitle = "Magic Stone of Fogs!";
                Aciklama9.SetToolTip(pictureBox18, "Adds ice protection feature to the pressed item.");
                Aciklama10.ToolTipTitle = "Magic Stone of Air!";
                Aciklama10.SetToolTip(pictureBox19, "Adds electrical protection feature to the pressed item.");
                Aciklama11.ToolTipTitle = "Magic Stone of Fire!";
                Aciklama11.SetToolTip(pictureBox20, "Adds fire protection feature to the pressed item.");
                Aciklama12.ToolTipTitle = "Magic Stone of Immunity!";
                Aciklama12.SetToolTip(pictureBox21, "Adds poison protection feature to the pressed item.");
                Aciklama13.ToolTipTitle = "Magic Stone of Revival!";
                Aciklama13.SetToolTip(pictureBox22, "Adds zombie protection feature to the pressed item.");
                Aciklama14.ToolTipTitle = "Magic Stone of Immortal!";
                Aciklama14.SetToolTip(pictureBox23, "It prevents the pressed item from disappearing after +5.");
                Aciklama15.ToolTipTitle = "Magic Stone of Astral!";
                Aciklama15.SetToolTip(pictureBox26, "If the pressed item explodes after +5, it remains at +4.");
                Aciklama16.ToolTipTitle = "Magic Stone of Steady!";
                Aciklama16.SetToolTip(pictureBox25, "Adds steady feature to the pressed item. The added feature prevents the item from breaking if it explodes after +5.");
                Aciklama17.ToolTipTitle = "Magic Stone of Luck!";
                Aciklama17.SetToolTip(pictureBox24, "Adds luck to the pressed item. Added feature plus increases the chance of holding at the time of pressing.");
                Aciklama18.ToolTipTitle = "Magic stone of Courage!";
                Aciklama18.SetToolTip(pictureBox27, "Changes the physical attack of your weapon.");
                Aciklama19.ToolTipTitle = "Magic stone of Warriors!";
                Aciklama19.SetToolTip(pictureBox28, "Changes the physical reinforce feature of your weapon.");
                Aciklama20.ToolTipTitle = "Magic stone of Philosophy!";
                Aciklama20.SetToolTip(pictureBox29, "Changes the magic attack of your weapon.");
                Aciklama21.ToolTipTitle = "Magic stone of Meditation!";
                Aciklama21.SetToolTip(pictureBox30, "Changes the magic reinforce feature of your weapon.");
                Aciklama22.ToolTipTitle = "Magic stone of Challenge!";
                Aciklama22.SetToolTip(pictureBox31, "Changes the critical stat of your weapon.");
                Aciklama23.ToolTipTitle = "Magic stone of Focus!";
                Aciklama23.SetToolTip(pictureBox32, "Changes the attack rate of your weapon.");
                Aciklama24.ToolTipTitle = "Magic stone of Flesh!";
                Aciklama24.SetToolTip(pictureBox33, "Changes the physical defense of your outfit and shield.");
                Aciklama25.ToolTipTitle = "Magic stone of Life!";
                Aciklama25.SetToolTip(pictureBox37, "Changes the physical reinforcement of your outfit and shield.");
                Aciklama26.ToolTipTitle = "Magic stone of Mind!";
                Aciklama26.SetToolTip(pictureBox36, "Changes the magic defense of your outfit and shield.");
                Aciklama27.ToolTipTitle = "Magic stone of Spirit!";
                Aciklama27.SetToolTip(pictureBox34, "Changes the magic boost of your outfit and shield.");
                Aciklama28.ToolTipTitle = "Magic stone of Dodging!";
                Aciklama28.SetToolTip(pictureBox38, "Changes the parry rate of your outfit.");
                Aciklama29.ToolTipTitle = "Magic stone of Agility!";
                Aciklama29.SetToolTip(pictureBox35, "Changes the blocking rate of your shield.");
                Aciklama30.ToolTipTitle = "Magic stone of Training!";
                Aciklama30.SetToolTip(pictureBox39, "Changes the physical absorption of your jewelry.");
                Aciklama31.ToolTipTitle = "Magic stone of Prayer!";
                Aciklama31.SetToolTip(pictureBox40, "Changes your shield's ability to absorb magic.");
                Aciklama32.ToolTipTitle = "Magic stone of Sharpness!";
                Aciklama32.SetToolTip(pictureBox41, "Adds critical feature to the pressed item.");
                Aciklama33.ToolTipTitle = "Magic stone of Iron Shield!";
                Aciklama33.SetToolTip(pictureBox43, "Adds blocking rate feature to the pressed item.");
                Aciklama34.ToolTipTitle = "Magic stone of Devil!";
                Aciklama34.SetToolTip(pictureBox45, "Adds HP & MP recovery feature to the pressed item.");
                Aciklama35.ToolTipTitle = "Magic stone of Guardian!";
                Aciklama35.SetToolTip(pictureBox42, "Adds protection from stun (weakness) to the pressed necklace item.");
                Aciklama36.ToolTipTitle = "Magic stone of Abyss!";
                Aciklama36.SetToolTip(pictureBox44, "Adds protection from burning (burning condition) to the printed earring item.");
                Aciklama37.ToolTipTitle = "Magic stone of Incandescence!";
                Aciklama37.SetToolTip(pictureBox46, "Adds protection from poisoning (illness) to the printed ring item.");
                Aciklama38.ToolTipTitle = "Magic stone of Sorrow!";
                Aciklama38.SetToolTip(pictureBox47, "Adds a feature to protect the printed ring item from sleep (sleep state).");
                Aciklama39.ToolTipTitle = "Magic stone of Iron Heard!";
                Aciklama39.SetToolTip(pictureBox48, "Adds protection from fear (fear state) to the printed ring item.");
                Aciklama40.ToolTipTitle = "Elixer Weapon!";
                Aciklama40.SetToolTip(pictureBox1, "Adds Plus(+) feature to Pressed Weapon.");
                Aciklama41.ToolTipTitle = "Elixer Shield!";
                Aciklama41.SetToolTip(pictureBox2, "Adds Plus(+) to the pressed Shield.");
                Aciklama42.ToolTipTitle = "Elixer Protector!";
                Aciklama42.SetToolTip(pictureBox3, "Adds Plus (+) feature to the printed Item (Clothes).");
                Aciklama43.ToolTipTitle = "Elixer Accessory!";
                Aciklama43.SetToolTip(pictureBox4, "Adds Plus (+) feature to Printed Jewelry (earrings, rings, necklaces).");
                Aciklama44.ToolTipTitle = "Adv. Weapon!";
                Aciklama44.SetToolTip(pictureBox5, "Adds +2 or more to the Pressed Weapon.");
                Aciklama45.ToolTipTitle = "Adv. Shield!";
                Aciklama45.SetToolTip(pictureBox6, "Adds +2 or more to the pressed Shield.");
                Aciklama46.ToolTipTitle = "Adv. Protector!";
                Aciklama46.SetToolTip(pictureBox7, "Adds +2 or more features to the pressed Item.");
                Aciklama47.ToolTipTitle = "Adv. Accessory!";
                Aciklama47.SetToolTip(pictureBox8, "Adds +2 or more features to Printed Jewelry.");
                Aciklama48.ToolTipTitle = "Lucky Powder!";
                Aciklama48.SetToolTip(pictureBox49, "Pressing Plus by being placed next to Elixirs Increases the Chance Rate of the items."); label1.Text = "Stones for Weapons";
                label2.Text = "Stones for the Shield";
                label3.Text = "Stones for Clothes";
                label4.Text = "Stones for the Rings";
                label5.Text = "Special Tablets";
                label6.Text = "Stones for Weapons";
                label7.Text = "Stones for Weapons";
                label8.Text = "Stones for Shield and Suits";
                label9.Text = "Stones for the Rings";
                label10.Text = "Stone for the Shield";
                label11.Text = "Stone for Clothes";
                label12.Text = "Stone for Rings";
                button1.Text = "Show Code";
                button2.Text = "Back";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_REINFORCE_RECIPE_WEAPON_A 50"; }
            if (radioButton2.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_REINFORCE_RECIPE_SHIELD_A 50"; }
            if (radioButton3.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_REINFORCE_RECIPE_ARMOR_A 50"; }
            if (radioButton4.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_REINFORCE_RECIPE_ACCESSARY_A 50"; }
            if (radioButton5.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_UPPER_REINFORCE_RECIPE_WE_A_0 1"; }
            if (radioButton6.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_UPPER_REINFORCE_RECIPE_SH_A_0 1"; }
            if (radioButton7.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_UPPER_REINFORCE_RECIPE_PR_A_0 1"; }
            if (radioButton8.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_UPPER_REINFORCE_RECIPE_AC_A_0 1"; }
            if (radioButton9.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DUR_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DUR_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DUR_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DUR_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DUR_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DUR_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DUR_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DUR_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DUR_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DUR_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DUR_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DUR_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DUR_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DUR_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DUR_15 50"; }
            if (radioButton10.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_EVADE_BLOCK_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_EVADE_BLOCK_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_EVADE_BLOCK_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_EVADE_BLOCK_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_EVADE_BLOCK_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_EVADE_BLOCK_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_EVADE_BLOCK_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_EVADE_BLOCK_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_EVADE_BLOCK_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_EVADE_BLOCK_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_EVADE_BLOCK_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_EVADE_BLOCK_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_EVADE_BLOCK_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_EVADE_BLOCK_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_EVADE_BLOCK_15 50"; }
            if (radioButton11.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ER_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ER_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ER_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ER_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ER_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ER_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ER_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ER_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ER_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ER_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ER_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ER_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ER_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ER_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ER_15 50"; }
            if (radioButton12.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_HP_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_HP_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_HP_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_HP_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_HP_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_HP_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_HP_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_HP_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_HP_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_HP_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_HP_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_HP_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_HP_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_HP_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_HP_15 50"; }
            if (radioButton13.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_MP_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_MP_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_MP_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_MP_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_MP_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_MP_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_MP_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_MP_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_MP_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_MP_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_MP_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_MP_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_MP_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_MP_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_MP_15 50"; }
            if (radioButton14.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DUR_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DUR_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DUR_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DUR_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DUR_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DUR_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DUR_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DUR_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DUR_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DUR_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DUR_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DUR_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DUR_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DUR_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DUR_15 50"; }
            if (radioButton15.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_STR_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_STR_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_STR_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_STR_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_STR_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_STR_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_STR_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_STR_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_STR_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_STR_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_STR_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_STR_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_STR_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_STR_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_STR_15 50"; }
            if (radioButton16.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_INT_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_INT_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_INT_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_INT_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_INT_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_INT_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_INT_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_INT_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_INT_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_INT_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_INT_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_INT_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_INT_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_INT_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_INT_15 50"; }
            if (radioButton17.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_FROSTBITE_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_FROSTBITE_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_FROSTBITE_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_FROSTBITE_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_FROSTBITE_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_FROSTBITE_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_FROSTBITE_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_FROSTBITE_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_FROSTBITE_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_FROSTBITE_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_FROSTBITE_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_FROSTBITE_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_FROSTBITE_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_FROSTBITE_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_FROSTBITE_15 50"; }
            if (radioButton18.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_BURN_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_BURN_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_BURN_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_BURN_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_BURN_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_BURN_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_BURN_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_BURN_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_BURN_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_BURN_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_BURN_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_BURN_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_BURN_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_BURN_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_BURN_15 50"; }
            if (radioButton19.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_POISON_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_POISON_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_POISON_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_POISON_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_POISON_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_POISON_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_POISON_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_POISON_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_POISON_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_POISON_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_POISON_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_POISON_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_POISON_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_POISON_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_POISON_15 50"; }
            if (radioButton20.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ESHOCK_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ESHOCK_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ESHOCK_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ESHOCK_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ESHOCK_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ESHOCK_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ESHOCK_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ESHOCK_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ESHOCK_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ESHOCK_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ESHOCK_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ESHOCK_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ESHOCK_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ESHOCK_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ESHOCK_15 50"; }
            if (radioButton21.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_POISON_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_POISON_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_POISON_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_POISON_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_POISON_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_POISON_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_POISO_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_POISON_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_POISON_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_POISON_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_POISON_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_POISON_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_POISON_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_POISON_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_POISON_15 50"; }
            if (radioButton22.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ATHANASIA_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ATHANASIA_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ATHANASIA_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ATHANASIA_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ATHANASIA_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ATHANASIA_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ATHANASIA_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ATHANASIA_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ATHANASIA_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ATHANASIA_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ATHANASIA_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ATHANASIA_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ATHANASIA_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ATHANASIA_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ATHANASIA_15 50"; }
            if (radioButton23.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ASTRAL_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ASTRAL_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ASTRAL_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ASTRAL_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ASTRAL_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ASTRAL_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ASTRAL_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ASTRAL_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ASTRAL_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ASTRAL_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ASTRAL_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ASTRAL_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ASTRAL_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ASTRAL_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ASTRAL_15 50"; }
            if (radioButton24.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_SOLID_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_SOLID_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_SOLID_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_SOLID_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_SOLID_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_SOLID_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_SOLID_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_SOLID_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_SOLID_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_SOLID_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_SOLID_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_SOLID_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_SOLID_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_SOLID_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_SOLID_15 50"; }
            if (radioButton25.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_LUCK_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_LUCK_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_LUCK_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_LUCK_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_LUCK_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_LUCK_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_LUCK_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_LUCK_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_LUCK_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_LUCK_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_LUCK_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_LUCK_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_LUCK_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_LUCK_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_LUCK_15 50"; }
            if (radioButton26.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_EVADE_CRITICAL_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_EVADE_CRITICAL_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_EVADE_CRITICAL_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_EVADE_CRITICAL_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_EVADE_CRITICAL_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_EVADE_CRITICAL_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_EVADE_CRITICAL_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_EVADE_CRITICAL_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_EVADE_CRITICAL_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_EVADE_CRITICAL_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_EVADE_CRITICAL_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_EVADE_CRITICAL_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_EVADE_CRITICAL_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_EVADE_CRITICAL_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_EVADE_CRITICAL_15 50"; }
            if (radioButton27.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_SHARP_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_SHARP_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_SHARP_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_SHARP_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_SHARP_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_SHARP_15 50"; }
            if (radioButton28.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DEVIL_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DEVIL_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DEVIL_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DEVIL_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DEVIL_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_DEVIL_15 50"; }
            if (radioButton29.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_GUARD_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_GUARD_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_GUARD_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_GUARD_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_GUARD_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_GUARD_15 50"; }
            if (radioButton30.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_STUPOR_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_STUPOR_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_STUPOR_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_STUPOR_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_STUPOR_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_STUPOR_15 50"; }
            if (radioButton31.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_HEAT_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_HEAT_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_HEAT_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_HEAT_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_HEAT_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_HEAT_15 50"; }
            if (radioButton32.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ABYSS_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ABYSS_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ABYSS_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ABYSS_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ABYSS_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_ABYSS_15 50"; }
            if (radioButton33.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_STRONGMIND_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_STRONGMIND_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_STRONGMIND_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_STRONGMIND_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_STRONGMIND_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_STRONGMIND_15 50"; }
            if (radioButton34.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_IRONWALL_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_IRONWALL_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_IRONWALL_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_IRONWALL_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_IRONWALL_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_MAGICSTONE_IRONWALL_15 50"; }
            if (radioButton35.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PA_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PA_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PA_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PA_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PA_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PA_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PA_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PA_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PA_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PA_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PA_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PA_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PA_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PA_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PA_15 50"; }
            if (radioButton36.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MA_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MA_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MA_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MA_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MA_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MA_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MA_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MA_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MA_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MA_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MA_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MA_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MA_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MA_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MA_15 50"; }
            if (radioButton37.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_CRITICAL_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_CRITICAL_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_CRITICAL_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_CRITICAL_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_CRITICAL_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_CRITICAL_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_CRITICAL_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_CRITICAL_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_CRITICAL_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_CRITICAL_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_CRITICAL_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_CRITICAL_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_CRITICAL_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_CRITICAL_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_CRITICAL_15 50"; }
            if (radioButton38.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PASTR_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PASTR_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PASTR_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PASTR_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PASTR_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PASTR_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PASTR_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PASTR_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PASTR_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PASTR_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PASTR_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PASTR_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PASTR_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PASTR_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PASTR_15 50"; }
            if (radioButton39.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MAINT_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MAINT_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MAINT_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MAINT_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MAINT_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MAINT_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MAINT_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MAINT_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MAINT_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MAINT_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MAINT_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MAINT_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MAINT_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MAINT_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MAINT_15 50"; }
            if (radioButton40.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_HR_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_HR_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_HR_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_HR_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_HR_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_HR_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_HR_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_HR_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_HR_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_HR_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_HR_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_HR_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_HR_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_HR_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_HR_15 50"; }
            if (radioButton41.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PD_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PD_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PD_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PD_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PD_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PD_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PD_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PD_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PD_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PD_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PD_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PD_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PD_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PD_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PD_15 50"; }
            if (radioButton42.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_BR_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_BR_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_BR_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_BR_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_BR_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_BR_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_BR_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_BR_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_BR_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_BR_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_BR_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_BR_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_BR_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_BR_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_BR_15 50"; }
            if (radioButton43.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PDSTR_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PDSTR_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PDSTR_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PDSTR_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PDSTR_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PDSTR_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PDSTR_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PDSTR_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PDSTR_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PDSTR_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PDSTR_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PDSTR_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PDSTR_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PDSTR_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PDSTR_15 50"; }
            if (radioButton44.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MDINT_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MDINT_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MDINT_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MDINT_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MDINT_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MDINT_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MDINT_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MDINT_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MDINT_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MDINT_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MDINT_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MDINT_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MDINT_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MDINT_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MDINT_15 50"; }
            if (radioButton45.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MD_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MD_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MD_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MD_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MD_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MD_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MD_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MD_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MD_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MD_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MD_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MD_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MD_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MD_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MD_15 50"; }
            if (radioButton46.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_ER_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_ER_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_ER_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_ER_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_ER_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_ER_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_ER_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_ER_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_ER_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_ER_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_ER_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_ER_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_ER_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_ER_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_ER_15 50"; }
            if (radioButton47.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PAR_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PAR_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PAR_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PAR_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PAR_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PAR_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PAR_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PAR_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PAR_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PAR_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PAR_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PAR_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PAR_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PAR_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_PAR_15 50"; }
            if (radioButton48.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MAR_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MAR_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MAR_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MAR_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MAR_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MAR_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MAR_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MAR_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MAR_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MAR_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MAR_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MAR_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MAR_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MAR_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_ATTRSTONE_MAR_15 50"; }
            if (radioButton49.Checked == true) { textBox1.Text = "/MAKEITEM ITEM_ETC_ARCHEMY_REINFORCE_PROB_UP_A_01 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_REINFORCE_PROB_UP_A_02 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_REINFORCE_PROB_UP_A_03 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_REINFORCE_PROB_UP_A_04 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_REINFORCE_PROB_UP_A_05 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_REINFORCE_PROB_UP_A_06 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_REINFORCE_PROB_UP_A_07 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_REINFORCE_PROB_UP_A_08 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_REINFORCE_PROB_UP_A_09 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_REINFORCE_PROB_UP_A_10 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_REINFORCE_PROB_UP_A_11 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_REINFORCE_PROB_UP_A_12 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_REINFORCE_PROB_UP_A_13 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_REINFORCE_PROB_UP_A_14 50\r\n/MAKEITEM ITEM_ETC_ARCHEMY_REINFORCE_PROB_UP_A_15 50"; }
        }

    }
}

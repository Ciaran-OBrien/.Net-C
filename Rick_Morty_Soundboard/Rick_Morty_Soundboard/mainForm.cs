using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rick_Morty_Soundboard
{
    public interface ISounds
    {
        //void aidsButton_Click(object sender, EventArgs e);
        void burgerButton_Click(object sender, EventArgs e);
        void grassButton_Click(object sender, EventArgs e);
        void lickButton_Click(object sender, EventArgs e);
        void taffyButton_Click(object sender, EventArgs e);
        void wubbaButton_Click(object sender, EventArgs e);

    }
    public class buttons :Form,newButtons {

        
    }

    public partial class mainForm : Form, ISounds
    {
        public mainForm()
        {
            InitializeComponent();

            mainForm_Load();
        }
        private void mainForm_Load()
        {
            Button aidsButton = new Button();
            aidsButton.Location = new System.Drawing.Point(136, 221);
            aidsButton.Name = "aidsButton";
            aidsButton.Size = new System.Drawing.Size(335, 56);
            aidsButton.TabIndex = 3;
            aidsButton.Text = "Aids";
            aidsButton.UseVisualStyleBackColor = true;
            // anonymous Method
            aidsButton.Click += (send, eventArgs) =>
            {
                SoundPlayer sp = new SoundPlayer(Rick_Morty_Soundboard.Properties.Resources.Aids__by_Sleepy_Gary_soundtake_net_);
                sp.Play();
            };
            this.Controls.Add(aidsButton);
        }

        public void burgerButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(Rick_Morty_Soundboard.Properties.Resources.Burger_Time__by_Sleepy_Gary_soundtake_net_);
            sp.Play();
        }

        public void grassButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(Rick_Morty_Soundboard.Properties.Resources.Graaaaaaaassss__by_Sleepy_Gary_soundtake_net_);
            sp.Play();
        }

        public void lickButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(Rick_Morty_Soundboard.Properties.Resources.Lick_Lick_Lick__by_Sleepy_Gary_soundtake_net_);
            sp.Play();
        }

        public void taffyButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(Rick_Morty_Soundboard.Properties.Resources.Ricky_Ticky_Taffy__by_Sleepy_Gary_soundtake_net_);
            sp.Play();
        }

        public void wubbaButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(Rick_Morty_Soundboard.Properties.Resources.Wubalubadubdub__by_Sleepy_Gary_soundtake_net_);
            sp.Play();
        }

    }
}

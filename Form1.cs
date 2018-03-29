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
#region Naudio namespaces
using NAudio;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
#endregion

namespace SoundMixer
{
    public partial class F_SoundMixer : Form
    {
        public F_SoundMixer()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_Create_Click(object sender, EventArgs e)
        {
            string fs = "";
            string ss = "";
            string r = "";

            if (!IsNull(txtB_Result.Text, txtB_FirstSound.Text, txtB_SecondSound.Text))
            {
                fs = txtB_FirstSound.Text;
                ss = txtB_SecondSound.Text;
                r = txtB_Result.Text;
            }

            try
            {
                using(var firstAudio = new AudioFileReader(fs))
                {
                    using(var secondAudio = new AudioFileReader(ss))
                    {
                        //"Prepare" the audios 
                        firstAudio.Volume = 0.75f;
                        secondAudio.Volume = 0.75f;

                        //Mix the audios.
                        var output = new MixingSampleProvider(new[] { firstAudio, secondAudio });

                        //Check if the output audio already exists.
                        if (!File.Exists(r))
                        {
                            //Create the file and show where it was created.
                            WaveFileWriter.CreateWaveFile16(r, output);
                            MessageBox.Show("Done, your file was created in " + Path.GetFullPath(r));
                        }
                        else
                        {
                            //If the file exist, it shows on the screen that and the file's path.
                            MessageBox.Show("This file already exists!\nIt's on " + Path.GetFullPath(r));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try again!\n" + ex.Message);
            }
        }

        private void bt_Play_Click(object sender, EventArgs e)
        {
            //Check if the textboxes are null 
            if(!IsNull(txtB_Result.Text))
            {
                //Check if the file exists.
                if (File.Exists(txtB_Result.Text))
                {
                    //Open it.
                    using(var reader = new AudioFileReader(txtB_Result.Text))
                    {
                        //Play it.
                        using (var player = new WaveOutEvent())
                        {
                            player.Init(reader);

                            player.Play();
                            MessageBox.Show("Press ok to stop the audio.");
                        }
                    }
                }
            }
        }

        private bool IsNull(string text1, string text2, string text3)
        {
            //Check if the first, the second and the third text aren't null.
            if ((text1 != null || text1.Length != 0) && (text2 != null || text2.Length != 0) && (text3 != null || text3.Length != 0))
                return false;

            else
                return true;
        }

        bool IsNull(string text)
        {
            //Check if the text is null.
            if (text != null || text.Length != 0)
                return false;

            else
                return true;
        }
    }
}

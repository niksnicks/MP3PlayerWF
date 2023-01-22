using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace MP3PlayerWF
{
    public partial class Form2 : Form
    {
        public string ttt;
        Point start_point = new Point(0, 0);
        private clsMp3 mp3 = new clsMp3();
        bool drag = false;
        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            int www = mp3.ShowCurrentVolume();
            btnSoundCtr.Location = new Point((int)Math.Round((double)(www / 436)) + 28, btnSoundCtr.Location.Y);
            listBox1.Items.Add(oldName);
        }
        public Form2(Point newLocation) : this()
        {
            Location = newLocation;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Bitmap sub_image = new Bitmap(@"C:\Users\a\source\repos\MP3PlayerWF\MP3PlayerWF\img\Без имени-5.png", true);
            btnPlay.Image = sub_image;
            mp3.Open(oldPath);
            mp3.Play();
            
        }

        private void btnPause_Click(object sender, EventArgs e)
        {

            mp3.Pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Bitmap sub_image = new Bitmap(@"C:\Users\a\source\repos\MP3PlayerWF\MP3PlayerWF\img\Без имени-1.png", true);
            btnPlay.Image = sub_image;
            mp3.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            mp3.Close();
            mp3.Open(oldPath);
            mp3.Play();
        }

        private void btnVolumMute_Click(object sender, EventArgs e)
        {
            mp3.SetMute(this.Handle);
        }

        private void btnSoundCtr_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
        }

        private void btnSoundCtr_MouseMove(object sender, MouseEventArgs e)
        {
            if ( btnSoundCtr.Location.Y == 33 && btnSoundCtr.Location.X >= 28 && btnSoundCtr.Location.X <= 165 )
            {
                if (drag)
                {
                    Point MouseHook = new Point();
                    if (e.Button != MouseButtons.Left)
                        MouseHook = e.Location;
                    Point izvr = new Point((Size)btnSoundCtr.Location - (Size)MouseHook + (Size)e.Location);
                    btnSoundCtr.Location = new Point(izvr.X, btnSoundCtr.Location.Y);
                }
   
            }
            else if (btnSoundCtr.Location.Y == 33 && btnSoundCtr.Location.X <= 28)
                btnSoundCtr.Location = new Point(28, 33);
            else
                btnSoundCtr.Location = new Point(165, 33);

        }

        private void btnSoundCtr_MouseUp(object sender, MouseEventArgs e)
        {

            drag = false;
            
            
            mp3.SetVolume((btnSoundCtr.Location.X - 28) * 436 );
        }

        public object oldName
        {
            get { return listBox1.Items; }
            set { listBox1.Items[0] = value; }
        }
        public string oldPath
        {
            get { return ttt; }
            set { ttt = value; }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            foreach (Form oForm in Application.OpenForms)
            {
                if (oForm is Form1)
                {
                    oForm.Location = this.Location;
                    oForm.Show();
                    break;
                }
            }
            /*          
            var formToShow = Application.OpenForms.Cast<Form>()
            .FirstOrDefault(c => c is Form1);
            if (formToShow != null)
            {
                formToShow.Show();
            }*/
            this.Close();
            
        }
    }
}

using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace MP3PlayerWF
{
    
    public partial class Form1 : Form
    {
        Point start_point = new Point(0, 0);
        private clsMp3 mp3 = new clsMp3();
        String[] paths, files;
        private Point MouseHook;
        bool drag = false;
        bool btnoff = false;
        public Form1()
        {
            
            InitializeComponent();
            int www = mp3.ShowCurrentVolume();
            btnSoundCtr.Location = new Point((int)Math.Round((double)(www / 436)) + 90, btnSoundCtr.Location.Y);
            string pathToFile = @"C:\С#\MP3PlayerWF\MP3PlayerWF\bin\Debug\test.txt";
            string word = "";
            // Считываем строки в массив
            string[] allLines = File.ReadAllLines(pathToFile, Encoding.GetEncoding(1251));
            // Добавляем каждую строку
            foreach (string line in allLines)
            {
                int index = line.LastIndexOf("\\"); //оставляем только название
                if (index > 0)
                    word = line.Substring(index+1);
                listBox1.Items.Add(word);
            }
            paths = allLines;
            if (listBox1.Items.Count != 0)
            {
                listBox1.SetSelected(listBox1.Items.Count - listBox1.Items.Count, true);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()) //позваляет открывать файлы
            {
                ofd.Multiselect = true;
                ofd.Filter = "Mp3 Files|*.mp3";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    files = ofd.SafeFileNames;
                    paths = ofd.FileNames;

                    File.WriteAllText(@"C:\GO\test.txt", string.Empty);
                    listBox1.Items.Clear();
                    System.IO.StreamWriter textFile = new System.IO.StreamWriter(@"C:\GO\test.txt");
                    for (int i = 0; i < paths.Length; i++)
                    {
                        textFile.WriteLine(paths[i]);
                    }
                    textFile.Close();
                    for (int i = 0; i <files.Length; i++)
                    {
                        listBox1.Items.Add(files[i]);
                    }

                    listBox1.SetSelected(0, true);
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Bitmap sub_image = new Bitmap(@"C:\С#\MP3PlayerWF\MP3PlayerWF\img\playon.png", true);
            btnPlay.Image = sub_image;
            mp3.Open(paths[listBox1.SelectedIndex]);
            mp3.Play();
            
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            mp3.Pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Bitmap sub_image = new Bitmap(@"C:\С#\MP3PlayerWF\MP3PlayerWF\img\playoff.png", true);
            btnPlay.Image = sub_image;
            mp3.Close();
        }

        private void btnVolumMute_Click(object sender, EventArgs e)
        {
            if (!btnoff)
            {
                Bitmap sub_image = new Bitmap(@"C:\С#\MP3PlayerWF\MP3PlayerWF\img\soundoff.png", true);
                btnVolumMute.Image = sub_image;
                btnoff = true;
            }
            else
            {
                Bitmap sub_image = new Bitmap(@"C:\С#\MP3PlayerWF\MP3PlayerWF\img\soundon.png", true);
                btnVolumMute.Image = sub_image;
                btnoff = false;
            }
            mp3.SetMute(this.Handle);
        }

        private void btnSoundCtr_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
        }

        private void btnSoundCtr_MouseMove(object sender, MouseEventArgs e)
        {
            if ( btnSoundCtr.Location.Y == 157 && btnSoundCtr.Location.X >= 90 && btnSoundCtr.Location.X <= 230 )
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
            else if (btnSoundCtr.Location.Y == 157 && btnSoundCtr.Location.X <= 90)
                btnSoundCtr.Location = new Point(90, 157);
            else
                btnSoundCtr.Location = new Point(230, 157);
        }

        private void btnSoundCtr_MouseUp(object sender, MouseEventArgs e)
        {

            drag = false;
            mp3.SetVolume((btnSoundCtr.Location.X - 90) * 436 );
        }

        private void btnWrap_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btmForward_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == listBox1.Items.Count-1)
            {
                listBox1.SetSelected(listBox1.Items.Count - listBox1.Items.Count, true);
            }
            else
                listBox1.SetSelected(listBox1.SelectedIndex + 1, true);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                listBox1.SetSelected(listBox1.Items.Count-1, true);
            }
            else
                listBox1.SetSelected(listBox1.SelectedIndex - 1, true);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                MouseHook = e.Location;

            Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                Form2 form2 = new Form2(this.Location);
                form2.oldName = listBox1.Items[listBox1.SelectedIndex];
                form2.oldPath = paths[listBox1.SelectedIndex];
                this.Hide();
                form2.Show();
            }
            else
            {
                MessageBox.Show(
        "Playlist пустой",
        "Сообщение",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

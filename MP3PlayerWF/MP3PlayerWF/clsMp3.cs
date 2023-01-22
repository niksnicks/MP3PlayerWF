using System;
using System.Runtime.InteropServices;
using System.Text;

namespace MP3PlayerWF
{
    class clsMp3
    {
        const int WM_APPCOMMAND = 0x319;
        const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        
        //управление воспроизведением
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwdCallBack);
        
        //управление звуком
        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint pdwVolume);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);
        //откючить звук
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        public void Open(string File)
        {
            string Format = @"Open ""{0}"" type MPEGVideo alias MediaFile";
            string Command = string.Format(Format, File);
            mciSendString(Command, null, 0, 0);
        }

        public void Play()
        {
            string Command = "play MediaFile";
            mciSendString(Command, null, 0, 0);
        }

        public void Pause()
        {
            string Command = "pause MediaFile";
            mciSendString(Command, null, 0, 0);
        }

        public void Stop()
        {
            string Command = "stop MediaFile";
            mciSendString(Command, null, 0, 0);
        }

        public void Close()
        {
            string Command = "close MediaFile";
            mciSendString(Command, null, 0, 0);
        }
        //получаем статус
        public string Status()
        {
            string z = "";
            int i = 128;
            StringBuilder stringBuilder = new StringBuilder(i);
            mciSendString("status MediaFile mode", stringBuilder, i, 0);
            z = stringBuilder.ToString();
            return z;
        }

        public int ShowCurrentVolume()
        {
            uint volume;
            waveOutGetVolume(IntPtr.Zero, out volume);
            int left = (int)(volume & 0xFFFF);
            return left;
        }

        public void SetVolume(int value)
        {
            uint volume = (uint)(value + (value << 16));
            waveOutSetVolume(IntPtr.Zero, volume);
        }

        public void SetMute(IntPtr Handle)
        {
            SendMessage(Handle, WM_APPCOMMAND, IntPtr.Zero, (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }

    }
}

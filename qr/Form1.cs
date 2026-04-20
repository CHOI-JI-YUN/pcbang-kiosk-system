using ZXing.Windows.Compatibility;
using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Qr
{
    public partial class Form1 : Form
    {
        FilterInfoCollection cameras;
        VideoCaptureDevice camera;
        bool scanned = false;

        public Form1()
        {
            InitializeComponent();

            btnStart.Click += btnStart_Click;
            btnStop.Click += btnStop_Click;
            this.FormClosing += Form1_FormClosing;

            Timer1.Interval = 2000;
            Timer1.Tick += Timer1_Tick;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (camera != null && camera.IsRunning)
                return;

            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (cameras.Count == 0)
            {
                MessageBox.Show("카메라 없음");
                return;
            }

            camera = new VideoCaptureDevice(cameras[0].MonikerString);
            camera.NewFrame += Camera_NewFrame;
            camera.Start();

            scanned = false;
            lblResult.Text = "QR 스캔 대기중";
        }

        private void Camera_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            Bitmap displayBitmap = (Bitmap)bitmap.Clone();

            try
            {
                if (pictureBoxCamera.InvokeRequired)
                {
                    pictureBoxCamera.BeginInvoke(new Action(() =>
                    {
                        var oldImage = pictureBoxCamera.Image;
                        pictureBoxCamera.Image = displayBitmap;
                        oldImage?.Dispose();
                    }));
                }
                else
                {
                    var oldImage = pictureBoxCamera.Image;
                    pictureBoxCamera.Image = displayBitmap;
                    oldImage?.Dispose();
                }

                if (scanned)
                {
                    bitmap.Dispose();
                    return;
                }

                var reader = new ZXing.Windows.Compatibility.BarcodeReader();
                var result = reader.Decode(bitmap);

                if (result != null)
                {
                    scanned = true;

                    if (InvokeRequired)
                    {
                        BeginInvoke(new Action(() => CheckAdult(result.Text)));
                    }
                    else
                    {
                        CheckAdult(result.Text);
                    }
                }
            }
            catch
            {
                displayBitmap.Dispose();
            }
            finally
            {
                bitmap.Dispose();
            }
        }

        void CheckAdult(string qr)
        {
            string[] parts = qr.Split(';');

            string name = "";
            string birth = "";

            foreach (var p in parts)
            {
                if (p.StartsWith("NAME="))
                    name = p.Replace("NAME=", "").Trim();

                if (p.StartsWith("BIRTH="))
                    birth = p.Replace("BIRTH=", "").Trim();
            }

            if (!DateTime.TryParse(birth, out DateTime birthDate))
            {
                lblResult.Text = "QR 형식 오류";
                scanned = false;
                return;
            }

            int age = DateTime.Today.Year - birthDate.Year;
            if (birthDate > DateTime.Today.AddYears(-age))
                age--;

            if (age >= 19)
            {
                lblResult.Text = $"{name}님 성인 인증 완료";

                MessageBox.Show(
                    $"{name}님 성인 인증이 완료되었습니다.\n문이 열립니다.",
                    "성인 인증",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Timer1.Start();
            }
            else
            {
                lblResult.Text = $"{name}님 미성년자 이용 불가";

                MessageBox.Show(
                    $"{name}님은 미성년자입니다.\n입장이 제한됩니다.",
                    "성인 인증 실패",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                Timer1.Start();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopCamera();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCamera();
        }

        private void StopCamera()
        {
            try
            {
                if (camera != null)
                {
                    camera.NewFrame -= Camera_NewFrame;

                    if (camera.IsRunning)
                        camera.SignalToStop();

                    camera = null;
                }

                if (pictureBoxCamera.Image != null)
                {
                    var old = pictureBoxCamera.Image;
                    pictureBoxCamera.Image = null;
                    old.Dispose();
                }
            }
            catch
            {
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Timer1.Stop();
            scanned = false;
            lblResult.Text = "다음 QR 스캔 대기중";
        }
    }
}
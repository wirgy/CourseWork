using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;
        GravityPoint point;
        
        PointBlue pointBlue; 
        PointRed pointRed;
        PointGreen pointGreen;
        PointYellow pointYellow;
        PointPurple pointPurple;
        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            this.emitter = new Emitter // создаю эмиттер и привязываю его к полю emitter
            {
                Direction = 200,
                Spreading = 350,
                SpeedMin = 10,
                SpeedMax = 10,
                ParticlesPerTick = 10,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2 - 200,
            };
            emitters.Add(this.emitter);

            pointBlue = new PointBlue{  X = picDisplay.Width / 2 - 110, Y = picDisplay.Height / 2, };
            pointRed = new PointRed { X = picDisplay.Width / 2, Y = picDisplay.Height / 2, };
            pointGreen = new PointGreen { X = picDisplay.Width / 2 + 110, Y = picDisplay.Height / 2, };
            pointYellow = new PointYellow { X = picDisplay.Width / 2 + 220, Y = picDisplay.Height / 2, };
            pointPurple = new PointPurple { X = picDisplay.Width / 2 - 220, Y = picDisplay.Height / 2, };
            // привязываем поля к эмиттеру
            emitter.impactPoints.Add(pointBlue);
            emitter.impactPoints.Add(pointRed);
            emitter.impactPoints.Add(pointGreen);
            emitter.impactPoints.Add(pointYellow);
            emitter.impactPoints.Add(pointPurple);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // ну и обработка тика таймера, тут просто декомпозицию выполнили
        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState();

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black); //ФОН 
                emitter.Render(g);
            }

            picDisplay.Invalidate();
        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void picDisplay_Click(object sender, EventArgs e)
        {
           
        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value; 
            lblDirection.Text = $"{tbDirection.Value}°"; 
        }

        private void tbSpreading_Scroll(object sender, EventArgs e)
        {
            emitter.Spreading = tbSpreading.Value;
            lblSpreading.Text = $"{tbSpreading.Value}°";
        }   

        private void picDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                point = new GravityPoint
                {
                    X = e.X,
                    Y = e.Y,
                };
                emitter.impactPoints.Add(point);
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (emitter.impactPoints.Count > 0)
                {
                    emitter.impactPoints.RemoveAt(emitter.impactPoints.Count - 1);
                }
            }
        }

        private void picDisplay_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void tbSizePoint_Scroll(object sender, EventArgs e)
        {
            pointRed.Power = tbSizePoint.Value;
            pointBlue.Power = tbSizePoint.Value;
            pointGreen.Power = tbSizePoint.Value;
            pointYellow.Power = tbSizePoint.Value;
            pointPurple.Power = tbSizePoint.Value;
            lblSizePoint.Text = $"{tbSizePoint.Value}";
        }

        private void tbEmitterX_Scroll(object sender, EventArgs e)
        {
            emitter.X = tbEmitterX.Value;
            lblEmitterX.Text = $"{tbEmitterX.Value}";
        }

        private void tbEmitterY_Scroll(object sender, EventArgs e)
        {
            emitter.Y = tbEmitterY.Value;
            lblEmitterY.Text = $"{tbEmitterY.Value}";
        }

        private void lblEmitterX_Click(object sender, EventArgs e)
        {

        }
    }
}

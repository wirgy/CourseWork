using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace CourseWork
{
    public abstract class IImpactPoint
    {
        public float X; 
        public float Y;
        public int Power = 100;
        public virtual void ImpactParticle(Particle particle)
        {
          
        }

        public virtual void Render(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Red), X - 5, Y - 5, 10, 10);
        }
    }
    public class GravityPoint : IImpactPoint
    {
        public int count = 0;
        public int alpha = 0;
   
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY); // считаем расстояние от центра точки до центра частицы
            if (r + particle.Radius < Power / 2) // если частица оказалось внутри окружности
            {
                  float r2 = (float)Math.Max(100, gX * gX + gY * gY);
                 // particle.SpeedX += gX * Power / r2;
                 // particle.SpeedY += gY * Power / r2;
                  count++;
                  particle.Life = 0;
                  if (alpha/10 < 255) alpha++;
            }
        }

        public override void Render(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.Red), X - Power / 2, Y - Power / 2, Power, Power);
            g.FillEllipse(new SolidBrush(Color.FromArgb(alpha/10, 255, 0, 0)),X - Power / 2, Y - Power / 2, Power, Power);

            var stringFormat = new StringFormat(); 
            stringFormat.Alignment = StringAlignment.Center; // выравнивание по горизонтали
            stringFormat.LineAlignment = StringAlignment.Center; // выравнивание по вертикали

            g.DrawString($"{count}", new Font("Verdana", 10), new SolidBrush(Color.White), X,  Y, stringFormat);
        }
    }
    public class PointBlue : IImpactPoint
    {
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY); 
            if (r + particle.Radius < Power / 2) 
            {
                var partColor = particle as ParticleColorful;
                partColor.FromColor = Color.Blue;
            }
        }

        public override void Render(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.Blue),X - Power / 2, Y - Power / 2, Power, Power);
        }
    }
    public class PointRed : IImpactPoint
    {
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY); 
            if (r + particle.Radius < Power / 2) 
            {
                var partColor = particle as ParticleColorful;
                partColor.FromColor = Color.Red;
            }
        }

        public override void Render(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.Red), X - Power / 2, Y - Power / 2, Power, Power);
        }
    }
    public class PointGreen : IImpactPoint
    {
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY); 
            if (r + particle.Radius < Power / 2)
            {
                var partColor = particle as ParticleColorful;
                partColor.FromColor = Color.Green;
            }
        }

        public override void Render(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.Green), X - Power / 2, Y - Power / 2, Power, Power);
        }
    }

    public class PointYellow : IImpactPoint
    {
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY); 
            if (r + particle.Radius < Power / 2) 
            {
                var partColor = particle as ParticleColorful;
                partColor.FromColor = Color.Yellow;
            }
        }

        public override void Render(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.Yellow), X - Power / 2, Y - Power / 2, Power, Power);
        }
    }

    public class PointPurple : IImpactPoint
    {
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY); 
            if (r + particle.Radius < Power / 2) 
            {
                var partColor = particle as ParticleColorful;
                partColor.FromColor = Color.Purple;
            }
        }

        public override void Render(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.Purple), X - Power / 2, Y - Power / 2, Power, Power);
        }
    }
}

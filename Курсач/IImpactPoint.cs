using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач
{
    public abstract class IImpactPoint
    {
        public float X;
        public float Y;
        

        // абстрактный метод с помощью которого изменяутся состояние частиц
        public abstract void ImpactParticle(Particle particle);

        public virtual void Render(Graphics g)
        {
            g.FillEllipse(
                new SolidBrush(Color.Red),
                X - 5,
                Y - 5,
                10,
                10
            );
        }
    }

    public class GravityPoint : IImpactPoint//круг притяжения
    {
        public int Power = 100;// сила притяжения

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            double r = Math.Sqrt(gX * gX + gY * gY);
            if (r + particle.Radius < Power / 2)
            {
                float r2 = (float)Math.Max(100, gX * gX + gY * gY);
                particle.SpeedX += gX * Power / r2;
                particle.SpeedY += gY * Power / r2;
            }
        }
        public override void Render(Graphics g)
        {
            //рисуем окружность с диаметром равным Power
            g.DrawEllipse(
                   new Pen(Color.Red),
                   X - Power / 2,
                   Y - Power / 2,
                   Power,
                   Power
            );
        }
    }

    public class AntiGravityPoint : IImpactPoint //круг отталкивания
    {
        public int Power = 100;// сила притяжения
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            float r2 = (float)Math.Max(100, gX * gX + gY * gY);

            particle.SpeedX -= gX * Power / r2;
            particle.SpeedY -= gY * Power / r2;
        }
    }

    public class Schetchik : IImpactPoint
    {
        public int schet = 0;
        public float radius = 10;

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            double r = Math.Sqrt(gX * gX + gY * gY);

            if (r - particle.Radius < radius)
            {
                particle.Life = 0;
                schet++;
            }
        }

        public override void Render(Graphics g)
        {
            g.FillEllipse(
                new SolidBrush(Color.FromArgb(220, 20, 60)), 
                X - radius, 
                Y - radius,
                radius * 2,
                radius * 2);
            g.DrawEllipse(
                new Pen(
                    new SolidBrush(Color.Yellow), 2),
                    X - radius,
                    Y - radius,
                    radius * 2,
                    radius * 2
            );
            var str = new StringFormat();
            str.Alignment = StringAlignment.Center;
            str.LineAlignment = StringAlignment.Center;
            g.DrawString(
                $"{schet}",
                new Font("Colibri", 10),
                new SolidBrush(Color.Yellow),
                X,
                Y
            );
        }
    }
}
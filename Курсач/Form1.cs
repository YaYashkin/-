using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;
        GravityPoint point;//первая точка
        GravityPoint point1;//первая точка

        Cyrcle cyrcle;

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);//Привязка изображения
            picDisplay.MouseWheel += picDisplay_MouseWheel;

            this.emitter = new Emitter
            {
                Direction = 0,
                Spreading = 10,
                SpeedMin = 10,
                SpeedMax = 10,
                ColorFrom = Color.Gold,
                ColorTo = Color.FromArgb(0, Color.Red),
                ParticlesPerTick = 10,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2
            };
            emitters.Add(this.emitter);

            point = new GravityPoint
            {
                X = picDisplay.Width / 2 + 100,
                Y = picDisplay.Height / 2
            };

            /*point1 = new GravityPoint
            {
                X = picDisplay.Width / 2 - 100,
                Y = picDisplay.Height / 2
            };*/

            cyrcle = new Cyrcle
            {
                X = picDisplay.Width / 2 - 100,
                Y = picDisplay.Height / 2
            };

            emitter.impactPoints.Add(cyrcle);
            emitter.impactPoints.Add(point);
            //emitter.impactPoints.Add(point1);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState();//обновление эмиттера
            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);//Очистка экрана, заливка формы в чёрный цвет
                emitter.Render(g); //Рендеринг системы через эмиттер
            }
            picDisplay.Invalidate();//обновление формы
        }

        //Фиксация положения мыши
        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            //положение мыши в переменные для хранения положения мыши
            foreach (var emitter in emitters)
            {
                emitter.MousePositionX = e.X;
                emitter.MousePositionY = e.Y;

                cyrcle.X = e.X;
                cyrcle.Y = e.Y;
            }
        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value;
            lblDirection.Text = $"{tbDirection.Value}°";
        }

        private void tbRazbros_Scroll(object sender, EventArgs e)
        {
            emitter.Spreading = tbRazbros.Value;
            lblRazbros.Text = $"{tbRazbros.Value}°";
        }

        private void tbGraviton_Scroll(object sender, EventArgs e)
        {
            point.Power = tbGraviton.Value;
            lblKryg.Text = $"{tbGraviton.Value}°";
        }

        private void picDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//Нажимаем на левую кнопку мыши
            {
                emitter.impactPoints.Add(//Добавляем счётчик
                    new Schetchik
                    {
                        X = e.X,
                        Y = e.Y,
                        radius = tbSchet.Value,
                    }
                    );
            }
            else if (e.Button == MouseButtons.Right)//Нажимаем на праваую кнопку мыши
            {
                foreach (var point in emitter.impactPoints.ToArray())
                {
                    if (point is Schetchik)//если круг - счётчик
                    {
                        Schetchik sc = point as Schetchik;
                        float gX = sc.X - e.X;
                        float gY = sc.Y - e.Y;
                        double r = Math.Sqrt(gX * gX + gY * gY);
                        if (r <= sc.radius)
                        {
                            emitter.impactPoints.Remove(point);//Удаляем счётчик
                        }
                    }
                }
            }
            else if (e.Button == MouseButtons.Middle)
            {
                foreach (var point in emitter.impactPoints.ToArray())
                {
                    if (point is Schetchik)//если круг - счётчик
                    {
                        Schetchik sc = point as Schetchik;
                        float gX = sc.X - e.X;
                        float gY = sc.Y - e.Y;
                        double r = Math.Sqrt(gX * gX + gY * gY);
                        if (r <= sc.radius)
                        {
                            sc.schet = 0;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = splitContainer1.Panel2Collapsed ? false : true;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void tbSchet_Scroll(object sender, EventArgs e)
        {
            lblSchet.Text = $"{tbSchet.Value}";
        }

        private void picDisplay_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                cyrcle.Raduis += 5;
                if(cyrcle.Raduis > 200)
                {
                    cyrcle.Raduis = 30;
                }
            }
            else if (e.Delta < 0)
            {
                cyrcle.Raduis -= 5;
                if(cyrcle.Raduis < 0)
                {
                    cyrcle.Raduis = 30;
                }
            }
        }
    }
}
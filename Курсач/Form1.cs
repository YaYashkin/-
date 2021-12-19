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
        List<Particle> particles = new List<Particle>();//Список частиц
        public Form1()
        {
            InitializeComponent();

            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);//Привязка изображения

            for (var i = 0; i < 500; ++i) //Генерация 500 частиц
            {
                var particle = new Particle();
                particle.X = picDisplay.Image.Width / 2; //Перенос частиц 
                particle.Y = picDisplay.Image.Height / 2;              // в центр изображения

                particles.Add(particle); //Добавление списка
            }
        }

        public void UpdateState() //Обновление логики
        {
            foreach(var particle in particles) //пересчитывание положения частиц в соответствии с их направлением движения и скоростью.
            {
                particle.Life -= 1;//Уменьшение здоровья
                if (particle.Life < 0)
                {
                    particle.Life = 20 + Particle.rand.Next(100);//Восстановление здоровья
                    particle.X = picDisplay.Image.Width / 2; //Перенос частиц 
                    particle.Y = picDisplay.Image.Height / 2;              // в центр изображения

                    particle.Direction = Particle.rand.Next(360);//рандомное направление движения
                    particle.Speed = 1 + Particle.rand.Next(10);//рандомная скорость
                    particle.Radius = 2 + Particle.rand.Next(10);//рандомный радиус

                }
                else
                {
                    var directionInRadians = particle.Direction / 180 * Math.PI;
                    particle.X += (float)(particle.Speed * Math.Cos(directionInRadians));
                    particle.Y -= (float)(particle.Speed * Math.Sin(directionInRadians));
                }
            }
        }

        public void Render(Graphics g) //Отрисовка
        {
            foreach (var particle in particles) //отрисовка частиц
            {
                particle.Draw(g);
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateState();//Каждый тик обновляет систему
            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.White);//Очистка экрана, заливка формы в белый цвет
                Render(g); //Рендеринг системы
            }
            picDisplay.Invalidate();//обновление формы
        }
    }
}

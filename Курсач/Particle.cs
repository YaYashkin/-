using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; //Библиотека для использованися Graphics

namespace Курсач
{
    public class Particle //Класс частиц
    {
        public int Radius; //Радиус частицы
        public float X; //X координата положения частицы в пространстве
        public float Y; //Y координата положения частицы в пространстве
        public float Direction; //Направление движения
        public float Speed; //Скорость перемещения
        public float Life; // здоровье частицы
        public static Random rand = new Random();//Генератор случайных чисел

        public Particle() //Констуруктор, который создаёт кастомную частицу
        {
            Direction = rand.Next(360);//
            Speed = 1 + rand.Next(10);// Скорость от 1 до 11
            Radius = 2 + rand.Next(10);// Радиус от 2 до 12
            Life = 20 + rand.Next(100);// Запас здоровья от 20 до 120
        }

        public void Draw(Graphics g)
        {
            float k = Math.Min(1f, Life / 100);//коэф прозрачности от 0 до 1.0
            int alpha = (int)(k * 255);//значение альфа от 0 до 255
                                       //задание прозрачности
            var color = Color.FromArgb(alpha, Color.Black);//привязываем к увету прозрачность

            var b = new SolidBrush(color); //Кисть для рисования
            g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2);//Создание залитого круга с радиусом и центром X, Y
            b.Dispose();//Сборщик мусора, удаление кисти из памяти
        }
    }
}

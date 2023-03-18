using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPI
{
    /// <summary>
    /// Класс блока.
    /// Задаёт положение блока, его форму и внешний вид.
    /// </summary>
    internal class Block
    {
        /// <summary>
        /// Переменная x, имеет тип данных - int и задаёт положение блока на игровом поле по оси абсцисс в пикселях. 
        /// </summary>
        public int x;
        /// <summary>
        /// Переменная y, имеет тип данных - int и задаёт положение блока на игровом поле по оси ординат в пикселях. 
        /// </summary>
        public int y;
        /// <summary>
        /// Переменная shape, имеет тип данных - int и задаёт номер формы блока. 
        /// </summary>
        public int shape;
        /// <summary>
        /// Переменная color, имеет тип данных - Color и задаёт цвет блока. 
        /// </summary>
        public Color color;
        /// <summary>
        /// Переменная skin, имеет тип данных - Bitmap и хранит в себе рисунок, являющийся
        /// отображаемой моделью блока.
        /// </summary>
        public Bitmap skin;

        /// <summary>
        /// Метод Draw отвечает за отрисовку блока.
        /// </summary>
        /// <param name="pictureBox">Принимаемый объект класса PictureBox, в котором будет отрисовываться блок,
        /// в соответствии с внешним видом хранящимся в переменных skin, color и shape и координатами
        /// на игровом поле хранящимися в переменных x и y.</param>
        public void Draw(PictureBox pictureBox)
        {

        }

        /// <summary>
        /// Метод SetSkin отвечает за установку внешнего вида блока.
        /// </summary>
        /// <param name="skinData">Принимаемая переменная byte[], в которой храниться массив байт, который будет преобразован в
        /// Bitmap и записан в переменную skin.</param>
        public void SetSkin(byte[] skinData)
        {

        }

        /// <summary>
        /// Метод Movement отвечает за установку новых координат в переменные x и y.
        /// </summary>
        /// <param name="newX">Принимаемая переменная int, в котором храниться новое положение блока по оси абсцисс в пикселях.</param>
        /// <param name="newY">Принимаемая переменная int, в котором храниться новое положение блока по оси ординат в пикселях.</param>
        public void Movement(int newX, int newY)
        {

        }

        /// <summary>
        /// Метод Fallen отвечает за остановку блока при достижении им дна или падении на другой упавший блок.
        /// </summary>
        public void Fallen()
        {

        }
    }
}

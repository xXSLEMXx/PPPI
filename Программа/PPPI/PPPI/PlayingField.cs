using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPI
{
    /// <summary>
    /// Класс игрового поля.
    /// Задаёт размеры игрового поля и его внешний вид.
    /// </summary>
    internal class PlayingField
    {
        /// <summary>
        /// Переменная width, имеет тип данных - int и задаёт ширину игрового поля в пикселях. 
        /// </summary>
        public int width;
        /// <summary>
        /// Переменная height, имеет тип данных - int и задаёт высоту игрового поля в пикселях. 
        /// </summary>
        public int height;
        /// <summary>
        /// Переменная skin, имеет тип данных - Bitmap и хранит в себе рисунок, являющийся
        /// отображаемой моделью игрового поля.
        /// </summary>
        public Bitmap skin;

        /// <summary>
        /// Метод Draw отвечает за отрисовку игрового поля.
        /// </summary>
        /// <param name="pictureBox">Принимаемый объект класса PictureBox, в котором будет отрисовываться игровое поле,
        /// в соответствии с внешним видом хранящимся в переменной skin.</param>
        public void Draw(PictureBox pictureBox)
        {

        }

        /// <summary>
        /// Метод SetSkin отвечает за установку внешнего вида игрового поля.
        /// </summary>
        /// <param name="skinData">Принимаемая переменная byte[], в которой храниться массив байт, который будет преобразован в
        /// Bitmap и записан в переменную skin.</param>
        public void SetSkin(byte[] skinData)
        {

        }
    }
}

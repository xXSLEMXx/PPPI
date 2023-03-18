using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPI
{
    /// <summary>
    /// Класс коллизии.
    /// Задаёт взаимодействие блока с другими блоками и игровым полем.
    /// </summary>
    internal class Collision
    {
        /// <summary>
        /// Метод isInside отвечает за проверку нахождения блока внутри игрового поля.
        /// Проверка осуществляется на основании размеров игрового поля и текущих координат проверяемого блока.
        /// </summary>
        /// <param name="block">Принимаемый объект класса Block, в котором храниться проверяемый блок.</param>
        /// <param name="playingField">Принимаемый объект класса PlayingField, в котором храниться игровое поле.</param>
        public bool isInside(Block block, PlayingField playingField)
        {
            return true;
        }

        /// <summary>
        /// Метод isPosibleMove отвечает за проверку возможности сдвига блока на новые координаты.
        /// Проверка осуществляется на основании размеров игрового поля, текущих и новых координат проверяемого блока.
        /// </summary>
        /// <param name="block">Принимаемый объект класса Block, в котором храниться проверяемый блок.</param>
        /// <param name="playingField">Принимаемый объект класса PlayingField, в котором храниться игровое поле.</param>
        /// <param name="newX">Принимаемая переменная int, в котором храниться новое положение блока по оси абсцисс в пикселях.</param>
        /// <param name="newY">Принимаемая переменная int, в котором храниться новое положение блока по оси ординат в пикселях.</param>
        public bool isPosibleMove(Block block, PlayingField playingField, int newX, int newY)
        {
            return true;
        }

        /// <summary>
        /// Метод isOnBottom отвечает за проверку нахождения блока на дне игрового поля или других блоках.
        /// Проверка осуществляется на основании размеров игрового поля и текущих координат проверяемого блока.
        /// </summary>
        /// <param name="block">Принимаемый объект класса Block, в котором храниться проверяемый блок.</param>
        /// <param name="playingField">Принимаемый объект класса PlayingField, в котором храниться игровое поле.</param>
        public bool isOnBottom(Block block, PlayingField playingField)
        {
            return true;
        }
    }
}

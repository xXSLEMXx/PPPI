using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPI
{
    //Класс для взаимодействия сущностей с игровым полем.
    internal class Collision
    {
        //Находится ли блок в пределах игрового поля.
        public bool isInside()
        {
            return true;
        }

        //Возможно ли передвинуть блок.
        public bool isPosibleMove()
        {
            return true;
        }
    }
}

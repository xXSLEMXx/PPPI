using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPI
{
    //Класс падающего блока.
    internal class Block
    {
        public int x;   //Положение блока по x.
        public int y;   //Положение блока по y.

        public int shape;   //Номер формы блока.
        public Color color; //Цвет блока.
        public Bitmap skin; //Внешний вид блока.

        //Отрисовка блока.
        public void Draw()
        {

        }
    }
}

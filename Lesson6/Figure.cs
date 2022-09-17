using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public abstract class Figure
    {
        public bool IsVisible { get; private set; } // Не стал определять отдельный метод для опроса состояния. Это можно делать через свойство.
        public Color Color { get; private set; }
        public decimal X { get; private set; }
        public decimal Y { get; private set; }

        public Figure(bool isVisible, Color color, decimal x, decimal y)
        {
            IsVisible = isVisible;
            Color = color;
            X = x;
            Y = y;
        }

        public Figure(bool isVisible, Color color)
        {
            IsVisible = isVisible;
            Color = color;
            X = 0;
            Y = 0;
        }

        /// <summary>
        /// Движение по вертикали.
        /// </summary>
        /// <param name="value">Значение, на которое происходит перемещение. Отрицательное - вниз, положительное - вверх.</param>
        public void MoveVertical(decimal value)
        {
            Y += value;
        }

        /// <summary>
        /// Движение по горизонтали.
        /// </summary>
        /// <param name="value">Значение, на которое происходит перемещение. Отрицательное - влево, положительное - вправо.</param>
        public void MoveHorizontal(decimal value)
        {
            X += value;
        }

        /// <summary>
        /// Установка цвета.
        /// </summary>
        /// <param name="color"></param>
        public void SetColor(Color color)
        {
            Color = color;
        }

        public override string ToString()
        {
            string visibility = IsVisible ? "Visible" : "Invisible";
            return $"{this.GetType().Name} is {visibility}; Coordinates: X:{X} Y:{Y}; Color: {Color.Name}.";
        }
    }
}

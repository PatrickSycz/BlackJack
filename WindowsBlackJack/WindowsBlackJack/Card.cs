using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsBlackJack
{
    public class Card
    {
        private string Name { get; set; }
        private List<Int32>Values { get; set; }
        private Bitmap CardImage { get; set; }
        private int x { get; set; }
        private int y { get; set; }

        public Card()
        {
            Values = new List<int>();
            x = 0;
            y = 0;

        }
        public string GetName()
        {
            return Name;
        }
        public bool SetName(string _name)
        {
            Name = _name;
            return Name != null ? true : false;
        }
        public List<int> GetValues()
        {
            return Values;
        }
        public bool AddValue(int _value)
        {
            if ( _value <= 0)
                return false;
            else
                Values.Add(_value);
            return true;
        }
        public Bitmap GetImage()
        {
            return CardImage;
        }
        public bool SetImage(string _fileName)
        {
            try
            {
                CardImage = (Bitmap)Bitmap.FromFile(_fileName);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public int GetX()
        {
            return x;
        }
        public bool SetX(int _x)
        {
            x = _x > 0 && _x < 700 ? _x : 0;
            return true;
        }
        public int GetY()
        {
            return y;
        }
        public bool SetY(int _y)
        {
            y = _y > 0 && _y < 400 ? _y : 0;
            return true;
        }
    }
}

namespace HW4{
    // TODO: Перевантажте оператор + для класу Vector, що додає два вектори.
    class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Vector(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }
    }
}
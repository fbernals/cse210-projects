public class Rectangle : Shape{
    private float _height;
    private float _floor;

    public Rectangle(float height, float floor, string color) : base(color){
        _height = height;
        _floor = floor;
    }
    public override double GetArea()
    {
        return _height * _floor;
    }
}
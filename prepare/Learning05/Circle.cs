public class Circle : Shape{

    private double _radius;

    public Circle(double radius, string color) : base(color){
        _radius = radius;
    }

    public override double GetArea(){
        return Math.Pow((_radius*Math.PI),2);

    }

}
public abstract class Shape {
    private string _color;
    public Shape(string color) {
        SetColor(color);
    }

    public string GetColor(){
        return this._color;
    }

    public void SetColor(string color){
        this._color = color;
    }

    public abstract double GetArea();
}

public class Square : Shape {
    private double _side;
    public Square(string color, double side) : base(color){
        this._side = side;

    }
    public override double GetArea(){
        return Math.Pow(this._side, 2);
    }
}

public class Rectangle : Shape {
    private double _length;
    private double _width;
    public Rectangle(string color, double length, double width) : base(color){
        this._length = length;
        this._width = width;

    }
    public override double GetArea(){
        return _length*_width;
    }
}

public class Circle : Shape {
    private double _radius;
    public Circle(string color, double radius) : base(color){
        this._radius = radius;

    }
    public override double GetArea(){
        return Math.Pow(this._radius, 2)*Math.PI;
    }
}
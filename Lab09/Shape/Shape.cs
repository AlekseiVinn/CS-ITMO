abstract class Shape
{
    protected int len0;
    protected double area;
    protected double length;
    
    public Shape() { }

    public Shape(int len)
    {
        len0 = len;        
    }

    abstract public void Show();

    abstract public void Area();

    abstract public void FigureLenght();

}

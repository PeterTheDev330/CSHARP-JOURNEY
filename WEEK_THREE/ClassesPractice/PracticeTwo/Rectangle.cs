using System;

class Rectangle
{

	public double Height;
	public double Width;

	public Rectangle(double height, double width)
	{
		if (height < 0 && width < 0)
		{
			throw new ArgumentException("Either width or hieght was less than 0");
		}

		Height = height;
		Width = width;
	}

	public double Area()
	{
		double area = Height * Width;

		return area;
	}
	public double Parameter()
	{
		double parameter = Height + Width;

		return parameter;
	}
}

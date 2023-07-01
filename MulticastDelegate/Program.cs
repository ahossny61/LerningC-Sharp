

using MulticastDelegate;

var rect = new Rectangle();

rectangleProcess rectangleProcess = rect.GetArea;
rectangleProcess += rect.GetPerimeter;

rectangleProcess(10, 10);

public delegate void rectangleProcess(int width, int height);


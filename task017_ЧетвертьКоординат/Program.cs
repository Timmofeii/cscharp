
Console.WriteLine("Введите координаты точки Х");
int userX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки Y");
int userY = Convert.ToInt32(Console.ReadLine());
if (userY > 0 && userY > 0)
{
    Console.WriteLine("Точка находится в 1 четверти");

}
if (userY < 0 && userY > 0)
{
    Console.WriteLine("Точка находится в 2 четверти");
}
if (userY < 0 && userY < 0)
{
    Console.WriteLine("Точка находится в 3 четверти");
}
if (userY > 0 && userY < 0)
{
    Console.WriteLine("Точка находится в 4 четверти");
}
if (userY == 0 && userY == 0)
{
    Console.WriteLine("Точка находится в оси четверти");
}
// See https://aka.ms/new-console-template for more information
var x = new Utils();
while (true)
{
    x.OutPut();
}
public class Utils
{
    public void OutPut()
    {
        Console.WriteLine("Changes on running");
        Thread.Sleep(1000);
    }

}

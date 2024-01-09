namespace Plug_Problem_Adapter_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITarget target = new Adapter(new Adptee());
            target.NormalPlug();
            //just for fun
        }
    }
}

using System;
using System.Reflection;
using System.Text;

public class StartUp
{
    static void Main()
    {
        var type = typeof(TestReflection);
        //Console.WriteLine(type.FullName);
        //var interfaces = type.GetInterfaces();
        //foreach (var inter in interfaces)
        //{
        //    Console.WriteLine(inter.FullName);
        //}

        //var baseType = type.BaseType;
        //Console.WriteLine(baseType.FullName);


        //var constructors=type.GetConstructors();

        //var test = Activator.CreateInstance(typeof(TestReflection),true);

        //var fields = type.GetFields(BindingFlags.Static | BindingFlags.NonPublic |
        //                            BindingFlags.Public | BindingFlags.Instance);

        var typeBuilder = typeof(StringBuilder);
        var constructor = typeBuilder.GetConstructor(new Type[] {typeof(string), typeof(int)});
        var sb = constructor.Invoke(new object[] {"georgi", 100});


        Console.WriteLine();
    }
}


namespace Demo_ForEachMembers
{
    using System;
    using System.Linq;
    using System.Reflection;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", typeof(MyClass).GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public).Select(x => x.Name)));
            typeof(MyClass).GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static).Select(field => field.Name).ToList().ForEach(Console.WriteLine);


            Console.ReadLine();
        }

        public void Version1()
        {
            Console.WriteLine("");
            Console.WriteLine("Version 1");
            Console.WriteLine("___________");

            Type type = typeof(MyClass);
            var fields = type.GetFields();
            Console.WriteLine(fields.Length);

            foreach (FieldInfo field in fields)
            {
                //var fieldValue = (int)field.GetValue(null);
                Console.WriteLine(field.Name);
            }
        }

        private void Version1_1()
        {
            Console.WriteLine("");
            Console.WriteLine("Version 1.1");
            Console.WriteLine("___________");

            Type type = typeof(MyClass);
            var fields = type.GetFields(BindingFlags.Public);
            Console.WriteLine(fields.Length);
            foreach (FieldInfo field in fields)
            {
                //var fieldValue = (int)field.GetValue(null);
                Console.WriteLine(field.Name);
            }
        }

        private void Version1_2()
        {
            Console.WriteLine("");
            Console.WriteLine("Version 1.1");
            Console.WriteLine("___________");

            Type type = typeof(MyClass);
            var fields = type.GetFields(BindingFlags.Public).Select(field => field.Name).ToList();
            Console.WriteLine(fields.Count);
            foreach (var field in fields)
            {
                Console.WriteLine(field);
            }
        }

        private void Version2()
        {
            Console.WriteLine("");
            Console.WriteLine("Version 2");
            Console.WriteLine("___________");

            var mc = new MyClass();
            var fields = mc.GetType().GetProperties();
            Console.WriteLine(fields.Length);
            foreach (var propertyInfo in fields)
            {
                Console.WriteLine(propertyInfo.Name);
            }
        }

        public void Version3()
        {
            Console.WriteLine("");
            Console.WriteLine("Version 3");
            Console.WriteLine("___________");

            var mc = new MyClass();
            var fields = mc.GetType().GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            Console.WriteLine(fields.Length);
            foreach (var propertyInfo in fields)
            {
                Console.WriteLine(propertyInfo.Name);
            }
        }

        public void Version4()
        {
            Console.WriteLine("");
            Console.WriteLine("Version 4");
            Console.WriteLine("___________");

            var mc = new MyClass();
            var fields = mc.GetType().GetProperties(BindingFlags.Public);
            Console.WriteLine(fields.Length);
            foreach (var propertyInfo in fields)
            {
                Console.WriteLine(propertyInfo.Name);
            }
        }

        public void Version5()
        {
            Console.WriteLine("");
            Console.WriteLine("Version 5");
            Console.WriteLine("___________");

            var mc = new MyClass();
            var fields = mc.GetType().GetFields();
            Console.WriteLine(fields.Length);
            foreach (var propertyInfo in fields)
            {
                Console.WriteLine(propertyInfo.Name);
            }
        }
    }
}

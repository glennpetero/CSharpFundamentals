using System.Text.Json.Serialization;

namespace TrainingAttributes
{
    [Serializable]  // attribute
    public class Program
    {
        [Obsolete]  // attribute
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public enum ObjectType
    { 
        Unit,
        Object,
        Prop,
    }
        
    [AttributeUsage(AttributeTargets.Class)]
    public class IsObjectTypeAttribute : System.Attribute  // custom attribute  (and this too can have an attribute!)
    {
        private ObjectType objectType;
        public IsObjectTypeAttribute(ObjectType objectType) 
        { 
            this.objectType = objectType;
        }        
    }
}

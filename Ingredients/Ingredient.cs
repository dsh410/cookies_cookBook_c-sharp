namespace cookies_cookBook.Ingredients
{
    public abstract class Ingredients
    {
         public abstract string Name { get; }
         public abstract int ID { get; }

         public abstract void Preparation();

    }
}

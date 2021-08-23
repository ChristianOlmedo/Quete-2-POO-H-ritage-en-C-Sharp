namespace Animal
{
    public abstract class Animal
    {
      protected short _legsCount;
      protected string _specie;

      public Animal(short legsCount) 
      {
        _legsCount = legsCount;
      }

      public virtual void Eat()
      {
        System.Console.WriteLine(_specie + " eats");
      }

      public virtual void Move()
      {
        System.Console.WriteLine("This specie moves using" + _legsCount + " legs !");
      }

      public string GetSpecie()
      {
        return _specie;
      }
    }

    public class Snake: Animal
    {
      public Snake(): base (0)
      {

      }

      public override void Move()
      {
        System.Console.WriteLine("This specie doesn't have legs, it is just crawling !");
      }
    
  }
}
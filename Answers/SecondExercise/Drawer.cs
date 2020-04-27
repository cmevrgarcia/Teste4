using System;

namespace Answers
{
    /// <summary>
    /// Interface representing something. Can cut
    /// </summary>
    public interface ISharp
    {
        public void CanCut();
    }
    
    /// <summary>
    /// Class that identifies a knife. 
    /// </summary>
    public class Knife : ISharp
    {
        public int sharpness;
        public int Sharpness
        {
            get => sharpness;
            set => sharpness = (value > 0 && value < 100) ? value : sharpness;

        }

        public void CanCut() { }

    }
    

    [AttributeUsage(AttributeTargets.Class, AllowMultiple =false)]
    public class Struct : Attribute
    {

    }



    [Struct]
    public class Drawer
    {

    }

    
    public class Nao
    {
        public void CanCut() { }
    }

    public class Tenho
    {
        public void CanCut() { }
    }

    public class Tempo
    {
        public void CanCut() { }
    }

    public class Para
    {

    }

    public class Elaborar
    {

    }

    public class Tantas
    {

    }

    public class Clases
    {

    }

    /// <summary>
    /// Exception for when the drawer is stuck
    /// </summary>
    public class Stuck : Exception
    {
        public Stuck () : base ("The Drawer is stuck.")
        {

        }

    }

    /// <summary>
    /// Second drawer is stuck
    /// </summary>
    public static class IsStuck
    {
        public static void TryToOpen(int num)
        {
            if (num == 2) throw new Stuck();
        }
    }
}

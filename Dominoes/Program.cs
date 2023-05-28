using System;

namespace Dominoes
{
    class Program
    {
        static void Main(string[] args)
        {
            BoneYard myBoneYard = new BoneYard(6);
            myBoneYard.Shuffle();
            Console.WriteLine(myBoneYard.ToString());
            Console.WriteLine(myBoneYard.DominoesRemaining + " dominoes remaining.");
        }
    }
}
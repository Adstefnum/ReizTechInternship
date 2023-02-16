
namespace HierarchialStructureNS
{
    public class Program {

        static void Main(string[] args)
        {
            Branch root = new Branch();
            root.AddBranch(2);
            root.branches[0].AddBranch(1);
            root.branches[1].AddBranch(3);

            root.branches[1].branches[0].AddBranch(1);
            root.branches[1].branches[1].AddBranch(2);

            root.branches[1].branches[1].branches[0].AddBranch(1);


            Console.Write("The depth of the structure is " + root.DetermineDepth());

        }

        

    } 
}
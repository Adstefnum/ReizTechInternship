

namespace HierarchialStructureNS
{
    public class Branch
    {
       public List<Branch> branches;

      
        public void AddBranch(int noOfBranchesToAdd)
        {
            if (this.branches == null)
            {
                this.branches = new List<Branch>();
            }

            for (int i = 0; i < noOfBranchesToAdd; i++)
            {
                Branch newBranch = new Branch();
                this.branches.Add(newBranch);
            }
   
        }
       

        public int DetermineDepth() 
        {

            int maxDepth = 0;
            if(this == null) return 0;

            if (this.branches == null || this.branches.Count == 0) return 1;

            foreach(Branch branch in this.branches)
            {
               int depth = branch.DetermineDepth()+1;
                if (depth > maxDepth) maxDepth = depth;
            }

            return maxDepth;
        }

    }
}

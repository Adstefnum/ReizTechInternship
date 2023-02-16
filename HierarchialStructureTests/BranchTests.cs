using HierarchialStructureNS;

namespace HierarchialStructureTests
{
    [TestClass]
    public class BranchTests
    {

        
        [TestMethod]
        public void DepthShouldBeOneOnBranchWithNoBranches()
        {
            Branch branch = new Branch();

            int actualDepth = branch.DetermineDepth();

            Assert.AreEqual(1, actualDepth);
        }

        [TestMethod]
        public void AddBranchShouldAddNewBranchesToList()
        {
            Branch root = new Branch();
            int expectedNoOfBranches = 3;

            root.AddBranch(expectedNoOfBranches);

            Assert.IsNotNull(root.branches);
            Assert.AreEqual(expectedNoOfBranches, root.branches.Count);
        }



        [TestMethod]
        public void ShouldReturnDepthOfFive()
        {
           

            int expectedDepth = 5;

            Branch root = new Branch();
            root.AddBranch(2);
            root.branches[0].AddBranch(1);
            root.branches[1].AddBranch(3);
            root.branches[1].branches[0].AddBranch(1);
            root.branches[1].branches[1].AddBranch(2);
            root.branches[1].branches[1].branches[0].AddBranch(1);

         

            int actualDepth = root.DetermineDepth();

            Assert.AreEqual(expectedDepth, actualDepth);
        }

        [TestMethod]
        public void ShouldReturnDepthOfThree()
        {
            Branch root = new Branch();
            root.AddBranch(1);
            root.branches[0].AddBranch(1);
            root.branches[0].AddBranch(1);
         

            int expectedDepth = 3;

            int actualDepth = root.DetermineDepth();

            Assert.AreEqual(expectedDepth, actualDepth);
        }
        

    }
}

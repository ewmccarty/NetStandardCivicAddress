namespace NetStandardCivicAddress.Test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public sealed class EqualsTests
    {
        #region Public Methods

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void NewCaEqualsNewCa()
        {
            var ca1 = new CivicAddress();
            var ca2 = new CivicAddress();
            System.Boolean nullEqual1 = ca1.Equals(ca2);
            System.Boolean nullEqual2 = ca2.Equals(ca1);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(nullEqual1);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(nullEqual2);
        }

        #endregion Public Methods
    }
}
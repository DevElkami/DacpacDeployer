using DacpacDeployerCore;

namespace VaultTestProject;

[TestClass]
public class UnitTestDeployerCore
{
    [TestMethod("Test check")]
    public void TestMethodException()
    {
        DeployerCore deployerCore = new();
        Assert.ThrowsException<ArgumentNullException>(() => deployerCore.Deploy());
    }
}
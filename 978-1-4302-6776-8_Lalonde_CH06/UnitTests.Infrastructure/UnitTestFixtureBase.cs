using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Infrastructure
{
    public abstract class UnitTestFixtureBase
    {
        protected abstract void PrepareMockDependencies();
        
        //TODO create a class to verify the order in which a mocked object's methods and properties are used

        protected abstract void TestMockDependencyExecutionOrder();



    }
}

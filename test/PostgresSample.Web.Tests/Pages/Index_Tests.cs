using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace PostgresSample.Pages;

public class Index_Tests : PostgresSampleWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}

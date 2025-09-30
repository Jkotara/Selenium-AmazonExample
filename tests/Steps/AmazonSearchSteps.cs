using TechTalk.SpecFlow;
using NUnit.Framework;
using Framework.Pages;
using Tests.Drivers;

namespace Tests.Steps
{
    [Binding]
    public class AmazonSearchSteps
    {
        private Amazon? _page;

        [Given("I am on Amazon")]
        public void GivenIAmOnAmazon()
        {
            _page = new Amazon(Hooks.Driver!);
            _page.Navigate();
        }

        [When("I search for \"(.*)\"")]
        public void WhenISearchFor(string query)
        {
            _page!.Search(query);
        }

        [Then("I should see results")]
        public void ThenIShouldSeeResults()
        {
            Assert.IsTrue(_page!.HasResults());
        }
    }
}

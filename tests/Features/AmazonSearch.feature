Feature: Amazon Search
  Simple check to demonstrate SpecFlow + Selenium setup

  Scenario: Search for a term
    Given I am on Amazon
    When I search for "dog bed"
    Then I should see results

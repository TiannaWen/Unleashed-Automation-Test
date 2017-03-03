Feature: UnleashedSpecFlow

@mytag
Scenario: Login to Unleashed and create a new product
	Given I have logged in to Unleashed
	And I navigate to Add Product page
	Then I create a new product

Scenario: Create a Sales Order and verify stock
	Given I have created a new customer
	And I have verified the available stock of the product
	Then I create a sales order
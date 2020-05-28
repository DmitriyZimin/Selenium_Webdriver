Feature: ItemAdding
		As a user
		I want to open the application
		So I can add items


		Scenario: Adding items

		Given I open "http://localhost:5000" url
		When I type in Name field "user" login, Password field "user" password
		And I click on submit button to log in
		And I click on 'All products' button
		And I click on 'Create new' button
		And I type in ProductName field "English tea" name
		And I select "Beverages" category
		And I select "Mayumi's" supplier
		And I type in UnitPrice field "500" price
		And I type in QuantityPerUnit field "15" quantity
		And I type in UnitsInStock field "10" quantity
		And I type in UnitsOnOrder field "5" quantity
		And I type in ReorderLevel field "1" level
		And I click on submit button to add an item
		Then All products page should be opened with "All Products" header
Feature: Pets
		

@mytag
Scenario:1. Retrieve all available pets and confirm that the name “doggie” with category id "12" is on the list
	Given user sends a GET request to retrive all available pets
	Then verify that the name "doggie" with category id "0" is on the list

Scenario:2. Add a new pet with an auto generated name and status available - Confirm the new pet has been added
	Given user sends a POST request to add a pet with a auto generated name and available status
	Then verify the pet has been added 

Scenario: 3. From point 2 above retrieve the created pet using the ID
		Given user sends a GET request using the ID
		Then verify pet is retured
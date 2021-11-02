Feature: Dog

@Regression
Scenario:1. Verify that a successful message is returned when a user searches for random breeds
	Given user sends a GET request to search for random breeds
	Then user should recieve a message with status "success"

Scenario:2. Verify that bulldog is on the list of all breeds
	Given user sends a GET Request to search for list of all breeds
	Then check that "bulldog" does exist in the list

Scenario:3. Retrieve all sub-breeds for bulldogs and their respective images
	Given user sends a GET request to search for list of all sub breeds for bulldog and their images
	Then user should recieve a message with status "success"
	And the message should contain "images"
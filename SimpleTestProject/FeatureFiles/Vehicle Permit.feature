Feature: Vehicle Permit	
	As a customer
	I want to be able to register new vehicle via vic roads page

@UnregisteredVehiclePermit
Scenario: Get an Unregistered Vehicle Permit
	Given I navigate to the Get an Unregistered Vehicle Permit page
	When the verify the page title is Get an Unregistered Vehicle Permit
	And I select Motorcycle from Vehicle type dropdown
	And I select Less than 61 cc from Engine capacity dropdown
	And input customer address 64 Old Geelong Rd, Hoppers Crossing VIC 3029	
	And select 7 days from permit duration dropdown	
	And click on Next button on Step1
	Then permit types displayed as "Preparation for Registration in Victoria"
	And permit types displayed as "Single Trip / Journey"
	
# RESTserver
C# Code Test
A small REST server with good performance for simple customer management has two functions:
•	POST customers
Request:
[
	  {
		 firstName: 'Aaaa',
		 lastName: 'Bbbb',
		 age: 20,
		 id: 5
	  },
	  {
		 firstName: 'Bbbb',
		 lastName: 'Cccc',
		 age: 24,
		 id: 6
	  }
]
Multiple customers can be sent in one request.
The server validates every customer of the request:
•	checks that every field is supplied
•	validates that the age is above 18
•	validates that the ID has not been used before
The server then adds each customer as an object to an internal array – the customers will not be appended to the array but instead it will be inserted at a position so that the customers are sorted by last name and then first name WITHOUT using any available sorting functionality (an example for the inserting is in the Appendix).
The server also persists the array so it will be still available after a restart of the server.
•	GET customers
Returns the array of customers with all fields

### Week 3 — Data management \& REST API

#### Requirement specification





##### Assignment specs:

* API to perform CRUD (Post, Get, Put, Delete).

  * 'Get' returns all products, or one product with a given ID.
  * Filters to take parametres.

* "Driver class" to test methods. Kinda like unit testing?
* Structured and documented code.
* README file.

  * API documentation.
  * Endpoints?
  * Response formats, possibly with examples.
  * Description of design and reasoning behind design decisions.

* Database to store data. Parse data from CSV file.

  * Make sure the parser can handle extra data? What does that even mean; more fields?
  * Make sure the database supports CRUD-operations.
  * Have relevant constraints, such as UNIQUE fields and not-null values.

* One endpoint to delete products by ID.
* One endpoint to create new products via POST-request.

  * If ID given and ID exists in database, update existing post.
  * If ID given and no matching ID exists, throw error. ID cannot be set on new posts.
  * If no ID given, create new object.



##### Other specs:

* GUI? To show a lot of data, probably use tables.
* Website?
* Text input or buttons to sort and filter? Assignment says the user may type *e.g.* "value>=100".

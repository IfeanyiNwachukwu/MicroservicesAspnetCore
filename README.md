# MicroservicesAspnetCore
// Mongo DB Interactive
 docker exec -it shopping-mongo /bin/bash
 // Bash Commands
 --ls = lists everything in directory
 --mongo = bash command to start interacting with Mongo Db
 // Commands to Interact with Db After Bash Command
 --show dbs = lists all default db's
 -- use<dbName> = creates a database named dbName
 -- db.createCollection('Products') = creates a table named Products
 -- db.Products.insertMany([]) = inserts values into the table
 -- db.Products.find({}).pretty() = returns everything in our database
 --db.Products.remove({}) = removes everything in our database
 -- show databases = shows all database(both default and custom)
 --show collections = lists all available tables
 
 // Run a docker container e.g mongo
 docker run -d -p 27017:27017 --name shopping-mongo mongo
  

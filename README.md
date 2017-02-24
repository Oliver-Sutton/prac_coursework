#This is practise course work for college.

_The end goal for this to create modules for ease of life that will be turned into dll(s)_

I'm using this as a place for [filehandler.vb](fileHandler.vb) and [security.vb](security.vb) (***These maybe subject to a few update's still***) that I have developed, to deal
with .txt database type files in single lines of code. I am now using this as a place to test
[positioning.vb](labelPositions.vb) that I am ***developing***, to deal with static label positioning.

##Security
I recommend using salt for both hashing and also using part of that salt as a key to encrypt.
With this do not encrypt salt unless using a standard number using encrypt/decrypt without key.
Doing this will allow you to decrypt data from an entire file without need to the key.  
Example(s):  
1. Products in a file.  
2. Entire user files for admins. (Using part of the salt instead of set shift number)

###Features
1. encrypt
    1. (data, key) - Encrypts data using a key.
    2. (data) - Encrypts data using a set shift number.
2. decrypt
    1. (data, key) - Decrypts data using a key.
    2. (data) - Decrypts data using a set shift number.
3. hash() - Hashes a string using SHA512 and salt.
4. generateSalt() - Generates a unique salt of specified length.

##File Handler
This is best used along side the security module that I have written since storing
data in .txt file is bad practise and if you can you should use a database like MySQL.
If you have to use it then security module will help you keep that data somewhat safe.

###Features
1. readFile() - Reads the entire file.
2. getRecord() - Reads a single record.
3. isUnique() - Checks if a value is unique to that field.
4. changeRecord() - Change's a single value in a record.
5. removeRecord() - Remove's a single record in a file.
6. backupFile() - Backup's the entire file, saving it with the date of backup.
7. addRecord() - Adds a new record to the file.
8. generatePrimaryKey() - Generates a integer primary key 1 more than the highest in the file.

***Within development of this project I came across an issue with reading entire
files for admins since each user had unique key dependent on username which made
the it impossible using part of the salt for the password fixed this issue.***

###System Features
1. Logins with Admin/User permissions
2. Dealing with orders on products including:
  1. Creating orders
  2. Removing orders
  3. Fulfilling orders
  4. Checking stock
3. Full Admin control over the system including:
  1. Removing accounts
  2. Creating backups of all files
  3. Creating new user accounts.
4. Access for users to change passwords.

##To-do List

1. Begin/Complete development of [positioning.vb](labelPositions.vb).
2. Refine/Bug fix features in all 3 modules.

######Find my website at [oliver-sutton.com](http://www.oliver-sutton.com)

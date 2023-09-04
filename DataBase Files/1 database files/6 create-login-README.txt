script to create login and user is excluded from this repo.
create a file calle creat-login.sql (this file is ignored by git ignore in this repo)
add the following to that file.

--create login in master
create login [loginname] with password = '[password]'

--switch to recordkeeperdb
create user [username] from login [loginname]
